using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaMerced.Common.Entities;
using ClinicaMerced.Common.Entities.Custom;
using ClinicaMerced.Backend.Entities;
using Fwk.Bases;

namespace ClinicaMerced.Common.Entities.Custom
{
    public class ConsultaGridList : Entities<ConsultaGrid>
    { 
    
    }


    public class ConsultaGrid : ConsultaBE
    {

        public ConsultaGrid() { }
        public ConsultaGrid(Consulta pConsulta, string MutualNombre, string ProfecionalNombre)
            : base(pConsulta)
        {

        }


        public string MutualNombre { get; set; }
        public string ProfecionalNombre { get; set; }
        public string TipoConsultaNombre { get; set; }

        public string Turno
        {
            get
            {
                if (Fecha.ToString("tt").ToLower().Equals("a.m."))

                    return "Mañana";
                else
                    return "Tarde";
            }
        }
        public string Hora
        {
            get { return base.Fecha.ToShortTimeString(); }
        }
    }
}
