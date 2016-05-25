using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaMerced.Common.Entities;
using ClinicaMerced.Common.Entities.Custom;
using Fwk.UI.Common;
using ClinicaMerced.Common.Enums;
using DevExpress.XtraGrid.Views.Grid;

namespace ClinicaMerced.Front.UC
{
    public partial class UC_Grid_Consultas_Listado : Xtra_UC_Base
    {
        GridView View = null;
        ConsultaGridList _ConsultaGridList = null;
        public UC_Grid_Consultas_Listado()
        {
            InitializeComponent();

            View = gridControl1.FocusedView as GridView;
            int rHandle = View.FocusedRowHandle;
            View.SetMasterRowExpanded(rHandle, !View.GetMasterRowExpanded(rHandle));
        }

        public override void Populate(object filter)
        {
            uC_FitroConsultaHorizontal1.Populate(null);
        }

        public void Populate(ConsultaBE filter)
        {
            using (WaitCursorHelper whait = new WaitCursorHelper(this))
            {
                if (filter.GetType().Equals(typeof(ConsultaBE)))
                    _ConsultaGridList = Controller.SearchByParams(filter);
                this.gridControl1.DataSource = _ConsultaGridList;
                this.gridControl1.Refresh();
            }
        }

        public void ExpandAllRows()
        {
            View.BeginUpdate();
            try
            {
                int dataRowCount = View.DataRowCount;
                for (int rHandle = 0; rHandle < dataRowCount; rHandle++)
                    View.SetMasterRowExpanded(rHandle, true);
            }
            finally
            {
                View.EndUpdate();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SetFilter();
            ExpandAllRows();
        }

        void SetFilter()
        {
      
            ConsultaBE wConsultaBE = uC_FitroConsultaHorizontal1.GetFilter();
            Populate(wConsultaBE);
        }


        private void btnExportExel_Click(object sender, EventArgs e)
        {
            //string wFileName = Fwk.HelperFunctions.FileFunctions.OpenFileDialog_New("", "Exel Files(*.xls)|*.xls|All files (*.*)|*.*", false);
            //if (string.IsNullOrEmpty(wFileName)) return;
            //gridView1.ExportToPdf(wFileName);
            //System.Diagnostics.Process.Start(wFileName);
            gridView1.ShowPrintPreview();
        }

        private void btnExporPdf_Click(object sender, EventArgs e)
        {
            string wFileName = Fwk.HelperFunctions.FileFunctions.OpenFileDialog_New("", "PDF Files(*.pdf)|*.pdf|All files (*.*)|*.*", false);
            if (string.IsNullOrEmpty(wFileName)) return;
            gridView1.ExportToPdf(wFileName);
            System.Diagnostics.Process.Start(wFileName);
        }
        ConsultaGrid selectedConsultaGrid;
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            selectedConsultaGrid = ((ConsultaGrid)gridControl1.FocusedView.GetRow(gridView1.FocusedRowHandle));
        }



        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (selectedConsultaGrid == null) return;
            using (frm_Crear frm = new frm_Crear())
            {
                frm.State = Fwk.Bases.EntityUpdateEnum.UPDATED;

                frm.Populate(selectedConsultaGrid);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //ConsultaBE consulta = frm.GetData();
                    //Controller.UpdateConsulta(consulta);
                    Populate(DateTime.Now);
                }
            }
        }

       

        public override void Refresh()
        {
            SetFilter();
            ExpandAllRows();
            base.Refresh();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //if (gridView1.SelectedRowsCount == 0)
                gridView1.SelectAll();
                gridControl1.Focus();
            gridView1.CopyToClipboard();
        }
    }
}
