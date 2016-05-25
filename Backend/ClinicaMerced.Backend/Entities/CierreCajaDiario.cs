using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fwk.Bases;
using ClinicaMerced.Common.Enums;

namespace ClinicaMerced.Common.Entities
{
    [Serializable]
    public class CierreCajaDiarioList : BaseEntities<CierreCajaDiario>
    {
        public CierreCajaDiarioList Search_TipoIngreso(TipoIngresoCaja tipo)
        {
            CierreCajaDiarioList wCierreCajaDiarioList = new CierreCajaDiarioList();
            var list = from s in this where s.IdTipoIngreso.Equals((int)tipo) select s;

            wCierreCajaDiarioList.AddRange(list.ToArray<CierreCajaDiario>());
            return wCierreCajaDiarioList;
        }

        public CierreCajaDiarioList Search_Resetas()
        {
            CierreCajaDiarioList wCierreCajaDiarioList = new CierreCajaDiarioList ();
            var list = from s in this where s.IdIipoConsulta.Equals((int) TipoConsulta.Recetario) select s;

             wCierreCajaDiarioList.AddRange(list.ToArray<CierreCajaDiario>());
             return wCierreCajaDiarioList;
        }

        public CierreCajaDiarioList Search_TipoProfecional(TipoProfecional pTipoProfecional)
        {
            CierreCajaDiarioList wCierreCajaDiarioList = new CierreCajaDiarioList();
            var list = from s in this where s.IdIipoProfecional.Equals((int)pTipoProfecional) select s;

            wCierreCajaDiarioList.AddRange(list.ToArray<CierreCajaDiario>());
            return wCierreCajaDiarioList;
        }
        public CierreCajaDiarioList Search_ConsultaMedica()
        {
            CierreCajaDiarioList wCierreCajaDiarioList = new CierreCajaDiarioList();
            var list = from s in this where s.IdIipoConsulta.Equals((int)TipoConsulta.ConsultaMedica) select s;

            wCierreCajaDiarioList.AddRange(list.ToArray<CierreCajaDiario>());
            return wCierreCajaDiarioList;
        }
    }
    [Serializable]
    public class CierreCajaDiario:BaseEntity
    {
        public DateTime Fecha { get; set; }
        public int IdIipoConsulta { get; set; }
        public int IdIipoProfecional { get; set; }
        public int IdProfecional { get; set; }
        public string NombreProfecional { get; set; }
        public decimal TotalCoseguro { get; set; }
        public decimal TotalArancel { get; set; }
        bool _Update = false;

        public bool Update
        {
            get { return _Update; }
            set { _Update = value; }
        }


        public int IdToUpdate { get; set; }

        public int? IdTipoIngreso { get; set; }
    }
}
