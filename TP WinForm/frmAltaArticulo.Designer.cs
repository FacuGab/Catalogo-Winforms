namespace TP_WinForm
{
    partial class frmAltaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaArticulo));
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtBoxCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.txtBoxUrlImagen = new System.Windows.Forms.TextBox();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.cboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.cboBoxMarca = new System.Windows.Forms.ComboBox();
            this.pBoxImagenArticulo = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.btnCargarImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Location = new System.Drawing.Point(41, 43);
            this.lblCodArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(97, 13);
            this.lblCodArticulo.TabIndex = 0;
            this.lblCodArticulo.Text = "Código de artículo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(91, 67);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(72, 90);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(68, 113);
            this.lblUrlImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(70, 13);
            this.lblUrlImagen.TabIndex = 0;
            this.lblUrlImagen.Text = "URL Imagen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(98, 136);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(81, 160);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(98, 185);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // txtBoxCodigoArticulo
            // 
            this.txtBoxCodigoArticulo.Location = new System.Drawing.Point(155, 43);
            this.txtBoxCodigoArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxCodigoArticulo.Name = "txtBoxCodigoArticulo";
            this.txtBoxCodigoArticulo.Size = new System.Drawing.Size(76, 20);
            this.txtBoxCodigoArticulo.TabIndex = 0;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(155, 67);
            this.txtBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(76, 20);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(155, 90);
            this.txtBoxDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(76, 20);
            this.txtBoxDescripcion.TabIndex = 2;
            // 
            // txtBoxUrlImagen
            // 
            this.txtBoxUrlImagen.Location = new System.Drawing.Point(155, 113);
            this.txtBoxUrlImagen.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxUrlImagen.Name = "txtBoxUrlImagen";
            this.txtBoxUrlImagen.Size = new System.Drawing.Size(76, 20);
            this.txtBoxUrlImagen.TabIndex = 3;
            this.txtBoxUrlImagen.Leave += new System.EventHandler(this.txtBoxUrlImagen_Leave);
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(155, 136);
            this.txtBoxPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(76, 20);
            this.txtBoxPrecio.TabIndex = 4;
            // 
            // cboBoxCategoria
            // 
            this.cboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxCategoria.FormattingEnabled = true;
            this.cboBoxCategoria.Location = new System.Drawing.Point(155, 160);
            this.cboBoxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboBoxCategoria.Name = "cboBoxCategoria";
            this.cboBoxCategoria.Size = new System.Drawing.Size(76, 21);
            this.cboBoxCategoria.TabIndex = 5;
            // 
            // cboBoxMarca
            // 
            this.cboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxMarca.FormattingEnabled = true;
            this.cboBoxMarca.Location = new System.Drawing.Point(155, 185);
            this.cboBoxMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cboBoxMarca.Name = "cboBoxMarca";
            this.cboBoxMarca.Size = new System.Drawing.Size(76, 21);
            this.cboBoxMarca.TabIndex = 6;
            // 
            // pBoxImagenArticulo
            // 
            this.pBoxImagenArticulo.Location = new System.Drawing.Point(263, 43);
            this.pBoxImagenArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxImagenArticulo.Name = "pBoxImagenArticulo";
            this.pBoxImagenArticulo.Size = new System.Drawing.Size(250, 273);
            this.pBoxImagenArticulo.TabIndex = 3;
            this.pBoxImagenArticulo.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(44, 283);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(74, 33);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(157, 283);
            this.bntCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(74, 33);
            this.bntCancelar.TabIndex = 8;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // btnCargarImg
            // 
            this.btnCargarImg.Location = new System.Drawing.Point(157, 232);
            this.btnCargarImg.Name = "btnCargarImg";
            this.btnCargarImg.Size = new System.Drawing.Size(74, 35);
            this.btnCargarImg.TabIndex = 9;
            this.btnCargarImg.Text = "Cargar Imagen";
            this.btnCargarImg.UseVisualStyleBackColor = true;
            this.btnCargarImg.Click += new System.EventHandler(this.btnCargarImg_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 344);
            this.Controls.Add(this.btnCargarImg);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pBoxImagenArticulo);
            this.Controls.Add(this.cboBoxMarca);
            this.Controls.Add(this.cboBoxCategoria);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.txtBoxUrlImagen);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtBoxCodigoArticulo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAltaArticulo";
            this.Text = "Nuevo artículo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBoxCodigoArticulo;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.TextBox txtBoxUrlImagen;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.ComboBox cboBoxMarca;
        private System.Windows.Forms.PictureBox pBoxImagenArticulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.ComboBox cboBoxCategoria;
        private System.Windows.Forms.Button btnCargarImg;
    }
}