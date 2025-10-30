namespace TPFInalNivel2
{
    partial class frmAgregarArticulos
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigoDeProducto = new System.Windows.Forms.TextBox();
            this.txtNombreDelProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcionDelProducto = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboMarcaDelProducto = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lblAgregarArticulo = new System.Windows.Forms.Label();
            this.lblModificarArticulo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(143, 109);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(137, 165);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(69, 20);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(110, 222);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtCodigoDeProducto
            // 
            this.txtCodigoDeProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigoDeProducto.Location = new System.Drawing.Point(216, 109);
            this.txtCodigoDeProducto.Name = "txtCodigoDeProducto";
            this.txtCodigoDeProducto.Size = new System.Drawing.Size(259, 20);
            this.txtCodigoDeProducto.TabIndex = 0;
            // 
            // txtNombreDelProducto
            // 
            this.txtNombreDelProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombreDelProducto.Location = new System.Drawing.Point(216, 167);
            this.txtNombreDelProducto.Name = "txtNombreDelProducto";
            this.txtNombreDelProducto.Size = new System.Drawing.Size(259, 20);
            this.txtNombreDelProducto.TabIndex = 1;
            // 
            // txtDescripcionDelProducto
            // 
            this.txtDescripcionDelProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcionDelProducto.Location = new System.Drawing.Point(216, 224);
            this.txtDescripcionDelProducto.Name = "txtDescripcionDelProducto";
            this.txtDescripcionDelProducto.Size = new System.Drawing.Size(259, 20);
            this.txtDescripcionDelProducto.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(223, 494);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(81, 38);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(351, 494);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 38);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbMarca
            // 
            this.lbMarca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(143, 280);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(57, 20);
            this.lbMarca.TabIndex = 9;
            this.lbMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(124, 328);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(82, 20);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoría:";
            // 
            // cboMarcaDelProducto
            // 
            this.cboMarcaDelProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboMarcaDelProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaDelProducto.FormattingEnabled = true;
            this.cboMarcaDelProducto.Location = new System.Drawing.Point(216, 282);
            this.cboMarcaDelProducto.Name = "cboMarcaDelProducto";
            this.cboMarcaDelProducto.Size = new System.Drawing.Size(259, 21);
            this.cboMarcaDelProducto.TabIndex = 3;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "1 - Celulares",
            "2- Televisores",
            "3- Media",
            "4- Audio"});
            this.cboCategoria.Location = new System.Drawing.Point(216, 330);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(259, 21);
            this.cboCategoria.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(149, 381);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrecio.Location = new System.Drawing.Point(216, 380);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(259, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(534, 109);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(535, 385);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 15;
            this.pbxImagen.TabStop = false;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.Location = new System.Drawing.Point(102, 430);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(104, 20);
            this.lblUrlImagen.TabIndex = 16;
            this.lblUrlImagen.Text = "URL Imagen:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(216, 430);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(259, 20);
            this.txtUrlImagen.TabIndex = 6;
            this.txtUrlImagen.TextChanged += new System.EventHandler(this.txtUrlImagen_TextChanged_1);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(491, 432);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(30, 19);
            this.btnAgregarImagen.TabIndex = 18;
            this.btnAgregarImagen.Text = "...";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click_1);
            // 
            // lblAgregarArticulo
            // 
            this.lblAgregarArticulo.AutoSize = true;
            this.lblAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarArticulo.Location = new System.Drawing.Point(424, 39);
            this.lblAgregarArticulo.Name = "lblAgregarArticulo";
            this.lblAgregarArticulo.Size = new System.Drawing.Size(230, 26);
            this.lblAgregarArticulo.TabIndex = 19;
            this.lblAgregarArticulo.Text = "Agregar artículo nuevo";
            this.lblAgregarArticulo.Visible = false;
            // 
            // lblModificarArticulo
            // 
            this.lblModificarArticulo.AutoSize = true;
            this.lblModificarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarArticulo.Location = new System.Drawing.Point(436, 39);
            this.lblModificarArticulo.Name = "lblModificarArticulo";
            this.lblModificarArticulo.Size = new System.Drawing.Size(176, 26);
            this.lblModificarArticulo.TabIndex = 20;
            this.lblModificarArticulo.Text = "Modificar artículo";
            this.lblModificarArticulo.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAgregarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 573);
            this.Controls.Add(this.lblModificarArticulo);
            this.Controls.Add(this.lblAgregarArticulo);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarcaDelProducto);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescripcionDelProducto);
            this.Controls.Add(this.txtNombreDelProducto);
            this.Controls.Add(this.txtCodigoDeProducto);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1102, 612);
            this.MinimumSize = new System.Drawing.Size(1102, 612);
            this.Name = "frmAgregarArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar artículos";
            this.Load += new System.EventHandler(this.frmVentana3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigoDeProducto;
        private System.Windows.Forms.TextBox txtNombreDelProducto;
        private System.Windows.Forms.TextBox txtDescripcionDelProducto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboMarcaDelProducto;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label lblAgregarArticulo;
        private System.Windows.Forms.Label lblModificarArticulo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}