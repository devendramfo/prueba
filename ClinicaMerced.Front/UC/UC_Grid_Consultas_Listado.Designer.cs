namespace ClinicaMerced.Front.UC
{
    partial class UC_Grid_Consultas_Listado
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition6 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colIdMutual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresentaqOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.consultaGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoConsultaNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfecionalNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMutualNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCoseguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArancelMutual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExigeCoseguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.paramComercialBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profecionalListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExporPdf = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportExel = new DevExpress.XtraEditors.SimpleButton();
            this.mutualBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uC_FitroConsultaHorizontal1 = new ClinicaMerced.Front.UC.UC_FitroConsultaHorizontal();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramComercialBEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profecionalListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualBEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.White;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Size = new System.Drawing.Size(1043, 41);
            this.lblTitle.Text = "Listado de consultas ";
            // 
            // colIdMutual
            // 
            this.colIdMutual.FieldName = "IdMutual";
            this.colIdMutual.Name = "colIdMutual";
            // 
            // colPresentaqOrden
            // 
            this.colPresentaqOrden.Caption = "Presento Orden";
            this.colPresentaqOrden.FieldName = "PresentaOrden";
            this.colPresentaqOrden.Name = "colPresentaqOrden";
            this.colPresentaqOrden.OptionsColumn.AllowEdit = false;
            this.colPresentaqOrden.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colPresentaqOrden.Visible = true;
            this.colPresentaqOrden.VisibleIndex = 4;
            this.colPresentaqOrden.Width = 112;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.consultaGridBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(218, 101);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(822, 553);
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
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colHora,
            this.colTurno,
            this.colTipoConsultaNombre,
            this.colNombreCliente,
            this.colPresentaqOrden,
            this.colProfecionalNombre,
            this.colMutualNombre,
            this.colCoseguro,
            this.colArancelMutual,
            this.colExigeCoseguro,
            this.colIdMutual});
            styleFormatCondition4.Appearance.BackColor = System.Drawing.Color.SeaShell;
            styleFormatCondition4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Tomato;
            styleFormatCondition4.Appearance.Options.UseBackColor = true;
            styleFormatCondition4.Appearance.Options.UseFont = true;
            styleFormatCondition4.Appearance.Options.UseForeColor = true;
            styleFormatCondition4.ApplyToRow = true;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition4.Expression = "[ExigeCoseguro] == True && [Coseguro] == 0";
            styleFormatCondition5.Appearance.BackColor = System.Drawing.Color.AntiqueWhite;
            styleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Blue;
            styleFormatCondition5.Appearance.Options.UseBackColor = true;
            styleFormatCondition5.Appearance.Options.UseForeColor = true;
            styleFormatCondition5.ApplyToRow = true;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition5.Expression = "[PresentaOrden] == False ";
            styleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition6.Appearance.Options.UseForeColor = true;
            styleFormatCondition6.ApplyToRow = true;
            styleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition6.Expression = "[PresentaOrden] == False && [IdMutual]  != ?";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition4,
            styleFormatCondition5,
            styleFormatCondition6});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.GroupPanelText = "Arrastre aquí una columna para agrupar";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Coseguro", this.colCoseguro, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ArancelMutual", this.colArancelMutual, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdMutual.Value", null, "Cantiad ---> {0}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
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
            this.colNombreCliente.VisibleIndex = 9;
            this.colNombreCliente.Width = 153;
            // 
            // colProfecionalNombre
            // 
            this.colProfecionalNombre.Caption = "Profecional";
            this.colProfecionalNombre.FieldName = "ProfecionalNombre";
            this.colProfecionalNombre.Name = "colProfecionalNombre";
            this.colProfecionalNombre.OptionsColumn.AllowEdit = false;
            this.colProfecionalNombre.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colProfecionalNombre.Visible = true;
            this.colProfecionalNombre.VisibleIndex = 5;
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
            this.colMutualNombre.VisibleIndex = 6;
            this.colMutualNombre.Width = 163;
            // 
            // colCoseguro
            // 
            this.colCoseguro.Caption = "Coseguro";
            this.colCoseguro.FieldName = "Coseguro";
            this.colCoseguro.Name = "colCoseguro";
            this.colCoseguro.OptionsColumn.AllowEdit = false;
            this.colCoseguro.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Coseguro", "{0:0.00}")});
            this.colCoseguro.Visible = true;
            this.colCoseguro.VisibleIndex = 7;
            // 
            // colArancelMutual
            // 
            this.colArancelMutual.Caption = "Arancel";
            this.colArancelMutual.FieldName = "ArancelMutual";
            this.colArancelMutual.Name = "colArancelMutual";
            this.colArancelMutual.OptionsColumn.AllowEdit = false;
            this.colArancelMutual.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ArancelMutual", " {0:0.00}")});
            this.colArancelMutual.Visible = true;
            this.colArancelMutual.VisibleIndex = 8;
            // 
            // colExigeCoseguro
            // 
            this.colExigeCoseguro.Caption = "Exige coseguro";
            this.colExigeCoseguro.FieldName = "ExigeCoseguro";
            this.colExigeCoseguro.Name = "colExigeCoseguro";
            this.colExigeCoseguro.OptionsColumn.AllowEdit = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnRefresh.Appearance.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseForeColor = true;
            this.btnRefresh.Image = global::ClinicaMerced.Front.Properties.Resources.medical_history_refresh_48;
            this.btnRefresh.Location = new System.Drawing.Point(223, 49);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 50);
            this.btnRefresh.TabIndex = 2014;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // paramComercialBEBindingSource
            // 
            this.paramComercialBEBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.ParamComercialBE);
            // 
            // profecionalListBindingSource
            // 
            this.profecionalListBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.ProfecionalList);
            // 
            // btnExporPdf
            // 
            this.btnExporPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExporPdf.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExporPdf.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnExporPdf.Appearance.Options.UseFont = true;
            this.btnExporPdf.Appearance.Options.UseForeColor = true;
            this.btnExporPdf.Image = global::ClinicaMerced.Front.Properties.Resources.export_32;
            this.btnExporPdf.Location = new System.Drawing.Point(730, 59);
            this.btnExporPdf.Name = "btnExporPdf";
            this.btnExporPdf.Size = new System.Drawing.Size(93, 36);
            this.btnExporPdf.TabIndex = 2039;
            this.btnExporPdf.Text = "PDF";
            this.btnExporPdf.Click += new System.EventHandler(this.btnExporPdf_Click);
            // 
            // btnExportExel
            // 
            this.btnExportExel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExportExel.Appearance.ForeColor = System.Drawing.Color.SlateGray;
            this.btnExportExel.Appearance.Options.UseFont = true;
            this.btnExportExel.Appearance.Options.UseForeColor = true;
            this.btnExportExel.Image = global::ClinicaMerced.Front.Properties.Resources.print_preview;
            this.btnExportExel.Location = new System.Drawing.Point(537, 57);
            this.btnExportExel.Name = "btnExportExel";
            this.btnExportExel.Size = new System.Drawing.Size(187, 38);
            this.btnExportExel.TabIndex = 2038;
            this.btnExportExel.Text = "Vistas de impresión";
            this.btnExportExel.Click += new System.EventHandler(this.btnExportExel_Click);
            // 
            // mutualBEBindingSource
            // 
            this.mutualBEBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.MutualBE);
            // 
            // uC_FitroConsultaHorizontal1
            // 
            this.uC_FitroConsultaHorizontal1.AcceptButton = null;
            this.uC_FitroConsultaHorizontal1.CancelButton = null;
            this.uC_FitroConsultaHorizontal1.ComboMonthsEnabled = true;
            this.uC_FitroConsultaHorizontal1.ComboMonthsVisible = true;
            this.uC_FitroConsultaHorizontal1.CombosGroupEnabled = true;
            this.uC_FitroConsultaHorizontal1.CombosGroupVisible = true;
            this.uC_FitroConsultaHorizontal1.Location = new System.Drawing.Point(0, 36);
            this.uC_FitroConsultaHorizontal1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_FitroConsultaHorizontal1.Name = "uC_FitroConsultaHorizontal1";
            this.uC_FitroConsultaHorizontal1.Size = new System.Drawing.Size(222, 610);
            this.uC_FitroConsultaHorizontal1.TabIndex = 2046;
            // 
            // btnCopy
            // 
            this.btnCopy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnCopy.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCopy.Appearance.Options.UseFont = true;
            this.btnCopy.Appearance.Options.UseForeColor = true;
            this.btnCopy.Image = global::ClinicaMerced.Front.Properties.Resources.copy_24;
            this.btnCopy.Location = new System.Drawing.Point(406, 57);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(125, 38);
            this.btnCopy.TabIndex = 2047;
            this.btnCopy.Text = "Copiar todo";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // UC_Grid_Consultas_Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.uC_FitroConsultaHorizontal1);
            this.Controls.Add(this.btnExporPdf);
            this.Controls.Add(this.btnExportExel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gridControl1);
            this.Name = "UC_Grid_Consultas_Listado";
            this.Size = new System.Drawing.Size(1043, 661);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            this.Controls.SetChildIndex(this.btnExportExel, 0);
            this.Controls.SetChildIndex(this.btnExporPdf, 0);
            this.Controls.SetChildIndex(this.uC_FitroConsultaHorizontal1, 0);
            this.Controls.SetChildIndex(this.btnCopy, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramComercialBEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profecionalListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualBEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colPresentaqOrden;
        private System.Windows.Forms.BindingSource consultaGridBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colProfecionalNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colMutualNombre;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colHora;
        private DevExpress.XtraEditors.SimpleButton btnExporPdf;
        private DevExpress.XtraEditors.SimpleButton btnExportExel;
        private DevExpress.XtraGrid.Columns.GridColumn colCoseguro;
        private System.Windows.Forms.BindingSource paramComercialBEBindingSource;
        private System.Windows.Forms.BindingSource profecionalListBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colArancelMutual;
        private DevExpress.XtraGrid.Columns.GridColumn colExigeCoseguro;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private System.Windows.Forms.BindingSource mutualBEBindingSource;
        private UC_FitroConsultaHorizontal uC_FitroConsultaHorizontal1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMutual;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoConsultaNombre;
        private DevExpress.XtraEditors.SimpleButton btnCopy;

    }
}
