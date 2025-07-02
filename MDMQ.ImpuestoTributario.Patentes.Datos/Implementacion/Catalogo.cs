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
    public class Catalogo : ICatalogoRepository
    {
        private readonly MDMQ_CORE_TRIBUTARIOContext _contextCoreTributario;

        public Catalogo(MDMQ_CORE_TRIBUTARIOContext contextCoreTributario)
        {
            _contextCoreTributario = contextCoreTributario;
        }

        public async Task<IEnumerable<DTOCatalogo>> ObtenerCatalogo()
        {
            List<DTOCatalogo> result = new List<DTOCatalogo>();

            result = await _contextCoreTributario.CorTdCatalogo
                    .Select(x => new DTOCatalogo
                    {
                        catalogoId = x.CorTdCatalogoId,
                        catalogoPadre = x.CatalogoPadre.GetValueOrDefault(),
                        catalogoHijo = x.CatalogoHijo.GetValueOrDefault(),
                        descripcion = x.Descripcion,
                        codigoNegocio = x.CodigoNegocio
                    })
                    .ToListAsync();

            return result;
        }
    }
}
