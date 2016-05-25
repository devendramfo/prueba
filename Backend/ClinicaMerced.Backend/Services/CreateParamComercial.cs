using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaMerced.Common.Entities;
using ClinicaMerced.Common;
using System.Xml.Serialization;
using Fwk.Bases;

namespace ClinicaMerced.Common.Isvc.CreateParamComercial
{   
    [Serializable]
    public class CreateParamComercialReq : Fwk.Bases.Request< ParamComercialBE>
    {

        public CreateParamComercialReq()
        {
            base.ServiceName = "CreateParamComercialService";
        }
    }



    [Serializable]
    public class CreateParamComercialRes : Fwk.Bases.Response<DummyContract>
    {
    }
   
}
