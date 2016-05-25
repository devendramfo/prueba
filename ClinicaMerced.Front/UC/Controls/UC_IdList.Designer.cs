namespace ClinicaMerced.Front
{
    partial class UC_FiltroTipoList
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
            this.chkListSectorGastoGasto = new System.Windows.Forms.CheckedListBox();
            this.chkAll = new DevExpress.XtraEditors.CheckEdit();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chkAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.White;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Size = new System.Drawing.Size(186, 41);
            this.lblTitle.Visible = false;
            // 
            // chkListSectorGastoGasto
            // 
            this.chkListSectorGastoGasto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkListSectorGastoGasto.CheckOnClick = true;
            this.chkListSectorGastoGasto.FormattingEnabled = true;
            this.chkListSectorGastoGasto.Location = new System.Drawing.Point(3, 27);
            this.chkListSectorGastoGasto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkListSectorGastoGasto.Name = "chkListSectorGastoGasto";
            this.chkListSectorGastoGasto.Size = new System.Drawing.Size(177, 310);
            this.chkListSectorGastoGasto.TabIndex = 6;
            // 
            // chkAll
            // 
            this.chkAll.EditValue = true;
            this.chkAll.Location = new System.Drawing.Point(-2, -2);
            this.chkAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAll.Name = "chkAll";
            this.chkAll.Properties.Caption = "Seleccionar todos";
            this.chkAll.Size = new System.Drawing.Size(188, 21);
            this.chkAll.TabIndex = 25;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // UC_FiltroTipoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.chkListSectorGastoGasto);
            this.Name = "UC_FiltroTipoList";
            this.Size = new System.Drawing.Size(186, 341);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.chkListSectorGastoGasto, 0);
            this.Controls.SetChildIndex(this.chkAll, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chkAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckedListBox chkListSectorGastoGasto;
        private DevExpress.XtraEditors.CheckEdit chkAll;
        private System.Windows.Forms.BindingSource tipoBindingSource;
    }
}
