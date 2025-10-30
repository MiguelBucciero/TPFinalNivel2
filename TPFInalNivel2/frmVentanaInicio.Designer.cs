namespace TPFInalNivel2
{
    partial class frmVentanaInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListaArticulos = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListaArticulos
            // 
            this.btnListaArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListaArticulos.Location = new System.Drawing.Point(883, 412);
            this.btnListaArticulos.Name = "btnListaArticulos";
            this.btnListaArticulos.Size = new System.Drawing.Size(150, 77);
            this.btnListaArticulos.TabIndex = 1;
            this.btnListaArticulos.Text = "Listado de artículos";
            this.btnListaArticulos.UseVisualStyleBackColor = true;
            this.btnListaArticulos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(528, 410);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(150, 81);
            this.btnAgregarArticulo.TabIndex = 0;
            this.btnAgregarArticulo.Text = "Agregar artículos";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeArticulosToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // listaDeArticulosToolStripMenuItem
            // 
            this.listaDeArticulosToolStripMenuItem.Name = "listaDeArticulosToolStripMenuItem";
            this.listaDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.listaDeArticulosToolStripMenuItem.Text = "Lista de Artículos";
            this.listaDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.listaDeArticulosToolStripMenuItem_Click);
            // 
            // frmVentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1584, 952);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnListaArticulos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1600, 991);
            this.Name = "frmVentanaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListaArticulos;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeArticulosToolStripMenuItem;
    }
}

