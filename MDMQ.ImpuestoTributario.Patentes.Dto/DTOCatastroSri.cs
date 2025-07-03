using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDMQ.ImpuestoTributario.Patentes.Dto
{
    public class DTOCatastroSri
    {
        public string numeroRuc { get; set; }
        public string numeroIdentificacion { get; set; }
        public string claseContribuyenteId { get; set; }
        public string actividadEconomicaId { get; set; }
        public long? personaId { get; set; }
        public string tipoContribuyente { get; set; }
        public string grupoContribuyente { get; set; }
        public string obligado { get; set; }
        public string rucContador { get; set; }
        public string identificacionRepresentanteLegal { get; set; }
        public string cargoRepresentanteLegal { get; set; }
        public DateOnly? fechaInscripcion { get; set; }
        public DateOnly? fechaInicioActividades { get; set; }
        public DateOnly? fechaConstitucion { get; set; }
        public DateOnly? fechaReinicioActividades { get; set; }
        public DateOnly? fechaSuspensionDefinitiva { get; set; }
        public string estado { get; set; }
        public string estadoSociedad { get; set; }
        public string estadoLegalCompania { get; set; }
        public DateOnly fechaRegistro { get; set; }
        public DateTime fechaHoraRegistro { get; set; }
        public string usuarioRegistro { get; set; }
        public string terminalRegistro { get; set; }
        public DateOnly? fechaActualizacion { get; set; }
        public DateTime? fechaHoraActualizacion { get; set; }
        public string usuarioActualizacion { get; set; }
        public string terminalActualizacion { get; set; }
        public string razonSocial { get; set; }
        public decimal? codigoPersonaSri { get; set; }
        public decimal? codigoPersonaRelacionadaSri { get; set; }
        public string nombreRepresentanteLegal { get; set; }
        public string callePrincipal { get; set; }
        public string numeroCasa { get; set; }
        public string interseccion { get; set; }
        public string codigoUbicacionGeograficaProvincia { get; set; }
        public string codigoUbicacionGeograficaCanton { get; set; }
        public string codigoUbicacionGeograficaParroquia { get; set; }
        public string barrio { get; set; }
        public string emailPrincipal { get; set; }
        public string telefonoCelular { get; set; }
        public string telefonoConvencional { get; set; }
        public string cargaInicial { get; set; }
        public string descripcionEstadoContribuyente { get; set; }
        public DateOnly? fechaNombramiento { get; set; }
        public string referencia { get; set; }

        public DTOCatastroSri()
        {
        }
    }
}
