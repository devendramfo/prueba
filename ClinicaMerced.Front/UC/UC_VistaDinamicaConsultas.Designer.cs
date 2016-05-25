namespace ClinicaMerced.Front.UC
{
    partial class UC_VistaDinamicaConsultas
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
            this.uC_FitroConsultaHorizontal1 = new ClinicaMerced.Front.UC.UC_FitroConsultaHorizontal();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.rptConsultaFullBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldFecha1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPresentaOrden1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCoseguro1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExigeCoseguro1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldArancelMutual1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTipoConsulta1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProfecional1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMutual = new DevExpress.XtraPivotGrid.PivotGridField();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptConsultaFullBEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.White;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Size = new System.Drawing.Size(1030, 41);
            this.lblTitle.Text = "Vista pivot de cosultas";
            // 
            // uC_FitroConsultaHorizontal1
            // 
            this.uC_FitroConsultaHorizontal1.AcceptButton = null;
            this.uC_FitroConsultaHorizontal1.CancelButton = null;
            this.uC_FitroConsultaHorizontal1.ComboMonthsEnabled = true;
            this.uC_FitroConsultaHorizontal1.ComboMonthsVisible = true;
            this.uC_FitroConsultaHorizontal1.CombosGroupEnabled = true;
            this.uC_FitroConsultaHorizontal1.CombosGroupVisible = true;
            this.uC_FitroConsultaHorizontal1.Location = new System.Drawing.Point(3, 49);
            this.uC_FitroConsultaHorizontal1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_FitroConsultaHorizontal1.Name = "uC_FitroConsultaHorizontal1";
            this.uC_FitroConsultaHorizontal1.Size = new System.Drawing.Size(226, 610);
            this.uC_FitroConsultaHorizontal1.TabIndex = 2047;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.DataSource = this.rptConsultaFullBEBindingSource;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldFecha1,
            this.fieldPresentaOrden1,
            this.fieldCoseguro1,
            this.fieldExigeCoseguro1,
            this.fieldArancelMutual1,
            this.fieldTipoConsulta1,
            this.fieldProfecional1,
            this.fieldMutual});
            this.pivotGridControl1.Location = new System.Drawing.Point(245, 104);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(782, 624);
            this.pivotGridControl1.TabIndex = 2048;
            // 
            // rptConsultaFullBEBindingSource
            // 
            this.rptConsultaFullBEBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.Rpt_Consulta_FullBE);
            // 
            // fieldFecha1
            // 
            this.fieldFecha1.AreaIndex = 3;
            this.fieldFecha1.Caption = "Fecha";
            this.fieldFecha1.FieldName = "Fecha";
            this.fieldFecha1.Name = "fieldFecha1";
            // 
            // fieldPresentaOrden1
            // 
            this.fieldPresentaOrden1.AreaIndex = 0;
            this.fieldPresentaOrden1.Caption = "Presenta Orden";
            this.fieldPresentaOrden1.FieldName = "PresentaOrden";
            this.fieldPresentaOrden1.Name = "fieldPresentaOrden1";
            // 
            // fieldCoseguro1
            // 
            this.fieldCoseguro1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCoseguro1.AreaIndex = 0;
            this.fieldCoseguro1.Caption = "Coseguro";
            this.fieldCoseguro1.FieldName = "Coseguro";
            this.fieldCoseguro1.Name = "fieldCoseguro1";
            // 
            // fieldExigeCoseguro1
            // 
            this.fieldExigeCoseguro1.AreaIndex = 2;
            this.fieldExigeCoseguro1.Caption = "Exige Coseguro";
            this.fieldExigeCoseguro1.FieldName = "ExigeCoseguro";
            this.fieldExigeCoseguro1.Name = "fieldExigeCoseguro1";
            // 
            // fieldArancelMutual1
            // 
            this.fieldArancelMutual1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldArancelMutual1.AreaIndex = 1;
            this.fieldArancelMutual1.Caption = "Arancel Mutual";
            this.fieldArancelMutual1.FieldName = "ArancelMutual";
            this.fieldArancelMutual1.Name = "fieldArancelMutual1";
            // 
            // fieldTipoConsulta1
            // 
            this.fieldTipoConsulta1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldTipoConsulta1.AreaIndex = 1;
            this.fieldTipoConsulta1.Caption = "Tipo Consulta";
            this.fieldTipoConsulta1.FieldName = "TipoConsulta";
            this.fieldTipoConsulta1.Name = "fieldTipoConsulta1";
            // 
            // fieldProfecional1
            // 
            this.fieldProfecional1.AreaIndex = 1;
            this.fieldProfecional1.Caption = "Nombre Profecional";
            this.fieldProfecional1.FieldName = "Profecional";
            this.fieldProfecional1.Name = "fieldProfecional1";
            // 
            // fieldMutual
            // 
            this.fieldMutual.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMutual.AreaIndex = 0;
            this.fieldMutual.Caption = "Mutual";
            this.fieldMutual.FieldName = "Mutual";
            this.fieldMutual.Name = "fieldMutual";
            this.fieldMutual.Width = 161;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseForeColor = true;
            this.btnRefresh.Image = global::ClinicaMerced.Front.Properties.Resources.medical_history_refresh_48;
            this.btnRefresh.Location = new System.Drawing.Point(245, 44);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(174, 55);
            this.btnRefresh.TabIndex = 2049;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UC_VistaDinamicaConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.uC_FitroConsultaHorizontal1);
            this.Name = "UC_VistaDinamicaConsultas";
            this.Size = new System.Drawing.Size(1030, 733);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.uC_FitroConsultaHorizontal1, 0);
            this.Controls.SetChildIndex(this.pivotGridControl1, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptConsultaFullBEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC_FitroConsultaHorizontal uC_FitroConsultaHorizontal1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource rptConsultaFullBEBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFecha1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPresentaOrden1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCoseguro1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExigeCoseguro1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldArancelMutual1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTipoConsulta1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProfecional1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMutual;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}
