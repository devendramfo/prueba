using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fwk.Exceptions;
using Fwk.Security.Cryptography;

namespace ClinicaMerced.Backend
{

    public class lic
    {
        public static void chk()
        {
            DateTime expTime = new DateTime();
            string expk = "keTtly7za5UIrDkDlqsU+jqBCzKoBM76no4hzuUnNOo=$5dPNk6aYiLiH+9+dPHfjIQ==";
            string l = string.Empty;
            string sn = string.Empty;
            try
            {
                if (System.Configuration.ConfigurationManager.AppSettings["license"] != null)
                    l = System.Configuration.ConfigurationManager.AppSettings["license"].ToString();
                
                if (string.IsNullOrEmpty(l))
                {
                    TechnicalException te = new TechnicalException("Your pelsoft license is corrupted. Please contact your suppor or software provider");
                    te.Source = "Pelsoft Lic mannager";
                    te.ErrorId = "100";
                    throw te;
                }

                FwkSymetricAlg a = new FwkSymetricAlg(expk);

                string[] decrypted = a.Dencrypt(l).Split('$');
                int index =0;

                if (decrypted.Length == 2)
                {
                    index = 1;
                    sn = decrypted[0];
                }
                string[] d = decrypted[index].Split('|');
                   expTime = new DateTime(Convert.ToInt32(d[2]), Convert.ToInt32(d[1]), Convert.ToInt32(d[0]));
            }
            catch (Exception ex)
            {

                TechnicalException te = new TechnicalException("Your pelsoft license has expired or is corrupted. Please contact your suppor or software provider", ex);
                te.Source = "Pelsoft Lic manager";
                te.ErrorId = "100";
                throw te;
            }


            chkExp(5, expTime);
            if (!String.IsNullOrEmpty(sn))
                chkAuthorization(sn);
        }

        static void chkAuthorization(string data)
        {
            if (!data.Equals(Fwk.HelperFunctions.EnvironmentFunctions.GetDriverSerealNumber()))
            {
                TechnicalException te = new TechnicalException("Your pelsoft license is corrupted. Host not authorized. Please contact your suppor or software provider");
                te.Source = "Pelsoft Lic manager";
                te.ErrorId = "102";
                throw te;

            }
        }

        static void chkExp(int? alerSince, DateTime expTime)
        {
    
            DateTime today = DateTime.Now;
            //Si ya paso
            if (DateTime.Compare(today, expTime) >= 0)
            {
                TechnicalException te = new TechnicalException("Your pelsoft license has expired . Please contact your suppor software provider for renew");
                te.Source = "Pelsoft Lic manager";
                te.ErrorId = "101";
                throw te;
            }

            TimeSpan dateDif = today - expTime;
            //Si faltan 5= o menos dias que aviar desde
            //alerSince >= days => 0
            if (alerSince >= (dateDif.Days * -1))
            {
                TechnicalException te = new TechnicalException(string.Format("Your pelsoft license will expire in {0} days. Please contact your suppor software provider for renew", dateDif.Days * -1));
                te.Source = "Pelsoft Lic manager";
                te.ErrorId = "101";
                throw te;
            }





        }
    }
}
