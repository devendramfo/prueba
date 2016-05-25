using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaMerced.Common.Entities;
using ClinicaMerced.Common.Enums;
using DevExpress.XtraEditors;
using ClinicaMerced.Common.Entities.Custom;
using ClinicaMerced.Backend.Entities;
using ClinicaMerced.Common.Entities.Angel;
using Fwk.Exceptions;

namespace ClinicaMerced.Front
{
    [ToolboxItem(true)]
    public partial class UC_Consulta : Xtra_UC_Base
    {
        ConsultaGrid _ConsultaGrid_ToUpdate;

        public UC_Consulta()
        {
            InitializeComponent();
        }
        ProfecionalList _ProfecionalList = new ProfecionalList();
        ParamComercialList _TipoCons = new ParamComercialList();
        MutualList _Mutuales = new MutualList();

        public override void Populate(object filter)
        {
            if (this.DesignMode) return;

            _Mutuales.AddRange(Controller.MutualList.Where<MutualBE>(p => p.IdMutual != (int)CommonValuesEnum.TodosComboBoxValue));
            //cmbMutual.Properties.DataSource = _Mutuales;

            _ProfecionalList.AddRange(Controller.ProfecionalList.Where<ProfecionalBE>(p => p.IdProfecional != (int)CommonValuesEnum.TodosComboBoxValue));
            cmbProfecionales.Properties.DataSource = _ProfecionalList;
          
          
            _TipoCons.AddRange(Controller.TipoConsultaList.Where<ParamComercialBE>(p => p.IdParamComercial != (int)CommonValuesEnum.TodosComboBoxValue));
            cmbTipoConsulta.Properties.DataSource = _TipoCons;

            if (State != Fwk.Bases.EntityUpdateEnum.NEW)
            {
                _ConsultaGrid_ToUpdate = (ConsultaGrid)filter;
            }
        }


        void Fill(ConsultaGrid c)
        {
            int index =0;
            lblTitle.Text = "            Actualizar consulta en recepcion";
            if (c.IdMutual.HasValue)
            {
                //index = cmbMutual.Properties.GetDataSourceRowIndex("IdMutual", c.IdMutual);
                //cmbMutual.ItemIndex = index;
            }
          
            if (c.IdProfecional.HasValue)
            {
                index = cmbProfecionales.Properties.GetDataSourceRowIndex("IdProfecional", c.IdProfecional);
                cmbProfecionales.ItemIndex = index;
            }
            if (c.IdTipoConsulta.HasValue )
            {
                index = cmbTipoConsulta.Properties.GetDataSourceRowIndex("IdParamComercial", c.IdTipoConsulta);
                cmbTipoConsulta.ItemIndex = index;
            }

            txtCliente.Text = c.NombreCliente;

            txtCoseguro.Text = c.Coseguro.Value.ToString();
            txtArancelMutual.Text = c.ArancelMutual.Value.ToString();
            txtObservacion.Text = c.Descripcion;
            txtNroAfiliado.Text = c.NroAfiliadoMutual;

            txtTelefono.Text = c.TelefonoCliente;

            chkPresentaOrden.Checked = c.PresentaOrden.Value;
        }

        public bool HasErrors()
        {
            dxErrorProvider1.ClearErrors();
            if (string.IsNullOrEmpty(txtCliente.Text))
                dxErrorProvider1.SetError(txtCliente, "Nombre de cliente es requerido");

            //if (Convert.ToInt32(txtCoseguro.EditValue) == 0)
            //    dxErrorProvider1.SetError(txtCoseguro, "Falta importe");

            if ((int)cmbTipoConsulta.EditValue == (int)TipoConsulta.ConsultaMedica )
            {
                if ((int)cmbProfecionales.EditValue == (int)CommonValuesEnum.Ninguno)
                    dxErrorProvider1.SetError(cmbProfecionales, "Debe seleccionar un profecional para este tipo de consulta");
            }

            return dxErrorProvider1.HasErrors;
        }

        private void txtCliente_Validating(object sender, CancelEventArgs e)
        {
            dxErrorProvider1.ClearErrors();
            if (string.IsNullOrEmpty(txtCliente.Text))
                dxErrorProvider1.SetError(txtCliente, "Nombre de cliente es requerido");
        }

        public ConsultaBE GetData()
        {
            ConsultaBE wConsultaBE = new ConsultaBE();
            //if (Convert.ToInt32(cmbMutual.EditValue) != (int)CommonValuesEnum.Ninguno)
            //{
            //    //wConsultaBE.IdMutual = Convert.ToInt32(cmbMutual.EditValue);
            //    wConsultaBE.PresentaOrden = chkPresentaOrden.Checked;
            //    wConsultaBE.NroAfiliadoMutual = txtNroAfiliado.Text.Trim();

            //    //wConsultaBE.ExigeCoseguro = Convert.ToBoolean(cmbMutual.GetColumnValue("ExigeCoseguro"));
            //}
            //else
            //{
            //    wConsultaBE.IdMutual = null;
            //    wConsultaBE.PresentaOrden = false;
            //    wConsultaBE.NroAfiliadoMutual = string.Empty;
            //}

            if ((int)cmbProfecionales.EditValue != (int)CommonValuesEnum.Ninguno)
                wConsultaBE.IdProfecional = Convert.ToInt32(cmbProfecionales.EditValue);

            wConsultaBE.NombreCliente = txtCliente.Text.Trim();
            wConsultaBE.Descripcion = txtObservacion.Text.Trim();
            wConsultaBE.TelefonoCliente = txtTelefono.Text.Trim();

            wConsultaBE.IdTipoConsulta = (int)cmbTipoConsulta.EditValue;


            wConsultaBE.Fecha = DateTime.Now;

            wConsultaBE.ArancelMutual = Convert.ToDecimal(txtArancelMutual.EditValue);

            wConsultaBE.Coseguro = Convert.ToDecimal(txtCoseguro.EditValue);

            if(_ConsultaGrid_ToUpdate != null)
                wConsultaBE.IdConsulta = _ConsultaGrid_ToUpdate.IdConsulta;

            return wConsultaBE;
        }

        private void UC_Consulta_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            int index = 0;
            //if (State == Fwk.Bases.EntityUpdateEnum.NEW)
            //{
            //index = cmbMutual.Properties.GetDataSourceRowIndex("IdMutual", (int)CommonValuesEnum.Ninguno);
            //cmbMutual.ItemIndex = index;

            cmbTipoConsulta.ItemIndex = 0;


            //}

            index = cmbProfecionales.Properties.GetDataSourceRowIndex("IdProfecional", (int)CommonValuesEnum.Ninguno);

            cmbProfecionales.ItemIndex = index;
            cmbProfecionales.Refresh();

            if (State != Fwk.Bases.EntityUpdateEnum.NEW)
            {
                Fill(_ConsultaGrid_ToUpdate);
            }


        }

        private void cmbMutual_EditValueChanged(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(cmbMutual.EditValue) == (int)CommonValuesEnum.Ninguno)
            //{
            //    txtNroAfiliado.Enabled = chkPresentaOrden.Enabled = false;
            //}
            //else
            //{
            //    txtNroAfiliado.Enabled = chkPresentaOrden.Enabled = true;
            //}

        }



        private void txt_Enter(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Constants.FOCUSED_BACK_COLOR;
            ((DevExpress.XtraEditors.TextEdit)sender).SelectAll();
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        private void cmbTipoConsulta_EditValueChanged(object sender, EventArgs e)
        {
            if ((int)cmbTipoConsulta.EditValue == (int)TipoConsulta.Recetario)
            {
                int index = cmbProfecionales.Properties.GetDataSourceRowIndex("IdProfecional", (int)CommonValuesEnum.Ninguno);
                cmbProfecionales.ItemIndex = index;
                cmbProfecionales.Enabled = false;
            }
            else
            {
                cmbProfecionales.Enabled = true;
            }
        }

        private void btnFindPatints_Click(object sender, EventArgs e)
        {
            base.MessageViewer.Show("Funcionalidad disponible en version de desarrollo");
            return;
            PatientList s = null;
            try
            {
                s = Controller.GetAllPatients();
            }
            catch (Exception ex)
            {
                base.ExceptionViewer.Show(ex);
                //if (ex.GetType() == typeof(Fwk.Exceptions.TechnicalException))
                //{
                //    ((TechnicalException)ex).ErrorId.Equals("3001")

                //}
                return;
             }

           using (frm_PatientsGrid frm = new frm_PatientsGrid())
           {
               frm.Populate(s);
               if (frm.ShowDialog() == DialogResult.OK)
               {
                   if (frm.SelectedPatient != null)
                       txtCliente.Text = frm.SelectedPatient.full_name;
               }
           }
        }

    }
}
