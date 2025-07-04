﻿using MDMQ.ImpuestoTributario.Patentes.Dto;
using MDMQ.ImpuestoTributario.Patentes.Negocio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MDMQ.ImpuestoTributario.Patentes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BeneficioTributarioController : Controller
    {
        private readonly IBeneficioTributarioService _patente;
        public BeneficioTributarioController(IBeneficioTributarioService patente)
        {
            _patente = patente;
        }


        [HttpGet]
        public async Task<IEnumerable<DTOBeneficioTributario>> GetBeneficioTributario()
        {
            return await _patente.GetBeneficioTributario();
        }
    }
}
