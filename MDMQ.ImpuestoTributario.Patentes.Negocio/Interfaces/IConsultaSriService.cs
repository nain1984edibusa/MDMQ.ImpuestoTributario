﻿using MDMQ.ImpuestoTributario.Patentes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDMQ.ImpuestoTributario.Patentes.Negocio.Interfaz
{
    public interface IConsultaSriService
    {
        Task<DTOCatastroSri> ConsultarContribuyentePorRuc(string ruc);
    }
}
