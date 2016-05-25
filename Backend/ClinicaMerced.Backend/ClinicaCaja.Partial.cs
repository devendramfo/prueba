using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClinicaMerced.Common.Entities.Caja
{
    public partial class vw_ConsultaToCierreCajaDetail
    {
        public string Turno
        {
            get
            {
                if (_Fecha.ToString("tt").ToLower().Equals("a.m."))

                    return "Mañana";
                else
                    return "Tarde";
                
            }
        }
        public string Hora
        {
            get { return _Fecha.ToShortTimeString(); }
        }
	}
}
