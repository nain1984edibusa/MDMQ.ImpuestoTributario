using System.ComponentModel;

namespace MDMQ.ImpuestoTributario.Patentes.Dto
{
    public class DTOBeneficioTributario
    {
        public int beneficioTributarioId { get; set; }
        public string numeroIdentificacion { get; set; }

        public string razonSocial { get; set; }

        public int tipoEmpresaId { get; set; }

        public string tipoEmpresa { get; set; }

        public int tipoCertificadoId { get; set; }
        
        public string tipoCertificado { get; set; }

        public DateTime fechaRegistro { get; set; }

        public DateTime fechaActualizacion { get; set; }

        public string estado { get; set; }

        public string path { get; set; }

        public string numeroTrabajadores { get; set; }

        public string ingresoDesde { get; set; }

        public string ingresoHasta { get; set; }

        public DTOBeneficioTributario()
        {
        }
    }
}
