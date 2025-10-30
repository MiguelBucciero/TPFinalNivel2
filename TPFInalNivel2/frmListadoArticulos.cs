using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPFInalNivel2
{
    public partial class frmListadoArticulos : Form
    {
        private List<Articulo> listaArticulos;
        private List<Imagen> imagenes;
        private ArticuloNegocio articuloNegocio;
        public frmListadoArticulos()
        {
            InitializeComponent();
        }
        private void frmVentana1_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Número");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Precio");
        }
        private void frmVentana1_Activated(object sender, EventArgs e)
        {
            cargar();
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            articuloNegocio = new ArticuloNegocio();
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                imagenes = new List<Imagen>();
                imagenes = articuloNegocio.listarImagenes(seleccionado);
                cargarImagen(imagenes[0].Url);
            }
            bool seleccion = dgvArticulos.SelectedRows.Count > 0;
            btnModificar.Enabled = seleccion;
            btnAgregarOtraImagen.Enabled = seleccion;
            btnEliminar.Enabled = seleccion;
            btnDetalleArticulo.Enabled = seleccion;
        }  
        private void cargarImagen(string imagen) 
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                 pbImagen.Load("https://media.istockphoto.com/id/1222357475/vector/image-preview-icon-picture-placeholder-for-website-or-ui-ux-design-vector-illustration.jpg?s=612x612&w=0&k=20&c=KuCo-dRBYV7nz2gbk4J9w1WtTAgpTdznHu55W9FjimE=");
            }
            
        }
        private void cargar()
        {
            articuloNegocio = new ArticuloNegocio();
            try
            {
                listaArticulos = articuloNegocio.listarDgv();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColummnas();
                imagenes = new List<Imagen>();
                imagenes = articuloNegocio.listarImagenes(listaArticulos[0]);
                cargarImagen(imagenes[0].Url);
                btnModificar.Enabled = false;
                btnAgregarOtraImagen.Enabled = false;
                btnEliminar.Enabled = false;
                btnDetalleArticulo.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColummnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["CodigoArticulo"].Visible = false;
            dgvArticulos.Columns["Marca"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulos alta = new frmAgregarArticulos();
            alta.ShowDialog();

        }
        private void btnDetalleArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmDetalleArticulos detalleArticulos = new frmDetalleArticulos(seleccionado);
            detalleArticulos.ShowDialog();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregarArticulos modificar = new frmAgregarArticulos(seleccionado);
            modificar.ShowDialog();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            articuloNegocio = new ArticuloNegocio();
            Articulo seleccionado; 
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de eliminar el articulo?", "Eliminando",MessageBoxButtons.YesNo,MessageBoxIcon.Warning );
                if(respuesta == DialogResult.Yes)
                {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                articuloNegocio.eliminar(seleccionado.Id);
                cargar();
                  
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >=3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColummnas();
        }
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Número" || opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");

            }
            else if (opcion == "Nombre")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
        private bool validarFiltro()
        {
            if(cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un campo para filtrar");
                return true;
            }
            if(cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un criterio para filtrar");
                return true;
            }
            if(cboCampo.SelectedItem.ToString()== "Número")
            {
                if(string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Por favor, ingrese un número para filtrar");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Por favor, ingrese un número válido");
                    return true;
                }
            }
            return false;

        }
        private bool soloNumeros(string cadena)
        {
            if (cadena.StartsWith("-"))
            {
                return false;
            }
            foreach (char caracter in cadena)
            {
                if(!(char.IsNumber(caracter) ))
                    return false;
            }
            return true;
        }
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if(validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAgregarOtraImagen_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregarImagen agregarImagen = new frmAgregarImagen(seleccionado);
            agregarImagen.ShowDialog();
        }
    }
}

