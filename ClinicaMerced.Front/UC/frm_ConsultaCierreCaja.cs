using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaMerced.Common.Enums;
using ClinicaMerced.Backend.DAC;
using ClinicaMerced.Common.Entities;

namespace ClinicaMerced.Front.UC
{
    public partial class frm_ConsultaCierreCaja : frm_Base
    {
        ClinicaMerced.Common.Entities.CierreCajaDiarioList list_Rezetas = null;
        ClinicaMerced.Common.Entities.CierreCajaDiarioList list_Propietarios = null;

        public frm_ConsultaCierreCaja()
        {
            InitializeComponent();

            
        }

        void Pupulate(DateTime fechaInicio,DateTime fechafin,int? IdProfecional)
        {
            ClinicaMerced.Common.Entities.CierreCajaDiarioList list = CajaDAC.Retrive_CierreCaja(fechaInicio, fechafin,null);
            list_Rezetas = list.Search_TipoIngreso(TipoIngresoCaja.Rezeta);
            list_Propietarios = list.Search_TipoIngreso(TipoIngresoCaja.ProfecionalMedico);
            

            
            cierreCajaDiarioBindingSource_Resetas.DataSource = list_Rezetas;
            cierreCajaDiarioBindingSource_Profecionales.DataSource = list_Propietarios;

            gridView1.RefreshData();
            gridView2.RefreshData();
            
        }

        private void frm_ConsultaCierreCaja_Load(object sender, EventArgs e)
        {
            Pupulate(DateTime.Now,DateTime.Now,null);
        }

      


        public override void Populate(object filter)
        {
            uC_FitroConsultaHorizontal1.Populate(null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
          
            ConsultaBE filter = this.uC_FitroConsultaHorizontal1.GetFilter();
            Pupulate(filter.Fecha, filter.FechaFin.Value, null);
        }

        public override void Refresh()
        {
            ConsultaBE filter = this.uC_FitroConsultaHorizontal1.GetFilter();
            Pupulate(filter.Fecha, filter.FechaFin.Value, null);

            base.Refresh();
        }
    }
}
