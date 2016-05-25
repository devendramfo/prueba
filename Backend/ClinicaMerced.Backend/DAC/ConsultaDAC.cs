using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaMerced.Common.Entities;
using ClinicaMerced.Backend.Entities;
using ClinicaMerced.Common.Entities.Custom;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

namespace ClinicaMerced.Backend.DAC
{
    public class ConsultaDAC
    {
       
      
        	
		/// <summary>
		/// SearchByParam
		/// </summary>
		///<param name="pConsulta">Consulta</param>
		/// <returns>ConsultaList</returns>
		/// <Date>2011-09-23T11:21:03</Date>
		/// <Author>marcelo</Author>
        public static ConsultaGridList SearchByParams_(ConsultaBE pConsulta)
        {
            Database wDataBase = null;
            DbCommand wCmd = null;
            ConsultaGridList wConsultaList = new ConsultaGridList();
            ConsultaGrid wConsultaGrid;


            try
            {
                wDataBase = DatabaseFactory.CreateDatabase(CommonDAC.clinica_cnnstring);
                wCmd = wDataBase.GetStoredProcCommand("dbo.Consulta_s");
                wDataBase.AddInParameter(wCmd, "IdTipoConsulta", System.Data.DbType.Int32, pConsulta.IdTipoConsulta);
                wDataBase.AddInParameter(wCmd, "IdProfecional", System.Data.DbType.Int32, pConsulta.IdProfecional);

                wDataBase.AddInParameter(wCmd, "IdMutual", System.Data.DbType.Int32, pConsulta.IdMutual);

                wDataBase.AddInParameter(wCmd, "FechaDesde", System.Data.DbType.DateTime, pConsulta.Fecha);
                wDataBase.AddInParameter(wCmd, "FechaHasta", System.Data.DbType.DateTime, pConsulta.FechaFin);
                if (!string.IsNullOrEmpty(pConsulta.NombreCliente))
                    wDataBase.AddInParameter(wCmd, "NombreCliente", System.Data.DbType.String, pConsulta.NombreCliente);

                wDataBase.AddInParameter(wCmd, "PresentaOrden", System.Data.DbType.Boolean, pConsulta.PresentaOrden);


                using (IDataReader reader = wDataBase.ExecuteReader(wCmd))
                {
                    while (reader.Read())
                    {
                        wConsultaGrid = new ConsultaGrid();
                        wConsultaGrid.IdConsulta = Convert.ToInt32(reader["IdConsulta"]);
                        wConsultaGrid.IdTipoConsulta = Convert.ToInt32(reader["IdTipoConsulta"]);

                        if (reader["IdProfecional"] != DBNull.Value)
                            wConsultaGrid.IdProfecional = Convert.ToInt32(reader["IdProfecional"]);

                        wConsultaGrid.Descripcion = reader["Descripcion"].ToString();
                        wConsultaGrid.Coseguro = Convert.ToInt32(reader["Coseguro"]);
                        wConsultaGrid.Fecha = Convert.ToDateTime(reader["Fecha"]);

                        if (reader["IdMutual"] != DBNull.Value)
                            wConsultaGrid.IdMutual = Convert.ToInt32(reader["IdMutual"]);

                        wConsultaGrid.MutualNombre = reader["MutualNombre"].ToString();
                        wConsultaGrid.ProfecionalNombre = reader["ProfecionalNombre"].ToString();
                        wConsultaGrid.TelefonoCliente = reader["TelefonoCliente"].ToString();

                        wConsultaGrid.NombreCliente = reader["NombreCliente"].ToString();
                        wConsultaGrid.NroAfiliadoMutual = reader["NroAfiliadoMutual"].ToString();

                        if (reader["PresentaOrden"] != DBNull.Value)
                            wConsultaGrid.PresentaOrden = Convert.ToBoolean(reader["PresentaOrden"]);
                        if (reader["ExigeCoseguro"] != DBNull.Value)
                            wConsultaGrid.ExigeCoseguro = Convert.ToBoolean(reader["ExigeCoseguro"]);
                        if (reader["ArancelMutual"] != DBNull.Value)
                            wConsultaGrid.ArancelMutual = Convert.ToDecimal(reader["ArancelMutual"]);

                        wConsultaList.Add(wConsultaGrid);
                    }
                }

                return wConsultaList;

            }
            catch (Exception ex)
            {
                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

        }


        //tira error Only primitive types ('such as Int32, String, and Guid') are supported in this context.
        //public static ConsultaGridList SearchByParams(ConsultaBE param, DateTime? fechaFin)
        //{


        //    foreach (Consulta c in x)
        //    {
        //        ConsultaGrid wConsultaGrid = new ConsultaGrid();
        //        wConsultaGrid.Descripcion = c.Descripcion;
        //        wConsultaGrid.Coseguro = c.Coseguro;
        //        wConsultaGrid.Fecha = c.Fecha;
        //        wConsultaGrid.IdConsulta = c.IdConsulta;
        //        wConsultaGrid.IdMutual = c.IdMutual;
        //        wConsultaGrid.IdProfecional = c.IdProfecional;
        //        wConsultaGrid.MutualNombre = c.Mutual.Nombre;
        //        wConsultaGrid.NombreCliente = c.Profecional.Nombre;
        //        wConsultaGrid.TelefonoCliente = c.TelefonoCliente;
        //        wConsultaGrid.NroAfiliadoMutual = c.NroAfiliadoMutual;
        //        wConsultaGrid.IdTipoConsulta = c.IdTipoConsulta;
        //        wConsultaGrid.PresentaOrden = c.PresentaOrden;

        //    }

        //    //list.AddRange(x.ToArray<ConsultaGrid>());
        //}
    

        public static ConsultaGridList SearchByParams_old(ConsultaBE param)
        {
            ConsultaGridList list = new ConsultaGridList();
            using (ClinicaEntities dc = new ClinicaEntities())
            {
                var x = from c in dc.Consulta
                        where
                            (param.IdProfecional.Equals(null) || c.IdProfecional==param.IdProfecional)
                            &&
                            ( c.IdTipoConsulta == 200)
                            &&
                            (param.IdMutual.Equals(null) || c.IdMutual.Value == param.IdMutual.Value)
                          
                            &&
                            (string.IsNullOrEmpty(param.NombreCliente) || c.NombreCliente.Contains(param.NombreCliente))
                            &&
                            (param.PresentaOrden.Equals(null) || c.PresentaOrden.Value== param.PresentaOrden.Value)
                             &&
                            (param.IdTipoConsulta.Equals(null) || c.IdTipoConsulta.Value == param.IdTipoConsulta.Value)
                              &&
                            (param.Fecha.Equals(null) || (c.Fecha >=param.Fecha && c.Fecha <= param.FechaFin ))

                        select new ConsultaGrid
                        {
                            Descripcion = c.Descripcion,
                            Coseguro = c.Coseguro,
                            Fecha = c.Fecha,
                            IdConsulta = c.IdConsulta,
                            IdMutual = c.IdMutual,
                            IdProfecional = c.IdProfecional,
                            MutualNombre = c.Mutual.Nombre,
                            NombreCliente = c.NombreCliente,
                            ProfecionalNombre = c.Profecional.Nombre,
                            TelefonoCliente = c.TelefonoCliente,
                            NroAfiliadoMutual = c.NroAfiliadoMutual,
                            IdTipoConsulta = c.IdTipoConsulta,
                            PresentaOrden = c.PresentaOrden,
                            ExigeCoseguro = c.ExigeCoseguro,
                            ArancelMutual = c.ArancelMutual
                        };
                if (x.Count<ConsultaGrid>() == 0) return list;

                list.AddRange(x.ToArray<ConsultaGrid>());
            }

            return list;
        }


        public static ConsultaGridList SearchByParams(ConsultaBE param)
        {
            ConsultaGridList list = new ConsultaGridList();
            using (ClinicaEntities dc = new ClinicaEntities())
            {
                var x = from c in dc.ConsultaView
                        where
                            (param.IdProfecional.Equals(null) || c.IdProfecional == param.IdProfecional)
                            &&
                            (c.IdTipoConsulta == 200)
                            &&
                            (param.IdMutual.Equals(null) || c.IdMutual.Value == param.IdMutual.Value)

                            &&
                            (string.IsNullOrEmpty(param.NombreCliente) || c.NombreCliente.Contains(param.NombreCliente))
                            &&
                            (param.PresentaOrden.Equals(null) || c.PresentaOrden.Value == param.PresentaOrden.Value)
                             &&
                            (param.IdTipoConsulta.Equals(null) || c.IdTipoConsulta.Value == param.IdTipoConsulta.Value)
                              &&
                            (param.Fecha.Equals(null) || (c.Fecha >= param.Fecha && c.Fecha <= param.FechaFin))

                        select new ConsultaGrid
                        {
                            Descripcion = c.Descripcion,
                            Coseguro = c.Coseguro,
                            Fecha = c.Fecha,
                            IdConsulta = c.IdConsulta,
                            IdMutual = c.IdMutual,
                            IdProfecional = c.IdProfecional,
                            MutualNombre = c.NombreMutual,
                            NombreCliente = c.NombreCliente,
                            ProfecionalNombre = c.NombreProfesional,
                            TipoConsultaNombre = c.NombreTipoConsulta,
                            TelefonoCliente = c.TelefonoCliente,
                            NroAfiliadoMutual = c.NroAfiliadoMutual,
                            IdTipoConsulta = c.IdTipoConsulta,
                            PresentaOrden = c.PresentaOrden,
                            ExigeCoseguro = c.ExigeCoseguro,
                            ArancelMutual = c.ArancelMutual
                        };
                if (x.Count<ConsultaGrid>() == 0) return list;

                list.AddRange(x.ToArray<ConsultaGrid>());
            }

            return list;
        }

        public static ConsultaGridList SearchByDay(DateTime fecha)
        {
            ConsultaGridList list = new ConsultaGridList();
            using (ClinicaEntities dc = new ClinicaEntities())
            {
                var x = from c in dc.ConsultaView
                        where
                                  c.Fecha.Day.Equals(fecha.Day) &&
                                  c.Fecha.Month.Equals(fecha.Month) &&
                                  c.Fecha.Year.Equals(fecha.Year)




                        select new ConsultaGrid
                        {
                            Descripcion = c.Descripcion,
                            Coseguro = c.Coseguro,
                            Fecha = c.Fecha,
                            IdConsulta = c.IdConsulta,
                            IdMutual = c.IdMutual,
                            IdProfecional = c.IdProfecional,
                            MutualNombre = c.NombreMutual,
                            NombreCliente = c.NombreCliente,
                            ProfecionalNombre = c.NombreProfesional,
                            TipoConsultaNombre = c.NombreTipoConsulta,
                            TelefonoCliente = c.TelefonoCliente,
                            NroAfiliadoMutual = c.NroAfiliadoMutual,
                            IdTipoConsulta = c.IdTipoConsulta,
                            PresentaOrden = c.PresentaOrden,
                            ExigeCoseguro = c.ExigeCoseguro,
                            ArancelMutual = c.ArancelMutual
                        };

                list.AddRange(x.ToArray<ConsultaGrid>());
            }

            return list;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pConsultaBE"></param>
        public static  void Create(ConsultaBE pConsultaBE)
        {
            Consulta c = pConsultaBE.GetConsultaEF();
            using (ClinicaEntities dc = new ClinicaEntities())
            {
                pConsultaBE.UserName = Environment.UserName;
                dc.Consulta.AddObject(c);
                dc.SaveChanges();
            }
        }

        /// <summary>
        /// Insert
        /// </summary>
        ///<param name="pConsulta">Consulta</param>
        /// <returns>void</returns>
        /// <Date>2011-09-23T15:48:36</Date>
        /// <Author>marcelo</Author>
        public static void Insert(ConsultaBE pConsulta)
        {
            Database wDataBase = null;
            DbCommand wCmd = null;

            try
            {
                wDataBase = DatabaseFactory.CreateDatabase(CommonDAC.clinica_cnnstring);
                wCmd = wDataBase.GetStoredProcCommand("Consulta_i");
                /// IdConsulta
                wDataBase.AddOutParameter(wCmd, "IdConsulta", System.Data.DbType.Int32, 4);

                wDataBase.AddInParameter(wCmd, "IdTipoConsulta", System.Data.DbType.Int32, pConsulta.IdTipoConsulta);

                wDataBase.AddInParameter(wCmd, "IdProfecional", System.Data.DbType.Int32, pConsulta.IdProfecional);

                wDataBase.AddInParameter(wCmd, "IdMutual", System.Data.DbType.Int32, pConsulta.IdMutual);

                wDataBase.AddInParameter(wCmd, "NroAfiliadoMutual", System.Data.DbType.String, pConsulta.NroAfiliadoMutual);

                wDataBase.AddInParameter(wCmd, "Fecha", System.Data.DbType.DateTime, pConsulta.Fecha);

                wDataBase.AddInParameter(wCmd, "Descripcion", System.Data.DbType.String, pConsulta.Descripcion);

                wDataBase.AddInParameter(wCmd, "NombreCliente", System.Data.DbType.String, pConsulta.NombreCliente);

                wDataBase.AddInParameter(wCmd, "PresentaOrden", System.Data.DbType.Boolean, pConsulta.PresentaOrden);

                wDataBase.AddInParameter(wCmd, "TelefonoCliente", System.Data.DbType.String, pConsulta.TelefonoCliente);

                wDataBase.AddInParameter(wCmd, "Coseguro", System.Data.DbType.Decimal, pConsulta.Coseguro);
                
                wDataBase.AddInParameter(wCmd, "ExigeCoseguro", System.Data.DbType.Boolean, pConsulta.ExigeCoseguro);
                wDataBase.AddInParameter(wCmd, "ArancelMutual", System.Data.DbType.Boolean, pConsulta.ArancelMutual);
                wDataBase.AddInParameter(wCmd, "UserName", System.Data.DbType.Boolean, Environment.UserName);
                wDataBase.ExecuteNonQuery(wCmd);


                pConsulta.IdConsulta = (System.Int32)wDataBase.GetParameterValue(wCmd, "IdConsulta");

            }
            catch (Exception ex)
            {
                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

        }

        /// <summary>
        /// Insert
        /// </summary>
        ///<param name="pConsulta">Consulta</param>
        /// <returns>void</returns>
        /// <Date>2011-09-23T15:48:36</Date>
        /// <Author>marcelo</Author>
        public static void Update(ConsultaBE pConsulta)
        {
            Database wDataBase = null;
            DbCommand wCmd = null;

            try
            {
                wDataBase = DatabaseFactory.CreateDatabase(CommonDAC.clinica_cnnstring);
                wCmd = wDataBase.GetStoredProcCommand("Consulta_u");
                /// IdConsulta
                wDataBase.AddInParameter(wCmd, "IdConsulta", System.Data.DbType.Int32, pConsulta.IdConsulta);

                wDataBase.AddInParameter(wCmd, "IdTipoConsulta", System.Data.DbType.Int32, pConsulta.IdTipoConsulta);

                wDataBase.AddInParameter(wCmd, "IdProfecional", System.Data.DbType.Int32, pConsulta.IdProfecional);

                wDataBase.AddInParameter(wCmd, "IdMutual", System.Data.DbType.Int32, pConsulta.IdMutual);

                wDataBase.AddInParameter(wCmd, "NroAfiliadoMutual", System.Data.DbType.String, pConsulta.NroAfiliadoMutual);

                //wDataBase.AddInParameter(wCmd, "Fecha", System.Data.DbType.DateTime, pConsulta.Fecha);

                wDataBase.AddInParameter(wCmd, "Descripcion", System.Data.DbType.String, pConsulta.Descripcion);

                wDataBase.AddInParameter(wCmd, "NombreCliente", System.Data.DbType.String, pConsulta.NombreCliente);

                wDataBase.AddInParameter(wCmd, "PresentaOrden", System.Data.DbType.Boolean, pConsulta.PresentaOrden);

                wDataBase.AddInParameter(wCmd, "TelefonoCliente", System.Data.DbType.String, pConsulta.TelefonoCliente);

                wDataBase.AddInParameter(wCmd, "Coseguro", System.Data.DbType.Decimal, pConsulta.Coseguro);

                wDataBase.AddInParameter(wCmd, "ExigeCoseguro", System.Data.DbType.Boolean, pConsulta.ExigeCoseguro);
                wDataBase.AddInParameter(wCmd, "UserName", System.Data.DbType.Decimal, pConsulta.UserName);
                wDataBase.AddInParameter(wCmd, "ArancelMutual", System.Data.DbType.Decimal, pConsulta.ArancelMutual);
                wDataBase.ExecuteNonQuery(wCmd);


                pConsulta.IdConsulta = (System.Int32)wDataBase.GetParameterValue(wCmd, "IdConsulta");

            }
            catch (Exception ex)
            {
                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

        }

        /// <summary>
        /// Delete
        /// </summary>
        ///<param name="pIdConsulta">Id por el cual realizar la busqueda de registros a eliminar de tabla Consulta</param>
        /// <returns>void</returns>
        /// <Date>2011-10-05T20:40:47</Date>
        /// <Author>marcelo</Author>
        public static void Delete(System.Int32 pIdConsulta)
        {
            Database wDataBase = null;
            DbCommand wCmd = null;

            try
            {
                wDataBase = DatabaseFactory.CreateDatabase(CommonDAC.clinica_cnnstring);
                wCmd = wDataBase.GetStoredProcCommand("Consulta_d");

                wDataBase.AddInParameter(wCmd, "IdConsulta", System.Data.DbType.Int32, pIdConsulta);

                wDataBase.ExecuteNonQuery(wCmd);
            }
            catch (Exception ex)
            {
                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

        }

    }
}
