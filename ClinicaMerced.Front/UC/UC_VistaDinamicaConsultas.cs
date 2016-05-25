using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaMerced.Common.Entities;
using Fwk.UI.Common;
using DevExpress.Utils;

namespace ClinicaMerced.Front.UC
{
   
    public partial class UC_VistaDinamicaConsultas : Xtra_UC_Base
    {
        Rpt_Consulta_FullList _Rpt_Consulta_FullList;
        public UC_VistaDinamicaConsultas()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }


        public override void Populate(object filter)
        {
            uC_FitroConsultaHorizontal1.Populate(null);
        }
     

        public void Populate()
        {
            
            ConsultaBE wConsultaBE = uC_FitroConsultaHorizontal1.GetFilter();
            

            using (WaitCursorHelper whait = new WaitCursorHelper(this))
            {

                _Rpt_Consulta_FullList = Controller.Search_Consulta_FullView_ByParams(wConsultaBE);

                this.pivotGridControl1.DataSource = _Rpt_Consulta_FullList;
                this.pivotGridControl1.Refresh();


            }
        }


        public override void Refresh()
        {
            Populate();

            ImageCollection im = new ImageCollection();
            im.AddImage(ClinicaMerced.Front.Properties.Resources.save_as_large);
            im.AddImage(ClinicaMerced.Front.Properties.Resources.Shopping_Chart);
            im.AddImage(ClinicaMerced.Front.Properties.Resources.reminders_and_recalls_close_32);

            pivotGridControl1.ValueImages = im;
            base.Refresh();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            
        }
    }
}
