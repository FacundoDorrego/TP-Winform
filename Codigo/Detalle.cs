using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Libreria para todo lo relacionado con la base de datos
using Funcionalidades;
using Clases;

namespace TP_WINFORM_PROGRAM3_
{
    public partial class Detalle : Form
    {
        public Detalle()
        {
            InitializeComponent();
        }

        public Detalle(string codigo, string nombre, string descripcion, string marca, string categoria, string precio,string url)
        {
            InitializeComponent();

            // Establecer los valores en los TextBox
            txtCodigo.Text = codigo;
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtMarca.Text = marca;
            txtCategoria.Text = categoria;
            txtPrecio.Text = precio;
            try
            {
                PbArticulo.Load(url);
                txtImagen.Text= url;
            }
            catch (Exception)
            {
                PbArticulo.Load("https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png");
                txtImagen.Text = "Imagen no encontrada";
            }
           
        }

        

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Detalle_Load(object sender, EventArgs e)
        {

        }
    }
}
