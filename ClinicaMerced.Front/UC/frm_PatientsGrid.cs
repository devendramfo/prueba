using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClinicaMerced.Front.UC;
using ClinicaMerced.Common.Entities.Angel;

namespace ClinicaMerced.Front
{
    public partial class frm_PatientsGrid : frm_Base
    {
        public frm_PatientsGrid()
        {
            InitializeComponent();
        }

        public override void Populate(object filter)
        {
            this.patientListBindingSource.DataSource = filter;
            this.gridView1.RefreshData();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        public Patient SelectedPatient;
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            SelectedPatient = ((Patient)gridControl1.FocusedView.GetRow(gridView1.FocusedRowHandle));
        }

      
    }
}