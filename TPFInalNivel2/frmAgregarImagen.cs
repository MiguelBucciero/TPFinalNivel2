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
using System.IO;

namespace TPFInalNivel2
{
    public partial class frmAgregarImagen : Form
    {
        private Articulo nuevo;
        private OpenFileDialog archivo;
        public frmAgregarImagen(Articulo nuevo)
        {
            InitializeComponent();
            this.nuevo = nuevo;
        }

        private void frmVentana2_Load(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();
            nuevo = negocio.listarArticuloModificar(nuevo);
            if (nuevo == null)
            {
                MessageBox.Show("Ups! Fallo la carga de los datos...", "Error");
                Close();
                return;
            }
            cargarImagen(nuevo.Imagen.Url);
            
        }
        private void btnAgregarOtraImagen_Click(object sender, EventArgs e)
        {
            try
            {
                //if (archivo != null && !(txtUrl.Text.ToUpper().Contains("HTTP")))
                //{
                //    // Obtener ruta del proyecto (dos niveles arriba de bin\Debug)
                //    string projectDir = Path.Combine(Application.StartupPath, @"..\..\..\TPWinForm_equipo-A");
                //    projectDir = Path.GetFullPath(projectDir);
                //    string destino = Path.Combine(projectDir, "Img", Path.GetFileName(archivo.FileName));

                //    // Crear carpeta si no existe
                //    Directory.CreateDirectory(Path.GetDirectoryName(destino));

                //    // Copiar imagen al proyecto
                //    File.Copy(archivo.FileName, destino, true);

                //    // Usar la ruta relativa (para que sea portable)
                //    txtUrl.Text = "Img/" + Path.GetFileName(archivo.FileName);
                //}

                ArticuloNegocio negocio = new ArticuloNegocio();
                Imagen imagen = new Imagen();
                imagen.Url = txtUrl.Text.Trim();
                imagen.IdArticulo = nuevo.Imagen.IdArticulo;
                negocio.agregarImagen(imagen);

                MessageBox.Show("Imagen agregada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Close();
            }
        }

        private void cargarImagen(string imagen)
        {
            {
                try
                {
                    pbxImagenUrl.Load(imagen);
                }
                catch (Exception ex)
                {
                    pbxImagenUrl.Load("https://media.istockphoto.com/id/1222357475/vector/image-preview-icon-picture-placeholder-for-website-or-ui-ux-design-vector-illustration.jpg?s=612x612&w=0&k=20&c=KuCo-dRBYV7nz2gbk4J9w1WtTAgpTdznHu55W9FjimE=");
                }
            }

        }
        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            nuevo.Imagen.Url = txtUrl.Text;
            cargarImagen(nuevo.Imagen.Url);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png;|bmp|*.bmp;";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
