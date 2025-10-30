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
using negocio;

namespace TPFInalNivel2
{
    public partial class frmDetalleArticulos : Form
    {
        private Articulo nuevo;
        private List<Imagen> imagenes;
        public frmDetalleArticulos(Articulo nuevo)
        {
            InitializeComponent();
            this.nuevo = nuevo;
        }
        private void frmVentana6_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void ocultarColummnas()
        {
            dgvDetalleArticulo.Columns["Id"].Visible = false;
            dgvDetalleArticulo.Columns["Imagen"].Visible = false;
            dgvDetalleArticulo.Columns["CodigoArticulo"].Visible = false;
        }
        private void cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo articuloDetalle = negocio.listarDetalle(nuevo);
                List<Articulo> listaArticulos = new List<Articulo> { articuloDetalle };
                dgvDetalleArticulo.DataSource = listaArticulos;
                ocultarColummnas();
                imagenes = negocio.listarImagenes(nuevo);
                lbxImagenes.DataSource = imagenes;
                cargarImagen(imagenes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        private void cargarImagen(List<Imagen> imagenes)
        {
            try
            {
                pbxImagen.Load(imagenes[0].ToString());
            }
            catch (Exception ex)
            {
                pbxImagen.Load("https://media.istockphoto.com/id/1222357475/vector/image-preview-icon-picture-placeholder-for-website-or-ui-ux-design-vector-illustration.jpg?s=612x612&w=0&k=20&c=KuCo-dRBYV7nz2gbk4J9w1WtTAgpTdznHu55W9FjimE=");
            }

        }
        private void lbxImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbxImagenes.SelectedItem != null)
            {
                Imagen imagenSeleccionada = (Imagen)lbxImagenes.SelectedItem;
                try
                {
                    pbxImagen.Load(imagenSeleccionada.Url);
                }
                catch (Exception ex)
                {
                    pbxImagen.Load("https://media.istockphoto.com/id/1222357475/vector/image-preview-icon-picture-placeholder-for-website-or-ui-ux-design-vector-illustration.jpg?s=612x612&w=0&k=20&c=KuCo-dRBYV7nz2gbk4J9w1WtTAgpTdznHu55W9FjimE=");
                }
            }

        }
    }
}
