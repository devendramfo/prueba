using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaMerced.Common.Entities.Angel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Transactions;

namespace ClinicaMerced.Backend.DAC
{
    public class InsuranceNomenclatorDAC
    {

        public static void Import()
        {
            #region get data
            AngelDataContext dc = new AngelDataContext(System.Configuration.ConfigurationManager.ConnectionStrings[CommonDAC.clinica_cnnstring].ConnectionString);
            dc.Connection.Open();

            Int32? since = (from s in dc.nomenclators select (Nullable<Int32>)s.id).Max();
            if (!since.HasValue) since = 0;
            List<nomenclator> nomenclatorList = AngelDAC.nomenclator_GetAll(since.Value);

            List<nomenclator_expenses_value> nomenclator_expenses_valueList = AngelDAC.nomenclator_expenses_value_GetAll();
            List<nomenclator_practice> nomenclator_practiceList = AngelDAC.nomenclator_practice_GetAll();

            since = (from s in dc.nomenclator_practice_groups select (Nullable<Int32>)s.id).Max();
            if (!since.HasValue) since = 0;
            List<nomenclator_practice_group> nomenclator_practice_groupList = AngelDAC.nomenclator_practice_group_GetAll(since.Value);

            since = (from s in dc.medical_insurance_companies select (Nullable<Int32>)s.id).Max();
            if (!since.HasValue) since = 0;
            List<medical_insurance_company> medical_insurance_companyList = AngelDAC.medical_insurance_company_GetAll(since.Value);

            since = (from s in dc.medical_insurance_plans select (Nullable<Int32>)s.id).Max();
            if (!since.HasValue) since = 0;
            List<medical_insurance_plan> medical_insurance_planList = AngelDAC.medical_insurance_plan_GetAll(since.Value);

            dc.Connection.Close();
            #endregion


            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {

                ClearData();

                using (AngelDataContext _CoreDataContext = new AngelDataContext(System.Configuration.ConfigurationManager.ConnectionStrings[CommonDAC.clinica_cnnstring].ConnectionString))
                {
                    _CoreDataContext.Connection.Open();

                    #region Inserts

                    _CoreDataContext.nomenclators.InsertAllOnSubmit<nomenclator>(nomenclatorList);
                    _CoreDataContext.nomenclator_expenses_values.InsertAllOnSubmit<nomenclator_expenses_value>(nomenclator_expenses_valueList);
                    _CoreDataContext.nomenclator_practices.InsertAllOnSubmit<nomenclator_practice>(nomenclator_practiceList);
                    _CoreDataContext.nomenclator_practice_groups.InsertAllOnSubmit<nomenclator_practice_group>(nomenclator_practice_groupList);
                    _CoreDataContext.medical_insurance_companies.InsertAllOnSubmit<medical_insurance_company>(medical_insurance_companyList);
                    _CoreDataContext.medical_insurance_plans.InsertAllOnSubmit<medical_insurance_plan>(medical_insurance_planList);

                    #endregion

                    _CoreDataContext.SubmitChanges();

                }
                scope.Complete();
            }
        }

        public static void Import2()
        {
            #region get data
            AngelDataContext dc = new AngelDataContext(System.Configuration.ConfigurationManager.ConnectionStrings[CommonDAC.clinica_cnnstring].ConnectionString);
            dc.Connection.Open();

            Int32? since = (from s in dc.nomenclators select (Nullable<Int32>)s.id).Max();
            if (!since.HasValue) since = 0;
            List<nomenclator> nomenclatorList = AngelDAC.nomenclator_GetAll(since.Value);

            List<nomenclator_expenses_value> nomenclator_expenses_valueList = AngelDAC.nomenclator_expenses_value_GetAll();
            List<nomenclator_practice> nomenclator_practiceList = AngelDAC.nomenclator_practice_GetAll();

            since = (from s in dc.nomenclator_practice_groups select (Nullable<Int32>)s.id).Max();
            if (!since.HasValue) since = 0;
            List<nomenclator_practice_group> nomenclator_practice_groupList = AngelDAC.nomenclator_practice_group_GetAll(since.Value);

            since = (from s in dc.medical_insurance_companies select (Nullable<Int32>)s.id).Max();
            if (!since.HasValue) since = 0;
            List<medical_insurance_company> medical_insurance_companyList = AngelDAC.medical_insurance_company_GetAll(since.Value);

            since = (from s in dc.medical_insurance_plans select (Nullable<Int32>)s.id).Max();
            if (!since.HasValue) since = 0;
            List<medical_insurance_plan> medical_insurance_planList = AngelDAC.medical_insurance_plan_GetAll(since.Value);

            dc.Connection.Close();
            #endregion


            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {

                ClearData();
                scope.Complete();

            }

            using (AngelDataContext _CoreDataContext = new AngelDataContext(System.Configuration.ConfigurationManager.ConnectionStrings[CommonDAC.clinica_cnnstring].ConnectionString))
            {
                _CoreDataContext.Connection.Open();
                try
                {
                    _CoreDataContext.Transaction = _CoreDataContext.Connection.BeginTransaction();

                    #region Inserts

                    _CoreDataContext.nomenclators.InsertAllOnSubmit<nomenclator>(nomenclatorList);
                    _CoreDataContext.nomenclator_expenses_values.InsertAllOnSubmit<nomenclator_expenses_value>(nomenclator_expenses_valueList);
                    _CoreDataContext.nomenclator_practices.InsertAllOnSubmit<nomenclator_practice>(nomenclator_practiceList);
                    _CoreDataContext.nomenclator_practice_groups.InsertAllOnSubmit<nomenclator_practice_group>(nomenclator_practice_groupList);
                    _CoreDataContext.medical_insurance_companies.InsertAllOnSubmit<medical_insurance_company>(medical_insurance_companyList);
                    _CoreDataContext.medical_insurance_plans.InsertAllOnSubmit<medical_insurance_plan>(medical_insurance_planList);

                    #endregion

                    _CoreDataContext.SubmitChanges();
                    _CoreDataContext.Transaction.Commit();

                }
                catch (Exception ex)
                {
                    _CoreDataContext.Transaction.Rollback();
                    //throw ex;
                    //Helper.Log("Error en la transacción de datos al grabar los tweets.", ex);
                }
                finally
                {

                    _CoreDataContext.Connection.Close();
                }
            }

        }


        static void ClearData()
        {
            Database wDataBase = null;
            DbCommand wCmd = null;

            try
            {
                wDataBase = DatabaseFactory.CreateDatabase(CommonDAC.clinica_cnnstring);
                wCmd = wDataBase.GetStoredProcCommand("dbo.ClearExternaldata");
                wDataBase.ExecuteReader(wCmd);
            }
              
            catch (Exception ex)
            {
                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

        }
    }
}
