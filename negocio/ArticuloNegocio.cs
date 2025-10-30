using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using dominio;
using static System.Net.Mime.MediaTypeNames;

namespace negocio
{
    public class ArticuloNegocio
    {
        AccesoDatos datos = new AccesoDatos();
        public List<Articulo> listarDgv()
        {
            List<Articulo> lista = new List<Articulo>();
            try
            {
                datos.setearConsulta("Select Id, Nombre, Descripcion , Precio From ARTICULOS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (Decimal)datos.Lector["Precio"];
                  
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public Articulo listarDetalle(Articulo nuevo)
        {
            try
            {
                datos.setearConsulta("Select A.Id Id, Nombre, A.Descripcion Descripcion , Precio , M.Descripcion Marca, C.Descripcion Categoria From ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id AND A.IdCategoria = C.id AND A.Id =@Id");
                datos.setearParametro("Id",nuevo.Id );
                datos.ejecutarLectura();
                
                Articulo aux = new Articulo();
                if (datos.Lector.Read())
                {
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (Decimal)datos.Lector["Precio"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public Articulo listarArticuloModificar(Articulo nuevo) 
        {
            try
            {
                datos.setearConsulta("Select Codigo, I.Id IdImagen, I.IdArticulo IdArticulo, I.ImagenUrl, M.Descripcion Marca, M.Id IdMarca, C.Descripcion Categoria, C.Id IdCat " +
                    "From ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I " +
                    "Where A.IdCategoria=C.Id AND A.IdMarca=M.Id AND A.Id=I.IdArticulo AND A.Id = @Id");
                datos.setearParametro("Id", nuevo.Id);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {

                    nuevo.CodigoArticulo = (string)datos.Lector["Codigo"];
                    nuevo.Nombre = nuevo.Nombre;
                    nuevo.Descripcion = nuevo.Descripcion;
                    nuevo.Precio = nuevo.Precio;
                    nuevo.Imagen = new Imagen();
                    nuevo.Imagen.Id = (int)datos.Lector["IdImagen"];
                    nuevo.Imagen.IdArticulo = (int)datos.Lector["IdArticulo"];
                    nuevo.Imagen.Url = (string)datos.Lector["ImagenUrl"];
                    nuevo.Categoria = new Categoria();
                    nuevo.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    nuevo.Categoria.Id = (int)datos.Lector["IdCat"];
                    nuevo.Marca = new Marca();
                    nuevo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    nuevo.Marca.Id = (int)datos.Lector["IdMarca"];
                    return nuevo;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public int agregar(Articulo nuevo)
        {
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) output inserted.Id VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                datos.setearParametro("@Codigo", nuevo.CodigoArticulo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);
                return datos.ejecutarAccionScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Articulo nuevo)
        {
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion,IdMarca=@IdMarca,IdCategoria=@IdCategoria, Precio = @Precio WHERE Id = @Id");
                datos.setearParametro("@Codigo", nuevo.CodigoArticulo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@Id", nuevo.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int id)
        {
            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregarImagen(Imagen nuevo)
        {
            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                datos.setearParametro("@IdArticulo", nuevo.IdArticulo);
                datos.setearParametro("@ImagenUrl", nuevo.Url);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificarImagen(Imagen nuevo)
        {
            try
            {
                datos.setearConsulta("UPDATE IMAGENES SET ImagenUrl = @ImagenUrl WHERE Id = @Id");
                datos.setearParametro("@Id", nuevo.Id);
                datos.setearParametro("@ImagenUrl", nuevo.Url);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public Articulo traerUrlImagen(Articulo nuevo)
        {
            try
            {
                datos.setearConsulta("Select ImagenUrl From IMAGENES where Id= @Id");
                datos.setearParametro("Id", nuevo.Imagen.Id);                                                                    
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    nuevo.Imagen = new Imagen();
                    nuevo.Imagen.Url = (string)(datos.Lector["ImagenUrl"]);
                }
                return nuevo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            try
            {
                string consulta = ("Select A.Id, Codigo, Nombre, A.Descripcion, Precio, ImagenUrl, I.IdArticulo, C.Descripcion ,C.Id, M.Descripcion,M.Id Marca From ARTICULOS A, IMAGENES I, CATEGORIAS C, MARCAS M Where I.Id = A.Id AND C.Id = A.IdCategoria AND M.Id = A.IdMarca AND ");
                if (campo == "Número")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "A.Id > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "A.Id < " + filtro;
                            break;
                        default:
                            consulta += "A.Id = " + filtro;
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '% " + filtro + "'";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Precio < " + filtro;
                            break;
                        default:
                            consulta += "Precio = " + filtro;
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (Decimal)datos.Lector["Precio"];
                    aux.Imagen = new Imagen();
                    aux.Imagen.Url = (string)datos.Lector["ImagenUrl"];
                    aux.Imagen.IdArticulo = (int)datos.Lector["IdArticulo"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Categoria.Id = (int)datos.Lector["Id"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca.Id = (int)datos.Lector["Id"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Imagen> listarImagenes(Articulo nuevo)
        {
            List<Imagen> lista = new List<Imagen>();
            try
            {
                datos.setearConsulta("Select ImagenUrl From IMAGENES Where IdArticulo = @IdArticulo");
                datos.setearParametro("@IdArticulo", nuevo.Id);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.Url = (string)datos.Lector["ImagenUrl"];
                    lista.Add(imagen);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}


