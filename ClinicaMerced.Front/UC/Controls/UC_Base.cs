using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ClinicaMerced.Front
{
    public partial class Xtra_UC_Base : Fwk.UI.Controls.UC_UserControlBase
    {
        public Fwk.Bases.EntityUpdateEnum State = Fwk.Bases.EntityUpdateEnum.NEW;

        public Xtra_UC_Base()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        public virtual void Populate(object filter) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        public virtual void SetTitle(string title) { }

        private void Xtra_UC_Base_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.Refresh();
            }
        }
    }
}
