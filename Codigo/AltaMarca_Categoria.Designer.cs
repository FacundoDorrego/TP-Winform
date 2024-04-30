namespace TP_WINFORM_PROGRAM3_
{
    partial class AltaMarca_Categoria
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
            this.lblCat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBajaFisica = new System.Windows.Forms.Button();
            this.btnBajaFisicaMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(42, 107);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(78, 13);
            this.lblCat.TabIndex = 0;
            this.lblCat.Text = "Categoria: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca:";
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(126, 104);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(136, 20);
            this.txtCat.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(126, 154);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(136, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(91, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alta de Marca/Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Registros actuales:";
            // 
            // cbCat
            // 
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(331, 103);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(121, 21);
            this.cbCat.TabIndex = 6;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(331, 154);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbMarca.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(97, 221);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Aceptar Alta";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(358, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBajaFisica
            // 
            this.btnBajaFisica.BackColor = System.Drawing.Color.White;
            this.btnBajaFisica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBajaFisica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBajaFisica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaFisica.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaFisica.ForeColor = System.Drawing.Color.Red;
            this.btnBajaFisica.Location = new System.Drawing.Point(465, 101);
            this.btnBajaFisica.Name = "btnBajaFisica";
            this.btnBajaFisica.Size = new System.Drawing.Size(127, 23);
            this.btnBajaFisica.TabIndex = 10;
            this.btnBajaFisica.Text = "Baja fisica";
            this.btnBajaFisica.UseVisualStyleBackColor = false;
            this.btnBajaFisica.Click += new System.EventHandler(this.btnBajaFisica_Click);
            // 
            // btnBajaFisicaMarca
            // 
            this.btnBajaFisicaMarca.BackColor = System.Drawing.Color.White;
            this.btnBajaFisicaMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBajaFisicaMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBajaFisicaMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaFisicaMarca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaFisicaMarca.ForeColor = System.Drawing.Color.Red;
            this.btnBajaFisicaMarca.Location = new System.Drawing.Point(465, 151);
            this.btnBajaFisicaMarca.Name = "btnBajaFisicaMarca";
            this.btnBajaFisicaMarca.Size = new System.Drawing.Size(127, 23);
            this.btnBajaFisicaMarca.TabIndex = 11;
            this.btnBajaFisicaMarca.Text = "Baja fisica";
            this.btnBajaFisicaMarca.UseVisualStyleBackColor = false;
            this.btnBajaFisicaMarca.Click += new System.EventHandler(this.btnBajaFisicaMarca_Click);
            // 
            // AltaMarca_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(615, 271);
            this.Controls.Add(this.btnBajaFisicaMarca);
            this.Controls.Add(this.btnBajaFisica);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCat);
            this.MaximumSize = new System.Drawing.Size(631, 310);
            this.MinimumSize = new System.Drawing.Size(631, 310);
            this.Name = "AltaMarca_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaMarca_Categoria";
            this.Load += new System.EventHandler(this.AltaMarca_Categoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBajaFisica;
        private System.Windows.Forms.Button btnBajaFisicaMarca;
    }
}