using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaMerced.Common.Enums;

namespace ClinicaMerced.Common.Entities.Repòrts
{
    [Serializable]
    public class rpt_consultas_mes_tipo : Fwk.Bases.Entity
    {
        public DateTime? Fecha { get; set; }
        public Int32? NumMes { get; set; }
        public Decimal Arancel { get; set; }
        public Decimal Coseguro { get; set; }
        public String NombreTipoConsulta { get; set; }
        public String NombreProfecional { get; set; }
        public String NombreMutual { get; set; }

        public String Mes
        {


            get
            {
                if (NumMes.HasValue)
                    return Enum.GetName(typeof(Meses), NumMes);
                else
                    return Enum.GetName(typeof(Meses), Fecha.Value.Month);

            }
        }

    }
    [Serializable]
    public class rpt_consultas_mes_tipoList 
        : Fwk.Bases.Entities<rpt_consultas_mes_tipo>
    { }
}
