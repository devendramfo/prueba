namespace ClinicaMerced.Front.UC
{
    partial class UC_FitroConsultaHorizontal
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
            this.cmb_Mutual = new DevExpress.XtraEditors.LookUpEdit();
            this.mutualBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rndRangoFechas = new System.Windows.Forms.RadioButton();
            this.rndPorMes = new System.Windows.Forms.RadioButton();
            this.cmbMonths = new DevExpress.XtraEditors.LookUpEdit();
            this.grpFechas = new DevExpress.XtraEditors.GroupControl();
            this.btnHoy = new DevExpress.XtraEditors.SimpleButton();
            this.dtPickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtPickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTipoConsulta = new DevExpress.XtraEditors.LookUpEdit();
            this.paramComercialBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbProfecionales = new DevExpress.XtraEditors.LookUpEdit();
            this.profecionalListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grpCombos = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mutual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualBEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonths.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpFechas)).BeginInit();
            this.grpFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoConsulta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramComercialBEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProfecionales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profecionalListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCombos)).BeginInit();
            this.grpCombos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.White;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Size = new System.Drawing.Size(285, 41);
            this.lblTitle.Text = "Filtros";
            // 
            // cmb_Mutual
            // 
            this.cmb_Mutual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Mutual.Location = new System.Drawing.Point(9, 160);
            this.cmb_Mutual.Name = "cmb_Mutual";
            this.cmb_Mutual.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Mutual.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Apellido", "Apellido", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cmb_Mutual.Properties.DataSource = this.mutualBEBindingSource;
            this.cmb_Mutual.Properties.DisplayMember = "Nombre";
            this.cmb_Mutual.Properties.ValueMember = "IdMutual";
            this.cmb_Mutual.Size = new System.Drawing.Size(229, 22);
            this.cmb_Mutual.TabIndex = 2053;
            this.cmb_Mutual.EditValueChanged += new System.EventHandler(this.cmbTipoConsulta_EditValueChanged);
            // 
            // mutualBEBindingSource
            // 
            this.mutualBEBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.MutualBE);
            // 
            // rndRangoFechas
            // 
            this.rndRangoFechas.AutoSize = true;
            this.rndRangoFechas.ForeColor = System.Drawing.Color.DimGray;
            this.rndRangoFechas.Location = new System.Drawing.Point(3, 123);
            this.rndRangoFechas.Name = "rndRangoFechas";
            this.rndRangoFechas.Size = new System.Drawing.Size(189, 21);
            this.rndRangoFechas.TabIndex = 2052;
            this.rndRangoFechas.Text = "Filtrar por rango de fechas";
            this.rndRangoFechas.UseVisualStyleBackColor = true;
            // 
            // rndPorMes
            // 
            this.rndPorMes.AutoSize = true;
            this.rndPorMes.Checked = true;
            this.rndPorMes.ForeColor = System.Drawing.Color.DimGray;
            this.rndPorMes.Location = new System.Drawing.Point(8, 48);
            this.rndPorMes.Name = "rndPorMes";
            this.rndPorMes.Size = new System.Drawing.Size(116, 21);
            this.rndPorMes.TabIndex = 2051;
            this.rndPorMes.TabStop = true;
            this.rndPorMes.Text = "Filtrar por mes";
            this.rndPorMes.UseVisualStyleBackColor = true;
            this.rndPorMes.CheckedChanged += new System.EventHandler(this.rndPorMes_CheckedChanged);
            // 
            // cmbMonths
            // 
            this.cmbMonths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMonths.Location = new System.Drawing.Point(3, 75);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMonths.Properties.NullText = "";
            this.cmbMonths.Properties.ShowHeader = false;
            this.cmbMonths.Size = new System.Drawing.Size(229, 22);
            this.cmbMonths.TabIndex = 2050;
            this.cmbMonths.EditValueChanged += new System.EventHandler(this.cmbMonths_EditValueChanged);
            // 
            // grpFechas
            // 
            this.grpFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFechas.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grpFechas.Controls.Add(this.btnHoy);
            this.grpFechas.Controls.Add(this.dtPickerFechaInicio);
            this.grpFechas.Controls.Add(this.lblFechaInicio);
            this.grpFechas.Controls.Add(this.dtPickerFechaFin);
            this.grpFechas.Controls.Add(this.lblFechaFin);
            this.grpFechas.Location = new System.Drawing.Point(-2, 150);
            this.grpFechas.Name = "grpFechas";
            this.grpFechas.ShowCaption = false;
            this.grpFechas.Size = new System.Drawing.Size(277, 147);
            this.grpFechas.TabIndex = 2049;
            // 
            // btnHoy
            // 
            this.btnHoy.Location = new System.Drawing.Point(12, 118);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(75, 23);
            this.btnHoy.TabIndex = 2036;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.ToolTip = "Establece el calendario al dia actual";
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // dtPickerFechaInicio
            // 
            this.dtPickerFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPickerFechaInicio.Location = new System.Drawing.Point(9, 35);
            this.dtPickerFechaInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtPickerFechaInicio.Name = "dtPickerFechaInicio";
            this.dtPickerFechaInicio.Size = new System.Drawing.Size(243, 23);
            this.dtPickerFechaInicio.TabIndex = 2032;
            this.dtPickerFechaInicio.ValueChanged += new System.EventHandler(this.dtPickerFechaInicio_ValueChanged);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.lblFechaInicio.Location = new System.Drawing.Point(4, 11);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(99, 20);
            this.lblFechaInicio.TabIndex = 2035;
            this.lblFechaInicio.Text = "Fecha inicio";
            // 
            // dtPickerFechaFin
            // 
            this.dtPickerFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPickerFechaFin.Location = new System.Drawing.Point(10, 89);
            this.dtPickerFechaFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtPickerFechaFin.Name = "dtPickerFechaFin";
            this.dtPickerFechaFin.Size = new System.Drawing.Size(242, 23);
            this.dtPickerFechaFin.TabIndex = 2033;
            this.dtPickerFechaFin.ValueChanged += new System.EventHandler(this.dtPickerFechaFin_ValueChanged);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.Black;
            this.lblFechaFin.Location = new System.Drawing.Point(4, 65);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(78, 20);
            this.lblFechaFin.TabIndex = 2034;
            this.lblFechaFin.Text = "Fecha fin";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Location = new System.Drawing.Point(9, 77);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 18);
            this.labelControl1.TabIndex = 2047;
            this.labelControl1.Text = "Profecional";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl7.Location = new System.Drawing.Point(9, 25);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(101, 18);
            this.labelControl7.TabIndex = 2048;
            this.labelControl7.Text = "Tipo Consulta";
            // 
            // cmbTipoConsulta
            // 
            this.cmbTipoConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoConsulta.Location = new System.Drawing.Point(9, 49);
            this.cmbTipoConsulta.Name = "cmbTipoConsulta";
            this.cmbTipoConsulta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoConsulta.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbTipoConsulta.Properties.DataSource = this.paramComercialBEBindingSource;
            this.cmbTipoConsulta.Properties.DisplayMember = "Nombre";
            this.cmbTipoConsulta.Properties.ValueMember = "IdParamComercial";
            this.cmbTipoConsulta.Size = new System.Drawing.Size(229, 22);
            this.cmbTipoConsulta.TabIndex = 2045;
            this.cmbTipoConsulta.EditValueChanged += new System.EventHandler(this.cmbTipoConsulta_EditValueChanged);
            // 
            // paramComercialBEBindingSource
            // 
            this.paramComercialBEBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.ParamComercialBE);
            // 
            // cmbProfecionales
            // 
            this.cmbProfecionales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProfecionales.Location = new System.Drawing.Point(9, 101);
            this.cmbProfecionales.Name = "cmbProfecionales";
            this.cmbProfecionales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProfecionales.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Apellido", "Apellido", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbProfecionales.Properties.DataSource = this.profecionalListBindingSource;
            this.cmbProfecionales.Properties.DisplayMember = "Nombre";
            this.cmbProfecionales.Properties.ValueMember = "IdProfecional";
            this.cmbProfecionales.Size = new System.Drawing.Size(229, 22);
            this.cmbProfecionales.TabIndex = 2046;
            this.cmbProfecionales.EditValueChanged += new System.EventHandler(this.cmbTipoConsulta_EditValueChanged);
            // 
            // profecionalListBindingSource
            // 
            this.profecionalListBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.ProfecionalList);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl2.Location = new System.Drawing.Point(9, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 18);
            this.labelControl2.TabIndex = 2054;
            this.labelControl2.Text = "Mutual";
            // 
            // grpCombos
            // 
            this.grpCombos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCombos.Controls.Add(this.cmbProfecionales);
            this.grpCombos.Controls.Add(this.cmbTipoConsulta);
            this.grpCombos.Controls.Add(this.labelControl7);
            this.grpCombos.Controls.Add(this.labelControl2);
            this.grpCombos.Controls.Add(this.labelControl1);
            this.grpCombos.Controls.Add(this.cmb_Mutual);
            this.grpCombos.Location = new System.Drawing.Point(8, 303);
            this.grpCombos.Name = "grpCombos";
            this.grpCombos.Size = new System.Drawing.Size(264, 200);
            this.grpCombos.TabIndex = 2055;
            // 
            // UC_FitroConsultaHorizontal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbMonths);
            this.Controls.Add(this.rndRangoFechas);
            this.Controls.Add(this.grpCombos);
            this.Controls.Add(this.rndPorMes);
            this.Controls.Add(this.grpFechas);
            this.Name = "UC_FitroConsultaHorizontal";
            this.Size = new System.Drawing.Size(285, 610);
            this.Load += new System.EventHandler(this.UC_FitroConsultaHorizontal_Load);
            this.Controls.SetChildIndex(this.grpFechas, 0);
            this.Controls.SetChildIndex(this.rndPorMes, 0);
            this.Controls.SetChildIndex(this.grpCombos, 0);
            this.Controls.SetChildIndex(this.rndRangoFechas, 0);
            this.Controls.SetChildIndex(this.cmbMonths, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mutual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualBEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonths.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpFechas)).EndInit();
            this.grpFechas.ResumeLayout(false);
            this.grpFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoConsulta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramComercialBEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProfecionales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profecionalListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCombos)).EndInit();
            this.grpCombos.ResumeLayout(false);
            this.grpCombos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cmb_Mutual;
        private System.Windows.Forms.RadioButton rndRangoFechas;
        private System.Windows.Forms.RadioButton rndPorMes;
        private DevExpress.XtraEditors.LookUpEdit cmbMonths;
        private DevExpress.XtraEditors.GroupControl grpFechas;
        private System.Windows.Forms.DateTimePicker dtPickerFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtPickerFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit cmbTipoConsulta;
        private DevExpress.XtraEditors.LookUpEdit cmbProfecionales;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource mutualBEBindingSource;
        private System.Windows.Forms.BindingSource paramComercialBEBindingSource;
        private System.Windows.Forms.BindingSource profecionalListBindingSource;
        private DevExpress.XtraEditors.GroupControl grpCombos;
        private DevExpress.XtraEditors.SimpleButton btnHoy;
    }
}
