namespace ClinicaMerced.Front.UC
{
    partial class UC_Grid_Consultas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.consultaGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoConsultaNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresentaqOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfecionalNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMutualNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCrearNueva = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportExel = new DevExpress.XtraEditors.SimpleButton();
            this.btnExporPdf = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelette = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.White;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTitle.Size = new System.Drawing.Size(841, 33);
            this.lblTitle.Text = "Gestion de consultas ";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.consultaGridBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 87);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(838, 323);
            this.gridControl1.TabIndex = 2012;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // consultaGridBindingSource
            // 
            this.consultaGridBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.Custom.ConsultaGrid);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colHora,
            this.colTurno,
            this.colTipoConsultaNombre,
            this.colNombreCliente,
            this.colPresentaqOrden,
            this.colProfecionalNombre,
            this.colMutualNombre});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.GroupPanelText = "Arrastre aquí una columna para agrupar";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "MutualNombre", null, "Cantidad --> {0}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 98;
            // 
            // colHora
            // 
            this.colHora.FieldName = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.OptionsColumn.AllowEdit = false;
            this.colHora.Visible = true;
            this.colHora.VisibleIndex = 1;
            this.colHora.Width = 79;
            // 
            // colTurno
            // 
            this.colTurno.FieldName = "Turno";
            this.colTurno.Name = "colTurno";
            this.colTurno.OptionsColumn.AllowEdit = false;
            this.colTurno.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTurno.Visible = true;
            this.colTurno.VisibleIndex = 2;
            this.colTurno.Width = 143;
            // 
            // colTipoConsultaNombre
            // 
            this.colTipoConsultaNombre.Caption = "Tipo consulta";
            this.colTipoConsultaNombre.FieldName = "TipoConsultaNombre";
            this.colTipoConsultaNombre.Name = "colTipoConsultaNombre";
            this.colTipoConsultaNombre.OptionsColumn.AllowEdit = false;
            this.colTipoConsultaNombre.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTipoConsultaNombre.Visible = true;
            this.colTipoConsultaNombre.VisibleIndex = 3;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.FieldName = "NombreCliente";
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.OptionsColumn.AllowEdit = false;
            this.colNombreCliente.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNombreCliente.Visible = true;
            this.colNombreCliente.VisibleIndex = 7;
            this.colNombreCliente.Width = 153;
            // 
            // colPresentaqOrden
            // 
            this.colPresentaqOrden.Caption = "Presento Orden";
            this.colPresentaqOrden.FieldName = "PresentaOrden";
            this.colPresentaqOrden.Name = "colPresentaqOrden";
            this.colPresentaqOrden.OptionsColumn.AllowEdit = false;
            this.colPresentaqOrden.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPresentaqOrden.Visible = true;
            this.colPresentaqOrden.VisibleIndex = 5;
            this.colPresentaqOrden.Width = 112;
            // 
            // colProfecionalNombre
            // 
            this.colProfecionalNombre.Caption = "Profecional";
            this.colProfecionalNombre.FieldName = "ProfecionalNombre";
            this.colProfecionalNombre.Name = "colProfecionalNombre";
            this.colProfecionalNombre.OptionsColumn.AllowEdit = false;
            this.colProfecionalNombre.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colProfecionalNombre.Visible = true;
            this.colProfecionalNombre.VisibleIndex = 6;
            this.colProfecionalNombre.Width = 153;
            // 
            // colMutualNombre
            // 
            this.colMutualNombre.Caption = "Mutual";
            this.colMutualNombre.FieldName = "MutualNombre";
            this.colMutualNombre.Name = "colMutualNombre";
            this.colMutualNombre.OptionsColumn.AllowEdit = false;
            this.colMutualNombre.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colMutualNombre.Visible = true;
            this.colMutualNombre.VisibleIndex = 4;
            this.colMutualNombre.Width = 163;
            // 
            // btnCrearNueva
            // 
            this.btnCrearNueva.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnCrearNueva.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnCrearNueva.Appearance.Options.UseFont = true;
            this.btnCrearNueva.Appearance.Options.UseForeColor = true;
            this.btnCrearNueva.Image = global::ClinicaMerced.Front.Properties.Resources.medical_history_add_48;
            this.btnCrearNueva.Location = new System.Drawing.Point(3, 39);
            this.btnCrearNueva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearNueva.Name = "btnCrearNueva";
            this.btnCrearNueva.Size = new System.Drawing.Size(126, 44);
            this.btnCrearNueva.TabIndex = 2013;
            this.btnCrearNueva.Text = "Crear nueva";
            this.btnCrearNueva.Click += new System.EventHandler(this.btnCrearNueva_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnRefresh.Appearance.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseForeColor = true;
            this.btnRefresh.Image = global::ClinicaMerced.Front.Properties.Resources.medical_history_refresh_48;
            this.btnRefresh.Location = new System.Drawing.Point(149, 39);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 44);
            this.btnRefresh.TabIndex = 2014;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExportExel
            // 
            this.btnExportExel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExportExel.Appearance.ForeColor = System.Drawing.Color.SlateGray;
            this.btnExportExel.Appearance.Options.UseFont = true;
            this.btnExportExel.Appearance.Options.UseForeColor = true;
            this.btnExportExel.Image = global::ClinicaMerced.Front.Properties.Resources.print_preview;
            this.btnExportExel.Location = new System.Drawing.Point(484, 52);
            this.btnExportExel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportExel.Name = "btnExportExel";
            this.btnExportExel.Size = new System.Drawing.Size(148, 31);
            this.btnExportExel.TabIndex = 2015;
            this.btnExportExel.Text = "Vistas de impresión";
            this.btnExportExel.Click += new System.EventHandler(this.btnExportExel_Click);
            // 
            // btnExporPdf
            // 
            this.btnExporPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExporPdf.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExporPdf.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnExporPdf.Appearance.Options.UseFont = true;
            this.btnExporPdf.Appearance.Options.UseForeColor = true;
            this.btnExporPdf.Image = global::ClinicaMerced.Front.Properties.Resources.export_32;
            this.btnExporPdf.Location = new System.Drawing.Point(652, 54);
            this.btnExporPdf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExporPdf.Name = "btnExporPdf";
            this.btnExporPdf.Size = new System.Drawing.Size(80, 29);
            this.btnExporPdf.TabIndex = 2016;
            this.btnExporPdf.Text = "PDF";
            this.btnExporPdf.Click += new System.EventHandler(this.btnExporPdf_Click);
            // 
            // btnDelette
            // 
            this.btnDelette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelette.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDelette.Appearance.ForeColor = System.Drawing.Color.SlateGray;
            this.btnDelette.Appearance.Options.UseFont = true;
            this.btnDelette.Appearance.Options.UseForeColor = true;
            this.btnDelette.Image = global::ClinicaMerced.Front.Properties.Resources.reminders_and_recalls_close_32;
            this.btnDelette.Location = new System.Drawing.Point(393, 50);
            this.btnDelette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelette.Name = "btnDelette";
            this.btnDelette.Size = new System.Drawing.Size(83, 31);
            this.btnDelette.TabIndex = 2017;
            this.btnDelette.Text = "Eliminar";
            this.btnDelette.Click += new System.EventHandler(this.btnDelette_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnCopy.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCopy.Appearance.Options.UseFont = true;
            this.btnCopy.Appearance.Options.UseForeColor = true;
            this.btnCopy.Image = global::ClinicaMerced.Front.Properties.Resources.copy_24;
            this.btnCopy.Location = new System.Drawing.Point(273, 50);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(99, 32);
            this.btnCopy.TabIndex = 2048;
            this.btnCopy.Text = "Copiar todo";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // UC_Grid_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDelette);
            this.Controls.Add(this.btnExporPdf);
            this.Controls.Add(this.btnExportExel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCrearNueva);
            this.Controls.Add(this.gridControl1);
            this.Name = "UC_Grid_Consultas";
            this.Size = new System.Drawing.Size(841, 412);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.btnCrearNueva, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            this.Controls.SetChildIndex(this.btnExportExel, 0);
            this.Controls.SetChildIndex(this.btnExporPdf, 0);
            this.Controls.SetChildIndex(this.btnDelette, 0);
            this.Controls.SetChildIndex(this.btnCopy, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colPresentaqOrden;
        private DevExpress.XtraEditors.SimpleButton btnCrearNueva;
        private System.Windows.Forms.BindingSource consultaGridBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colProfecionalNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colMutualNombre;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colHora;
        private DevExpress.XtraEditors.SimpleButton btnExportExel;
        private DevExpress.XtraEditors.SimpleButton btnExporPdf;
        private DevExpress.XtraEditors.SimpleButton btnDelette;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoConsultaNombre;
        private DevExpress.XtraEditors.SimpleButton btnCopy;

    }
}
