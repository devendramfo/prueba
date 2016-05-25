using System;
using System.Collections.Generic;
using ClinicaMerced.Common.Entities;
using Fwk.Bases;
using ClinicaMerced.Common;
using ClinicaMerced.Common.Isvc.SearchParamComercialByParams;
using ClinicaMerced.Backend;
using ClinicaMerced.Backend.DAC;

namespace ClinicaMerced.Backend.Svc
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchParamComercialByParamsService : BusinessService<SearchParamComercialByParamsReq, SearchParamComercialByParamsRes>
    {
        public override SearchParamComercialByParamsRes Execute(SearchParamComercialByParamsReq pServiceRequest)
        {
            SearchParamComercialByParamsRes wRes = new SearchParamComercialByParamsRes();

          //(int)ClinicaMerced.Common.Common.TipoParametroEnum.ClaseTipoGasto
            wRes.BusinessData = ParamComercialDAC.GetByParams(pServiceRequest.BusinessData.IdTipoParametro, 
                pServiceRequest.BusinessData.IdParamComercialRef, pServiceRequest.BusinessData.Vigente,
                pServiceRequest.ContextInformation.AppId);
            return wRes;
        }

       
    }
}
