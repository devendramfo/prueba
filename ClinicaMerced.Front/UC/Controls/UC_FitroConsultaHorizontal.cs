using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaMerced.Common.Enums;
using ClinicaMerced.Common.Entities;

namespace ClinicaMerced.Front.UC
{
    [ToolboxItem(true)]
    public partial class UC_FitroConsultaHorizontal : Xtra_UC_Base
    {
        public event EventHandler OnFilterChaged;

        void FilterChaged()
        {
            return;
            if (OnFilterChaged != null)
                OnFilterChaged(this, new EventArgs());
        }
        public void SetBeginOfYEar()
        {
            dtPickerFechaInicio.Value = new DateTime(DateTime.Now.Year, 1, 1);
        }
        [Browsable(true)]
        public bool ComboMonthsEnabled
        {
            set
            {
                rndPorMes.Enabled = cmbMonths.Enabled = value;
                if (value)
                {
                    rndPorMes.Checked = true;
                }
                else
                {
                    rndRangoFechas.Checked = true;
                }
            }
            get { return cmbMonths.Enabled; }
        }
        [Browsable(true)]
        public bool ComboMonthsVisible
        {
            set {rndPorMes.Visible = cmbMonths.Visible = value;

            if (value)
            {
                rndPorMes.Checked = true;
            }
            else
            {
                rndRangoFechas.Checked = true;
            }
            }
            get { return cmbMonths.Visible; }
        }
        [Browsable(true)]
        public bool CombosGroupEnabled
        {
            set { grpCombos.Enabled = value; }
            get {return grpCombos.Enabled ; }
        }
        [Browsable(true)]
        public bool CombosGroupVisible
        {
            set { grpCombos.Visible = value; }
            get { return grpCombos.Visible; }
        }
        public bool MonthSelected
        {
            get { return rndPorMes.Checked; }
        }

        public UC_FitroConsultaHorizontal()
        {
            InitializeComponent();
        }

        ProfecionalList _ProfecionalList = new ProfecionalList();
        ParamComercialList _TipoCons = new ParamComercialList();
        MutualList _Mutuales = new MutualList();

        public override void Populate(object filter)
        {
      

         

            _Mutuales.AddRange(Controller.MutualList.Where<MutualBE>(p => p.IdMutual != (int)CommonValuesEnum.Ninguno));
            cmb_Mutual.Properties.DataSource = _Mutuales;

            _ProfecionalList.AddRange(Controller.ProfecionalList.Where<ProfecionalBE>(p => p.IdProfecional != (int)CommonValuesEnum.Ninguno));
            cmbProfecionales.Properties.DataSource = _ProfecionalList;

            _TipoCons.AddRange(Controller.TipoConsultaList.Where<ParamComercialBE>(p => p.IdParamComercial != (int)CommonValuesEnum.Ninguno));
            cmbTipoConsulta.Properties.DataSource = _TipoCons;



            cmbMonths.Properties.DataSource = Enum.GetNames(typeof(Meses));
            cmbMonths.Refresh();

        }

        private void UC_FitroConsultaHorizontal_Load(object sender, EventArgs e)
        {
            int index = cmbTipoConsulta.Properties.GetDataSourceRowIndex("IdParamComercial", (int)CommonValuesEnum.TodosComboBoxValue);
            cmbTipoConsulta.ItemIndex = 0;


            index = cmbProfecionales.Properties.GetDataSourceRowIndex("IdProfecional", (int)CommonValuesEnum.TodosComboBoxValue);
            cmbProfecionales.ItemIndex = index;

            index = cmb_Mutual.Properties.GetDataSourceRowIndex("IdMutual", (int)CommonValuesEnum.TodosComboBoxValue);
            cmb_Mutual.ItemIndex = index;

            cmbMonths.ItemIndex = DateTime.Now.Month - 1;


            cmbMonths.Enabled = rndPorMes.Checked;
            grpFechas.Enabled = !rndPorMes.Checked;

            dtPickerFechaInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtPickerFechaFin.Value = System.DateTime.Now;
            
        }

        private void rndPorMes_CheckedChanged(object sender, EventArgs e)
        {

            cmbMonths.Enabled = rndPorMes.Checked;
            grpFechas.Enabled = !rndPorMes.Checked;

            FilterChaged();
        }

        public ConsultaBE GetFilter()
        {
            ConsultaBE wConsultaBE = new ConsultaBE();

            if (rndPorMes.Checked)
            {
                int month = (int)(Enum.Parse(typeof(Meses), cmbMonths.EditValue.ToString()));

                wConsultaBE.Fecha = new DateTime(DateTime.Now.Year, month, 1);
                int day = DateTime.DaysInMonth(DateTime.Now.Year, month);
                wConsultaBE.FechaFin = new DateTime(DateTime.Now.Year, month, day);
            }
            else
            {
                wConsultaBE.Fecha = new DateTime(dtPickerFechaInicio.Value.Year, dtPickerFechaInicio.Value.Month, dtPickerFechaInicio.Value.Day, 0, 0, 0);
                wConsultaBE.FechaFin = new DateTime(dtPickerFechaFin.Value.Year,dtPickerFechaFin.Value.Month,dtPickerFechaFin.Value.Day,23,59,59);
               
            }

            if (grpCombos.Visible && grpCombos.Enabled)
            {
                if ((int)cmbProfecionales.EditValue != (int)CommonValuesEnum.TodosComboBoxValue)
                    wConsultaBE.IdProfecional = Convert.ToInt32(cmbProfecionales.EditValue);

                if ((int)cmbTipoConsulta.EditValue != (int)CommonValuesEnum.TodosComboBoxValue)
                    wConsultaBE.IdTipoConsulta = Convert.ToInt32(cmbTipoConsulta.EditValue);


                if ((int)cmb_Mutual.EditValue != (int)CommonValuesEnum.TodosComboBoxValue)
                    wConsultaBE.IdMutual = Convert.ToInt32(cmb_Mutual.EditValue);
            }
            return wConsultaBE;
        }

        private void dtPickerFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            FilterChaged();
        }

        private void dtPickerFechaFin_ValueChanged(object sender, EventArgs e)
        {
            FilterChaged();
        }

        private void cmbMonths_EditValueChanged(object sender, EventArgs e)
        {
            FilterChaged();
        }

        private void cmbTipoConsulta_EditValueChanged(object sender, EventArgs e)
        {
            FilterChaged();
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Now;
            dtPickerFechaInicio.Value = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
            dtPickerFechaFin.Value = new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59);
            dtPickerFechaInicio.Refresh();
            dtPickerFechaFin.Refresh();
        }
    }
}
