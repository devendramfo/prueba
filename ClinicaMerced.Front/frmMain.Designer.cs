namespace ClinicaMerced.Front
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvPrincipal = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvConsultaFiltros = new DevExpress.XtraNavBar.NavBarItem();
            this.nvCunsultaPivot = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.nvEstadisticas = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvCierreDiario = new DevExpress.XtraNavBar.NavBarItem();
            this.nvConsultar = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvAddUser = new DevExpress.XtraNavBar.NavBarItem();
            this.nvMutuales = new DevExpress.XtraNavBar.NavBarItem();
            this.uC_Grid_Consultas2 = new ClinicaMerced.Front.UC.UC_Grid_Consultas();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.navBarControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uC_Grid_Consultas2);
            this.splitContainer1.Size = new System.Drawing.Size(978, 714);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup4,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nvConsultaFiltros,
            this.nvPrincipal,
            this.navBarItem3,
            this.nvAddUser,
            this.nvMutuales,
            this.nvEstadisticas,
            this.navBarItem1,
            this.nvCunsultaPivot,
            this.nvCierreDiario,
            this.nvConsultar,
            this.navBarItem2,
            this.navBarItem4});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 258;
            this.navBarControl1.Size = new System.Drawing.Size(161, 710);
            this.navBarControl1.TabIndex = 0;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.navBarGroup1.Appearance.Options.UseFont = true;
            this.navBarGroup1.Caption = "Recepcion";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvPrincipal),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nvPrincipal
            // 
            this.nvPrincipal.Caption = "Principal";
            this.nvPrincipal.LargeImage = global::ClinicaMerced.Front.Properties.Resources.medical_history_pen_48;
            this.nvPrincipal.Name = "nvPrincipal";
            this.nvPrincipal.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvPrincipal_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Alta cliente";
            this.navBarItem3.LargeImage = global::ClinicaMerced.Front.Properties.Resources.vcard;
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.navBarGroup2.Appearance.Options.UseFont = true;
            this.navBarGroup2.Caption = "Consultas";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvConsultaFiltros),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvCunsultaPivot),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvEstadisticas)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // nvConsultaFiltros
            // 
            this.nvConsultaFiltros.Caption = "Listado de consultas";
            this.nvConsultaFiltros.Name = "nvConsultaFiltros";
            this.nvConsultaFiltros.SmallImage = global::ClinicaMerced.Front.Properties.Resources.reminders_and_recalls_ok_32;
            this.nvConsultaFiltros.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvConsultaFiltros_LinkClicked);
            // 
            // nvCunsultaPivot
            // 
            this.nvCunsultaPivot.Caption = "Vista pivot";
            this.nvCunsultaPivot.Name = "nvCunsultaPivot";
            this.nvCunsultaPivot.SmallImage = global::ClinicaMerced.Front.Properties.Resources.Shopping_Chart;
            this.nvCunsultaPivot.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvCunsultaPivot_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Grafico fluctuaciones de ingresos diarios";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImage = global::ClinicaMerced.Front.Properties.Resources.Chart__Alt_2_;
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Grafico montos total mensual";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImage = global::ClinicaMerced.Front.Properties.Resources.Chart__Alt_2_;
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // nvEstadisticas
            // 
            this.nvEstadisticas.Caption = "Estadísticas";
            this.nvEstadisticas.Name = "nvEstadisticas";
            this.nvEstadisticas.SmallImage = global::ClinicaMerced.Front.Properties.Resources.statistic_32;
            this.nvEstadisticas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvEstadisticas_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Caja";
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList;
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvCierreDiario),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvConsultar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // nvCierreDiario
            // 
            this.nvCierreDiario.Caption = "CierreDiario";
            this.nvCierreDiario.Name = "nvCierreDiario";
            this.nvCierreDiario.SmallImage = global::ClinicaMerced.Front.Properties.Resources.price;
            this.nvCierreDiario.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvCierreDiario_LinkClicked);
            // 
            // nvConsultar
            // 
            this.nvConsultar.Caption = "Consultar Cierres";
            this.nvConsultar.Name = "nvConsultar";
            this.nvConsultar.SmallImage = global::ClinicaMerced.Front.Properties.Resources.summary_zoom_32;
            this.nvConsultar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvConsultar_LinkClicked);
            this.nvConsultar.ItemChanged += new System.EventHandler(this.nvConsultar_ItemChanged);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Consulta por tiempo";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.SmallImage = global::ClinicaMerced.Front.Properties.Resources.summary_zoom_32;
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.navBarGroup3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navBarGroup3.Appearance.Options.UseFont = true;
            this.navBarGroup3.Appearance.Options.UseForeColor = true;
            this.navBarGroup3.Caption = "Misc";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvAddUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvMutuales)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // nvAddUser
            // 
            this.nvAddUser.Caption = "Usuarios";
            this.nvAddUser.Name = "nvAddUser";
            this.nvAddUser.SmallImage = global::ClinicaMerced.Front.Properties.Resources.users_32;
            this.nvAddUser.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvAddUser_LinkClicked);
            // 
            // nvMutuales
            // 
            this.nvMutuales.Caption = "Importar datos ";
            this.nvMutuales.Name = "nvMutuales";
            this.nvMutuales.SmallImage = global::ClinicaMerced.Front.Properties.Resources.Shopping_Chart;
            this.nvMutuales.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvMutuales_LinkClicked);
            // 
            // uC_Grid_Consultas2
            // 
            this.uC_Grid_Consultas2.AcceptButton = null;
            this.uC_Grid_Consultas2.CancelButton = null;
            this.uC_Grid_Consultas2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Grid_Consultas2.Location = new System.Drawing.Point(0, 0);
            this.uC_Grid_Consultas2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_Grid_Consultas2.Name = "uC_Grid_Consultas2";
            this.uC_Grid_Consultas2.Size = new System.Drawing.Size(801, 710);
            this.uC_Grid_Consultas2.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 722);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepción";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nvPrincipal;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem nvConsultaFiltros;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        
        private UC.UC_Grid_Consultas uC_Grid_Consultas2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem nvAddUser;
        private DevExpress.XtraNavBar.NavBarItem nvMutuales;
        private DevExpress.XtraNavBar.NavBarItem nvEstadisticas;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem nvCunsultaPivot;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem nvCierreDiario;
        private DevExpress.XtraNavBar.NavBarItem nvConsultar;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
    }
}

