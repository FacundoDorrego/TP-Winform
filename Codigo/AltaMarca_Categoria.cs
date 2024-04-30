using Clases;
using Funcionalidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WINFORM_PROGRAM3_
{
    public partial class AltaMarca_Categoria : Form
    {
        bool parametro = true;
        public AltaMarca_Categoria() //cuando sea marca
        {
            InitializeComponent();
            txtCat.ReadOnly = true;
            cbCat.Visible = false;
            btnBajaFisica.Visible = false;
        }
        public AltaMarca_Categoria(bool parametro) //cuando sea categoria
        {
            InitializeComponent();
            this.parametro = parametro;
            txtMarca.ReadOnly = true;
            cbMarca.Visible = false;
            btnBajaFisicaMarca.Visible=false;

        }


        private void AltaMarca_Categoria_Load(object sender, EventArgs e)
        {
            RepositorioMarca repoMarca = new RepositorioMarca();

            cbMarca.DataSource = repoMarca.Listar(); // seteo desplegable marca
            cbMarca.ValueMember = "ID";
            cbMarca.DisplayMember = "Descripcion";


            RepositorioCategoria repoCategoria = new RepositorioCategoria();

            cbCat.DataSource = repoCategoria.Listar(); // seteo desplegable categoria
            cbCat.ValueMember = "ID";
            cbCat.DisplayMember = "Descripcion";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (parametro == false)
            {
                if (txtCat.Text == "")

                {
                    MessageBox.Show("Campo vacio, porfavor rellenarlo correctamente...");
                }
                else
                {

                    RepositorioCategoria repoCat = new RepositorioCategoria();
                    try
                    {
                        Categoria auxcat = new Categoria();

                        auxcat.Descripcion = txtCat.Text;
                        repoCat.Agregar(auxcat);

                        MessageBox.Show("Agregado exitosamente...");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    finally { Close(); }
                }

            }
            if (parametro == true)
            {


                if (txtMarca.Text == "")
                {
                    MessageBox.Show("Campo vacio, porfavor rellenarlo correctamente...");
                }

                else
                {

                    RepositorioMarca repoMarca = new RepositorioMarca();
                    try
                    {
                        Marca auxMarca = new Marca();

                        auxMarca.Descripcion = txtMarca.Text;
                        repoMarca.Agregar(auxMarca);

                        MessageBox.Show("Agregado exitosamente...");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    finally { Close(); }

                }



            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBajaFisica_Click(object sender, EventArgs e)
        {
            try
            {
                RepositorioCategoria repocat= new RepositorioCategoria();
                
                    Categoria seleccion = (Categoria)cbCat.SelectedItem;
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult resultado = MessageBox.Show("La Baja Fisica borrará el articulo de la base de datos permanentemente. ¿Está seguro que desea borrar el articulo?", "Borrar", botones);
                    if (resultado == DialogResult.Yes)
                    {
                        repocat.BajaFisica(seleccion);
                        MessageBox.Show("Borrado exitosamente...");
                    }
                

            }

            catch (Exception)
            {

                MessageBox.Show("Error al borrar");
            }
            finally
            {
                Close();
            }
        }

        private void btnBajaFisicaMarca_Click(object sender, EventArgs e)
        {
            try
            {
                RepositorioMarca repomar = new RepositorioMarca();

                Marca seleccion = (Marca)cbMarca.SelectedItem;
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult resultado = MessageBox.Show("La Baja Fisica borrará el articulo de la base de datos permanentemente. ¿Está seguro que desea borrar el articulo?", "Borrar", botones);
                if (resultado == DialogResult.Yes)
                {
                    repomar.BajaFisica(seleccion);
                    MessageBox.Show("Borrado exitosamente...");
                }


            }

            catch (Exception)
            {

                MessageBox.Show("Error al borrar");
            }
            finally
            {
                Close();
            }

        }
    }
}

            
        
    



    

