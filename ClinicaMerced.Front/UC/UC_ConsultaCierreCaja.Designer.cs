namespace ClinicaMerced.Front.UC
{
    partial class UC_ConsultaCierreCaja
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
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTab_Cierre = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabProfecionales_Internos = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cierreCajaDiarioBindingSource_Profecionales = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreProfecional = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCoseguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalArancel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTab_Receta = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.cierreCajaDiarioBindingSource_Resetas = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uC_FitroConsultaHorizontal1 = new ClinicaMerced.Front.UC.UC_FitroConsultaHorizontal();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab_Cierre)).BeginInit();
            this.xtraTab_Cierre.SuspendLayout();
            this.xtraTabProfecionales_Internos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cierreCajaDiarioBindingSource_Profecionales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTab_Receta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cierreCajaDiarioBindingSource_Resetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.White;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Size = new System.Drawing.Size(998, 41);
            this.lblTitle.Text = "Consulta de cierre de caja";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseForeColor = true;
            this.btnRefresh.Image = global::ClinicaMerced.Front.Properties.Resources.medical_history_refresh_48;
            this.btnRefresh.Location = new System.Drawing.Point(0, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(224, 48);
            this.btnRefresh.TabIndex = 2053;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // xtraTab_Cierre
            // 
            this.xtraTab_Cierre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTab_Cierre.Location = new System.Drawing.Point(227, 48);
            this.xtraTab_Cierre.Name = "xtraTab_Cierre";
            this.xtraTab_Cierre.SelectedTabPage = this.xtraTabProfecionales_Internos;
            this.xtraTab_Cierre.Size = new System.Drawing.Size(768, 596);
            this.xtraTab_Cierre.TabIndex = 2051;
            this.xtraTab_Cierre.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabProfecionales_Internos,
            this.xtraTab_Receta});
            // 
            // xtraTabProfecionales_Internos
            // 
            this.xtraTabProfecionales_Internos.Controls.Add(this.gridControl1);
            this.xtraTabProfecionales_Internos.Name = "xtraTabProfecionales_Internos";
            this.xtraTabProfecionales_Internos.Size = new System.Drawing.Size(762, 567);
            this.xtraTabProfecionales_Internos.Text = "Profecionales Internos";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.cierreCajaDiarioBindingSource_Profecionales;
            this.gridControl1.Location = new System.Drawing.Point(0, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(759, 550);
            this.gridControl1.TabIndex = 2042;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cierreCajaDiarioBindingSource_Profecionales
            // 
            this.cierreCajaDiarioBindingSource_Profecionales.DataSource = typeof(ClinicaMerced.Common.Entities.CierreCajaDiario);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colNombreProfecional,
            this.colTotalCoseguro,
            this.colTotalArancel});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            // 
            // colNombreProfecional
            // 
            this.colNombreProfecional.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colNombreProfecional.AppearanceHeader.Options.UseFont = true;
            this.colNombreProfecional.FieldName = "NombreProfecional";
            this.colNombreProfecional.Name = "colNombreProfecional";
            this.colNombreProfecional.OptionsColumn.AllowEdit = false;
            this.colNombreProfecional.OptionsColumn.ReadOnly = true;
            this.colNombreProfecional.Visible = true;
            this.colNombreProfecional.VisibleIndex = 1;
            // 
            // colTotalCoseguro
            // 
            this.colTotalCoseguro.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colTotalCoseguro.AppearanceHeader.Options.UseFont = true;
            this.colTotalCoseguro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalCoseguro.FieldName = "TotalCoseguro";
            this.colTotalCoseguro.Name = "colTotalCoseguro";
            this.colTotalCoseguro.OptionsColumn.AllowEdit = false;
            this.colTotalCoseguro.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTotalCoseguro.OptionsColumn.AllowMove = false;
            this.colTotalCoseguro.OptionsColumn.AllowShowHide = false;
            this.colTotalCoseguro.OptionsColumn.AllowSize = false;
            this.colTotalCoseguro.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTotalCoseguro.OptionsColumn.ReadOnly = true;
            this.colTotalCoseguro.Visible = true;
            this.colTotalCoseguro.VisibleIndex = 2;
            // 
            // colTotalArancel
            // 
            this.colTotalArancel.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colTotalArancel.AppearanceHeader.Options.UseFont = true;
            this.colTotalArancel.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalArancel.FieldName = "TotalArancel";
            this.colTotalArancel.Name = "colTotalArancel";
            this.colTotalArancel.OptionsColumn.AllowEdit = false;
            this.colTotalArancel.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTotalArancel.OptionsColumn.AllowMove = false;
            this.colTotalArancel.OptionsColumn.AllowShowHide = false;
            this.colTotalArancel.OptionsColumn.AllowSize = false;
            this.colTotalArancel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTotalArancel.OptionsColumn.ReadOnly = true;
            this.colTotalArancel.Visible = true;
            this.colTotalArancel.VisibleIndex = 3;
            // 
            // xtraTab_Receta
            // 
            this.xtraTab_Receta.Controls.Add(this.gridControl2);
            this.xtraTab_Receta.Name = "xtraTab_Receta";
            this.xtraTab_Receta.Size = new System.Drawing.Size(762, 513);
            this.xtraTab_Receta.Text = "Recetas";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.cierreCajaDiarioBindingSource_Resetas;
            this.gridControl2.Location = new System.Drawing.Point(7, 16);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(752, 364);
            this.gridControl2.TabIndex = 2045;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // cierreCajaDiarioBindingSource_Resetas
            // 
            this.cierreCajaDiarioBindingSource_Resetas.DataSource = typeof(ClinicaMerced.Common.Entities.CierreCajaDiario);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupCount = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView2.OptionsMenu.EnableColumnMenu = false;
            this.gridView2.OptionsMenu.EnableFooterMenu = false;
            this.gridView2.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Fecha";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.FieldName = "TotalCoseguro";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.OptionsColumn.AllowMove = false;
            this.gridColumn3.OptionsColumn.AllowShowHide = false;
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.FieldName = "TotalArancel";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.OptionsColumn.AllowMove = false;
            this.gridColumn4.OptionsColumn.AllowShowHide = false;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // uC_FitroConsultaHorizontal1
            // 
            this.uC_FitroConsultaHorizontal1.AcceptButton = null;
            this.uC_FitroConsultaHorizontal1.CancelButton = null;
            this.uC_FitroConsultaHorizontal1.ComboMonthsEnabled = true;
            this.uC_FitroConsultaHorizontal1.ComboMonthsVisible = true;
            this.uC_FitroConsultaHorizontal1.CombosGroupEnabled = false;
            this.uC_FitroConsultaHorizontal1.CombosGroupVisible = false;
            this.uC_FitroConsultaHorizontal1.Location = new System.Drawing.Point(0, 97);
            this.uC_FitroConsultaHorizontal1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_FitroConsultaHorizontal1.Name = "uC_FitroConsultaHorizontal1";
            this.uC_FitroConsultaHorizontal1.Size = new System.Drawing.Size(224, 542);
            this.uC_FitroConsultaHorizontal1.TabIndex = 2052;
            // 
            // UC_ConsultaCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.xtraTab_Cierre);
            this.Controls.Add(this.uC_FitroConsultaHorizontal1);
            this.Name = "UC_ConsultaCierreCaja";
            this.Size = new System.Drawing.Size(998, 661);
            this.Load += new System.EventHandler(this.UC_ConsultaCierreCaja_Load);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.uC_FitroConsultaHorizontal1, 0);
            this.Controls.SetChildIndex(this.xtraTab_Cierre, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab_Cierre)).EndInit();
            this.xtraTab_Cierre.ResumeLayout(false);
            this.xtraTabProfecionales_Internos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cierreCajaDiarioBindingSource_Profecionales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTab_Receta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cierreCajaDiarioBindingSource_Resetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraTab.XtraTabControl xtraTab_Cierre;
        private DevExpress.XtraTab.XtraTabPage xtraTabProfecionales_Internos;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreProfecional;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCoseguro;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalArancel;
        private DevExpress.XtraTab.XtraTabPage xtraTab_Receta;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private UC_FitroConsultaHorizontal uC_FitroConsultaHorizontal1;
        private System.Windows.Forms.BindingSource cierreCajaDiarioBindingSource_Profecionales;
        private System.Windows.Forms.BindingSource cierreCajaDiarioBindingSource_Resetas;
    }
}
