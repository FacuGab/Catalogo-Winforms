using Dominio;
using Negocio;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;


namespace TP_WinForm
{
    public partial class frmAltaArticulo : Form
    {
        //ATRIBUTOS:
        private Articulo _articulo = null;
        private NegocioDetalle _negocioDetalle;
        private NegocioArticulo _negocioArticulo;
        private OpenFileDialog _archivo = null;
        private string _urlString = null;

        //CONSTRUCTOR:
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo art)
        {
            InitializeComponent();
            _articulo = art;
        }

        //METODOS:
        // Load:
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            _negocioDetalle = new NegocioDetalle();
            try
            {
                cboBoxMarca.DataSource = _negocioDetalle.listar("MARCAS");
                cboBoxCategoria.ValueMember = "_Id";
                cboBoxCategoria.DisplayMember = "_Descripcion";
                cboBoxCategoria.DataSource = _negocioDetalle.listar("CATEGORIAS");
                cboBoxMarca.ValueMember = "_Id";
                cboBoxMarca.DisplayMember = "_Descripcion";

                if (_articulo != null)
                {
                    txtBoxCodigoArticulo.Text = _articulo._codArticulo;
                    txtBoxNombre.Text = _articulo._nombre;
                    txtBoxDescripcion.Text = _articulo._descripcion;
                    txtBoxPrecio.Text = decimal.Round(_articulo._precio, 2).ToString();
                    txtBoxUrlImagen.Text = _articulo._urlImagen;
                    cargarImagen(_articulo._urlImagen);
                    cboBoxCategoria.SelectedValue = _articulo._categoria._Id;
                    cboBoxMarca.SelectedValue = _articulo._marca._Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        // Evento Boton Cancelar:
        private void bntCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Evento al dejar caja de texto Urlimagen:
        private void txtBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtBoxUrlImagen.Text);
        }

        // Evento boton Aceptar:
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _urlString = null;
            _negocioArticulo = new NegocioArticulo();
            try
            {
                if(_articulo == null) _articulo = new Articulo();

                _articulo._codArticulo = txtBoxCodigoArticulo.Text;
                _articulo._descripcion = txtBoxDescripcion.Text;
                _articulo._urlImagen = txtBoxUrlImagen.Text;
                _urlString = txtBoxUrlImagen.Text;
                if(validarPrecio(txtBoxPrecio.Text))
                {
                    MessageBox.Show("Campo Incorrecto\nRecuerde:\nSolo codigos con numeros, letras y menor a 3 \nPrecio solo numerico\nNombre no mayor a 30 caracterez, descripcion no mayor a 100");
                    return;
                }
                else
                {
                    _articulo._precio = decimal.Parse(txtBoxPrecio.Text);
                }
                _articulo._nombre = txtBoxNombre.Text;
                _articulo._categoria = (Detalle)cboBoxCategoria.SelectedItem;
                _articulo._marca = (Detalle)cboBoxMarca.SelectedItem;

                if(_articulo._Id == 0)
                {
                    // Si da true, quiere decir que el campo contenia el string parametro o era mayor al numero parametro
                    if ( validar(_articulo._codArticulo, 3) || validar(_articulo._nombre, 30) || validar(_articulo._nombre, 100))
                    {
                        MessageBox.Show("Campo Incorrecto\nRecuerde:\nSolo codigos con numeros, letras y menor a 3 \nPrecio solo numerico\nNombre no mayor a 30 caracteres, descripcion no mayor a 100");
                        return;
                    }
                    _negocioArticulo.agregarArticulo(_articulo);
                    MessageBox.Show("Articulo Agregado");
                }
                else
                {
                    if ( validar(_articulo._codArticulo, 3) || validar(_articulo._nombre, 30) || validar(_articulo._nombre, 100) )
                    {
                        MessageBox.Show("Campo incorrecto\nRecuerde:\nSolo codigos con numeros, letras y menor a 3 \nPrecio solo numerico\nNombre no mayor a 30 caracteres, descripcion no mayor a 100");
                        return;
                    }
                    _negocioArticulo.modificarArticulo(_articulo);
                    MessageBox.Show("Articulo Modificado");
                }

                // comprovar antes de guardar una img:
                if ( _archivo != null && !(_urlString.ToUpper().Contains("HTTP")) )
                {
                    guardarImagen(txtBoxUrlImagen.Text, _archivo.SafeFileName);
                }
               Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        // Evento Boton Cargar Imagen:
        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            _archivo = new OpenFileDialog();
            _archivo.Filter = "jpg|*.jpg; |png|*.png";
            try
            {
               if( _archivo.ShowDialog() == DialogResult.OK )
                {
                    txtBoxUrlImagen.Text = _archivo.FileName;
                    cargarImagen(txtBoxUrlImagen.Text);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        // Metodo Cargar Imagen:
        private void cargarImagen(string img)
        {
            try
            {
                pBoxImagenArticulo.Load(img);
            }
            catch
            {
                pBoxImagenArticulo.Load("https://static.vecteezy.com/system/resources/previews/004/639/366/non_2x/error-404-not-found-text-design-vector.jpg");
            }
        }

        // Metodo GuardarImagen:
        //     - si string destino es null, guardamos en ruta por defecto, sino usamos su valor como ruta
        public void guardarImagen(string fuente, string nombreArchivo, string destino = null)
        {
            destino = destino ?? ConfigurationManager.AppSettings["images-folder"] + nombreArchivo;
            try
            {
                if ( !File.Exists(destino) ) 
                    File.Copy(fuente, destino);
                else 
                    MessageBox.Show("Imagen no guardada, ya existe");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // -- Metodos Validaciones -- :
        public bool validar(string campo, int valorMax)
        {
            string caracter = "°!%&/\"()=?·$?¿";
            campo.ToUpper();
            if (caracter.Intersect(campo).Count() > 0)
                return true;
            else if (campo.Length > valorMax)
                return true;
            else if (string.IsNullOrWhiteSpace(campo))
                return true;
            else
                return false;
        }
        public bool validarPrecio(string campo)
        {
            string chars = "°!%&/\"()=?·$?¿ABCDEFGHIJKLMNROPQRSTUVWXYZabcdefghijklrmnopqrstuvwxyz";
            if (chars.Intersect(campo).Count() > 0)
                return true;
            else if (string.IsNullOrWhiteSpace(campo))
                return true;
            else
                return false;
        }
        
        // Modificar String campo(sin uso x ahora)
        public void ModificarStringCampo(string campo, string str, bool flag = true)
        {
            campo.ToUpper();
            str.ToUpper();
            if(flag)
                _ = campo.Contains(str) ? "" : campo;
            else
                _ = !campo.Contains(str) ? "" : campo;
        }

    }//fin form
}
