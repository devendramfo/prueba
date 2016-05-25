using System;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Fwk.Bases;
using ClinicaMerced.Common.Entities;
using System.Linq;
using ClinicaMerced.Common;
using System.Transactions;
using System.Collections.Generic;
using ClinicaMerced.Common.Enums;
namespace ClinicaMerced.Backend.DAC
{
    public class CajaDAC
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static bool Exist(DateTime fecha, int idProfecional)
        {
            using (ClinicaMerced.Common.Entities.Caja.ClinicaCajaDataContext dc = new ClinicaMerced.Common.Entities.Caja.ClinicaCajaDataContext(CommonDAC.clinica_cnnstring_value))
            {
                return dc.CierreCajaDiarios.Any<ClinicaMerced.Common.Entities.Caja.CierreCajaDiario>(
                    s => s.Fecha.Value.Day.Equals(fecha.Day)
                        && s.IdProfecional.Equals(idProfecional));
            }
        }

        public static bool Exist(DateTime fecha, TipoIngresoCaja tipoIngresoCaja)
        {
            using (ClinicaMerced.Common.Entities.Caja.ClinicaCajaDataContext dc = new ClinicaMerced.Common.Entities.Caja.ClinicaCajaDataContext(CommonDAC.clinica_cnnstring_value))
            {
                return dc.CierreCajaDiarios.Any<ClinicaMerced.Common.Entities.Caja.CierreCajaDiario>(
                    s => s.Fecha.Value.Day.Equals(fecha.Day)
                        && s.IdTipoIngreso == (int)tipoIngresoCaja);
            }
        }
        public static ClinicaMerced.Common.Entities.Caja.CierreCajaDiario Get(DateTime fecha, int idProfecional)
        {
          
            using (ClinicaMerced.Common.Entities.Caja.ClinicaCajaDataContext dc = new ClinicaMerced.Common.Entities.Caja.ClinicaCajaDataContext())
            {
                var x = from s in  dc.CierreCajaDiarios where
                  s.Fecha.Value.ToShortDateString().Equals(fecha.ToShortDateString())
                        && s.IdProfecional.Equals(idProfecional) select s;
                return x.FirstOrDefault<ClinicaMerced.Common.Entities.Caja.CierreCajaDiario>();
            }
        }

        public static CierreCajaDiarioList Retrive_Consultas_CierreCajaDiario(DateTime fecha)
        {
            Database wDatabase = null;
            DbCommand wCmd = null;
            CierreCajaDiarioList list = new CierreCajaDiarioList();
            CierreCajaDiario wCierreCajaDiario = null;
            try
            {
                wDatabase = DatabaseFactory.CreateDatabase(CommonDAC.clinica_cnnstring);
                wCmd = wDatabase.GetStoredProcCommand("Consultas_CierreCajaDiario_g");
                wDatabase.AddInParameter(wCmd, "fecha", System.Data.DbType.DateTime, fecha);

                IDataReader reader = wDatabase.ExecuteReader(wCmd);

                #region Fill wGastoBECollection
                while (reader.Read())
                {
                    wCierreCajaDiario = new CierreCajaDiario();
                    wCierreCajaDiario.Fecha = Convert.ToDateTime(reader["fecha"]);
                    wCierreCajaDiario.IdIipoConsulta = Convert.ToInt32(reader["idtipoconsulta"]);
                    if (reader["idprofecional"] != DBNull.Value)
                        wCierreCajaDiario.IdProfecional = Convert.ToInt32(reader["idprofecional"]);

                    if (reader["IdIipoProfecional"] != DBNull.Value)
                        wCierreCajaDiario.IdIipoProfecional = Convert.ToInt32(reader["IdIipoProfecional"]);

                    wCierreCajaDiario.NombreProfecional = reader["NombreProfecional"].ToString().Trim();

                    if (reader["TotalCoseguro"] != DBNull.Value)
                        wCierreCajaDiario.TotalCoseguro = Convert.ToDecimal(reader["TotalCoseguro"]);
                    if (reader["TotalArancel"] != DBNull.Value)
                        wCierreCajaDiario.TotalArancel = Convert.ToDecimal(reader["TotalArancel"]);

                    list.Add(wCierreCajaDiario);

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

        public static CierreCajaDiarioList Retrive_CierreCaja( DateTime fechaDesde , DateTime fechaHasta,int? idProfecional )
        {
            Database wDatabase = null;
            DbCommand wCmd = null;
            CierreCajaDiarioList list = new CierreCajaDiarioList();
            CierreCajaDiario wCierreCajaDiario = null;
            try
            {
                wDatabase = DatabaseFactory.CreateDatabase(CommonDAC.clinica_cnnstring);
                wCmd = wDatabase.GetStoredProcCommand("CierreCajaDiario_g");
                wDatabase.AddInParameter(wCmd, "FechaDesde", System.Data.DbType.DateTime, fechaDesde);
                wDatabase.AddInParameter(wCmd, "fechaHasta", System.Data.DbType.DateTime, fechaHasta);

                IDataReader reader = wDatabase.ExecuteReader(wCmd);

                #region Fill wGastoBECollection
                while (reader.Read())
                {
                    wCierreCajaDiario = new CierreCajaDiario();
                    wCierreCajaDiario.Fecha = Convert.ToDateTime(reader["fecha"]);

                    if (reader["IdProfecional"] != DBNull.Value)
                        wCierreCajaDiario.IdProfecional = Convert.ToInt32(reader["IdProfecional"]);

                    wCierreCajaDiario.IdTipoIngreso = Convert.ToInt32(reader["IdTipoIngreso"]);

                        wCierreCajaDiario.NombreProfecional = reader["NombreProfecional"].ToString().Trim();

                    if (reader["Coseguro"] != DBNull.Value)
                        wCierreCajaDiario.TotalCoseguro = Convert.ToDecimal(reader["Coseguro"]);
                    if (reader["Arancel"] != DBNull.Value)
                        wCierreCajaDiario.TotalArancel = Convert.ToDecimal(reader["Arancel"]);

                    list.Add(wCierreCajaDiario);

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
        public static void Create(List<ClinicaMerced.Common.Entities.Caja.CierreCajaDiario>  list)
        {
            
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                using (ClinicaMerced.Common.Entities.Caja.ClinicaCajaDataContext dc =
                    new ClinicaMerced.Common.Entities.Caja.ClinicaCajaDataContext(CommonDAC.clinica_cnnstring_value))
                {
                
                    foreach (ClinicaMerced.Common.Entities.Caja.CierreCajaDiario c in list)
                    {
                        dc.CierreCajaDiarios.InsertOnSubmit(c);
                    }
                    dc.SubmitChanges();
                }
                scope.Complete();
            }
        }
        public static List<ClinicaMerced.Common.Entities.Caja.vw_ConsultaToCierreCajaDetail> Retrive_Details(DateTime f)
        {
            using (ClinicaMerced.Common.Entities.Caja.ClinicaCajaDataContext dc = new ClinicaMerced.Common.Entities.Caja.ClinicaCajaDataContext(CommonDAC.clinica_cnnstring_value))
            {
                return dc.vw_ConsultaToCierreCajaDetails.Where(
                    p => p.Fecha.Day.Equals(f.Day) &&
                        p.Fecha.Month.Equals(f.Month) &&
                        p.Fecha.Year.Equals(f.Year)).ToList<ClinicaMerced.Common.Entities.Caja.vw_ConsultaToCierreCajaDetail>();
            }
        }


    }
}
