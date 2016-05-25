namespace ClinicaMerced.Front
{
    partial class UC_Consulta
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.profecionalListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mutualListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNroAfiliado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.chkPresentaOrden = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
     
            this.mutualBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnFindPatints = new DevExpress.XtraEditors.SimpleButton();
            this.paramComercialBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTipoConsulta = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbProfecionales = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCoseguro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtArancelMutual = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.profecionalListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroAfiliado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPresentaOrden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
 
            ((System.ComponentModel.ISupportInitialize)(this.mutualBEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paramComercialBEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoConsulta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProfecionales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoseguro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArancelMutual.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.White;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.LineVisible = true;
            this.lblTitle.Text = "            Nueva consulta en recepcion";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Location = new System.Drawing.Point(7, 94);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 18);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Profecional";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl2.Location = new System.Drawing.Point(16, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 18);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Mutual";
            // 
            // profecionalListBindingSource
            // 
            this.profecionalListBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.ProfecionalList);
            // 
            // mutualListBindingSource
            // 
            this.mutualListBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.MutualList);
            // 
            // txtCliente
            // 
            this.txtCliente.EditValue = "";
            this.txtCliente.Location = new System.Drawing.Point(146, 42);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCliente.Size = new System.Drawing.Size(275, 22);
            this.txtCliente.TabIndex = 3;
            this.txtCliente.ToolTipController = this.toolTipController1;
            this.txtCliente.ToolTipTitle = "Ingrese aqui el nombre del pasiente o persona ";
            this.txtCliente.Enter += new System.EventHandler(this.txt_Enter);
            this.txtCliente.Leave += new System.EventHandler(this.txt_Leave);
            this.txtCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtCliente_Validating);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl3.Location = new System.Drawing.Point(24, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(114, 18);
            this.labelControl3.TabIndex = 2014;
            this.labelControl3.Text = "Nombre cliente";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl4.Location = new System.Drawing.Point(14, 79);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 18);
            this.labelControl4.TabIndex = 2015;
            this.labelControl4.Text = "Nro Afiliado";
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Location = new System.Drawing.Point(136, 78);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(239, 22);
            this.txtNroAfiliado.TabIndex = 5;
            this.txtNroAfiliado.Enter += new System.EventHandler(this.txt_Enter);
            this.txtNroAfiliado.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl5.Location = new System.Drawing.Point(24, 71);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 18);
            this.labelControl5.TabIndex = 2017;
            this.labelControl5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(146, 70);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.EditFormat.FormatString = "(99999)(9999999999)";
            this.txtTelefono.Properties.Mask.BeepOnError = true;
            this.txtTelefono.Size = new System.Drawing.Size(275, 22);
            this.txtTelefono.TabIndex = 11;
            this.txtTelefono.Enter += new System.EventHandler(this.txt_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl6.Location = new System.Drawing.Point(13, 380);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(94, 18);
            this.labelControl6.TabIndex = 2019;
            this.labelControl6.Text = "Observacion";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(12, 406);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(718, 108);
            this.txtObservacion.TabIndex = 6;
            this.txtObservacion.Enter += new System.EventHandler(this.txt_Enter);
            this.txtObservacion.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // chkPresentaOrden
            // 
            this.chkPresentaOrden.Location = new System.Drawing.Point(396, 36);
            this.chkPresentaOrden.Name = "chkPresentaOrden";
            this.chkPresentaOrden.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chkPresentaOrden.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.chkPresentaOrden.Properties.Appearance.Options.UseFont = true;
            this.chkPresentaOrden.Properties.Appearance.Options.UseForeColor = true;
            this.chkPresentaOrden.Properties.Caption = "Presenta orden";
            this.chkPresentaOrden.Size = new System.Drawing.Size(179, 23);
            this.chkPresentaOrden.TabIndex = 2024;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.chkPresentaOrden);
            
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtNroAfiliado);
            this.groupControl1.Location = new System.Drawing.Point(27, 111);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(632, 105);
            this.groupControl1.TabIndex = 2025;
            this.groupControl1.Text = "Obra social";
         
            // mutualBEBindingSource
            // 
            this.mutualBEBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.MutualBE);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnFindPatints);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtTelefono);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtCliente);
            this.groupControl2.Controls.Add(this.groupControl1);
            this.groupControl2.Location = new System.Drawing.Point(3, 141);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(718, 232);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Cliente";
            // 
            // btnFindPatints
            // 
            this.btnFindPatints.Location = new System.Drawing.Point(425, 43);
            this.btnFindPatints.Name = "btnFindPatints";
            this.btnFindPatints.Size = new System.Drawing.Size(75, 23);
            this.btnFindPatints.TabIndex = 2026;
            this.btnFindPatints.Text = "...";
            this.btnFindPatints.Click += new System.EventHandler(this.btnFindPatints_Click);
            // 
            // paramComercialBEBindingSource
            // 
            this.paramComercialBEBindingSource.DataSource = typeof(ClinicaMerced.Common.Entities.ParamComercialBE);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl7.Location = new System.Drawing.Point(7, 59);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(101, 18);
            this.labelControl7.TabIndex = 2027;
            this.labelControl7.Text = "Tipo Consulta";
            // 
            // cmbTipoConsulta
            // 
            this.cmbTipoConsulta.Location = new System.Drawing.Point(149, 58);
            this.cmbTipoConsulta.Name = "cmbTipoConsulta";
            this.cmbTipoConsulta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoConsulta.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbTipoConsulta.Properties.DataSource = this.paramComercialBEBindingSource;
            this.cmbTipoConsulta.Properties.DisplayMember = "Nombre";
            this.cmbTipoConsulta.Properties.ValueMember = "IdParamComercial";
            this.cmbTipoConsulta.Size = new System.Drawing.Size(239, 22);
            this.cmbTipoConsulta.TabIndex = 0;
            this.cmbTipoConsulta.EditValueChanged += new System.EventHandler(this.cmbTipoConsulta_EditValueChanged);
            this.cmbTipoConsulta.Enter += new System.EventHandler(this.txt_Enter);
            this.cmbTipoConsulta.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // cmbProfecionales
            // 
            this.cmbProfecionales.Location = new System.Drawing.Point(149, 93);
            this.cmbProfecionales.Name = "cmbProfecionales";
            this.cmbProfecionales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProfecionales.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Apellido", "Apellido", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbProfecionales.Properties.DataSource = this.profecionalListBindingSource;
            this.cmbProfecionales.Properties.DisplayMember = "Nombre";
            this.cmbProfecionales.Properties.ValueMember = "IdProfecional";
            this.cmbProfecionales.Size = new System.Drawing.Size(239, 22);
            this.cmbProfecionales.TabIndex = 1;
            this.cmbProfecionales.Enter += new System.EventHandler(this.txt_Enter);
            this.cmbProfecionales.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtCoseguro
            // 
            this.txtCoseguro.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCoseguro.Location = new System.Drawing.Point(112, 526);
            this.txtCoseguro.Name = "txtCoseguro";
            this.txtCoseguro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtCoseguro.Properties.Appearance.Options.UseFont = true;
            this.txtCoseguro.Properties.Mask.EditMask = "c";
            this.txtCoseguro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCoseguro.Size = new System.Drawing.Size(106, 31);
            this.txtCoseguro.TabIndex = 2028;
            this.txtCoseguro.Enter += new System.EventHandler(this.txt_Enter);
            this.txtCoseguro.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.labelControl8.Location = new System.Drawing.Point(20, 534);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(76, 18);
            this.labelControl8.TabIndex = 2029;
            this.labelControl8.Text = "Co-seguro";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::ClinicaMerced.Front.Properties.Resources.medical_history_add_48;
            this.pictureEdit1.Location = new System.Drawing.Point(7, 4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(49, 38);
            this.pictureEdit1.TabIndex = 2031;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.labelControl9.Location = new System.Drawing.Point(248, 534);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(112, 18);
            this.labelControl9.TabIndex = 2033;
            this.labelControl9.Text = "Arancel Mutual";
            // 
            // txtArancelMutual
            // 
            this.txtArancelMutual.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtArancelMutual.Location = new System.Drawing.Point(366, 526);
            this.txtArancelMutual.Name = "txtArancelMutual";
            this.txtArancelMutual.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtArancelMutual.Properties.Appearance.Options.UseFont = true;
            this.txtArancelMutual.Properties.Mask.EditMask = "c";
            this.txtArancelMutual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtArancelMutual.Size = new System.Drawing.Size(106, 31);
            this.txtArancelMutual.TabIndex = 2032;
            // 
            // UC_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtArancelMutual);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtCoseguro);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cmbTipoConsulta);
            this.Controls.Add(this.cmbProfecionales);
            this.Name = "UC_Consulta";
            this.Size = new System.Drawing.Size(733, 575);
            this.Load += new System.EventHandler(this.UC_Consulta_Load);
            this.Controls.SetChildIndex(this.cmbProfecionales, 0);
            this.Controls.SetChildIndex(this.cmbTipoConsulta, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.txtObservacion, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.txtCoseguro, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            this.Controls.SetChildIndex(this.pictureEdit1, 0);
            this.Controls.SetChildIndex(this.txtArancelMutual, 0);
            this.Controls.SetChildIndex(this.labelControl9, 0);
            ((System.ComponentModel.ISupportInitialize)(this.profecionalListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroAfiliado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPresentaOrden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            
            ((System.ComponentModel.ISupportInitialize)(this.mutualBEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paramComercialBEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoConsulta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProfecionales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoseguro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArancelMutual.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource profecionalListBindingSource;
        private System.Windows.Forms.BindingSource mutualListBindingSource;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNroAfiliado;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txtObservacion;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.CheckEdit chkPresentaOrden;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource paramComercialBEBindingSource;

        private DevExpress.XtraEditors.LookUpEdit cmbTipoConsulta;
        private DevExpress.XtraEditors.LookUpEdit cmbProfecionales;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtCoseguro;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtArancelMutual;
        private System.Windows.Forms.BindingSource mutualBEBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnFindPatints;
    }
}
