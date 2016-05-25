using System;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Fwk.Bases;
using ClinicaMerced.Common.Entities;
using System.Linq;
using ClinicaMerced.Common;

namespace ClinicaMerced.Backend.DAC
{
    public class ParamComercialDAC
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pIdTipoParametro">Tipo (gasto, clase, forma pago etc)</param>
        /// <param name="pIdParamComercialRef">Relacion con otro param</param>
        /// <param name="vigente">Vigentes o no</param>
        /// <returns></returns>
        public static ParamComercialList GetByParams(int? pIdTipoParametro, int? pIdParamComercialRef, bool? vigente, string pCompanyId)
        {
            Database wDatabase = null;
            DbCommand wCmd = null;

            ParamComercialList list = new ParamComercialList();
            ParamComercialBE wParamComercialBE = null;
            try
            {
                wDatabase = DatabaseFactory.CreateDatabase(CommonDAC.clinica_cnnstring);
                wCmd = wDatabase.GetStoredProcCommand("ParamComercial_s_ByParam");


                wDatabase.AddInParameter(wCmd, "IdTipoParametro", System.Data.DbType.Int32, pIdTipoParametro);

                wDatabase.AddInParameter(wCmd, "IdParamComercialRef", System.Data.DbType.Int32, pIdParamComercialRef);

                wDatabase.AddInParameter(wCmd, "Vigente", System.Data.DbType.Boolean, vigente);

                //if(
                //wDatabase.AddInParameter(wCmd, "CompanyId", System.Data.DbType.String, pCompanyId);
                
                IDataReader reader = wDatabase.ExecuteReader(wCmd);

                #region Fill wGastoBECollection
                while (reader.Read())
                {
                    wParamComercialBE = new ParamComercialBE();
                    wParamComercialBE.IdParamComercial = Convert.ToInt32(reader["IdParamComercial"]);
                    if (reader["IdTipoParametro"] != DBNull.Value)
                        wParamComercialBE.IdTipoParametro = Convert.ToInt32(reader["IdTipoParametro"]);
                    wParamComercialBE.Nombre = reader["Nombre"].ToString().Trim();

                    if (reader["IdParamComercialRef"] != DBNull.Value)
                        wParamComercialBE.IdParamComercialRef = Convert.ToInt32(reader["IdParamComercialRef"]);
                    if (reader["NombreRef"] != DBNull.Value)
                        wParamComercialBE.NombreRef = reader["NombreRef"].ToString();

                    list.Add(wParamComercialBE);

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


        /// <summary>
        /// Obtiene una lista de gastos
        /// </summary>
        /// <returns></returns>
        public static TipoParametroList SearchAllTipoParametro(int? pIdTipo)
        {

            TipoParametroList wList = new TipoParametroList();
            TipoParametroBE wBE = null;
            try
            {
                //using (ClinicaMerced.Backend.GastosDataContext dc = new ClinicaMerced.Backend.GastosDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["ClinicaMerced"].ConnectionString))
                //{
                //    var rulesinCat = from s in dc.TipoParametros where s.IdTipoParametroRelacion == pIdTipo select s;
                //    foreach (ClinicaMerced.Backend.TipoParametro tp in rulesinCat.ToList<ClinicaMerced.Backend.TipoParametro>())
                //    { 
                //        wBE = new TipoParametroBE();

                //        wBE.IdTipoParametro = tp.IdTipoParametro;
                //        wBE.Nombre = tp.Nombre;

                //        wList.Add(wBE);
                //    }
                //}


                return wList;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pParamComercialBE"></param>
        /// <param name="pUserId"></param>
        /// <param name="pCompanyId"></param>
        public static void Create(ParamComercialBE pParamComercialBE, Guid pUserId,string pCompanyId)
        {
            Database wDatabase = null;
            DbCommand wCmd = null;

            try
            {
                wDatabase = DatabaseFactory.CreateDatabase(CommonDAC.clinica_cnnstring);
                wCmd = wDatabase.GetStoredProcCommand("ParamComercial_i");

                wDatabase.AddOutParameter(wCmd, "IdParamComercial", DbType.Int32, 4);

                wDatabase.AddInParameter(wCmd, "@IdTipoParametro", System.Data.DbType.Int32, pParamComercialBE.IdTipoParametro.Value);

                if(pParamComercialBE.IdParamComercialRef!=null)
                    wDatabase.AddInParameter(wCmd, "@IdParamComercialRef", System.Data.DbType.Int32, pParamComercialBE.IdParamComercialRef);

                wDatabase.AddInParameter(wCmd, "Nombre", System.Data.DbType.String, pParamComercialBE.Nombre);

                wDatabase.AddInParameter(wCmd, "UserId", DbType.Guid, pUserId);

                wDatabase.AddInParameter(wCmd, "CompanyId", System.Data.DbType.String, pCompanyId);

                if (!string.IsNullOrEmpty(pParamComercialBE.Descripcion))
                    wDatabase.AddInParameter(wCmd, "Descripcion", System.Data.DbType.String, pParamComercialBE.Descripcion);

                wDatabase.ExecuteNonQuery(wCmd);
                pParamComercialBE.IdParamComercial = (System.Int32)wDatabase.GetParameterValue(wCmd, "IdParamComercial");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pIdParamComercial"></param>
        public static void Delete(int pIdParamComercial)
        {

            Database wDatabase = null;
            DbCommand wCmd = null;

            try
            {
                wDatabase = DatabaseFactory.CreateDatabase(CommonDAC.clinica_cnnstring);
                wCmd = wDatabase.GetStoredProcCommand("ParamComercial_d");

                /// IdTipoGasto
                wDatabase.AddInParameter(wCmd, "IdParamComercial", System.Data.DbType.Int32, pIdParamComercial);


                wDatabase.ExecuteNonQuery(wCmd);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool IsUsed(int id)
        {
            Database wDatabase = null;
            DbCommand wCmd = null;

            try
            {
                wDatabase = DatabaseFactory.CreateDatabase(CommonDAC.clinica_cnnstring);
                wCmd = wDatabase.GetStoredProcCommand("ParamComercial_g_IsUsed");
                wDatabase.AddInParameter(wCmd, "IdParam", System.Data.DbType.Int32, id);
            

                wDatabase.AddOutParameter(wCmd, "Used", System.Data.DbType.Boolean,1);
                
                wDatabase.ExecuteNonQuery(wCmd);

                return (System.Boolean)wDatabase.GetParameterValue(wCmd, "Used");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}