using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaMerced.Front.UC;
using ClinicaMerced.Backend.DAC;
using System.Runtime.Remoting.Messaging;

namespace ClinicaMerced.Front
{
    public delegate void DelegateWithOutAndRefParameters(out Exception ex);
    public partial class frmImportExternalData : frm_Base
    {
        public frmImportExternalData()
        {
            InitializeComponent();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.btnImport.Enabled = false;
            this.txtTExt.Visible = true;
            this.pictureBox1.Visible = true;
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtTExt.Text = "Realizando importación de datos. \r Por favor aguarde unos instantes..";
            
            PopulateAsync();
        }

        /// <summary>
        /// Carga de manera asincrona los Dominios relacionados entre si en la grilla.-
        /// </summary>
        public void PopulateAsync()
        {
            Exception ex = null;
            DelegateWithOutAndRefParameters s = new DelegateWithOutAndRefParameters(Import);
            s.BeginInvoke(out ex, new AsyncCallback(EndPopulate), null);
        }

        /// <summary>
        /// Fin de el metodo populate que fue llamado de forma asincrona
        /// </summary>
        /// <param name="res"></param>
        void EndPopulate(IAsyncResult res)
        {
            Exception ex;
            if (this.InvokeRequired)
            {
                AsyncCallback d = new AsyncCallback(EndPopulate);
                this.Invoke(d, new object[] { res });
            }
            else
            {
                AsyncResult result = (AsyncResult)res;
                DelegateWithOutAndRefParameters del = (DelegateWithOutAndRefParameters)result.AsyncDelegate;
                del.EndInvoke(out ex, res);
                this.Cursor = System.Windows.Forms.Cursors.Default;
                if (ex != null)
                {
                    txtTExt.Text = Fwk.Exceptions.ExceptionHelper.GetAllMessageException(ex);
                    //img_info.Image = this.ExceptionViewer.Icon;
                    this.img_info.Visible = true;
                    this.ExceptionViewer.Show(ex);
                }
                else
                {

                    this.MessageViewer.Show("La importación se realizo con éxito");
                    txtTExt.Text = "La importación se realizo con éxito";
                    this.img_info.Visible = false;
                    pictureBox1.Visible = false;
                    btnImport.Enabled = true;
                }

            }

        }



        /// <summary>
        /// Carga Dominios relacionados entre al objeto _RelatedDomains que esta bindiado a la grilla
        /// </summary>
        void Import(out Exception ex)
        {
            ex = null;
            try
            {
                InsuranceNomenclatorDAC.Import();
            }
            catch (Exception err)
            {
                err.Source = "Origen de datos";
                ex = err;
            }

        }

        void Import()
        {
            pictureBox1.Visible = true;
            try
            {
                InsuranceNomenclatorDAC.Import();
            }
            catch(Exception ex)
            {

                txtTExt.Text = Fwk.Exceptions.ExceptionHelper.GetAllMessageException(ex);
                //img_info.Image = this.ExceptionViewer.Icon;
                this.img_info.Visible = true;
                this.ExceptionViewer.Show(ex);
                return;
                
            }
            
            this.MessageViewer.Show("La importacion se realiso con exito");
            txtTExt.Text = "La importacion se realiso con exito";
            this.img_info.Visible = false;
            pictureBox1.Visible = false;
        }
    }
}
