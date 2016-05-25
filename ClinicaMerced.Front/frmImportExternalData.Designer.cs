namespace ClinicaMerced.Front
{
    partial class frmImportExternalData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportExternalData));
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.img_info = new System.Windows.Forms.PictureBox();
            this.txtTExt = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTExt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // aceptCancelButtonBar1
            // 
            this.aceptCancelButtonBar1.AceptButtonVisible = true;
            this.aceptCancelButtonBar1.BottomsVisible = true;
            this.aceptCancelButtonBar1.CancelButtonVisible = true;
            this.aceptCancelButtonBar1.Location = new System.Drawing.Point(6, 241);
            this.aceptCancelButtonBar1.Size = new System.Drawing.Size(614, 42);
            // 
            // btnImport
            // 
            this.btnImport.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.Image = global::ClinicaMerced.Front.Properties.Resources.db5;
            this.btnImport.Location = new System.Drawing.Point(93, 55);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(218, 57);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Importar datos";
            this.btnImport.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(210, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // img_info
            // 
            this.img_info.BackColor = System.Drawing.Color.White;
            this.img_info.Location = new System.Drawing.Point(48, 165);
            this.img_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.img_info.Name = "img_info";
            this.img_info.Size = new System.Drawing.Size(16, 16);
            this.img_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_info.TabIndex = 58;
            this.img_info.TabStop = false;
            this.img_info.Visible = false;
            // 
            // txtTExt
            // 
            this.txtTExt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTExt.EditValue = "...";
            this.txtTExt.Location = new System.Drawing.Point(93, 136);
            this.txtTExt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTExt.Name = "txtTExt";
            this.txtTExt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTExt.Properties.Appearance.Options.UseFont = true;
            this.txtTExt.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtTExt.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.txtTExt.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtTExt.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.txtTExt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtTExt.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White;
            this.txtTExt.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtTExt.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.txtTExt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtTExt.Properties.ReadOnly = true;
            this.txtTExt.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTExt.Size = new System.Drawing.Size(527, 147);
            this.txtTExt.TabIndex = 60;
            this.txtTExt.Visible = false;
            // 
            // frmImportExternalData
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 292);
            this.Controls.Add(this.txtTExt);
            this.Controls.Add(this.img_info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImport);
            this.LookAndFeel.SkinName = "Black";
            this.Name = "frmImportExternalData";
            this.Padding = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Text = "frmImportExternalData";
            this.Controls.SetChildIndex(this.btnImport, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.img_info, 0);
            this.Controls.SetChildIndex(this.txtTExt, 0);
            this.Controls.SetChildIndex(this.aceptCancelButtonBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTExt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnImport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox img_info;
        private DevExpress.XtraEditors.MemoEdit txtTExt;
    }
}