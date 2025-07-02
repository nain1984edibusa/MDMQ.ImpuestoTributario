using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDMQ.ImpuestoTributario.Patentes.Dto
{
    public class DTOCatalogo
    {
        public int catalogoId { get; set; }
        public int catalogoPadre { get; set; }
        public int catalogoHijo { get; set; }
        public string descripcion { get; set; }
        public string codigoNegocio { get; set; }
        public int nivel { get; set; }
        public bool vigente { get; set; }
        public string descripcionParametro { get; set; }
        public decimal? valorNumerico { get; set; }
        public string valorCarater { get; set; }
        public string parametro1 { get; set; }
        public int? parametro2 { get; set; }
        public decimal? parametro3 { get; set; }
        public DateTime? parametro4 { get; set; }

        public DTOCatalogo()
        {
        }
    }
}
