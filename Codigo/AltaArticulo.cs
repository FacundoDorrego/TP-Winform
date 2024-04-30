using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Funcionalidades;
 

namespace TP_WINFORM_PROGRAM3_
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
            
        }

        

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            RepositorioMarca repoMarca = new RepositorioMarca();
            
            CboMarca.DataSource = repoMarca.Listar(); // seteo desplegable marca
            CboMarca.ValueMember = "ID";
            CboMarca.DisplayMember = "Descripcion";


            RepositorioCategoria repoCategoria = new RepositorioCategoria();

            cboCategoria.DataSource = repoCategoria.Listar(); // seteo desplegable categoria
            cboCategoria.ValueMember = "ID";
            cboCategoria.DisplayMember = "Descripcion";

            if (articulo != null) // si es nulo significa que es un nuevo articulo
            {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.descripcion;
                txtPrecio.Text= articulo.Precio.ToString();
                txtUrlImagen.Text = articulo.IdImagenUrl.ImagenURL;

                cargarImagen(articulo.IdImagenUrl.ImagenURL);

                CboMarca.SelectedValue = articulo.idMarca.Id;
                cboCategoria.SelectedValue = articulo.idCategoria.Id;


            }

            
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                PbArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                PbArticulo.Load("https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png");
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int contNull = 0;
            if (txtCodigo.Text == "") // pinto de rojo los campos que no esten completos
            {
                txtCodigo.BackColor = Color.Salmon;
                contNull = 0;

            }
            else
            {
                txtCodigo.BackColor = System.Drawing.SystemColors.Control;
                contNull++;
            }
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Salmon;
                contNull = 0;

            }
            else
            {
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
                contNull++;
            }
            if (txtPrecio.Text == "")
            {
                txtPrecio.BackColor = Color.Salmon;
                contNull = 0;

            }
            else
            {
                txtPrecio.BackColor = System.Drawing.SystemColors.Control;
                contNull++;
            }

            if (contNull == 3)
            {
                RepositorioArticulo repoart = new RepositorioArticulo();
                RepositorioImagen repoImg = new RepositorioImagen();
                try
                {
                    Articulo auxArt = new Articulo();
                    auxArt.Codigo = txtCodigo.Text;
                    auxArt.Nombre = txtNombre.Text;
                    auxArt.descripcion = txtDescripcion.Text;
                    auxArt.idCategoria = (Categoria)cboCategoria.SelectedItem;
                    auxArt.idMarca = (Marca)CboMarca.SelectedItem;
                    auxArt.Precio = decimal.Parse(txtPrecio.Text);
                    repoart.Agregar(auxArt);


                    Imagenes auxImg = new Imagenes();

                    auxImg.idArticulo = BuscarID(auxArt.Codigo);
                    auxImg.ImagenURL = txtUrlImagen.Text;
                    repoImg.Agregar(auxImg);

                    MessageBox.Show("Agregado exitosamente...");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                finally { Close(); }
            }
            else
            {
                MessageBox.Show("Campos vacios, porfavor ingresar los campos obligatorios (marcados en rojo) para poder guardar..");
            }
            }

        public int BuscarID(string codigo)
        {
            int id=0;
            Conexion_Comandos AccesoDatos = new Conexion_Comandos();
            AccesoDatos.setearConsulta("select id from articulos where codigo = @codigo");
            AccesoDatos.setearParametros("@codigo", codigo);
            AccesoDatos.ejecutarLectura();
            while (AccesoDatos.Lector.Read())
            {
                id = (int)AccesoDatos.Lector["Id"];
            return id;
            }
            return id;
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
        }



        
    }
}
