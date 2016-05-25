using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;

using Fwk.Bases;
using Fwk.Bases.Connector;
using Fwk.UI.Security.Controls;

using Fwk.Caching;
using Fwk.UI.Forms;
using Fwk.UI.Common;
using ClinicaMerced.Common.Entities;
using ClinicaMerced.Front;
using ClinicaMerced.Front.UC;
using System.Reflection;
using ClinicaMerced.Backend.DAC;
using Fwk.Exceptions;


namespace ClinicaMerced.Front
{
    public partial class frmMain : FormBase
    {
        UC_Consulta_SProfecional_AMes _UC_Consulta_SProfecional_AMes=null   ;
        UC_Consulta_SProfecional_ADia _UC_Consulta_SProfecional_ADia = null;

        UC_Grid_Consultas_Listado cC_Grid_Consultas_Listado = new UC.UC_Grid_Consultas_Listado();
        UC_VistaDinamicaConsultas wUC_VistaDinamicaConsultas = new UC_VistaDinamicaConsultas();
        UC_ConsultaCierreCaja wUC_ConsultaCierreCaja = new UC_ConsultaCierreCaja();
        static FwkSimpleStorageBase<ClientUserSettings> storage = new FwkSimpleStorageBase<ClientUserSettings>();
        Xtra_UC_Base currentControl;

        public frmMain()
        {
            Application.CurrentCulture = new CultureInfo("es-AR");
            InitializeComponent();
            this.Text = string.Concat(this.Text,  Assembly.GetExecutingAssembly().GetName().Version.ToString()," (Test version)");

            try
            {
                 _UC_Consulta_SProfecional_AMes = new UC_Consulta_SProfecional_AMes();
                 _UC_Consulta_SProfecional_ADia = new UC_Consulta_SProfecional_ADia();
             
            }
            catch (Exception cuero)
            {
                MessageBox.Show(cuero.Message);
            }

           
        }


        internal void SetDialogsToDefault()
        {
            this.MessageViewer.MessageBoxButtons = MessageBoxButtons.OK;
            this.MessageViewer.MessageBoxIcon = Fwk.UI.Common.MessageBoxIcon.Information;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMain.storage.Load();
            if (frmMain.storage.StorageObject == null)
            {
                frmMain.storage.StorageObject = new ClientUserSettings();
                frmMain.storage.Save();
            }

            this.uC_Grid_Consultas2.Populate(DateTime.Now);
            currentControl = this.uC_Grid_Consultas2;


            try
            {
                ClinicaMerced.Backend.lic.chk();
            }
            catch (TechnicalException te)
            {
                if (te.ErrorId != "101")
                {
                    
                    navBarControl1.Enabled = false;
                    this.currentControl.Enabled = false;
                }


                MessageBox.Show(te.Message, te.Source, MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);


                this.Text = this.Text + " " + te.Message;

            }
            //LoadAuthenticationForm();
        }


        void AddContronToPannel(Xtra_UC_Base ctrl, object obj)
        {

            //if (ctrl == null)
            //{
            //    string type = ctrl.AccessibleDescription;
            //    ctrl = (Xtra_UC_Base)Fwk.HelperFunctions.ReflectionFunctions.CreateInstance(type);
            //}
            if (!this.splitContainer1.Panel2.Contains(ctrl))
            {
                currentControl = ctrl;
                ctrl.Populate(obj);
                this.splitContainer1.Panel2.Controls.Add(ctrl);
                ctrl.Location = new System.Drawing.Point(0, 0);
                ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            }
            ctrl.BringToFront();
        }



        private void nvPrincipal_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AddContronToPannel(uC_Grid_Consultas2, null);
        }

        private void nvConsultaFiltros_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AddContronToPannel(cC_Grid_Consultas_Listado, null);
        }

        private void nvCunsultaPivot_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AddContronToPannel(wUC_VistaDinamicaConsultas, null);
        }

        private void nvAddUser_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            NotNotAvailable();
        }

        private void nvMutuales_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {


            using (frmImportExternalData frm = new frmImportExternalData())
            {
                frm.ShowDialog();
            }
        }
        
        private void nvEstadisticas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            NotNotAvailable();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            NotNotAvailable();
        }



        private void nvCierreDiario_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            using (frm_CierreCaja frm = new frm_CierreCaja())
            {
                frm.ShowDialog();
            }

        }

        private void nvConsultar_ItemChanged(object sender, EventArgs e)
        {
            NotNotAvailable();

        }

        private void nvConsultar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            AddContronToPannel(wUC_ConsultaCierreCaja, null);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (currentControl != null)
                    currentControl.Refresh();
            }
        }

        /// <summary>
        /// Cargamos el Formulario de Autenticación
        /// </summary>
        void LoadAuthenticationForm()
        {
            
            FRM_AuthenticationForm_ASPNet wAuthForm = new FRM_AuthenticationForm_ASPNet();


            wAuthForm.Auth_Title_Image = null;

            wAuthForm.Auth_Title_Text = "Autenticación";
            wAuthForm.InitCredentials(frmMain.storage.StorageObject.User, frmMain.storage.StorageObject.Password);
            string usr = string.Empty;
            
            if (wAuthForm.ShowDialog() == DialogResult.OK)
            {
                usr = frmMain.Principal.Identity.Name;
                frmMain.storage.StorageObject.User = FormBase.Principal.Identity.Name;
                frmMain.storage.StorageObject.Password = wAuthForm.Password;
                frmMain.storage.Save();
            }
            else
                this.Close();

        }
        void NotNotAvailable()
        {
            using (frmNotAvailable frm = new frmNotAvailable())
            {
                frm.ShowDialog();
            }
        }
 
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AddContronToPannel(_UC_Consulta_SProfecional_AMes, null);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AddContronToPannel(_UC_Consulta_SProfecional_ADia, null);
        }

    }

}

