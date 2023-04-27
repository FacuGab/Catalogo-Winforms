namespace TP_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbArticulos = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.tbxFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblCodigoSelecion = new System.Windows.Forms.Label();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.lblNombreArt = new System.Windows.Forms.Label();
            this.cbxFiltroCategorias = new System.Windows.Forms.ComboBox();
            this.cbxFiltroMarcas = new System.Windows.Forms.ComboBox();
            this.numFiltro = new System.Windows.Forms.NumericUpDown();
            this.cbxFiltroNumerico = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCriterioNum = new System.Windows.Forms.Label();
            this.lblFilrapido = new System.Windows.Forms.Label();
            this.btnActualizarGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 63);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(720, 250);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbArticulos
            // 
            this.pbArticulos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbArticulos.Location = new System.Drawing.Point(737, 63);
            this.pbArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbArticulos.Name = "pbArticulos";
            this.pbArticulos.Size = new System.Drawing.Size(231, 250);
            this.pbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulos.TabIndex = 1;
            this.pbArticulos.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 320);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 30);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(121, 320);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 30);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(230, 320);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 30);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Location = new System.Drawing.Point(12, 39);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(35, 13);
            this.lblFiltroRapido.TabIndex = 3;
            this.lblFiltroRapido.Text = "Filtrar:";
            // 
            // tbxFiltroRapido
            // 
            this.tbxFiltroRapido.Location = new System.Drawing.Point(12, 36);
            this.tbxFiltroRapido.Name = "tbxFiltroRapido";
            this.tbxFiltroRapido.Size = new System.Drawing.Size(181, 20);
            this.tbxFiltroRapido.TabIndex = 4;
            this.tbxFiltroRapido.TextChanged += new System.EventHandler(this.tbxFiltroRapido_TextChanged);
            // 
            // lblCodigoSelecion
            // 
            this.lblCodigoSelecion.AutoSize = true;
            this.lblCodigoSelecion.Location = new System.Drawing.Point(762, 321);
            this.lblCodigoSelecion.Name = "lblCodigoSelecion";
            this.lblCodigoSelecion.Size = new System.Drawing.Size(0, 13);
            this.lblCodigoSelecion.TabIndex = 5;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(631, 34);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(101, 23);
            this.btnBusqueda.TabIndex = 6;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // lblNombreArt
            // 
            this.lblNombreArt.AutoSize = true;
            this.lblNombreArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArt.Location = new System.Drawing.Point(762, 34);
            this.lblNombreArt.Name = "lblNombreArt";
            this.lblNombreArt.Size = new System.Drawing.Size(0, 16);
            this.lblNombreArt.TabIndex = 7;
            // 
            // cbxFiltroCategorias
            // 
            this.cbxFiltroCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroCategorias.FormattingEnabled = true;
            this.cbxFiltroCategorias.Location = new System.Drawing.Point(216, 35);
            this.cbxFiltroCategorias.Name = "cbxFiltroCategorias";
            this.cbxFiltroCategorias.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltroCategorias.TabIndex = 8;
            this.cbxFiltroCategorias.SelectedIndexChanged += new System.EventHandler(this.cbxFiltroCategorias_SelectedIndexChanged);
            // 
            // cbxFiltroMarcas
            // 
            this.cbxFiltroMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroMarcas.FormattingEnabled = true;
            this.cbxFiltroMarcas.Location = new System.Drawing.Point(345, 35);
            this.cbxFiltroMarcas.Name = "cbxFiltroMarcas";
            this.cbxFiltroMarcas.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltroMarcas.TabIndex = 9;
            this.cbxFiltroMarcas.SelectedIndexChanged += new System.EventHandler(this.cbxFiltroMarcas_SelectedIndexChanged);
            // 
            // numFiltro
            // 
            this.numFiltro.Enabled = false;
            this.numFiltro.Location = new System.Drawing.Point(552, 35);
            this.numFiltro.Name = "numFiltro";
            this.numFiltro.Size = new System.Drawing.Size(73, 20);
            this.numFiltro.TabIndex = 10;
            // 
            // cbxFiltroNumerico
            // 
            this.cbxFiltroNumerico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroNumerico.FormattingEnabled = true;
            this.cbxFiltroNumerico.Location = new System.Drawing.Point(473, 35);
            this.cbxFiltroNumerico.Name = "cbxFiltroNumerico";
            this.cbxFiltroNumerico.Size = new System.Drawing.Size(73, 21);
            this.cbxFiltroNumerico.TabIndex = 11;
            this.cbxFiltroNumerico.SelectedIndexChanged += new System.EventHandler(this.cbxFiltroNumerico_SelectedIndexChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(216, 19);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(345, 19);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca";
            // 
            // lblCriterioNum
            // 
            this.lblCriterioNum.AutoSize = true;
            this.lblCriterioNum.Location = new System.Drawing.Point(473, 19);
            this.lblCriterioNum.Name = "lblCriterioNum";
            this.lblCriterioNum.Size = new System.Drawing.Size(42, 13);
            this.lblCriterioNum.TabIndex = 13;
            this.lblCriterioNum.Text = "Criterio:";
            // 
            // lblFilrapido
            // 
            this.lblFilrapido.AutoSize = true;
            this.lblFilrapido.Location = new System.Drawing.Point(12, 20);
            this.lblFilrapido.Name = "lblFilrapido";
            this.lblFilrapido.Size = new System.Drawing.Size(182, 13);
            this.lblFilrapido.TabIndex = 14;
            this.lblFilrapido.Text = "Filtro por Nombre y/o Codigo articulo:";
            // 
            // btnActualizarGrid
            // 
            this.btnActualizarGrid.Location = new System.Drawing.Point(661, 320);
            this.btnActualizarGrid.Name = "btnActualizarGrid";
            this.btnActualizarGrid.Size = new System.Drawing.Size(71, 29);
            this.btnActualizarGrid.TabIndex = 15;
            this.btnActualizarGrid.Text = "Actualizar";
            this.btnActualizarGrid.UseVisualStyleBackColor = true;
            this.btnActualizarGrid.Click += new System.EventHandler(this.btnActualizarGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 361);
            this.Controls.Add(this.btnActualizarGrid);
            this.Controls.Add(this.lblFilrapido);
            this.Controls.Add(this.lblCriterioNum);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbxFiltroNumerico);
            this.Controls.Add(this.numFiltro);
            this.Controls.Add(this.cbxFiltroMarcas);
            this.Controls.Add(this.cbxFiltroCategorias);
            this.Controls.Add(this.lblNombreArt);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.lblCodigoSelecion);
            this.Controls.Add(this.tbxFiltroRapido);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gestion de Comercio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.TextBox tbxFiltroRapido;
        private System.Windows.Forms.Label lblCodigoSelecion;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Label lblNombreArt;
        private System.Windows.Forms.ComboBox cbxFiltroCategorias;
        private System.Windows.Forms.ComboBox cbxFiltroMarcas;
        private System.Windows.Forms.NumericUpDown numFiltro;
        private System.Windows.Forms.ComboBox cbxFiltroNumerico;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCriterioNum;
        private System.Windows.Forms.Label lblFilrapido;
        private System.Windows.Forms.Button btnActualizarGrid;
    }
}

