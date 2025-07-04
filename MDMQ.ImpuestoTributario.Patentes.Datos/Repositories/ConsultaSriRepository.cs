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
    public class ConsultaSriRepository : IConsultaSriRepository
    {
        private readonly MDMQ_CORE_TRIBUTARIOContext _contextCoreTributario;

        public ConsultaSriRepository(MDMQ_CORE_TRIBUTARIOContext contextCoreTributario)
        {
            _contextCoreTributario = contextCoreTributario;
        }
        /// <summary>
        /// ConsultarContribuyentePorRuc
        /// </summary>
        /// <param name="ruc"></param>
        /// <returns></returns>
        public async Task<DTOCatastroSri?> ConsultarContribuyentePorRuc(string ruc)
        {
            return await _contextCoreTributario.CorCatastroSri
                .Where(x => x.NumeroRuc == ruc)
                .Select(x => new DTOCatastroSri
                {
                    numeroRuc = x.NumeroRuc,
                    numeroIdentificacion = x.NumeroIdentificacion,
                    claseContribuyenteId = x.ClaseContribuyenteId,
                    actividadEconomicaId = x.ActividadEconomicaId,
                    personaId = x.PersonaId,
                    tipoContribuyente = x.TipoContribuyente,
                    grupoContribuyente = x.GrupoContribuyente,
                    obligado = x.Obligado,
                    rucContador = x.RucContador,
                    identificacionRepresentanteLegal = x.IdentificacionRepresentanteLegal,
                    cargoRepresentanteLegal = x.CargoRepresentanteLegal,
                    fechaInscripcion = x.FechaInscripcion,
                    fechaInicioActividades = x.FechaInicioActividades,
                    fechaConstitucion = x.FechaConstitucion,
                    fechaReinicioActividades = x.FechaReinicioActividades,
                    fechaSuspensionDefinitiva = x.FechaSuspensionDefinitiva,
                    estado = x.Estado,
                    estadoSociedad = x.EstadoSociedad,
                    estadoLegalCompania = x.EstadoLegalCompania,
                    fechaRegistro = x.FechaRegistro,
                    fechaHoraRegistro = x.FechaHoraRegistro,
                    usuarioRegistro = x.UsuarioRegistro,
                    terminalRegistro = x.TerminalRegistro,
                    fechaActualizacion = x.FechaActualizacion,
                    fechaHoraActualizacion = x.FechaHoraActualizacion,
                    usuarioActualizacion = x.UsuarioActualizacion,
                    terminalActualizacion = x.TerminalActualizacion,
                    razonSocial = x.RazonSocial,
                    codigoPersonaSri = x.CodigoPersonaSri,
                    codigoPersonaRelacionadaSri = x.CodigoPersonaRelacionadaSri,
                    nombreRepresentanteLegal = x.NombreRepresentanteLegal,
                    callePrincipal = x.CallePrincipal,
                    numeroCasa = x.NumeroCasa,
                    interseccion = x.Interseccion,
                    codigoUbicacionGeograficaProvincia = x.CodigoUbicacionGeograficaProvincia,
                    codigoUbicacionGeograficaCanton = x.CodigoUbicacionGeograficaCanton,
                    codigoUbicacionGeograficaParroquia = x.CodigoUbicacionGeograficaProvincia,
                    barrio = x.Barrio,
                    emailPrincipal = x.EmailPrincipal,
                    telefonoCelular = x.TelefonoCelular,
                    telefonoConvencional = x.TelefonoConvencional,
                    cargaInicial = x.CargaInicial,
                    descripcionEstadoContribuyente = x.DescripcionEstadoContribuyente,
                    fechaNombramiento =x.FechaNombramiento,
                    referencia = x.Referencia
                })
                .FirstOrDefaultAsync();
        }
    }
}
