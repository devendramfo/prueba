using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaMerced.Backend.DAC;
using ClinicaMerced.Common.Entities;
using ClinicaMerced.Common.Enums;
using ClinicaMerced.Common.Entities.Custom;
using ClinicaMerced.Backend.Entities;
using ClinicaMerced.Common.Entities.Angel;
using ClinicaMerced.Common.Entities.Repòrts;

namespace ClinicaMerced.Front
{
    internal class Controller 
    {
        static ParamComercialList _TipoConsultaList;

        public static ParamComercialList TipoConsultaList
        {
            get { return Controller._TipoConsultaList; }
            set { Controller._TipoConsultaList = value; }
        }

        static MutualList _MutualList;

        internal static MutualList MutualList
        {
            get { return _MutualList; }
            set { _MutualList = value; }
        }
        static ProfecionalList _ProfecionalList;

        internal static ProfecionalList ProfecionalList
        {
            get { return _ProfecionalList; }
            set { _ProfecionalList = value; }
        }


        static Controller()
        {
            _MutualList = EstablesIndependientesDAC.Search_MutualList_All();
            _MutualList.Add(new MutualBE { Nombre = "Todos", IdMutual = (int)CommonValuesEnum.TodosComboBoxValue });
            _MutualList.Add(new MutualBE { Nombre = Enum.GetName(typeof(CommonValuesEnum), CommonValuesEnum.Ninguno), IdMutual = (int)CommonValuesEnum.Ninguno });

            _ProfecionalList = EstablesIndependientesDAC.Search_ProfecionalList_ByParams(new ProfecionalBE());
            _ProfecionalList.Add(new ProfecionalBE { Nombre = "Todos", IdProfecional = (int)CommonValuesEnum.TodosComboBoxValue });
            _ProfecionalList.Add(new ProfecionalBE { Nombre = Enum.GetName(typeof(CommonValuesEnum), CommonValuesEnum.Ninguno), IdProfecional = (int)CommonValuesEnum.Ninguno });

            _TipoConsultaList = ParamComercialDAC.GetByParams(200, null, true, string.Empty);
            _TipoConsultaList.Add(new ParamComercialBE { Nombre = "Todos", IdParamComercial = (int)CommonValuesEnum.TodosComboBoxValue });
            _TipoConsultaList.Add(new ParamComercialBE { Nombre = Enum.GetName(typeof(CommonValuesEnum), CommonValuesEnum.Ninguno), IdParamComercial = (int)CommonValuesEnum.Ninguno });
        }

        internal static int CreateConsulta(ConsultaBE param)
        {

            ConsultaDAC.Create(param);
            return param.IdConsulta;
        }
        internal static void UpdateConsulta(ConsultaBE param)
        {
            ConsultaDAC.Update(param);
}
        internal static void DeleteConsulta(int param)
        {
            ConsultaDAC.Delete(param);
        }

        internal static ConsultaGridList SearchByParams(ConsultaBE param)
        {
            return ConsultaDAC.SearchByParams(param);
        }
        internal static ConsultaGridList SearchByParams(DateTime fecha)
        {
            return ConsultaDAC.SearchByDay(fecha);
        }

      



        internal static PatientList GetAllPatients()
        {
         return    AngelDAC.Patients_Get();

        }

        #region Reports and charts
        internal static Rpt_Consulta_FullList Search_Consulta_FullView_ByParams(ConsultaBE param)
        {

            return ConsultaViewDAC.SearchByParams(param);

        }

        internal static rpt_consultas_mes_tipoList rpt_consultas_mes_tipoList(List<string> pIdTipoConsultaList, DateTime? fechaIni, DateTime? fechaFin)
        {
            string lst = Fwk.HelperFunctions.FormatFunctions.GetStringBuilderWhitSeparator<string>(pIdTipoConsultaList, ',').ToString();
            return ConsultaViewDAC.rpt_consultas_mes_tipoList(lst, fechaIni, fechaFin);
        }

        /// <summary>
        /// Obtiene total diario de arancel y coseguro por profecional
        /// </summary>
        /// <param name="pIdTipoConsultaList"></param>
        /// <param name="fechaIni"></param>
        /// <param name="fechaFin"></param>
        /// <returns></returns>
        internal static rpt_consultas_mes_tipoList rpt_consultas_total_diario(List<string> pIdTipoConsultaList, DateTime? fechaIni, DateTime? fechaFin)
        {
            string lst = Fwk.HelperFunctions.FormatFunctions.GetStringBuilderWhitSeparator<string>(pIdTipoConsultaList, ',').ToString();
            return ConsultaViewDAC.rpt_consultas_total_diario(lst, fechaIni, fechaFin);
        }
        #endregion 
    }
}
