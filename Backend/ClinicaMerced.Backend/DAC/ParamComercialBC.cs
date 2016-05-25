using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaMerced.Backend.DAC;

namespace ClinicaMerced.Backend
{
    public class ParamComercialBC : Fwk.Bases.BaseBC
    {

        public ParamComercialBC(string companyId)
            : base(companyId)
        {
 
        }
        static string used = "{0} no se puede eliminar por que esta siendo utilizado";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pIdParamComercial"></param>
        /// <param name="name"></param>
        public void Delete(int pIdParamComercial , string name)
        {

            if (ParamComercialDAC.IsUsed(pIdParamComercial))
                throw new Fwk.Exceptions.FunctionalException(string.Format(used,name));

            ParamComercialDAC.Delete(pIdParamComercial);

        }
    }
}
