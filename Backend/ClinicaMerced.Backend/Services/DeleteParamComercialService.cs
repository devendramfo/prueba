using System;
using System.Collections.Generic;
using ClinicaMerced.Common.Entities;
using Fwk.Bases;
using ClinicaMerced.Common;
using ClinicaMerced.Common.Isvc.DeleteParamComercial;
using ClinicaMerced.Backend;

namespace ClinicaMerced.Backend.Svc
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteParamComercialService : BusinessService<DeleteParamComercialReq, DeleteParamComercialRes>
    {
        public override DeleteParamComercialRes Execute(DeleteParamComercialReq pServiceRequest)
        {
            DeleteParamComercialRes wRes = new DeleteParamComercialRes();
            ParamComercialBC wParamComercialBC = new ParamComercialBC(pServiceRequest.ContextInformation.AppId);
            wParamComercialBC.Delete(pServiceRequest.BusinessData.IdParamComercial, pServiceRequest.BusinessData.Name);
            return wRes;
        }

       
    }
}
