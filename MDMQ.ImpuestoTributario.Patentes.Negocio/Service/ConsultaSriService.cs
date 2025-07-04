using MDMQ.ImpuestoTributario.Patentes.Datos.Interfaz;
using MDMQ.ImpuestoTributario.Patentes.Dto;
using MDMQ.ImpuestoTributario.Patentes.Negocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDMQ.ImpuestoTributario.Patentes.Negocio.Implementacion
{
    public class ConsultaSriService : Interfaz.IConsultaSriService
    {
        private readonly Datos.Interfaz.IConsultaSriRepository _iConsultaSriRepository;

        public ConsultaSriService(Datos.Interfaz.IConsultaSriRepository iConsultaSriRepository)
        {
            _iConsultaSriRepository = iConsultaSriRepository;
        }

        public async Task<DTOCatastroSri> ConsultarContribuyentePorRuc(string ruc)
        {
            return await _iConsultaSriRepository.ConsultarContribuyentePorRuc(ruc);
        }
    }
}
