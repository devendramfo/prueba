using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaMerced.Front.UC
{
    public partial class frm_Crear : frm_Base
    {
        public frm_Crear()
        {
            InitializeComponent();
            this.aceptCancelButtonBar1.ClickOkCancelEvent += new Fwk.UI.Common.ClickOkCancelHandler(aceptCancelButtonBar1_ClickOkCancelEvent);
        }

        void aceptCancelButtonBar1_ClickOkCancelEvent(object sender, DialogResult result)
        {


        }


        public override void Populate(object filter)
        {
            if (!this.DesignMode)
            {
                this.UC_Consulta1.State = this.State;
                this.UC_Consulta1.Populate(filter);
            }
        }


        internal Common.Entities.ConsultaBE GetData()
        {
            if (!this.DesignMode)
                return this.UC_Consulta1.GetData();
            else
                return null;
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            if (!this.UC_Consulta1.HasErrors())
            {
                if (this.State == Fwk.Bases.EntityUpdateEnum.NEW)

                    Controller.CreateConsulta(this.UC_Consulta1.GetData());
                else

                    Controller.UpdateConsulta(this.UC_Consulta1.GetData());
            }

            else
            {
                this.MessageViewer.Show("Cheque los errores que se le muestran en la pantalla");
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }



            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {


            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


    }
}
