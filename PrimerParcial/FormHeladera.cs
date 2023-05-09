using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{

    public partial class FormHeladera : Form
    {
        List<Carne> listaDeProductos;
        Carne productoSeleccioando;
        public FormHeladera()
        {
            InitializeComponent();
        }

        /// <summary>
        /// si el cursor se mantiene estatico en la ventana 
        /// se cre un cartel informativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormHeladera_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(this, "la Heladera es una ventana en donde podeos reviar\n" +
                "todo nuestro stock y la informacion general \n");
        }
        /// <summary>
        /// al hacer click obtiene el producto a eleccion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                foreach (Carne producto in listaDeProductos)
                {
                    if (producto.Nombre == dataGridView1.Rows[n].Cells[0].Value.ToString() &&
                        producto.Tipo == dataGridView1.Rows[n].Cells[1].Value.ToString() &&
                        producto.Precio == (float)dataGridView1.Rows[n].Cells[2].Value)
                    {
                        productoSeleccioando = producto;
                        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
                        toolTip.SetToolTip(this.dataGridView1, productoSeleccioando.MostrarDetallesDeProducto());


                        break;
                    }
                }
            }
        }
        /// <summary>
        /// logea al trabajador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogearse_Click(object sender, EventArgs e)
        {
            DialogResult confirmarVenta;
            confirmarVenta = MessageBox.Show("Desea logearse", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmarVenta == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Hide();
            }

        }
        /// <summary>
        /// regesa a la vetana administrador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            FormAdministracion formAdministracion = new();
            this.Hide();
            formAdministracion.Show();
        }
        /// <summary>
        /// busca coincidencias y las imprime en el dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuscador_Click(object sender, EventArgs e)
        {

            List<Carne> productosEncontrados = listaDeProductos.Where(p => p.Nombre.Contains(textBoxBuscador.Text)).ToList();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = productosEncontrados;
            dataGridView1.Refresh();
        }


        /// <summary>
        /// cuando el cursor pasa por la pintura se mmuestra un cartel informarivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxNevera_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(this.pictureBoxNevera, "la Heladera siempre se debe revisar para brindar un buen producto" +
                "debeos estar siempre al pendiente que los productos esten a la tempertura correcta\n");
        }

        /// <summary>
        /// recibe una lista de objetos de la clase padre Carne y muestra los datos de estos objetos en un DataGridView. 
        /// Además, verifica si los objetos de la lista son de las clases hijas Cerdo, Ave o Vacuno
        /// </summary>
        /// <param name="listaDeProductos"></param>  es una lista de objetos de la clase padre Carne.
        public void CargarDataGridView(List<Carne> listaDeProductos)
        {

            dataGridView1.Rows.Clear();
            foreach (Carne producto in listaDeProductos)
            {
                if (producto is Cerdo)
                {
                    Cerdo cerdo = (Cerdo)producto;
                    dataGridView1.Rows.Add(cerdo.Nombre, cerdo.Tipo, cerdo.Precio, cerdo.RazasDeCerdo);
                }
                else if (producto is Ave)
                {
                    Ave ave = (Ave)producto;
                    dataGridView1.Rows.Add(ave.Nombre, ave.Tipo, ave.Precio, ave.TipoAve);
                }
                else if (producto is Vacuno)
                {
                    Vacuno vaca = (Vacuno)producto;
                    dataGridView1.Rows.Add(vaca.Nombre, vaca.Tipo, vaca.Precio, vaca.RazasDeVacas);
                }
            }
        }

        /// <summary>
        /// carga todos los item para que la ventana pueda funcionar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormHeladera_Load(object sender, EventArgs e)
        {
            listaDeProductos = Negocio.RetornarProductos();
            CargarDataGridView(listaDeProductos);
        }
    }
}
