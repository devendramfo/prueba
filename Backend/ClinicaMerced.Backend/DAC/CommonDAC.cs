using System;
using System.Linq;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Microsoft.Practices.EnterpriseLibrary.Data;
using ClinicaMerced.Common.Entities;
using Fwk.Bases;
using System.Collections;
using Fwk.Security.Common;


namespace ClinicaMerced.Backend.DAC
{
    public class CommonDAC
    {
        internal static string clinica_cnnstring = "clinica";
        internal static string clinica_cnnstring_value;


        static CommonDAC()
        {
            clinica_cnnstring_value = System.Configuration.ConfigurationManager.ConnectionStrings[clinica_cnnstring].ConnectionString;
        }
        public static User GetUserData(string pUserName)
        {
            try
            {
                //using (ClinicaMerced.Backend.UserDataDataContext dc = new ClinicaMerced.Backend.UserDataDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["ClinicaMerced"].ConnectionString))
                //{
                //    var user = from s in dc.UsersByCompanies from u in dc.aspnet_Users 
                //               where u.UserName.Equals(pUserName) && u.UserId.Equals(s.UserId) select new User { UserId = s.UserId,  UserName = pUserName };
                // //   var list2 = from p in projects
                // //join s in
                // //                   (from uc in dc.UsersByCompanies
                // //                    from u in dc.aspnet_Users 
                // //        select uc
                // //    ) on p.Id equals c.IdProject 
                // //    into customers

                // //select p.Name;

                //    return user.FirstOrDefault < User>();
                //}

                return new User();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
