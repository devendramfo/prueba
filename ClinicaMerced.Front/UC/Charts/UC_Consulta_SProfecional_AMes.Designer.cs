namespace ClinicaMerced.Front
{
    partial class UC_Consulta_SProfecional_AMes
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions2 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.rptconsultasmestipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uC_TipoList1 = new ClinicaMerced.Front.UC_FiltroTipoList();
            this.uC_FitroConsultaHorizontal1 = new ClinicaMerced.Front.UC.UC_FitroConsultaHorizontal();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArancel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCoseguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreTipoConsulta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreProfecional = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreMutual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptconsultasmestipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.White;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Text = "Gráfico de barras informativo";
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.DataSource = this.rptconsultasmestipoBindingSource;
            xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Location = new System.Drawing.Point(244, 38);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteBaseColorNumber = 4;
            this.chartControl1.SeriesDataMember = "NombreProfecional";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Mes";
            pointSeriesLabel2.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = pointSeriesLabel2;
            pointOptions2.PointView = DevExpress.XtraCharts.PointView.SeriesName;
            this.chartControl1.SeriesTemplate.PointOptions = pointOptions2;
            this.chartControl1.SeriesTemplate.ShowInLegend = false;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Coseguro";
            this.chartControl1.SeriesTemplate.View = splineSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(486, 349);
            this.chartControl1.TabIndex = 6;
            // 
            // rptconsultasmestipoBindingSource
            // 
            this.rptconsultasmestipoBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.Repòrts.rpt_consultas_mes_tipo);
            // 
            // uC_TipoList1
            // 
            this.uC_TipoList1.AcceptButton = null;
            this.uC_TipoList1.CancelButton = null;
            this.uC_TipoList1.Location = new System.Drawing.Point(12, 369);
            this.uC_TipoList1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_TipoList1.Name = "uC_TipoList1";
            this.uC_TipoList1.Size = new System.Drawing.Size(216, 202);
            this.uC_TipoList1.TabIndex = 7;
            // 
            // uC_FitroConsultaHorizontal1
            // 
            this.uC_FitroConsultaHorizontal1.AcceptButton = null;
            this.uC_FitroConsultaHorizontal1.CancelButton = null;
            this.uC_FitroConsultaHorizontal1.ComboMonthsEnabled = false;
            this.uC_FitroConsultaHorizontal1.ComboMonthsVisible = false;
            this.uC_FitroConsultaHorizontal1.CombosGroupEnabled = false;
            this.uC_FitroConsultaHorizontal1.CombosGroupVisible = false;
            this.uC_FitroConsultaHorizontal1.Location = new System.Drawing.Point(3, 104);
            this.uC_FitroConsultaHorizontal1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_FitroConsultaHorizontal1.Name = "uC_FitroConsultaHorizontal1";
            this.uC_FitroConsultaHorizontal1.Size = new System.Drawing.Size(235, 463);
            this.uC_FitroConsultaHorizontal1.TabIndex = 8;
            this.uC_FitroConsultaHorizontal1.Load += new System.EventHandler(this.uC_FitroConsultaHorizontal1_Load);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.rptconsultasmestipoBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(226, 415);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(504, 153);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colNumMes,
            this.colArancel,
            this.colCoseguro,
            this.colNombreTipoConsulta,
            this.colNombreProfecional,
            this.colNombreMutual,
            this.colMes});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            // 
            // colNumMes
            // 
            this.colNumMes.FieldName = "NumMes";
            this.colNumMes.Name = "colNumMes";
            this.colNumMes.Visible = true;
            this.colNumMes.VisibleIndex = 1;
            // 
            // colArancel
            // 
            this.colArancel.FieldName = "Arancel";
            this.colArancel.Name = "colArancel";
            this.colArancel.Visible = true;
            this.colArancel.VisibleIndex = 2;
            // 
            // colCoseguro
            // 
            this.colCoseguro.FieldName = "Coseguro";
            this.colCoseguro.Name = "colCoseguro";
            this.colCoseguro.Visible = true;
            this.colCoseguro.VisibleIndex = 3;
            // 
            // colNombreTipoConsulta
            // 
            this.colNombreTipoConsulta.FieldName = "NombreTipoConsulta";
            this.colNombreTipoConsulta.Name = "colNombreTipoConsulta";
            this.colNombreTipoConsulta.Visible = true;
            this.colNombreTipoConsulta.VisibleIndex = 4;
            // 
            // colNombreProfecional
            // 
            this.colNombreProfecional.FieldName = "NombreProfecional";
            this.colNombreProfecional.Name = "colNombreProfecional";
            this.colNombreProfecional.Visible = true;
            this.colNombreProfecional.VisibleIndex = 5;
            // 
            // colNombreMutual
            // 
            this.colNombreMutual.FieldName = "NombreMutual";
            this.colNombreMutual.Name = "colNombreMutual";
            this.colNombreMutual.Visible = true;
            this.colNombreMutual.VisibleIndex = 6;
            // 
            // colMes
            // 
            this.colMes.FieldName = "Mes";
            this.colMes.Name = "colMes";
            this.colMes.OptionsColumn.ReadOnly = true;
            this.colMes.Visible = true;
            this.colMes.VisibleIndex = 7;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseForeColor = true;
            this.btnRefresh.Image = global::ClinicaMerced.Front.Properties.Resources.medical_history_refresh_48;
            this.btnRefresh.Location = new System.Drawing.Point(3, 48);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(235, 46);
            this.btnRefresh.TabIndex = 2054;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UC_Consulta_SProfecional_AMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.uC_TipoList1);
            this.Controls.Add(this.uC_FitroConsultaHorizontal1);
            this.Name = "UC_Consulta_SProfecional_AMes";
            this.Size = new System.Drawing.Size(733, 571);
            this.Controls.SetChildIndex(this.uC_FitroConsultaHorizontal1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.uC_TipoList1, 0);
            this.Controls.SetChildIndex(this.chartControl1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptconsultasmestipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource rptconsultasmestipoBindingSource;
        private UC_FiltroTipoList uC_TipoList1;
        private UC.UC_FitroConsultaHorizontal uC_FitroConsultaHorizontal1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colNumMes;
        private DevExpress.XtraGrid.Columns.GridColumn colArancel;
        private DevExpress.XtraGrid.Columns.GridColumn colCoseguro;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreTipoConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreProfecional;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreMutual;
        private DevExpress.XtraGrid.Columns.GridColumn colMes;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}
