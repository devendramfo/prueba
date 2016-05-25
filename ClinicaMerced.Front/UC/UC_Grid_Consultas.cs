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

namespace ClinicaMerced.Front.UC
{
    [ToolboxItem(true)]
    public partial class UC_Grid_Consultas : Xtra_UC_Base
    {

        ConsultaGridList _ConsultaGridList = null;
        public UC_Grid_Consultas()
        {
            InitializeComponent();
        }

        public override void Populate(object filter)
        {
            if (this.DesignMode) return;
            using (WaitCursorHelper whait = new WaitCursorHelper(this))
            {
                if (filter.GetType().Equals(typeof(ConsultaBE)))
                    _ConsultaGridList = Controller.SearchByParams(((ConsultaBE)filter));

                if (filter.GetType().Equals(typeof(DateTime)))
                    _ConsultaGridList = Controller.SearchByParams(((DateTime)filter));


                this.gridControl1.DataSource = _ConsultaGridList;
                this.gridControl1.Refresh();
            }
        }

        private void btnCrearNueva_Click(object sender, EventArgs e)
        {
         
            
            using (frm_Crear frm = new frm_Crear())
            {
                frm.Populate(null);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Populate(DateTime.Now);
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Populate(DateTime.Now);
            
        }

        private void btnExportExel_Click(object sender, EventArgs e)
        {
            //string wFileName = Fwk.HelperFunctions.FileFunctions.OpenFileDialog_New("", "Exel Files(*.xls)|*.xls|All files (*.*)|*.*", false);
            //if (string.IsNullOrEmpty(wFileName)) return;
            //gridView1.ExportToPdf(wFileName);
            gridView1.ShowPrintPreview();
            //System.Diagnostics.Process.Start(wFileName);
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

        private void btnDelette_Click(object sender, EventArgs e)
        {
            if (selectedConsultaGrid != null)
            {
                ParamComercialBE tipoConsulta = Controller.TipoConsultaList.GetById(selectedConsultaGrid.IdTipoConsulta.Value);
                this.MessageViewer.MessageBoxIcon = Fwk.UI.Common.MessageBoxIcon.Question;
                this.MessageViewer.MessageBoxButtons = MessageBoxButtons.OKCancel;
                DialogResult d =  this.MessageViewer.Show(String.Format("Desea eliminar la {0}, para cliente {1}", tipoConsulta.Nombre, selectedConsultaGrid.NombreCliente));

                if (d == DialogResult.OK)
                {
                    Controller.DeleteConsulta(selectedConsultaGrid.IdConsulta);
                    
                    Populate(DateTime.Now);
                }
                base.SetMessageViewInfoDefault();
            }
        }

        public override void Refresh()
        {
            Populate(DateTime.Now);
            base.Refresh();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            gridView1.SelectAll();
            gridView1.CopyToClipboard();
            gridControl1.Focus();
        }
    }
}
