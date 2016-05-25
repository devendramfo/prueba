namespace ClinicaMerced.Front.UC
{
    partial class frm_Crear
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
            this.UC_Consulta1 = new ClinicaMerced.Front.UC_Consulta();
            this.btnAcept = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // aceptCancelButtonBar1
            // 
            this.aceptCancelButtonBar1.AceptButtonVisible = true;
            this.aceptCancelButtonBar1.BottomsVisible = true;
            this.aceptCancelButtonBar1.CancelButtonVisible = true;
            this.aceptCancelButtonBar1.Location = new System.Drawing.Point(6, 598);
            this.aceptCancelButtonBar1.Size = new System.Drawing.Size(786, 42);
            // 
            // UC_Consulta1
            // 
            this.UC_Consulta1.AcceptButton = null;
            this.UC_Consulta1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_Consulta1.CancelButton = null;
            this.UC_Consulta1.Location = new System.Drawing.Point(9, 13);
            this.UC_Consulta1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UC_Consulta1.Name = "UC_Consulta1";
            this.UC_Consulta1.Size = new System.Drawing.Size(783, 576);
            this.UC_Consulta1.TabIndex = 1;
            // 
            // btnAcept
            // 
            this.btnAcept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAcept.Image = global::ClinicaMerced.Front.Properties.Resources.confirm_16;
            this.btnAcept.Location = new System.Drawing.Point(488, 598);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(110, 33);
            this.btnAcept.TabIndex = 2;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Image = global::ClinicaMerced.Front.Properties.Resources.cancel_16;
            this.btnCancel.Location = new System.Drawing.Point(631, 596);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frm_Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 649);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.UC_Consulta1);
            this.LookAndFeel.SkinName = "Black";
            this.MaximumSize = new System.Drawing.Size(816, 694);
            this.MinimumSize = new System.Drawing.Size(816, 694);
            this.Name = "frm_Crear";
            this.Padding = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Text = "Recepción";
            this.Controls.SetChildIndex(this.aceptCancelButtonBar1, 0);
            this.Controls.SetChildIndex(this.UC_Consulta1, 0);
            this.Controls.SetChildIndex(this.btnAcept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Consulta UC_Consulta1;
        private DevExpress.XtraEditors.SimpleButton btnAcept;
        private DevExpress.XtraEditors.SimpleButton btnCancel;

    }
}