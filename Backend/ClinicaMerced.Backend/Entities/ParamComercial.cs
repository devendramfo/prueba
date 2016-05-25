using System;
using System.Linq;
using System.Collections.Generic;
using Fwk.Bases;
using System.Xml.Serialization;
using System.Text;

namespace ClinicaMerced.Common.Entities
{


  
    
        public class ParamComercialList3 : ParamComercialList
        {
            #region [Methods]
            /// <summary>
            /// Metodo estatico que retorna un objeto ParamComercialList apartir de un xml.-
            /// </summary>
            /// <param name="pXml">String con el xml</param>
            /// <returns>ParamComercialList</returns>
            public  ParamComercialList GetParamComercialListFromXml(String pXml)
            {
                return GetFromXml<ParamComercialList>( pXml);
            }

            public ParamComercialBE GetById(int id)
            {
                var item = this.Where<ParamComercialBE>(p => p.IdParamComercial == id);
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

        
        public partial class ParamComercialBE 
        {
          
            private System.String _NombreRef;

            public System.String NombreRef
            {
                get { return _NombreRef; }
                set { _NombreRef = value; }
            }
           
        }

    
    





	
	
}

