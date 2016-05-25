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
    public partial class frm_Base : Fwk.UI.Forms.FormDialogBase
    {
        public Fwk.Bases.EntityUpdateEnum State = Fwk.Bases.EntityUpdateEnum.NEW;
        public frm_Base()
        {
            InitializeComponent();

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        public virtual void Populate(object filter) { }

        private void frm_Base_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.Refresh();
            }
        }

        protected void NotNotAvailable()
        {
            using (frmNotAvailable frm = new frmNotAvailable())
            {
                frm.ShowDialog();
            }
        }
    }
}
