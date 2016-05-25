using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicaMerced.Common.Entities;

namespace ClinicaMerced.Front
{
    public partial class UC_Consulta_SProfecional_AMes : ClinicaMerced.Front.Xtra_UC_Base
    {
        public UC_Consulta_SProfecional_AMes()
        {
            InitializeComponent();
        }

        public override void Populate(object filter)
        {
            this.uC_FitroConsultaHorizontal1.Populate(filter);
            this.uC_TipoList1.Populate(null);

        
           
        }
        public override void Refresh()
        {
            
            ConsultaBE filter = uC_FitroConsultaHorizontal1.GetFilter();
            rptconsultasmestipoBindingSource.DataSource = Controller.rpt_consultas_mes_tipoList(uC_TipoList1.GetChecked().GetListOfId(),filter.Fecha,filter.FechaFin);

            this.chartControl1.RefreshData();
            base.Refresh();
        }

        private void uC_FitroConsultaHorizontal1_Load(object sender, EventArgs e)
        {
            this.uC_FitroConsultaHorizontal1.SetBeginOfYEar();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
