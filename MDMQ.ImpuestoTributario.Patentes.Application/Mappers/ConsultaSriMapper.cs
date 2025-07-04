using MDMQ.ImpuestoTributario.Patentes.Datos.Models;
using MDMQ.ImpuestoTributario.Patentes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDMQ.ImpuestoTributario.Patentes.Application.Mappers
{
    public class ConsultaSriMapper : IConsultaSriMapper
    {

        public DTOCatastroSri ToDTO(CorCatastroSri entity)
        {
            return new DTOCatastroSri
            {
                numeroRuc = entity.NumeroRuc,
                numeroIdentificacion = entity.NumeroIdentificacion,
                claseContribuyenteId = entity.ClaseContribuyenteId,
                actividadEconomicaId = entity.ActividadEconomicaId,
                personaId = entity.PersonaId,
                tipoContribuyente = entity.TipoContribuyente,
                grupoContribuyente = entity.GrupoContribuyente,
                obligado = entity.Obligado,
                rucContador = entity.RucContador,
                identificacionRepresentanteLegal = entity.IdentificacionRepresentanteLegal,
                cargoRepresentanteLegal = entity.CargoRepresentanteLegal,
                fechaInscripcion = entity.FechaInscripcion,
                fechaInicioActividades = entity.FechaInicioActividades,
                fechaConstitucion = entity.FechaConstitucion,
                fechaReinicioActividades = entity.FechaReinicioActividades,
                fechaSuspensionDefinitiva = entity.FechaSuspensionDefinitiva,
                estado = entity.Estado,
                estadoSociedad = entity.EstadoSociedad,
                estadoLegalCompania = entity.EstadoLegalCompania,
                fechaRegistro = entity.FechaRegistro,
                fechaHoraRegistro = entity.FechaHoraRegistro,
                usuarioRegistro = entity.UsuarioRegistro,
                terminalRegistro = entity.TerminalRegistro,
                fechaActualizacion = entity.FechaActualizacion,
                fechaHoraActualizacion = entity.FechaHoraActualizacion,
                usuarioActualizacion = entity.UsuarioActualizacion,
                terminalActualizacion = entity.TerminalActualizacion,
                razonSocial = entity.RazonSocial,
                codigoPersonaSri = entity.CodigoPersonaSri,
                codigoPersonaRelacionadaSri = entity.CodigoPersonaRelacionadaSri,
                nombreRepresentanteLegal = entity.NombreRepresentanteLegal,
                callePrincipal = entity.CallePrincipal,
                numeroCasa = entity.NumeroCasa,
                interseccion = entity.Interseccion,
                codigoUbicacionGeograficaProvincia = entity.CodigoUbicacionGeograficaProvincia,
                codigoUbicacionGeograficaCanton = entity.CodigoUbicacionGeograficaCanton,
                codigoUbicacionGeograficaParroquia = entity.CodigoUbicacionGeograficaProvincia,
                barrio = entity.Barrio,
                emailPrincipal = entity.EmailPrincipal,
                telefonoCelular = entity.TelefonoCelular,
                telefonoConvencional = entity.TelefonoConvencional,
                cargaInicial = entity.CargaInicial,
                descripcionEstadoContribuyente = entity.DescripcionEstadoContribuyente,
                fechaNombramiento =entity.FechaNombramiento,
                referencia = entity.Referencia
            };
        }

        public List<DTOCatastroSri> ToDTO(List<CorCatastroSri> entities)
        {
            return entities.Select(ToDTO).ToList();
        }

    }
}
