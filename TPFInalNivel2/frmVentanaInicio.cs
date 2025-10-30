using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace TPFInalNivel2
{
    public partial class frmVentanaInicio : Form
    {
        public frmVentanaInicio()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmListadoArticulos ventana = new frmListadoArticulos();
            ventana.ShowDialog();
        }
        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulos ventana3 = new frmAgregarArticulos();
            ventana3.ShowDialog();
        }
        private void listaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoArticulos ventana = new frmListadoArticulos();
            ventana.ShowDialog();
        }
        private void agregarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarArticulos ventana3 = new frmAgregarArticulos();
            ventana3.ShowDialog();
        }
        private void btnModificarArticulos_Click(object sender, EventArgs e)
        {
            frmAgregarArticulos ventana3 = new frmAgregarArticulos();
            ventana3.ShowDialog();
        }
    }
}
