namespace TP_WINFORM_PROGRAM3_
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.dgvarticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lbBusqueda = new System.Windows.Forms.Label();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.btcerrar = new System.Windows.Forms.Button();
            this.lbCampo = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.lbCriterio = new System.Windows.Forms.Label();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBajaFisica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvarticulos
            // 
            this.dgvarticulos.AccessibleName = "";
            this.dgvarticulos.AllowUserToAddRows = false;
            this.dgvarticulos.AllowUserToDeleteRows = false;
            this.dgvarticulos.AllowUserToResizeColumns = false;
            this.dgvarticulos.AllowUserToResizeRows = false;
            this.dgvarticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvarticulos.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvarticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvarticulos.Location = new System.Drawing.Point(13, 50);
            this.dgvarticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvarticulos.Name = "dgvarticulos";
            this.dgvarticulos.ReadOnly = true;
            this.dgvarticulos.RowHeadersWidth = 51;
            this.dgvarticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvarticulos.Size = new System.Drawing.Size(839, 366);
            this.dgvarticulos.TabIndex = 22;
            this.dgvarticulos.SelectionChanged += new System.EventHandler(this.dgvarticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAgregar.Location = new System.Drawing.Point(13, 424);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(176, 40);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(197, 424);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 40);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.LightCoral;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.No;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Location = new System.Drawing.Point(699, 424);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(153, 40);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Baja Logica";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(110, 16);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(140, 20);
            this.txtFiltro.TabIndex = 17;
            this.txtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(616, 486);
            this.btnLimpiarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(69, 24);
            this.btnLimpiarFiltro.TabIndex = 18;
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lbBusqueda
            // 
            this.lbBusqueda.AutoSize = true;
            this.lbBusqueda.Location = new System.Drawing.Point(13, 18);
            this.lbBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBusqueda.Name = "lbBusqueda";
            this.lbBusqueda.Size = new System.Drawing.Size(83, 13);
            this.lbBusqueda.TabIndex = 20;
            this.lbBusqueda.Text = "Filtro Rapido:";
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetalle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.Location = new System.Drawing.Point(390, 424);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(146, 40);
            this.btnDetalle.TabIndex = 25;
            this.btnDetalle.Text = "Ver detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(884, 52);
            this.pbArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(379, 366);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArticulo.TabIndex = 26;
            this.pbArticulo.TabStop = false;
            // 
            // btcerrar
            // 
            this.btcerrar.BackColor = System.Drawing.Color.LightCoral;
            this.btcerrar.Cursor = System.Windows.Forms.Cursors.No;
            this.btcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btcerrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcerrar.ForeColor = System.Drawing.Color.Black;
            this.btcerrar.Location = new System.Drawing.Point(1142, 426);
            this.btcerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(121, 40);
            this.btcerrar.TabIndex = 27;
            this.btcerrar.Text = "&Cerrar";
            this.btcerrar.UseVisualStyleBackColor = false;
            this.btcerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // lbCampo
            // 
            this.lbCampo.AutoSize = true;
            this.lbCampo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampo.Location = new System.Drawing.Point(10, 490);
            this.lbCampo.Name = "lbCampo";
            this.lbCampo.Size = new System.Drawing.Size(73, 17);
            this.lbCampo.TabIndex = 28;
            this.lbCampo.Text = "Campo : ";
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(78, 490);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(97, 20);
            this.cbCampo.TabIndex = 29;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbcampo_SelectedIndexChanged);
            // 
            // cbCriterio
            // 
            this.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(276, 490);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(86, 20);
            this.cbCriterio.TabIndex = 31;
            this.cbCriterio.SelectedIndexChanged += new System.EventHandler(this.cbCriterio_SelectedIndexChanged);
            // 
            // lbCriterio
            // 
            this.lbCriterio.AutoSize = true;
            this.lbCriterio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCriterio.Location = new System.Drawing.Point(195, 490);
            this.lbCriterio.Name = "lbCriterio";
            this.lbCriterio.Size = new System.Drawing.Size(75, 17);
            this.lbCriterio.TabIndex = 30;
            this.lbCriterio.Text = "Criterio : ";
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(387, 489);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(64, 17);
            this.lbFiltro.TabIndex = 32;
            this.lbFiltro.Text = "Filtro :  ";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFiltroAvanzado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(448, 488);
            this.txtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(106, 20);
            this.txtFiltroAvanzado.TabIndex = 33;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(561, 486);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 24);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBajaFisica
            // 
            this.btnBajaFisica.BackColor = System.Drawing.Color.Firebrick;
            this.btnBajaFisica.Cursor = System.Windows.Forms.Cursors.No;
            this.btnBajaFisica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBajaFisica.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaFisica.ForeColor = System.Drawing.Color.Black;
            this.btnBajaFisica.Location = new System.Drawing.Point(743, 16);
            this.btnBajaFisica.Margin = new System.Windows.Forms.Padding(4);
            this.btnBajaFisica.Name = "btnBajaFisica";
            this.btnBajaFisica.Size = new System.Drawing.Size(109, 24);
            this.btnBajaFisica.TabIndex = 35;
            this.btnBajaFisica.Text = "Baja Fisica";
            this.btnBajaFisica.UseVisualStyleBackColor = false;
            this.btnBajaFisica.Click += new System.EventHandler(this.btnBajaFisica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "(Codigo/ Categoria)";
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregarCat.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAgregarCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCat.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCat.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAgregarCat.Location = new System.Drawing.Point(561, 24);
            this.btnAgregarCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(81, 18);
            this.btnAgregarCat.TabIndex = 37;
            this.btnAgregarCat.Text = "abm categoria";
            this.btnAgregarCat.UseVisualStyleBackColor = false;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregarMarca.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAgregarMarca.Location = new System.Drawing.Point(473, 24);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(80, 18);
            this.btnAgregarMarca.TabIndex = 38;
            this.btnAgregarMarca.Text = "abm Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1279, 522);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.btnAgregarCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBajaFisica);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.cbCriterio);
            this.Controls.Add(this.lbCriterio);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.lbCampo);
            this.Controls.Add(this.btcerrar);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.dgvarticulos);
            this.Controls.Add(this.lbBusqueda);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1295, 561);
            this.MinimumSize = new System.Drawing.Size(1295, 561);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ PRINCIPAL";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvarticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lbBusqueda;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Button btcerrar;
        private System.Windows.Forms.Label lbCampo;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.Label lbCriterio;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBajaFisica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.Button btnAgregarMarca;
    }
}

