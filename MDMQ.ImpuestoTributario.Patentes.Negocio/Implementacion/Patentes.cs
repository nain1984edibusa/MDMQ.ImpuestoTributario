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
    public class Patentes : IPatentes
    {
        private readonly IBeneficioTributario _iBeneficioTributario;

        public Patentes(IBeneficioTributario iBeneficioTributario)
        {
            _iBeneficioTributario = iBeneficioTributario;
        }

        public async Task<IEnumerable<DTOBeneficioTributario>> GetBeneficioTributario()
        {
            return await _iBeneficioTributario.GetBeneficioTributario();
        }
    }
}
