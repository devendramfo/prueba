using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaMerced.Common.Entities
{

    
    public partial class ParamComercialList 
    {


        #region [Methods]
        /// <summary>
        /// Metodo estatico que retorna un objeto ParamComercialList apartir de un xml.-
        /// </summary>
        /// <param name="pXml">String con el xml</param>
        /// <returns>ParamComercialList</returns>
        public ParamComercialList GetParamComercialListFromXml(String pXml)
        {
            return GetFromXml<ParamComercialList>(pXml);
        }

        public ParamComercialBE GetById(int id)
        {
            var item = this.Where<ParamComercialBE>(p => p.IdParamComercial.Equals(id));
            return item.FirstOrDefault<ParamComercialBE>();

        }

        public void Quit(int id)
        {
            ParamComercialBE wParamComercialBE = GetById(id);
            if (wParamComercialBE != null)
                this.Remove(wParamComercialBE);
        }

        public List<string> GetListOfId()
        {
            StringBuilder strbl = Fwk.HelperFunctions.FormatFunctions.GetStringBuilderWhitSeparator<ParamComercialBE>(this, ',', "IdParamComercial");
            if (strbl.Length == 0) return null;
            return strbl.ToString().Split(',').ToList<string>();
        }
        #endregion
    }

    public partial class ConsultaBE
    {
        public DateTime? FechaFin
        { get; set; }
    }

   
}

