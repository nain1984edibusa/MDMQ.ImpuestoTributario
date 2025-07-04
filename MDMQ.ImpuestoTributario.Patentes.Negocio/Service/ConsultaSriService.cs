using MDMQ.ImpuestoTributario.Patentes.Application.Mappers;
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
        private readonly IConsultaSriMapper _mapper;

        public ConsultaSriService(Datos.Interfaz.IConsultaSriRepository iConsultaSriRepository, IConsultaSriMapper mapper)
        {
            _iConsultaSriRepository = iConsultaSriRepository;
            _mapper = mapper;
        }

        public async Task<DTOCatastroSri> ConsultarContribuyentePorRuc(string ruc)
        {
            return await _iConsultaSriRepository.ConsultarContribuyentePorRuc(ruc);
        }
    }
}
