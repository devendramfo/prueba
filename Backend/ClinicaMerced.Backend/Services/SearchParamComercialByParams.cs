using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaMerced.Common.Entities;
using ClinicaMerced.Common;
using System.Xml.Serialization;

using Fwk.Bases;

namespace ClinicaMerced.Common.Isvc.SearchParamComercialByParams
{   
    [Serializable]
    public class SearchParamComercialByParamsReq : Fwk.Bases.Request<Params>
    {

        public SearchParamComercialByParamsReq()
        {
            base.ServiceName = "SearchParamComercialByParamsService";
        }
    }

    [XmlInclude(typeof(Params)), Serializable]
    public class Params : Entity
    {
        bool? vigente;

        public bool? Vigente
        {
            get { return vigente; }
            set { vigente = value; }
        }

        int? _IdTipoParametro;

        public int? IdTipoParametro
        {
            get { return _IdTipoParametro; }
            set { _IdTipoParametro = value; }
        }
        int? _IdParamComercialRef;

        public int? IdParamComercialRef
        {
            get { return _IdParamComercialRef; }
            set { _IdParamComercialRef = value; }
        }
    }


    [Serializable]
    public class SearchParamComercialByParamsRes : Fwk.Bases.Response<ParamComercialList>
    {
    }
  
}
