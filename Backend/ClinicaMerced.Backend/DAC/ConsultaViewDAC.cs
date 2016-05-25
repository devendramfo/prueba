using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaMerced.Common.Entities.Custom;
using ClinicaMerced.Backend.Entities;
using ClinicaMerced.Common.Entities;
using ClinicaMerced.Common.Entities.Repòrts;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

namespace ClinicaMerced.Backend.DAC
{
    public class ConsultaViewDAC
    {

        //public static Rpt_Consulta_FullList SearchByParams_(ConsultaBE param, DateTime? fechaFin)
        //{
        //    Rpt_Consulta_FullList list = new Rpt_Consulta_FullList();

        //    using (ClinicaEntities dc = new ClinicaEntities())
        //    {
        //        var x = from c in dc.Rpt_Consulta_Full
        //                where
        //                   (param.IdProfecional.Equals(null) || c.IdProfecional.Value == param.IdProfecional.Value)
        //                    &&
        //                    (c.IdTipoConsulta.Value == 200)
        //                    &&
        //                    (param.IdMutual.Equals(null) || c.IdMutual.Value == param.IdMutual.Value)
        //                    &&
        //                    (param.Fecha.Equals(null) || (c.Fecha >= param.Fecha && c.Fecha <= fechaFin))

        //                select c;

        //        foreach (Rpt_Consulta_Full i in x)
        //        {
        //            list.Add(new Rpt_Consulta_FullBE(i));
        //        }
        //    }

        //    return list;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="fechaFin"></param>
        /// <returns></returns>
        public static Rpt_Consulta_FullList SearchByParams(ConsultaBE param)
        {
            Rpt_Consulta_FullList list = new Rpt_Consulta_FullList();
            using (ClinicaEntities dc = new ClinicaEntities())
            {
                var x = from c in dc.Rpt_Consulta_Full
                        where
                            (param.IdProfecional.Equals(null) || c.IdProfecional.Value == param.IdProfecional.Value)
                            &&
                            (param.IdTipoConsulta.Equals(null) || c.IdTipoConsulta.Value == param.IdTipoConsulta.Value)
                            &&
                            (param.IdMutual.Equals(null) || c.IdMutual.Value == param.IdMutual.Value)
                            &&
                            (param.Fecha.Equals(null) || (c.Fecha >= param.Fecha && c.Fecha <= param.FechaFin))
                        select new Rpt_Consulta_FullBE
                        {
                            IdProfecional = c.IdProfecional,
                            IdMutual = c.IdMutual,
                            Fecha = c.Fecha,
                            PresentaOrden = c.PresentaOrden,
                            Coseguro = c.Coseguro,
                            ExigeCoseguro = c.ExigeCoseguro,
                            ArancelMutual = c.ArancelMutual,
                            IdTipoConsulta = c.IdTipoConsulta,
                            TipoConsulta = c.TipoConsulta,
                            Profecional = c.Profecional,
                            Mutual = c.Mutual,
                        };


                if (x.Count<Rpt_Consulta_FullBE>() == 0) return list;

                list.AddRange(x.ToArray<Rpt_Consulta_FullBE>());
            }

            return list;
        }



        public static rpt_consultas_mes_tipoList rpt_consultas_mes_tipoList(string pIdTipoConsultaList, DateTime? fechaIni, DateTime? fechaFin)
        {
            rpt_consultas_mes_tipoList list = new rpt_consultas_mes_tipoList();
            Database wDatabase = null;
            DbCommand wCmd = null;

            rpt_consultas_mes_tipo entity = null;
            try
            {
                wDatabase = DatabaseFactory.CreateDatabase(CommonDAC.clinica_cnnstring);
                wCmd = wDatabase.GetStoredProcCommand("rpt_Consulta_Mes_Tipo");
                if (!string.IsNullOrEmpty(pIdTipoConsultaList))
                    wDatabase.AddInParameter(wCmd, "IdTipoConsultaList", System.Data.DbType.String, pIdTipoConsultaList);
                wDatabase.AddInParameter(wCmd, "FechaDesde", System.Data.DbType.DateTime, fechaIni);
                wDatabase.AddInParameter(wCmd, "FechaHasta", System.Data.DbType.DateTime, fechaFin);

                IDataReader reader = wDatabase.ExecuteReader(wCmd);

                #region Fill wGastoBECollection
                while (reader.Read())
                {
                    entity = new rpt_consultas_mes_tipo();
                    if (reader["Mes"] != DBNull.Value)
                        entity.NumMes = Convert.ToInt32(reader["Mes"]);

                    entity.Arancel = Convert.ToDecimal(reader["Arancel"]);
                    entity.Coseguro = Convert.ToDecimal(reader["Coseguro"]);
                    if (reader["NombreProfecional"] != DBNull.Value)
                        entity.NombreProfecional = reader["NombreProfecional"].ToString().Trim();
                    entity.NombreTipoConsulta = reader["NombreTipoConsulta"].ToString().Trim();


                    list.Add(entity);

                }
                #endregion

                reader.Dispose();

                return list;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static rpt_consultas_mes_tipoList rpt_consultas_total_diario(string pIdTipoConsultaList, DateTime? fechaIni, DateTime? fechaFin)
        {
            rpt_consultas_mes_tipoList list = new rpt_consultas_mes_tipoList();
            Database wDatabase = null;
            DbCommand wCmd = null;

            rpt_consultas_mes_tipo entity = null;
            try
            {
                wDatabase = DatabaseFactory.CreateDatabase(CommonDAC.clinica_cnnstring);
                wCmd = wDatabase.GetStoredProcCommand("rpt_Consulta_TotalDiario");
                if (!string.IsNullOrEmpty(pIdTipoConsultaList))
                    wDatabase.AddInParameter(wCmd, "IdTipoConsultaList", System.Data.DbType.String, pIdTipoConsultaList);
                wDatabase.AddInParameter(wCmd, "FechaDesde", System.Data.DbType.DateTime, fechaIni);
                wDatabase.AddInParameter(wCmd, "FechaHasta", System.Data.DbType.DateTime, fechaFin);

                IDataReader reader = wDatabase.ExecuteReader(wCmd);

                #region Fill wGastoBECollection
                while (reader.Read())
                {
                    entity = new rpt_consultas_mes_tipo();
                    if (reader["Fecha"] != DBNull.Value)
                        entity.Fecha = Convert.ToDateTime(reader["Fecha"]);

                    entity.Arancel = Convert.ToDecimal(reader["Arancel"]);
                    entity.Coseguro = Convert.ToDecimal(reader["Coseguro"]);
                    if (reader["NombreProfecional"] != DBNull.Value)
                        entity.NombreProfecional = reader["NombreProfecional"].ToString().Trim();
                    entity.NombreTipoConsulta = reader["NombreTipoConsulta"].ToString().Trim();


                    list.Add(entity);

                }
                #endregion

                reader.Dispose();

                return list;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
