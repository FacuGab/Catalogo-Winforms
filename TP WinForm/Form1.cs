using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace TP_WinForm
{
    // -- FORM MAIN --
    public partial class Form1 : Form
    {
        //CONSTRUCTOR:
        public Form1()
        {
            InitializeComponent();
        }

        //ATRIBUTOS:
        private List<Articulo> listaArticulos;
        private List<Detalle> listaDetalles;
        private NegocioDetalle negocioDetalle;
        private NegocioArticulo negocioArticulo;
        private Articulo articulo;
        private Articulo artBusqueda = new Articulo();
        private List<Articulo> listAux;
        private frmAltaArticulo frmAltaArticulo;
        private string filtroRapido;
        private string filtroBusqueda = null;

        //METODOS:
        // Load:
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                actualizarGridView();
                cargarComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Eventos
        // Evento Selecionar una fila:
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(articulo._urlImagen);
                lblCodigoSelecion.Text = "Codigo:" + articulo._codArticulo;
                lblNombreArt.Text = articulo._nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
       
        // Evento Boton Eliminar:
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                eliminar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Evento Boton Agregar:
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAltaArticulo = new frmAltaArticulo();
                frmAltaArticulo.Name = "Agregar Articulo";
                frmAltaArticulo.ShowDialog();
                actualizarGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Evento Boton Modificar:
        private void btnModificar_Click(object sender, EventArgs e)
        {
            articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            try
            {
                frmAltaArticulo = new frmAltaArticulo(articulo);
                frmAltaArticulo.Name = "Modificar Articulo";
                frmAltaArticulo.ShowDialog();
                actualizarGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        // Evento Cambio texto en caja de busqueda rapida:
        private void tbxFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filtrarRapido();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        // Evento Boton Actualizar:
        private void btnActualizarGrid_Click(object sender, EventArgs e)
        {
            try
            {
                actualizarGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        // Validación filtro Numerico:
        private void validarFiltro()
        {
            if (cbxFiltroNumerico.SelectedIndex < 0) MessageBox.Show("Por favor seleccione un filtro de criterio.");
        }
        
        // -- Eventos De Busqueda Avanzada --
        // Evento Cambio En filtro Numerico:
        private void cbxFiltroNumerico_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtroBusqueda = cbxFiltroNumerico.Text;
            numFiltro.Enabled = true;
            numFiltro.Maximum = 100000000;
            numFiltro.Minimum = 0;
        }

        // Eventos Seleccion ComoBox Categoria y Marcas:
        private void cbxFiltroCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CATEGORIAS
            artBusqueda._categoria._Descripcion = cbxFiltroCategorias.Text;
        }
        private void cbxFiltroMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MARCAS
            artBusqueda._marca._Descripcion = cbxFiltroMarcas.Text;
        }

        // Evento Boton Busqueda:
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (filtroBusqueda != null)
            {
                try
                {
                    decimal filNum = numFiltro.Value;
                    negocioArticulo = new NegocioArticulo();
                    actualizarGridView(negocioArticulo.busquedaFiltrada(artBusqueda, filNum, filtroBusqueda));

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        
        //Metodos
        // Metodo filtrarRapido:
        public void filtrarRapido()
        {
            filtroRapido = tbxFiltroRapido.Text;
            try
            {
                if(filtroRapido.Length > 2)
                {
                    listAux = listaArticulos.FindAll(itm => itm._nombre.ToUpper().Contains(filtroRapido.ToUpper()) || itm._codArticulo.ToUpper().Contains(filtroRapido.ToUpper()));
                }
                else
                { 
                    listAux = listaArticulos;
                }
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listAux;
                dgvArticulos.Columns["_codArticulo"].HeaderText = "CODIGO";
                dgvArticulos.Columns["_categoria"].HeaderText = "CATEGORIA";
                dgvArticulos.Columns["_marca"].HeaderText = "MARCA";
                dgvArticulos.Columns["_nombre"].HeaderText = "NOMBRE";
                dgvArticulos.Columns["_descripcion"].HeaderText = "DESCRIPCION";
                dgvArticulos.Columns["_precio"].HeaderText = "PRECIO";
                dgvArticulos.Columns["_urlImagen"].Visible = false;
                dgvArticulos.Columns["_Id"].Visible = false;
                lblCodigoSelecion.Text = "Codigo:" + listaArticulos[0]._codArticulo;
                lblNombreArt.Text = listaArticulos[0]._nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Metodo Actulizar GridView:
        public void actualizarGridView()
        {
            dgvArticulos.DataSource = null;
            try
            {
                negocioArticulo = new NegocioArticulo();
                listaArticulos= negocioArticulo.listarArticulos();
                dgvArticulos.DataSource = listaArticulos;

                dgvArticulos.Columns["_codArticulo"].HeaderText = "CODIGO";
                dgvArticulos.Columns["_categoria"].HeaderText = "CATEGORIA";
                dgvArticulos.Columns["_marca"].HeaderText = "MARCA";
                dgvArticulos.Columns["_nombre"].HeaderText = "NOMBRE";
                dgvArticulos.Columns["_descripcion"].HeaderText = "DESCRIPCION";
                dgvArticulos.Columns["_precio"].HeaderText = "PRECIO";
                dgvArticulos.Columns["_urlImagen"].Visible = false;
                dgvArticulos.Columns["_Id"].Visible = false;
                lblCodigoSelecion.Text = "Codigo:" + listaArticulos[0]._codArticulo;
                lblNombreArt.Text = listaArticulos[0]._nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Metodo Actulizar GridView sobrecarga:
        public void actualizarGridView(List<Articulo> lis)
        {
            try
            {
                if(lis.Count > 0)
                {
                    listaArticulos = lis;
                    dgvArticulos.DataSource = listaArticulos;

                    dgvArticulos.Columns["_codArticulo"].HeaderText = "CODIGO";
                    dgvArticulos.Columns["_categoria"].HeaderText = "CATEGORIA";
                    dgvArticulos.Columns["_marca"].HeaderText = "MARCA";
                    dgvArticulos.Columns["_nombre"].HeaderText = "NOMBRE";
                    dgvArticulos.Columns["_descripcion"].HeaderText = "DESCRIPCION";
                    dgvArticulos.Columns["_precio"].HeaderText = "PRECIO";
                    dgvArticulos.Columns["_urlImagen"].Visible = false;
                    dgvArticulos.Columns["_Id"].Visible = false;

                    cargarImagen(listaArticulos[0]._urlImagen);
                    lblCodigoSelecion.Text = "Codigo:" + listaArticulos[0]._codArticulo;
                    lblNombreArt.Text = listaArticulos[0]._nombre;
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar referencia");
                    dgvArticulos.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Metodo cargarImagen:
        private void cargarImagen(string img)
        {
            try
            { 
                pbArticulos.Load(img);
            }
            catch (Exception)
            {
                pbArticulos.Load("https://static.vecteezy.com/system/resources/previews/004/639/366/non_2x/error-404-not-found-text-design-vector.jpg");
            }
        }

        // Metodo Eliminar:
        public void eliminar()
        {
            articulo = new Articulo();
            negocioArticulo = new NegocioArticulo();
            try
            {
                // El MessageBox maneja estas alertas asi:
                DialogResult respuesta = MessageBox.Show("Desea Eliminar el Articulo seleccionado?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (respuesta == DialogResult.Yes)
                {
                    articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocioArticulo.eliminarArticulo(articulo._Id);
                    MessageBox.Show("Registro Eliminado permanentemente");
                    actualizarGridView();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Metodo Cargar Bombox Busqueda:
        public void cargarComboBox()
        {
            negocioDetalle = new NegocioDetalle();

            try
            {
                listaDetalles = negocioDetalle.listar("CATEGORIAS");
                cbxFiltroCategorias.DataSource = listaDetalles;
                listaDetalles = negocioDetalle.listar("MARCAS");
                cbxFiltroMarcas.DataSource = listaDetalles;
                cbxFiltroNumerico.Items.Add("Mayor a");
                cbxFiltroNumerico.Items.Add("Menor a");
                cbxFiltroNumerico.Items.Add("Igual a");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }// Fin Form1
}
