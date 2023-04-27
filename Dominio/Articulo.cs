
namespace Dominio
{
    public class Articulo
    {
        // ATRIBUTOS:
        public string _codArticulo { get; set; }
        public Detalle _categoria { get; set; }
        public Detalle _marca { get; set; }
        public string _nombre { get; set; } 
        public string _descripcion { get; set; }
        public string _urlImagen { get; set; }
        public decimal _precio { get; set; }

        public int _Id { get; set; }

        // CONSTRUCTOR:
        public Articulo()
        {
            _categoria = new Detalle();
            _marca = new Detalle();
        }

        // METODOS:
        public void redondear(int n)
        {
            _precio = decimal.Round(_precio, n);
        }
    }
}
