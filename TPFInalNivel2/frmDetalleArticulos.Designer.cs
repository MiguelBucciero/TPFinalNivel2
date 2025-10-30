namespace TPFInalNivel2
{
    partial class frmDetalleArticulos
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
            this.dgvDetalleArticulo = new System.Windows.Forms.DataGridView();
            this.lblDetalleDelArticulo = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lbxImagenes = new System.Windows.Forms.ListBox();
            this.lblListaImg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleArticulo
            // 
            this.dgvDetalleArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDetalleArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleArticulo.Location = new System.Drawing.Point(54, 104);
            this.dgvDetalleArticulo.Name = "dgvDetalleArticulo";
            this.dgvDetalleArticulo.Size = new System.Drawing.Size(663, 91);
            this.dgvDetalleArticulo.TabIndex = 0;
            // 
            // lblDetalleDelArticulo
            // 
            this.lblDetalleDelArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDetalleDelArticulo.AutoSize = true;
            this.lblDetalleDelArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleDelArticulo.Location = new System.Drawing.Point(648, 26);
            this.lblDetalleDelArticulo.MinimumSize = new System.Drawing.Size(215, 29);
            this.lblDetalleDelArticulo.Name = "lblDetalleDelArticulo";
            this.lblDetalleDelArticulo.Size = new System.Drawing.Size(215, 29);
            this.lblDetalleDelArticulo.TabIndex = 1;
            this.lblDetalleDelArticulo.Text = "Detalle del Articulo";
            // 
            // pbxImagen
            // 
            this.pbxImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxImagen.Location = new System.Drawing.Point(744, 104);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(742, 558);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 4;
            this.pbxImagen.TabStop = false;
            // 
            // lbxImagenes
            // 
            this.lbxImagenes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbxImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxImagenes.FormattingEnabled = true;
            this.lbxImagenes.ItemHeight = 20;
            this.lbxImagenes.Location = new System.Drawing.Point(311, 212);
            this.lbxImagenes.Name = "lbxImagenes";
            this.lbxImagenes.Size = new System.Drawing.Size(406, 144);
            this.lbxImagenes.TabIndex = 5;
            this.lbxImagenes.SelectedIndexChanged += new System.EventHandler(this.lbxImagenes_SelectedIndexChanged);
            // 
            // lblListaImg
            // 
            this.lblListaImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListaImg.AutoSize = true;
            this.lblListaImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaImg.Location = new System.Drawing.Point(50, 212);
            this.lblListaImg.Name = "lblListaImg";
            this.lblListaImg.Size = new System.Drawing.Size(255, 20);
            this.lblListaImg.TabIndex = 6;
            this.lblListaImg.Text = "Lista de imágenes disponibles:";
            // 
            // frmDetalleArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 697);
            this.Controls.Add(this.lblListaImg);
            this.Controls.Add(this.lbxImagenes);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.lblDetalleDelArticulo);
            this.Controls.Add(this.dgvDetalleArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1571, 736);
            this.MinimumSize = new System.Drawing.Size(1571, 736);
            this.Name = "frmDetalleArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver detalle de un artículo";
            this.Load += new System.EventHandler(this.frmVentana6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleArticulo;
        private System.Windows.Forms.Label lblDetalleDelArticulo;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.ListBox lbxImagenes;
        private System.Windows.Forms.Label lblListaImg;
    }
}