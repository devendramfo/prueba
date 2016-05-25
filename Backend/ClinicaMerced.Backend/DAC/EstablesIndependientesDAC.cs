using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaMerced.Common.Entities;
using ClinicaMerced.Backend.Entities;
using ClinicaMerced.Common.Entities.Custom;

namespace ClinicaMerced.Backend.DAC
{
    public  class EstablesIndependientesDAC
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static ProfecionalList Search_ProfecionalList_ByParams(ProfecionalBE param)
        {
            ProfecionalList list = new ProfecionalList();
            try
            {
                using (ClinicaEntities dc = new ClinicaEntities())
                {
                    var x = from c in dc.Profecional
                            where
                                (param.IdEspecialidad.Equals(null) || c.IdEspecialidad.Equals(param.IdEspecialidad))
                                &&
                                (string.IsNullOrEmpty(param.Nombre) || c.Nombre.Contains(param.Nombre))

                            select new ProfecionalBE
                            {
                                IdEspecialidad = c.IdEspecialidad,
                                IdProfecional = c.IdProfecional,
                                Nombre = c.Nombre,
                                Apellido = c.Apellido,
                                UserId = c.UserId,

                            };

                    list.AddRange(x.ToArray<ProfecionalBE>());
                }

                return list;
            }
            catch (Exception ex)
            {
                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static MutualList Search_MutualList_All()
        {
            try
            {
                MutualList list = new MutualList();
                using (ClinicaEntities dc = new ClinicaEntities())
                {
                    //var x = from c in dc.Mutual select new MutualBE(c); Only parameterless constructors and initializers are supported in LINQ to Entities.
                    var x = from c in dc.Mutual select new MutualBE {IdMutual = c.IdMutual,Nombre=c.Nombre,ExigeCoseguro= c.ExigeCoseguro };
                    

                    list.AddRange(x.ToArray<MutualBE>());
                }

                return list;
            }
            catch (Exception ex)
            {
                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }
        }

    }
}
