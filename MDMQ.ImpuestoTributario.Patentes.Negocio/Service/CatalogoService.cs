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
    public class CatalogoService : Interfaz.ICatalogoService
    {
        private readonly Datos.Interfaz.ICatalogoRepository _iCatalogoRepository;


        public CatalogoService(Datos.Interfaz.ICatalogoRepository iCatalogoRepository)
        {
            _iCatalogoRepository = iCatalogoRepository;
        }

        public async Task<IEnumerable<DTOCatalogo>> ObtenerCatalogo()
        {
            return await _iCatalogoRepository.ObtenerCatalogo();
        }
    }
}
