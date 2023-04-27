using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioDetalle
    {
        //ATRIBUTOS:
        private List<Detalle> _listaDetalles;
        private AccesoDatos _accesoDatos;
        private Detalle DetalleAux = null;
        public List<Detalle> listaCategorias { get; set; }
        public List<Detalle> listaMarcas { get; set; }

        //METODOS:
        // Listar:
        public List<Detalle> listar(string str = "CATEGORIAS")
        {
            _listaDetalles = new List<Detalle>();
            _accesoDatos = new AccesoDatos();
            try
            {
                _accesoDatos.setearQuery($"SELECT Id, Descripcion FROM {str}");
                _accesoDatos.ejecutarLectura();
                while(_accesoDatos._lector.Read())
                {
                    DetalleAux = new Detalle();
                    DetalleAux._Id = (int)_accesoDatos._lector["Id"];
                    DetalleAux._Descripcion = (string)_accesoDatos._lector["Descripcion"];
                    _listaDetalles.Add(DetalleAux);
                }

                return _listaDetalles;
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

        // Listar las dos categorias:
        public void listarDosCategorias()
        {
            listaCategorias = new List<Detalle>();
            listaMarcas = new List<Detalle>();
            try
            {
                listaCategorias = listar("CATEGORIAS");

                listaMarcas = listar("MARCAS");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }//fin NegocioDetalle
}
