namespace TPFInalNivel2
{
    partial class frmAgregarImagen
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarOtraImagen = new System.Windows.Forms.Button();
            this.pbxImagenUrl = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(109, 68);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(436, 26);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // btnAgregarOtraImagen
            // 
            this.btnAgregarOtraImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarOtraImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOtraImagen.Location = new System.Drawing.Point(280, 474);
            this.btnAgregarOtraImagen.Name = "btnAgregarOtraImagen";
            this.btnAgregarOtraImagen.Size = new System.Drawing.Size(121, 37);
            this.btnAgregarOtraImagen.TabIndex = 2;
            this.btnAgregarOtraImagen.Text = "Agregar";
            this.btnAgregarOtraImagen.UseVisualStyleBackColor = true;
            this.btnAgregarOtraImagen.Click += new System.EventHandler(this.btnAgregarOtraImagen_Click);
            // 
            // pbxImagenUrl
            // 
            this.pbxImagenUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxImagenUrl.Location = new System.Drawing.Point(60, 106);
            this.pbxImagenUrl.Name = "pbxImagenUrl";
            this.pbxImagenUrl.Size = new System.Drawing.Size(593, 346);
            this.pbxImagenUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenUrl.TabIndex = 3;
            this.pbxImagenUrl.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.Location = new System.Drawing.Point(551, 66);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(102, 34);
            this.btnAgregarImagen.TabIndex = 1;
            this.btnAgregarImagen.Text = "Cargar local";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 26);
            this.label2.MaximumSize = new System.Drawing.Size(221, 26);
            this.label2.MinimumSize = new System.Drawing.Size(221, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cargar imagen nueva";
            // 
            // frmAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.pbxImagenUrl);
            this.Controls.Add(this.btnAgregarOtraImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(712, 562);
            this.MinimumSize = new System.Drawing.Size(712, 562);
            this.Name = "frmAgregarImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar imagen";
            this.Load += new System.EventHandler(this.frmVentana2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenUrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarOtraImagen;
        private System.Windows.Forms.PictureBox pbxImagenUrl;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label label2;
    }
}