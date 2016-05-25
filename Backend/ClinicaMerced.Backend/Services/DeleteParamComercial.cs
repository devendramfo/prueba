using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaMerced.Common.Entities;

using ClinicaMerced.Common;
using System.Xml.Serialization;

using Fwk.Bases;

namespace ClinicaMerced.Common.Isvc.DeleteParamComercial
{   
    [Serializable]
    public class DeleteParamComercialReq : Fwk.Bases.Request<Params>
    {

        public DeleteParamComercialReq()
        {
            base.ServiceName = "DeleteParamComercialService";
        }
    }
    
    [XmlInclude(typeof(Params)), Serializable]
    public class Params : Entity
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        int _Id;

        public int IdParamComercial
        {
            get { return _Id; }
            set { _Id = value; }
        }

    }



    [Serializable]
    public class DeleteParamComercialRes : Fwk.Bases.Response<DummyContract>
    {
    }
   
}
