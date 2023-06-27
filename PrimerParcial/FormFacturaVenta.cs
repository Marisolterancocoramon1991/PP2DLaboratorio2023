using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;


namespace PrimerParcial
{
    public partial class FormFacturaVenta : Form
    {
        Cliente usuario;
        List<Venta> listaVentas;
        List<Venta> listaVentasTotal;

        public FormFacturaVenta(Cliente usuario, List<Venta> listaVentas)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.listaVentas = listaVentas;
            RegistroAcceso registro = new RegistroAcceso(usuario.Nombre, "formulario factura");
            this.Load+= registro.OnFrmAbierto;
            this.FormClosed+= registro.OnFrmCerrado;

        }
        /// <summary>
        /// carga los item para que la ventana pueda funcionar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFacturaVenta_Load(object sender, EventArgs e)
        {
            CargarDataGridView(listaVentas);
            labelDirecccion.Text = "Direcion: " + usuario.Direccion;
            labelNombre.Text = "Nombre del Cliente  " + usuario.Nombre;
            labelID.Text = "ID: " + usuario.ID;
            DateTime fechaActual = DateTime.Now;
            labelFechaActual.Text = "Fecha actual " + fechaActual.ToString();
            labelTotal.Text = "Haz click. Total gastado";
            labelMontoTotalNuevaLista.Text = "Total. Compra actual";
            listaVentasTotal = Negocio.RetornarListaDeVentas();
           

        }

        /// <summary>
        /// carga el data necesaria  en el dataGridView
        /// </summary>
        /// <param name="listaDeVentas"></param>
        public void CargarDataGridView(List<Venta> listaDeVentas)
        {

            foreach (Venta producto in listaDeVentas)
            {

                dataGridView1.Rows.Add(producto.Nombre, producto.Precio, producto.CantidadDeUnidades, producto.PrecioTotal);



            }
        }

        /// <summary>
        /// determina el producto que se esta clikeando en e Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            Venta productoSeleccionado;
            if (n != -1)
            {
                foreach (Venta producto in listaVentas)
                {
                    if (producto.Nombre == dataGridView1.Rows[n].Cells[0].Value.ToString() &&
                        producto.Precio == (float)dataGridView1.Rows[n].Cells[1].Value //&&
                        /*producto.ProductoVendido == (float)dataGridView1.Rows[n].Cells[2].Value*/)
                    {

                        productoSeleccionado = producto;
                        MessageBox.Show(producto.MostrarDetallesDeVenta());
                        break;
                    }

                }

            }
        }

        /// <summary>
        /// carga unlabel total de cossto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelTotal_Click(object sender, EventArgs e)
        {
            CalcularGastosDelegate calcularGananciasDelegate = Delegado.CalcularGastosTotales;

            labelTotal.Text = $"TOTAL {calcularGananciasDelegate(usuario, listaVentasTotal)}";
        }

        /// <summary>
        /// te lleva a la venta de carne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRegresar_Click(object sender, EventArgs e)
        {
            FormVentaDeCarne formVentaDeCarne = new FormVentaDeCarne(usuario, "Ave");
            formVentaDeCarne.Show();
            this.Hide();
        }
        /// <summary>
        /// te lleva a la ventana login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirmarVenta;
            confirmarVenta = MessageBox.Show("Desea logearse", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmarVenta == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("En esta ventana esta detallada la infromacion de su compra");
            }
        }

        private void labelMontoTotalNuevaLista_Click(object sender, EventArgs e)
        {
            labelMontoTotalNuevaLista.Text = ($"total: {Negocio.GananciaTotal(listaVentas, usuario)}");
        }

        private void groupCarniceria_Enter(object sender, EventArgs e)
        {

        }
    }
}