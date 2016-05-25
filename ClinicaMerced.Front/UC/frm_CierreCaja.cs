using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaMerced.Backend.DAC;
using ClinicaMerced.Common.Enums;



namespace ClinicaMerced.Front.UC
{
    public partial class frm_CierreCaja : frm_Base
    {
        ClinicaMerced.Common.Entities.CierreCajaDiarioList list_Rezetas = null;
        ClinicaMerced.Common.Entities.CierreCajaDiarioList list_Propietarios = null;
        ClinicaMerced.Common.Entities.CierreCajaDiarioList list_Externos = null;
        public frm_CierreCaja()
        {
            InitializeComponent();
        }




        void Pupulate(DateTime fecha)
        {
            ClinicaMerced.Common.Entities.CierreCajaDiarioList list = null;
            try
            {
                vwConsultaToCierreCajaDetailBindingSource.DataSource = CajaDAC.Retrive_Details(fecha);
                gridControl4.RefreshDataSource();
                list = CajaDAC.Retrive_Consultas_CierreCajaDiario(fecha);
            }
            catch (Exception ex)
            {
                this.ExceptionViewer.Show(ex);
                return;
            }

            list_Rezetas = list.Search_Resetas();
            list_Propietarios = list.Search_TipoProfecional(TipoProfecional.Propietario);
            list_Externos = list.Search_TipoProfecional(TipoProfecional.Externo);

            bindingSource_Externos.DataSource = list_Externos;
            cierreCajaDiarioBindingSource_Resetas.DataSource = list_Rezetas;
            cierreCajaDiarioBindingSource_Profecionales.DataSource = list_Propietarios;

            gridView1.RefreshData();
            gridView2.RefreshData();
            gridView3.RefreshData();

            CheckCierreExist();

        }

        private void frm_CierreCaja_Load(object sender, EventArgs e)
        {
            this.dtPickerFechaInicio.Value = DateTime.Now;
            //Pupulate(DateTime.Now);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
  

            if (CheckCierreExist())
            {
                CreateCierreProfecional(list_Propietarios);
                CreateCierreProfecional(list_Externos);
                CreateCierreResetas();
            }
            MessageViewer.Show("Cierre de caja realizado con éxito");
        }



        void CreateCierreProfecional(ClinicaMerced.Common.Entities.CierreCajaDiarioList list)
        {
            List<ClinicaMerced.Common.Entities.Caja.CierreCajaDiario> listToInsert = new List<ClinicaMerced.Common.Entities.Caja.CierreCajaDiario>();
            ClinicaMerced.Common.Entities.Caja.CierreCajaDiario cierreDB = null;
            foreach (ClinicaMerced.Common.Entities.CierreCajaDiario cierre in list)
            {


                cierreDB = new Common.Entities.Caja.CierreCajaDiario();
                cierreDB.Arancel = cierre.TotalArancel;
                cierreDB.Coseguro = cierre.TotalCoseguro;
                cierreDB.IdProfecional = cierre.IdProfecional;
                cierreDB.Fecha = this.dtPickerFechaInicio.Value;
                cierreDB.IdTipoIngreso = (int)TipoIngresoCaja.ProfecionalMedico;
                cierreDB.UserName = Environment.UserName;
                listToInsert.Add(cierreDB);

            }

            try
            {
                if (listToInsert.Count > 0)
                    CajaDAC.Create(listToInsert);
            }
            catch (Exception ex)
            {
                ExceptionViewer.Show(ex);
                return;
            }


        }

        void CreateCierreResetas()
        {
            List<ClinicaMerced.Common.Entities.Caja.CierreCajaDiario> listToInsert = new List<ClinicaMerced.Common.Entities.Caja.CierreCajaDiario>();
            ClinicaMerced.Common.Entities.Caja.CierreCajaDiario cierreDB = null;
            foreach (ClinicaMerced.Common.Entities.CierreCajaDiario cierre in list_Rezetas)
            {

                cierreDB = new Common.Entities.Caja.CierreCajaDiario();
                cierreDB.Arancel = cierre.TotalArancel;
                cierreDB.Coseguro = cierre.TotalCoseguro;
                //cierreDB.IdProfecional = cierre.IdProfecional;
                cierreDB.Fecha = this.dtPickerFechaInicio.Value;
                cierreDB.IdTipoIngreso = (int)TipoIngresoCaja.Rezeta;

                listToInsert.Add(cierreDB);

            }
            try
            {
                if (listToInsert.Count >= 0)
                    CajaDAC.Create(listToInsert);
            }
            catch (Exception ex)
            {
                ExceptionViewer.Show(ex);
                return;
            }

        }
        bool CheckCierreExist()
        {

            if (CajaDAC.Exist(dtPickerFechaInicio.Value, TipoIngresoCaja.Rezeta))
            {
                lblMessage.Text = string.Concat("Ya se realizó el cierre para ", dtPickerFechaInicio.Value.ToShortDateString());
                return false;
            }

            if (list_Propietarios.Count == 0 && list_Rezetas.Count == 0 && list_Externos.Count == 0)
            {
                lblMessage.Text = "No hay cierres para la fecha seleccionada";
                return false;
            }

            lblMessage.Text = string.Empty;
            return true;
        }



        private void dtPickerFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            Pupulate(this.dtPickerFechaInicio.Value);
        }
    }
}