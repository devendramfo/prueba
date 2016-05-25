namespace ClinicaMerced.Front.UC
{

    partial class frm_CierreCaja
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
            this.components = new System.ComponentModel.Container();
            this.dtPickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.xtraTab_Cierre = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabProfecionales_Internos = new DevExpress.XtraTab.XtraTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cierreCajaDiarioBindingSource_Profecionales = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreProfecional = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCoseguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalArancel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTab_Profecional_Externo = new DevExpress.XtraTab.XtraTabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource_Externos = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTab_Receta = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.cierreCajaDiarioBindingSource_Resetas = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.vwConsultaToCierreCajaDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresentaqOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfecionalNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMutualNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreTipoConsulta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCoseguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArancelMutual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.lblMessage = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab_Cierre)).BeginInit();
            this.xtraTab_Cierre.SuspendLayout();
            this.xtraTabProfecionales_Internos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cierreCajaDiarioBindingSource_Profecionales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTab_Profecional_Externo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Externos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTab_Receta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cierreCajaDiarioBindingSource_Resetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwConsultaToCierreCajaDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // aceptCancelButtonBar1
            // 
            this.aceptCancelButtonBar1.AceptButtonVisible = true;
            this.aceptCancelButtonBar1.BottomsVisible = true;
            this.aceptCancelButtonBar1.CancelButtonVisible = true;
            this.aceptCancelButtonBar1.Location = new System.Drawing.Point(7, 516);
            this.aceptCancelButtonBar1.Size = new System.Drawing.Size(912, 42);
            // 
            // dtPickerFechaInicio
            // 
            this.dtPickerFechaInicio.Location = new System.Drawing.Point(111, 13);
            this.dtPickerFechaInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtPickerFechaInicio.Name = "dtPickerFechaInicio";
            this.dtPickerFechaInicio.Size = new System.Drawing.Size(185, 23);
            this.dtPickerFechaInicio.TabIndex = 2039;
            this.dtPickerFechaInicio.ValueChanged += new System.EventHandler(this.dtPickerFechaInicio_ValueChanged);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.lblFechaInicio.Location = new System.Drawing.Point(18, 13);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(60, 20);
            this.lblFechaInicio.TabIndex = 2040;
            this.lblFechaInicio.Text = "Fecha ";
            // 
            // xtraTab_Cierre
            // 
            this.xtraTab_Cierre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTab_Cierre.Location = new System.Drawing.Point(7, 43);
            this.xtraTab_Cierre.Name = "xtraTab_Cierre";
            this.xtraTab_Cierre.SelectedTabPage = this.xtraTabProfecionales_Internos;
            this.xtraTab_Cierre.Size = new System.Drawing.Size(909, 527);
            this.xtraTab_Cierre.TabIndex = 2042;
            this.xtraTab_Cierre.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabProfecionales_Internos,
            this.xtraTab_Profecional_Externo,
            this.xtraTab_Receta});
            // 
            // xtraTabProfecionales_Internos
            // 
            this.xtraTabProfecionales_Internos.Controls.Add(this.label2);
            this.xtraTabProfecionales_Internos.Controls.Add(this.gridControl1);
            this.xtraTabProfecionales_Internos.Name = "xtraTabProfecionales_Internos";
            this.xtraTabProfecionales_Internos.Size = new System.Drawing.Size(903, 498);
            this.xtraTabProfecionales_Internos.Text = "Profecionales Internos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 36);
            this.label2.TabIndex = 2042;
            this.label2.Text = "Profecionales internos";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cierreCajaDiarioBindingSource_Profecionales;
            this.gridControl1.Location = new System.Drawing.Point(3, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(883, 428);
            this.gridControl1.TabIndex = 2041;
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
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colNombreProfecional,
            this.colTotalCoseguro,
            this.colTotalArancel});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFecha, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
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
            this.colNombreProfecional.VisibleIndex = 0;
            // 
            // colTotalCoseguro
            // 
            this.colTotalCoseguro.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colTotalCoseguro.AppearanceHeader.Options.UseFont = true;
            this.colTotalCoseguro.FieldName = "TotalCoseguro";
            this.colTotalCoseguro.Name = "colTotalCoseguro";
            this.colTotalCoseguro.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTotalCoseguro.OptionsColumn.AllowMove = false;
            this.colTotalCoseguro.OptionsColumn.AllowShowHide = false;
            this.colTotalCoseguro.OptionsColumn.AllowSize = false;
            this.colTotalCoseguro.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTotalCoseguro.Visible = true;
            this.colTotalCoseguro.VisibleIndex = 1;
            // 
            // colTotalArancel
            // 
            this.colTotalArancel.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colTotalArancel.AppearanceHeader.Options.UseFont = true;
            this.colTotalArancel.FieldName = "TotalArancel";
            this.colTotalArancel.Name = "colTotalArancel";
            this.colTotalArancel.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTotalArancel.OptionsColumn.AllowMove = false;
            this.colTotalArancel.OptionsColumn.AllowShowHide = false;
            this.colTotalArancel.OptionsColumn.AllowSize = false;
            this.colTotalArancel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTotalArancel.Visible = true;
            this.colTotalArancel.VisibleIndex = 2;
            // 
            // xtraTab_Profecional_Externo
            // 
            this.xtraTab_Profecional_Externo.Controls.Add(this.label3);
            this.xtraTab_Profecional_Externo.Controls.Add(this.gridControl3);
            this.xtraTab_Profecional_Externo.Name = "xtraTab_Profecional_Externo";
            this.xtraTab_Profecional_Externo.Size = new System.Drawing.Size(903, 498);
            this.xtraTab_Profecional_Externo.Text = "Profecionales externos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(5, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 36);
            this.label3.TabIndex = 2045;
            this.label3.Text = "Profecionales Externos";
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.bindingSource_Externos;
            this.gridControl3.Location = new System.Drawing.Point(3, 60);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(886, 424);
            this.gridControl3.TabIndex = 2044;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // bindingSource_Externos
            // 
            this.bindingSource_Externos.DataSource = typeof(ClinicaMerced.Common.Entities.CierreCajaDiario);
            // 
            // gridView3
            // 
            this.gridView3.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView3.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView3.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.GroupCount = 1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView3.OptionsMenu.EnableColumnMenu = false;
            this.gridView3.OptionsMenu.EnableFooterMenu = false;
            this.gridView3.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Fecha";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.FieldName = "NombreProfecional";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.FieldName = "TotalCoseguro";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.OptionsColumn.AllowMove = false;
            this.gridColumn6.OptionsColumn.AllowShowHide = false;
            this.gridColumn6.OptionsColumn.AllowSize = false;
            this.gridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.FieldName = "TotalArancel";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn7.OptionsColumn.AllowMove = false;
            this.gridColumn7.OptionsColumn.AllowShowHide = false;
            this.gridColumn7.OptionsColumn.AllowSize = false;
            this.gridColumn7.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // xtraTab_Receta
            // 
            this.xtraTab_Receta.Controls.Add(this.gridControl2);
            this.xtraTab_Receta.Controls.Add(this.label1);
            this.xtraTab_Receta.Name = "xtraTab_Receta";
            this.xtraTab_Receta.Size = new System.Drawing.Size(903, 498);
            this.xtraTab_Receta.Text = "Recetas";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.cierreCajaDiarioBindingSource_Resetas;
            this.gridControl2.Location = new System.Drawing.Point(3, 60);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(820, 169);
            this.gridControl2.TabIndex = 2043;
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
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
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
            this.gridColumn4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.OptionsColumn.AllowMove = false;
            this.gridColumn4.OptionsColumn.AllowShowHide = false;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 42);
            this.label1.TabIndex = 2041;
            this.label1.Text = "Recetas";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(903, 498);
            this.xtraTabPage1.Text = "Detalles";
            // 
            // gridControl4
            // 
            this.gridControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl4.DataSource = this.vwConsultaToCierreCajaDetailBindingSource;
            this.gridControl4.Location = new System.Drawing.Point(3, 24);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(897, 452);
            this.gridControl4.TabIndex = 2013;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // vwConsultaToCierreCajaDetailBindingSource
            // 
            this.vwConsultaToCierreCajaDetailBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.Caja.vw_ConsultaToCierreCajaDetail);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHora,
            this.colTurno,
            this.colNombreCliente,
            this.colPresentaqOrden,
            this.colProfecionalNombre,
            this.colMutualNombre,
            this.colNombreTipoConsulta,
            this.colCoseguro,
            this.colArancelMutual});
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.GroupCount = 1;
            this.gridView4.Name = "gridView4";
            this.gridView4.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProfecionalNombre, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colHora
            // 
            this.colHora.FieldName = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.OptionsColumn.AllowEdit = false;
            this.colHora.Visible = true;
            this.colHora.VisibleIndex = 0;
            this.colHora.Width = 67;
            // 
            // colTurno
            // 
            this.colTurno.FieldName = "Turno";
            this.colTurno.Name = "colTurno";
            this.colTurno.OptionsColumn.AllowEdit = false;
            this.colTurno.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTurno.Visible = true;
            this.colTurno.VisibleIndex = 1;
            this.colTurno.Width = 70;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.FieldName = "NombreCliente";
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.OptionsColumn.AllowEdit = false;
            this.colNombreCliente.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNombreCliente.Visible = true;
            this.colNombreCliente.VisibleIndex = 2;
            this.colNombreCliente.Width = 139;
            // 
            // colPresentaqOrden
            // 
            this.colPresentaqOrden.Caption = "Presento Orden";
            this.colPresentaqOrden.FieldName = "PresentaOrden";
            this.colPresentaqOrden.Name = "colPresentaqOrden";
            this.colPresentaqOrden.OptionsColumn.AllowEdit = false;
            this.colPresentaqOrden.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPresentaqOrden.Visible = true;
            this.colPresentaqOrden.VisibleIndex = 7;
            this.colPresentaqOrden.Width = 100;
            // 
            // colProfecionalNombre
            // 
            this.colProfecionalNombre.Caption = "Profecional";
            this.colProfecionalNombre.FieldName = "NombreProfecional";
            this.colProfecionalNombre.Name = "colProfecionalNombre";
            this.colProfecionalNombre.OptionsColumn.AllowEdit = false;
            this.colProfecionalNombre.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colProfecionalNombre.Visible = true;
            this.colProfecionalNombre.VisibleIndex = 2;
            this.colProfecionalNombre.Width = 139;
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
            this.colMutualNombre.Width = 127;
            // 
            // colNombreTipoConsulta
            // 
            this.colNombreTipoConsulta.FieldName = "NombreTipoConsulta";
            this.colNombreTipoConsulta.Name = "colNombreTipoConsulta";
            this.colNombreTipoConsulta.Visible = true;
            this.colNombreTipoConsulta.VisibleIndex = 3;
            this.colNombreTipoConsulta.Width = 123;
            // 
            // colCoseguro
            // 
            this.colCoseguro.FieldName = "Coseguro";
            this.colCoseguro.Name = "colCoseguro";
            this.colCoseguro.Visible = true;
            this.colCoseguro.VisibleIndex = 4;
            this.colCoseguro.Width = 57;
            // 
            // colArancelMutual
            // 
            this.colArancelMutual.FieldName = "ArancelMutual";
            this.colArancelMutual.Name = "colArancelMutual";
            this.colArancelMutual.Visible = true;
            this.colArancelMutual.VisibleIndex = 5;
            this.colArancelMutual.Width = 57;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Image = global::ClinicaMerced.Front.Properties.Resources.export_32;
            this.simpleButton2.Location = new System.Drawing.Point(664, 8);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(182, 35);
            this.simpleButton2.TabIndex = 2043;
            this.simpleButton2.Text = "Realizar cierre";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(302, 18);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(165, 16);
            this.lblMessage.TabIndex = 2044;
            this.lblMessage.Text = "---------------------------------";
            // 
            // frm_CierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 567);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.xtraTab_Cierre);
            this.Controls.Add(this.dtPickerFechaInicio);
            this.Controls.Add(this.lblFechaInicio);
            this.LookAndFeel.SkinName = "Black";
            this.MinimumSize = new System.Drawing.Size(938, 599);
            this.Name = "frm_CierreCaja";
            this.Text = "Cierre de caja diario";
            this.Load += new System.EventHandler(this.frm_CierreCaja_Load);
            this.Controls.SetChildIndex(this.aceptCancelButtonBar1, 0);
            this.Controls.SetChildIndex(this.lblFechaInicio, 0);
            this.Controls.SetChildIndex(this.dtPickerFechaInicio, 0);
            this.Controls.SetChildIndex(this.xtraTab_Cierre, 0);
            this.Controls.SetChildIndex(this.simpleButton2, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab_Cierre)).EndInit();
            this.xtraTab_Cierre.ResumeLayout(false);
            this.xtraTabProfecionales_Internos.ResumeLayout(false);
            this.xtraTabProfecionales_Internos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cierreCajaDiarioBindingSource_Profecionales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTab_Profecional_Externo.ResumeLayout(false);
            this.xtraTab_Profecional_Externo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Externos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTab_Receta.ResumeLayout(false);
            this.xtraTab_Receta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cierreCajaDiarioBindingSource_Resetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwConsultaToCierreCajaDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPickerFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private DevExpress.XtraTab.XtraTabControl xtraTab_Cierre;
        private DevExpress.XtraTab.XtraTabPage xtraTab_Receta;
        private DevExpress.XtraTab.XtraTabPage xtraTabProfecionales_Internos;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource cierreCajaDiarioBindingSource_Profecionales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreProfecional;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCoseguro;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalArancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cierreCajaDiarioBindingSource_Resetas;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraTab.XtraTabPage xtraTab_Profecional_Externo;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.BindingSource bindingSource_Externos;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colHora;
        private DevExpress.XtraGrid.Columns.GridColumn colTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colPresentaqOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colProfecionalNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colMutualNombre;
        private System.Windows.Forms.BindingSource vwConsultaToCierreCajaDetailBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreTipoConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn colCoseguro;
        private DevExpress.XtraGrid.Columns.GridColumn colArancelMutual;
        private DevExpress.XtraEditors.LabelControl lblMessage;
    }
}