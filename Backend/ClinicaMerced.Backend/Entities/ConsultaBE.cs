using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaMerced.Backend.Entities;

namespace ClinicaMerced.Common.Entities
{
    public partial class ConsultaBE
    {
        public Consulta GetConsultaEF()
        {
            Consulta wConsulta = new Consulta();
            wConsulta.IdConsulta = _IdConsulta;
            wConsulta.Descripcion = _Descripcion;
            wConsulta.NombreCliente = _NombreCliente;
            wConsulta.Fecha = _Fecha;
            wConsulta.PresentaOrden = _PresentaOrden;
            wConsulta.TelefonoCliente = _TelefonoCliente;
            wConsulta.Coseguro = _Coseguro;
            wConsulta.IdProfecional = _IdProfecional;
            wConsulta.IdMutual = _IdMutual;
            wConsulta.IdTipoConsulta = IdTipoConsulta;
            wConsulta.NroAfiliadoMutual = NroAfiliadoMutual;
            wConsulta.ExigeCoseguro = ExigeCoseguro;
            wConsulta.ArancelMutual = _ArancelMutual;
            return wConsulta;
        }
    }
}
