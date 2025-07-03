using MDMQ.ImpuestoTributario.Patentes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDMQ.ImpuestoTributario.Patentes.Datos.Interfaz
{
    public interface IConsultaSriRepository
    {
        Task<DTOCatastroSri> ConsultarContribuyentePorRuc(string ruc);
    }
}
