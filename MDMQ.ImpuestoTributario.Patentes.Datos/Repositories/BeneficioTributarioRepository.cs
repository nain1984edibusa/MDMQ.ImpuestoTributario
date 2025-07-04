using MDMQ.ImpuestoTributario.Patentes.Datos.Contexts;
using MDMQ.ImpuestoTributario.Patentes.Datos.Interfaz;
using MDMQ.ImpuestoTributario.Patentes.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDMQ.ImpuestoTributario.Patentes.Datos.Implementacion
{
    public class BeneficioTributarioRepository : IBeneficioTributarioRepository
    {
        private readonly MDMQ_CORE_TRIBUTARIOContext _contextCoreTributario;

        public BeneficioTributarioRepository(MDMQ_CORE_TRIBUTARIOContext contextCoreTributario)
        {
            _contextCoreTributario = contextCoreTributario;
        }

        public async Task<IEnumerable<DTOBeneficioTributario>> GetBeneficioTributario()
        {
            List<DTOBeneficioTributario> result = new List<DTOBeneficioTributario>();

            result = await _contextCoreTributario.CorBeneficioTributario
                    .Select(x => new DTOBeneficioTributario
                    {
                        beneficioTributarioId = x.BeneficioTributarioId,
                        numeroIdentificacion = x.NumeroIdentificacion,
                        razonSocial = x.RazonSocial,
                        tipoEmpresaId = x.TipoEmpresaId,
                        tipoCertificadoId = x.TipoCertificadoId,
                        estado = x.Estado,
                        path = x.Path
                    })
                    .ToListAsync();

            return result;
        }
    }
}
