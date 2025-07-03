using MDMQ.ImpuestoTributario.Patentes.Dto;
using MDMQ.ImpuestoTributario.Patentes.Negocio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MDMQ.ImpuestoTributario.Patentes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultaSriController : Controller
    {
        private readonly IConsultaSriNeg _consultaSriNeg;
        public ConsultaSriController(IConsultaSriNeg consultaSriNeg)
        {
            _consultaSriNeg = consultaSriNeg;
        }


        [HttpGet("{ruc}")]
        public async Task<ActionResult<DTOCatastroSri>> GetContribuyentePorRuc(string ruc)
        {
            var contribuyente = await _consultaSriNeg.ConsultarContribuyentePorRuc(ruc);

            if (contribuyente == null)
                return NotFound($"No se encontró contribuyente con RUC: {ruc}");

            return Ok(contribuyente);
        }
    }
}
