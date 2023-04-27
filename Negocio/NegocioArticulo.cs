using System;
using System.Collections.Generic;
using Dominio;

namespace Negocio
{
    public class NegocioArticulo
    {
        //ATRIBUTOS:
        private Articulo _articulo;
        private AccesoDatos _accesoDatos;
        private List<Articulo> _listaArticulos;

        //METODOS:
        // Listar Articulos:
        public List<Articulo> listarArticulos()
        {
            _listaArticulos = new List<Articulo>();
            _accesoDatos = new AccesoDatos();
            try
            {
                _accesoDatos.setearQuery("SELECT a.Id, a.Codigo, a.IdCategoria, c.Descripcion as Categoria, a.IdMarca, m.Descripcion as Marca, a.Descripcion, a.Nombre, a.Precio, a.ImagenUrl FROM ARTICULOS a LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id");
                _accesoDatos.ejecutarLectura();
                while (_accesoDatos._lector.Read())
                {
                    _articulo = new Articulo();

                    _articulo._Id = (int)_accesoDatos._lector["Id"];
                    if(!(_accesoDatos._lector["Codigo"] is DBNull)) _articulo._codArticulo = (string)_accesoDatos._lector["Codigo"];
                    _articulo._categoria._Id = (int)_accesoDatos._lector["IdCategoria"];
                    if (!(_accesoDatos._lector["Categoria"] is DBNull)) _articulo._categoria._Descripcion = (string)_accesoDatos._lector["Categoria"];
                    else _articulo._categoria._Descripcion = "";
                    _articulo._marca._Id = (int)_accesoDatos._lector["IdMarca"];
                    if(!(_accesoDatos._lector["Marca"] is DBNull))_articulo._marca._Descripcion = (string)_accesoDatos._lector["Marca"];
                    if(!(_accesoDatos._lector["Nombre"] is DBNull))_articulo._nombre = (string)_accesoDatos._lector["Nombre"];
                    if(!(_accesoDatos._lector["Descripcion"] is DBNull))_articulo._descripcion = (string)_accesoDatos._lector["Descripcion"];
                    if (!(_accesoDatos._lector["Precio"] is DBNull)) _articulo._precio = (decimal)_accesoDatos._lector["Precio"];
                    if (!(_accesoDatos._lector["ImagenUrl"] is DBNull)) _articulo._urlImagen = (string)_accesoDatos._lector["ImagenUrl"];
                    _articulo.redondear(2);
                    _listaArticulos.Add(_articulo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _accesoDatos.cerrarConexion();
            }
            return _listaArticulos;
        }

        // Agregar Articulo:
        public void agregarArticulo(Articulo art)
        {
            _accesoDatos = new AccesoDatos();
            try
            {
                art.redondear(2);
                _accesoDatos.setearQuery($"INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES ('{art._codArticulo}','{art._nombre }', '{art._descripcion }', @idMarca, @idCategoria, '{art._urlImagen}', @precio)");
                //_accesoDatos.setearQuery($"INSERT INTO ARTICULOS VALUES (@codart, @nombre, @descripcion, @idMarca, @idCategoria, @urlImg, @precio)");
                //_accesoDatos.setearParametro("@codart", art._codArticulo);
                //_accesoDatos.setearParametro("@nombre", art._nombre);
                //_accesoDatos.setearParametro("@descripcion", art._descripcion);
                //_accesoDatos.setearParametro("@urlImg", art._urlImagen);
                _accesoDatos.setearParametro("@idMarca", art._marca._Id);
                _accesoDatos.setearParametro("@idCategoria", art._categoria._Id);
                _accesoDatos.setearParametro("@precio", art._precio);
                _accesoDatos.ejecutarQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _accesoDatos.cerrarConexion();
            }
        }

        // Modificar Articulo:
        public void modificarArticulo(Articulo art)
        {
            _accesoDatos = new AccesoDatos();
            try
            {
                art.redondear(2);
                //_accesoDatos.setearQuery($"UPDATE ARTICULOS SET Codigo = '{art._codArticulo}', Nombre = '{art._nombre}', Descripcion = '{art._descripcion}', IdMarca = {art._marca._Id}, IdCategoria = {art._categoria._Id}, ImagenUrl = '{art._urlImagen}', Precio = {art._precio} WHERE Id = {art._Id}");
                _accesoDatos.setearQuery($"UPDATE ARTICULOS SET Codigo = '{art._codArticulo}', Nombre = '{art._nombre}', Descripcion = '{art._descripcion}', IdMarca = {art._marca._Id}, IdCategoria = {art._categoria._Id}, ImagenUrl = '{art._urlImagen}', Precio = @precio WHERE Id = {art._Id}");
                _accesoDatos.setearParametro("@precio", art._precio);
                _accesoDatos.ejecutarQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                _accesoDatos.cerrarConexion();
            }
        }

        // Eliminar Articulo:
        public void eliminarArticulo(int id)
        {
            _accesoDatos = new AccesoDatos();
            try
            {
                _accesoDatos.setearQuery($"DELETE FROM ARTICULOS WHERE Id = {id}");
                _accesoDatos.ejecutarQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _accesoDatos.cerrarConexion();
            }
        }

        // Busqueda Filtrada:
        public List<Articulo> busquedaFiltrada(Articulo art, decimal fil, string criterio)
        {
            string queryFiltrada = fitrarString(art, fil, criterio);
            _listaArticulos = new List<Articulo>();
            _accesoDatos = new AccesoDatos();
            try
            {
                _accesoDatos.setearQuery(queryFiltrada);
                _accesoDatos.ejecutarLectura();
                while (_accesoDatos._lector.Read())
                {
                    _articulo = new Articulo();
                    _articulo._Id = (int)_accesoDatos._lector["Id"];
                    if (!(_accesoDatos._lector["Codigo"] is DBNull)) _articulo._codArticulo = (string)_accesoDatos._lector["Codigo"];
                    _articulo._categoria._Id = (int)_accesoDatos._lector["IdCategoria"];
                    if (!(_accesoDatos._lector["Categoria"] is DBNull)) _articulo._categoria._Descripcion = (string)_accesoDatos._lector["Categoria"];
                    else _articulo._categoria._Descripcion = "";
                    _articulo._marca._Id = (int)_accesoDatos._lector["IdMarca"];
                    if (!(_accesoDatos._lector["Marca"] is DBNull)) _articulo._marca._Descripcion = (string)_accesoDatos._lector["Marca"];
                    if (!(_accesoDatos._lector["Nombre"] is DBNull)) _articulo._nombre = (string)_accesoDatos._lector["Nombre"];
                    if (!(_accesoDatos._lector["Descripcion"] is DBNull)) _articulo._descripcion = (string)_accesoDatos._lector["Descripcion"];
                    if (!(_accesoDatos._lector["Precio"] is DBNull)) _articulo._precio = (decimal)_accesoDatos._lector["Precio"];
                    if (!(_accesoDatos._lector["ImagenUrl"] is DBNull)) _articulo._urlImagen = (string)_accesoDatos._lector["ImagenUrl"];
                    _articulo.redondear(2);
                    _listaArticulos.Add(_articulo);
                }
                return _listaArticulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _accesoDatos.cerrarConexion();
            }
        }

        // Metodo filtro:
        private string fitrarString(Articulo art, decimal fil, string cri)
        {
            string filtroFinal;
            string filMarca = art._marca._Descripcion;
            string filCategoria = art._categoria._Descripcion;
            if (cri == "Mayor a")
            {
                filtroFinal = $"SELECT a.Id, a.Codigo, a.IdCategoria, c.Descripcion as Categoria, a.IdMarca, m.Descripcion as Marca, a.Descripcion, a.Nombre, a.Precio, a.ImagenUrl FROM ARTICULOS a LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id WHERE c.Descripcion LIKE '{filCategoria}' AND m.Descripcion LIKE '{filMarca}' AND a.Precio > {fil}";
            }
            else if(cri == "Menor a")
            {
                filtroFinal = $"SELECT a.Id, a.Codigo, a.IdCategoria, c.Descripcion as Categoria, a.IdMarca, m.Descripcion as Marca, a.Descripcion, a.Nombre, a.Precio, a.ImagenUrl FROM ARTICULOS a LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id WHERE c.Descripcion LIKE '{filCategoria}' AND m.Descripcion LIKE '{filMarca}' AND a.Precio < {fil}";
            }
            else
            {
                filtroFinal = $"SELECT a.Id, a.Codigo, a.IdCategoria, c.Descripcion as Categoria, a.IdMarca, m.Descripcion as Marca, a.Descripcion, a.Nombre, a.Precio, a.ImagenUrl FROM ARTICULOS a LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id WHERE c.Descripcion LIKE '{filCategoria}' AND m.Descripcion LIKE '{filMarca}' AND a.Precio = {fil}";
            }
            return filtroFinal;
        }

    }//Fin NegocioArticulo
}