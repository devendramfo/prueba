using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;
using ClinicaMerced.Backend.Entities;
using ClinicaMerced.Common.Entities.Angel;


namespace ClinicaMerced.Backend.DAC
{
    public class AngelDAC
    {
        static string cmsys_cnnstring;
        static AngelDAC()
        {
            cmsys_cnnstring = System.Configuration.ConfigurationManager.ConnectionStrings["cmsys"].ConnectionString;
        }

        public static PatientList Patients_Get()
        {
            //DataSet ds;
            //MySqlDataAdapter da;
            PatientList wPatientList = new PatientList();
            Patient wPatient;
            using (MySqlConnection conn = new MySqlConnection(cmsys_cnnstring))
            {
                try
                {
                    conn.Open();
                    MySqlCommand wCommand = new MySqlCommand("select * from patient", conn);
                    //da = new MySqlDataAdapter("select * from patients", conn);
                    //MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                    //ds = new DataSet();


                    //da.Fill(ds, "Patients");

                    MySqlDataReader myReader = wCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        wPatient = new Patient();
                        if (myReader["birth"] != DBNull.Value)
                            wPatient.birth = myReader.GetDateTime("birth");
                        if (myReader["business_addy"] != DBNull.Value)
                            wPatient.business_addy = myReader.GetString("business_addy");
                        if (myReader["business_city"] != DBNull.Value)
                            wPatient.business_city = myReader.GetString("business_city");

                        if (myReader["business_country_id"] != DBNull.Value)
                            wPatient.business_country_id = myReader.GetInt32("business_country_id");
                        if (myReader["business_email"] != DBNull.Value)
                            wPatient.business_email = myReader.GetString("business_email");
                        if (myReader["business_phone"] != DBNull.Value)
                            wPatient.business_phone = myReader.GetString("business_phone");

                        if (myReader["business_province_id"] != DBNull.Value)
                            wPatient.business_province_id = myReader.GetInt32("business_province_id");

                        if (myReader["business_province_name"] != DBNull.Value)
                            wPatient.business_province_name = myReader.GetString("business_province_name");
                        if (myReader["business_province_name"] != DBNull.Value)
                            wPatient.business_zip_code = myReader.GetString("business_province_name");
                        if (myReader["business_province_name"] != DBNull.Value)
                            wPatient.business_zip_code = myReader.GetString("business_province_name");
                        if (myReader["business_province_name"] != DBNull.Value)
                            wPatient.cuil = myReader.GetString("business_province_name");

                        if (myReader["death"] != DBNull.Value)
                            wPatient.death = myReader.GetDateTime("death");

                        //wPatient.extra = myReader.GetString("extra");
                        if (myReader["first_name"] != DBNull.Value)
                            wPatient.first_name = myReader.GetString("first_name");
                        if (myReader["home_addy"] != DBNull.Value)
                            wPatient.home_addy = myReader.GetString("home_addy");
                        if (myReader["home_city"] != DBNull.Value)
                            wPatient.home_city = myReader.GetString("home_city");



                        if (myReader["home_country_id"] != DBNull.Value)
                            wPatient.home_country_id = myReader.GetInt32("home_country_id");

                        if (myReader["home_email"] != DBNull.Value)
                            wPatient.home_phone = myReader.GetString("home_email");

                        if (myReader["home_province_id"] != DBNull.Value)
                            wPatient.home_province_id = myReader.GetInt32("home_province_id");

                        if (myReader["home_province_name"] != DBNull.Value)
                            wPatient.home_province_name = myReader.GetString("home_province_name");
                        if (myReader["home_zip_code"] != DBNull.Value)
                            wPatient.home_zip_code = myReader.GetString("home_zip_code");

                        wPatient.id1 = myReader.GetInt32("id1");
                        wPatient.id2 = myReader.GetInt32("id2");

                        if (myReader["last_name"] != DBNull.Value)
                            wPatient.last_name = myReader.GetString("last_name");

                        if (myReader["marital_status"] != DBNull.Value)
                            wPatient.marital_status = myReader.GetInt32("marital_status");

                        if (myReader["notes"] != DBNull.Value)
                            wPatient.notes = myReader.GetString("notes");

                        if (myReader["occupation"] != DBNull.Value)
                            wPatient.occupation = myReader.GetString("occupation");

                        if (myReader["patient_medins_default_plan_id"] != DBNull.Value)
                            wPatient.patient_medins_default_plan_id = myReader.GetInt32("patient_medins_default_plan_id");

                        if (myReader["relative_addy"] != DBNull.Value)
                            wPatient.relative_addy = myReader.GetString("relative_addy");

                        if (myReader["relative_city"] != DBNull.Value)
                            wPatient.relative_city = myReader.GetString("relative_city");

                        if (myReader["relative_country_id"] != DBNull.Value)
                            wPatient.relative_country_id = myReader.GetInt32("relative_country_id");

                        wPatientList.Add(wPatient);

                    }
                    myReader.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex1)
                {
                    Fwk.Exceptions.TechnicalException te = new Fwk.Exceptions.TechnicalException("Problemas de coneccion a base de adatos MySQL\r\ncomuniquese con su administrador", ex1);
                    te.ErrorId = "3001";
                    throw te;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return wPatientList;
            }


        }


        public static List<nomenclator> nomenclator_GetAll(int since)
        {

            List<nomenclator> wnomenclatorList = new List<nomenclator>();
            nomenclator wNomenclator;
            using (MySqlConnection conn = new MySqlConnection(cmsys_cnnstring))
            {
                try
                {
                    conn.Open();
                    MySqlCommand wCommand = new MySqlCommand(string.Format("select * from nomenclator where id > {0} ",since), conn);

                    MySqlDataReader myReader = wCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        wNomenclator = new nomenclator();
                        if (myReader["code"] != DBNull.Value)
                            wNomenclator.code = myReader.GetString("code");
                        if (myReader["description"] != DBNull.Value)
                            wNomenclator.description = myReader.GetString("description");
                        if (myReader["id"] != DBNull.Value)
                            wNomenclator.id = myReader.GetInt32("id");

                        if (myReader["owner_description"] != DBNull.Value)
                            wNomenclator.owner_description = myReader.GetString("owner_description");
                        if (myReader["owner_id1"] != DBNull.Value)
                            wNomenclator.owner_id1 = myReader.GetInt32("owner_id1");
                        if (myReader["owner_id2"] != DBNull.Value)
                            wNomenclator.owner_id2 = myReader.GetInt32("owner_id2");

                        

                        wnomenclatorList.Add(wNomenclator);

                    }
                    myReader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return wnomenclatorList;
            }


        }


        public static List<nomenclator_expenses_value> nomenclator_expenses_value_GetAll()
        {

            List<nomenclator_expenses_value> wnomenclatorList = new List<nomenclator_expenses_value>();
            nomenclator_expenses_value wNomenclator;
            using (MySqlConnection conn = new MySqlConnection(cmsys_cnnstring))
            {
                try
                {
                    conn.Open();
                    MySqlCommand wCommand = new MySqlCommand("select * from nomenclator_expenses_values", conn);
                    MySqlDataReader myReader = wCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        wNomenclator = new nomenclator_expenses_value();
                        if (myReader["code"] != DBNull.Value)
                            wNomenclator.code = myReader.GetString("code");
                        if (myReader["description"] != DBNull.Value)
                            wNomenclator.description = myReader.GetString("description");
                        if (myReader["expense_value"] != DBNull.Value)
                            wNomenclator.expense_value = myReader.GetDecimal("expense_value");

                        
                        wnomenclatorList.Add(wNomenclator);

                    }
                    myReader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return wnomenclatorList;
            }


        }


        public static List<nomenclator_practice> nomenclator_practice_GetAll()
        {

            List<nomenclator_practice> wnomenclatorList = new List<nomenclator_practice>();
            nomenclator_practice nomenclator_practice;
            using (MySqlConnection conn = new MySqlConnection(cmsys_cnnstring))
            {
                try
                {
                    conn.Open();
                    MySqlCommand wCommand = new MySqlCommand("select * from nomenclator_practice ", conn);
                    MySqlDataReader myReader = wCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        nomenclator_practice = new nomenclator_practice();

                        

                        if (myReader["adhoc_expense_code"] != DBNull.Value)
                            nomenclator_practice.adhoc_expense_code = myReader.GetString("adhoc_expense_code");
                        if (myReader["adhoc_subtotal"] != DBNull.Value)
                            nomenclator_practice.adhoc_subtotal = myReader.GetDecimal("adhoc_subtotal");
                        if (myReader["anestesist_expense_code"] != DBNull.Value)
                            nomenclator_practice.anestesist_expense_code = myReader.GetString("anestesist_expense_code");

                        if (myReader["anestesist_subtotal"] != DBNull.Value)
                            nomenclator_practice.anestesist_subtotal = myReader.GetDecimal("anestesist_subtotal");
                        if (myReader["authorization"] != DBNull.Value)
                            nomenclator_practice.authorization = myReader.GetChar("authorization");
                        if (myReader["ayudant_expense_code"] != DBNull.Value)
                            nomenclator_practice.ayudant_expense_code = myReader.GetString("ayudant_expense_code");
                        if (myReader["ayudant_subtotal"] != DBNull.Value)
                            nomenclator_practice.ayudant_subtotal = myReader.GetDecimal("ayudant_subtotal");
                        if (myReader["blame"] != DBNull.Value)
                            nomenclator_practice.blame = myReader.GetString("blame");
                        if (myReader["copayment"] != DBNull.Value)
                            nomenclator_practice.copayment = myReader.GetDecimal("copayment");

                        if (myReader["especialist_expense_code"] != DBNull.Value)
                            nomenclator_practice.especialist_expense_code = myReader.GetString("especialist_expense_code");
                        if (myReader["especialist_subtotal"] != DBNull.Value)
                            nomenclator_practice.especialist_subtotal = myReader.GetDecimal("especialist_subtotal");
                        if (myReader["lack"] != DBNull.Value)
                            nomenclator_practice.lack = myReader.GetInt32("lack");
                        if (myReader["nomenclator_id"] != DBNull.Value)
                            nomenclator_practice.nomenclator_id = myReader.GetInt32("nomenclator_id");

                        if (myReader["period"] != DBNull.Value)
                            nomenclator_practice.period = myReader.GetInt32("period");
                        if (myReader["practice_id"] != DBNull.Value)
                            nomenclator_practice.practice_id = myReader.GetInt32("practice_id");
                        //if (myReader["time_begin"] != DBNull.Value)
                        //{
                        //    try
                        //    {
                        //        nomenclator_practice.time_begin = myReader.GetDateTime("time_begin");
                        //    }
                        //    catch { }
                        //}
                        if (myReader["top_for_period"] != DBNull.Value)
                            nomenclator_practice.top_for_period = myReader.GetInt32("top_for_period");

                        if (myReader["total"] != DBNull.Value)
                            nomenclator_practice.total = myReader.GetDecimal("total");

                        if (myReader["totalpayment"] != DBNull.Value)
                            nomenclator_practice.totalpayment = myReader.GetDecimal("totalpayment");

                        if (myReader["top_for_period"] != DBNull.Value)
                            nomenclator_practice.top_for_period = myReader.GetInt32("top_for_period");

                        

                        wnomenclatorList.Add(nomenclator_practice);

                    }
                    myReader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return wnomenclatorList;
            }


        }


        public static List<nomenclator_practice_group> nomenclator_practice_group_GetAll(int since)
        {

            List<nomenclator_practice_group> list = new List<nomenclator_practice_group>();
            nomenclator_practice_group nomenclator_practice_group;
            using (MySqlConnection conn = new MySqlConnection(cmsys_cnnstring))
            {
                try
                {
                    conn.Open();
                    MySqlCommand wCommand = new MySqlCommand(string.Format("select * from nomenclator_practice_group where id > {0} ",since), conn);
                    MySqlDataReader myReader = wCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        nomenclator_practice_group = new nomenclator_practice_group();
                        if (myReader["code"] != DBNull.Value)
                            nomenclator_practice_group.code = myReader.GetString("code");
                        if (myReader["description"] != DBNull.Value)
                            nomenclator_practice_group.description = myReader.GetString("description");
                        if (myReader["id"] != DBNull.Value)
                            nomenclator_practice_group.id = myReader.GetInt32("id");

                        if (myReader["nomenclator_id"] != DBNull.Value)
                            nomenclator_practice_group.nomenclator_id = myReader.GetInt32("nomenclator_id");
                        if (myReader["payment"] != DBNull.Value)
                            nomenclator_practice_group.payment = myReader.GetDecimal("payment");

                        if (myReader["trigger_practice_id"] != DBNull.Value)
                            nomenclator_practice_group.trigger_practice_id = myReader.GetInt32("trigger_practice_id");

                        list.Add(nomenclator_practice_group);

                    }
                    myReader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return list;
            }


        }


        public static List<medical_insurance_company> medical_insurance_company_GetAll(int since)
        {

            List<medical_insurance_company> list = new List<medical_insurance_company>();
            medical_insurance_company medical_insurance_company;
            using (MySqlConnection conn = new MySqlConnection(cmsys_cnnstring))
            {
                try
                {
                    conn.Open();
                    MySqlCommand wCommand = new MySqlCommand(string.Format("SELECT * FROM cmsys.medical_insurance_company where id > {0} ", since), conn);
                    MySqlDataReader myReader = wCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        medical_insurance_company = new medical_insurance_company();
                        if (myReader["country_id"] != DBNull.Value)
                            medical_insurance_company.country_id = myReader.GetInt16("country_id");
                        if (myReader["entity_id1"] != DBNull.Value)
                            medical_insurance_company.entity_id1 = myReader.GetString("entity_id1");
                        if (myReader["id"] != DBNull.Value)
                            medical_insurance_company.id = myReader.GetInt32("id");

                        if (myReader["etc"] != DBNull.Value)
                            medical_insurance_company.etc = myReader.GetString("etc");
                        if (myReader["rnos"] != DBNull.Value)
                            medical_insurance_company.rnos = myReader.GetInt32("rnos");


                        list.Add(medical_insurance_company);

                    }
                    myReader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return list;
            }


        }


        public static List<medical_insurance_plan> medical_insurance_plan_GetAll(int since)
        {

            List<medical_insurance_plan> list = new List<medical_insurance_plan>();
            medical_insurance_plan medical_insurance_plan;
            using (MySqlConnection conn = new MySqlConnection(cmsys_cnnstring))
            {
                try
                {
                    conn.Open();
                    MySqlCommand wCommand = new MySqlCommand(string.Format("select * from medical_insurance_plan where id > {0}",since), conn);
                    MySqlDataReader myReader = wCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        medical_insurance_plan = new medical_insurance_plan();
                        if (myReader["code"] != DBNull.Value)
                            medical_insurance_plan.code = myReader.GetString("code");
                        if (myReader["description"] != DBNull.Value)
                            medical_insurance_plan.description = myReader.GetString("description");
                        if (myReader["id"] != DBNull.Value)
                            medical_insurance_plan.id = myReader.GetInt32("id");

                        if (myReader["medical_insurance_company_id"] != DBNull.Value)
                            medical_insurance_plan.medical_insurance_company_id = myReader.GetInt32("medical_insurance_company_id");
                        if (myReader["nomenclator_id"] != DBNull.Value)
                            medical_insurance_plan.nomenclator_id = myReader.GetInt32("nomenclator_id");


                        list.Add(medical_insurance_plan);

                    }
                    myReader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return list;
            }


        }
    }
}
