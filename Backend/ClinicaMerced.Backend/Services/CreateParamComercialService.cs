using System;
using System.Collections.Generic;
using ClinicaMerced.Common.Entities;
using Fwk.Bases;
using ClinicaMerced.Common;
using ClinicaMerced.Common.Isvc.CreateParamComercial;
using ClinicaMerced.Backend;
using ClinicaMerced.Backend.DAC;

namespace ClinicaMerced.Backend.Svc
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateParamComercialService : BusinessService<CreateParamComercialReq, CreateParamComercialRes>
    {
        public override CreateParamComercialRes Execute(CreateParamComercialReq pServiceRequest)
        {
            CreateParamComercialRes wRes = new CreateParamComercialRes();

            ParamComercialDAC.Create(pServiceRequest.BusinessData, new Guid(pServiceRequest.ContextInformation.UserId), pServiceRequest.ContextInformation.AppId);

            return wRes;
        }

       
    }
}
