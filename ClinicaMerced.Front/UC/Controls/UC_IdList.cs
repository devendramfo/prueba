using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaMerced.Common.Entities;
using System.ComponentModel.Design;

namespace ClinicaMerced.Front
{
    [ToolboxItem(true)]
    [DefaultEvent("ClickOkEvent")]
    public partial class UC_FiltroTipoList : ClinicaMerced.Front.Xtra_UC_Base
    {
        bool start = true;
        private ParamComercialList _CheckedsList = null;
        public UC_FiltroTipoList()
        {
            InitializeComponent();

            this.Load += new EventHandler(UC_FiltroTipoList_Load);
        }

        void UC_FiltroTipoList_Load(object sender, EventArgs e)
        {
            
        }
        public override void Populate(object filter)
        {
            //if (GetService(typeof(IDesignerHost)) == null) return;
            _CheckedsList = Controller.TipoConsultaList.Clone < ParamComercialList>();
            _CheckedsList.Quit((int)ClinicaMerced.Common.Enums.CommonValuesEnum.TodosComboBoxValue);
            _CheckedsList.Quit((int)ClinicaMerced.Common.Enums.CommonValuesEnum.Ninguno);
            
            chkListSectorGastoGasto.DataSource = _CheckedsList;

            chkListSectorGastoGasto.DisplayMember = "Nombre";
            chkListSectorGastoGasto.ValueMember = "IdParamComercial";
            
            this.start = false;
            base.Populate(filter);

            SetAllItemsChecked(true);
        }
        public ParamComercialList GetChecked()
        {
            _CheckedsList.Clear();
            foreach (object itemChecked in chkListSectorGastoGasto.CheckedItems)
            {
                ParamComercialBE wTipoGastoBE = (ParamComercialBE)itemChecked;
                _CheckedsList.Add(wTipoGastoBE);
            }
            return _CheckedsList;
        }

        void SetAllItemsChecked(bool pChecked)
        {
            for (int index = 0; index <= chkListSectorGastoGasto.Items.Count - 1; index++)
            {
                chkListSectorGastoGasto.SetItemChecked(index, pChecked);
            }
            if (pChecked)
                chkAll.Text = "Deseleccionar todos";
            else
            chkAll.Text = "Seleccionar todos";
        }
        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            SetAllItemsChecked(chkAll.Checked);
            
        }

        private void chkListClaseTipoGasto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start) return;
            int id = ((ParamComercialBE)chkListSectorGastoGasto.SelectedItem).IdParamComercial;

        }

    }
}
