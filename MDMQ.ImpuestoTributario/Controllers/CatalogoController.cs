﻿using MDMQ.ImpuestoTributario.Patentes.Dto;
using MDMQ.ImpuestoTributario.Patentes.Negocio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MDMQ.ImpuestoTributario.Patentes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogoController : Controller
    {
        private readonly ICatalogoService _catalogoNeg;
        public CatalogoController(ICatalogoService catalogoNeg)
        {
            _catalogoNeg = catalogoNeg;
        }


        [HttpGet]
        public async Task<IEnumerable<DTOCatalogo>> ObtenerCatalogo()
        {
            return await _catalogoNeg.ObtenerCatalogo();
        }
    }
}
