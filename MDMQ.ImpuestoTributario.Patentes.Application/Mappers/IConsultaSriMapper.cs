using MDMQ.ImpuestoTributario.Patentes.Datos.Models;
using MDMQ.ImpuestoTributario.Patentes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDMQ.ImpuestoTributario.Patentes.Application.Mappers
{
    public interface IConsultaSriMapper
    {
        DTOCatastroSri ToDTO(CorCatastroSri entity);

        List<DTOCatastroSri> ToDTO(List<CorCatastroSri> entities);


    }
}
