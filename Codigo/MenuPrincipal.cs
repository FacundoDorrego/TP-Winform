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
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
namespace TP_WINFORM_PROGRAM3_
{
    public partial class MenuPrincipal : Form
    {
        private List<Articulo> ListaArticulos; 

        public MenuPrincipal()
        {
            InitializeComponent();

        }
        //
        // botones 
        //
        private void btnAgregar_Click(object sender, EventArgs e) // boton de Alta..
        {
            frmAltaArticulo altaArticulo = new frmAltaArticulo();
            altaArticulo.ShowDialog();
            CargarListado();
        }
        private void btnDetalle_Click(object sender, EventArgs e) // Boton de Ver detalle..
        {
            try
            {
                if (dgvarticulos.SelectedRows.Count > 0)
                {  
                    string codigo = dgvarticulos.SelectedRows[0].Cells[1].Value.ToString();
                    string nombre = dgvarticulos.SelectedRows[0].Cells[2].Value.ToString();
                    string descripcion = dgvarticulos.SelectedRows[0].Cells[3].Value.ToString();
                    string marca = dgvarticulos.SelectedRows[0].Cells[4].Value.ToString();
                    string categoria = dgvarticulos.SelectedRows[0].Cells[5].Value.ToString();
                    string precio = dgvarticulos.SelectedRows[0].Cells[6].Value.ToString();                
                    Articulo seleccion = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
                    string url = seleccion.IdImagenUrl.ImagenURL;
                    Detalle frmdetalle = new Detalle(codigo, nombre, descripcion, marca, categoria, precio,url);
                    frmdetalle.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila antes de ver el detalle.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, seleccione otra fila"); ;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e) // Boton de modificar..
        {
            try
            {
                if (dgvarticulos.SelectedRows.Count > 0)
                {
                    Articulo aux = new Articulo();
                    aux.id= (int)dgvarticulos.SelectedRows[0].Cells[0].Value;
                    aux.Codigo = dgvarticulos.SelectedRows[0].Cells[1].Value.ToString();
                    aux.Nombre = dgvarticulos.SelectedRows[0].Cells[2].Value.ToString();
                    aux.descripcion = dgvarticulos.SelectedRows[0].Cells[3].Value.ToString();
                    aux.idMarca= (Marca)dgvarticulos.SelectedRows[0].Cells[4].Value;
                    aux.idCategoria = (Categoria)dgvarticulos.SelectedRows[0].Cells[5].Value;
                    aux.Precio = (decimal)dgvarticulos.SelectedRows[0].Cells[6].Value;
                    Articulo seleccion = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
                    if (seleccion.IdImagenUrl != null)
                    {
                        aux.IdImagenUrl = (Imagenes)seleccion.IdImagenUrl;
                    }
                    else
                    {
                         aux.IdImagenUrl.ImagenURL = "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png"; }
                    ModificarArticulo frmModificar = new ModificarArticulo(aux);
                    frmModificar.ShowDialog();
                    CargarListado();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila antes de ver el detalle.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, seleccione otra fila");
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e) // Boton de BAJA (Logica)..
        {
            try
            {
                RepositorioArticulo repoArt = new RepositorioArticulo();
                if (dgvarticulos.CurrentRow != null)
                {
                    Articulo seleccion = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea borrar el articulo?", "Borrar", botones);
                    if (resultado == DialogResult.Yes)
                    {
                        repoArt.BajaLogica(seleccion);
                        MessageBox.Show("Borrado exitosamente...");
                    }
                }
                
            }

            catch (Exception)
            {

                MessageBox.Show("Error al borrar");
            }
            finally
            {
                CargarListado();
            }

            


        }
        private void btnLimpiarFiltro_Click(object sender, EventArgs e) //boton de limpiar Filtro
        {
            txtFiltroAvanzado.Text = null;
            CargarListado();
        }
        private void btncerrar_Click(object sender, EventArgs e) // Boton de cerrar programa
        {
            Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e) // Boton de buscar en Filtro Avanzado..
        {
            RepositorioArticulo repoarti = new RepositorioArticulo();
            try
            {

                if (validacionFiltros())
                    return;
                string campo = cbCampo.SelectedItem.ToString();
                string criterio = cbCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvarticulos.DataSource = repoarti.FiltrarArticulos(campo, criterio, filtro);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //
        // FUNCIONES
        //
        private void cargarImagen(string imagen) // carga imagen o coloca una por default..
        {
            try
            {
                pbArticulo.Load(imagen);
            }
            catch (Exception)
            {

                pbArticulo.Load("https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png");

            }
        }
        private bool validacionFiltros() // Valido que los filtros esten bien y no se cargue nada mal..
        {
            if (cbCampo.SelectedIndex == -1)
            {

                MessageBox.Show("Por favor, Seleccione el campo para filtrar... ");
                return true;
            }
            if (cbCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, Seleccione el criterio para filtrar... ");
                return true;
            }
            if (cbCampo.SelectedItem.ToString() == "Precio.")
            {
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {

                    MessageBox.Show("Solo numeros para filtrar en un campo numerico...");
                    return true;
                }

            }
            if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
            {
                MessageBox.Show("Por favor, Escriba la palabra a filtrar... ");
                return true;
            }

            return false;

        }
        private bool soloNumeros(string cadena) // Obliga a ingresar numeros
        {
            foreach (char character in cadena)
            {
                if (!(char.IsNumber(character)))
                {
                    return false;
                }
            }
            return true;
        }
        private void CargarListado()
        {


            try
            {


                RepositorioArticulo repoArticulo = new RepositorioArticulo();
                
                ListaArticulos = repoArticulo.Listar().Where(Articulo=>Articulo.Precio >=0).ToList(); // seteo lista
                dgvarticulos.DataSource = ListaArticulos; //agrego al dgv la lista para que se pueda visualizar
                pbArticulo.Load(ListaArticulos[0].IdImagenUrl.ImagenURL);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        } // carga el listado de articulos
        private void ocultarColumnas()
        {
            dgvarticulos.Columns["IdImagen"].Visible = false;
            dgvarticulos.Columns["id"].Visible = false;
        } // oculto columnas del dgv
        
        //
        //EVENTOS
        //
        private void MenuPrincipal_Load(object sender, EventArgs e) // Load del menu
        {  
            
            CargarListado();
            cbCampo.Items.Add("Precio.");
            cbCampo.Items.Add("Nombre.");
        }

        private void dgvarticulos_SelectionChanged(object sender, EventArgs e) // funcion al momento de cambiar de fila en el DataGridView
        {
            if (dgvarticulos.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccion.IdImagenUrl.ImagenURL);
            }

        }
        private void TxtFiltro_TextChanged(object sender, EventArgs e) // Funcion al momento de ingresar/borrar/colocar letras en el filtro rapido
        {

            List<Articulo> ListaFiltrada;
            String Filtro = txtFiltro.Text;
            ListaFiltrada = ListaArticulos.FindAll(x => x.Codigo.ToUpper().Contains(Filtro.ToUpper()) || x.idCategoria.Descripcion.ToUpper().Contains(Filtro.ToUpper()));

            dgvarticulos.DataSource = null;
            dgvarticulos.DataSource = ListaFiltrada;
        }
        private void cbcampo_SelectedIndexChanged(object sender, EventArgs e) //funcion al momento de seleccionar el desplegable de campo
        {
            
                string opcion = cbCampo.SelectedItem.ToString();

                if (opcion == "Precio.")
                {
                    cbCriterio.Items.Clear(); // aparecia un error que sumaba los items, con el clear limpio cada vez que se selecciona el campo
                cbCriterio.Items.Add("Mayor a..");
                cbCriterio.Items.Add("Menor a..");
                cbCriterio.Items.Add("Igual a..");


                }
                else if (opcion == "Nombre.")
                {
                cbCriterio.Items.Clear();
                    cbCriterio.Items.Add("comienza con..");
                    cbCriterio.Items.Add("Termina con..");
                    cbCriterio.Items.Add("Contiene..");

                }

            
        }

        private void btnBajaFisica_Click(object sender, EventArgs e)
        {
            try
            {
                RepositorioArticulo repoArt = new RepositorioArticulo();
                if (dgvarticulos.CurrentRow != null)
                {
                    Articulo seleccion = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult resultado = MessageBox.Show("La Baja Fisica borrará el articulo de la base de datos permanentemente. ¿Está seguro que desea borrar el articulo?", "Borrar", botones);
                    if (resultado == DialogResult.Yes)
                    {
                        repoArt.BajaFisica(seleccion);
                        MessageBox.Show("Borrado exitosamente...");
                    }
                }

            }

            catch (Exception)
            {

                MessageBox.Show("Error al borrar");
            }
            finally
            {
                CargarListado();
            }
        }

        private void cbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            AltaMarca_Categoria AltaCate = new AltaMarca_Categoria(false);
            AltaCate.ShowDialog();
            CargarListado();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            AltaMarca_Categoria AltaCate = new AltaMarca_Categoria();
            AltaCate.ShowDialog();
            CargarListado();
        }
    }
}
