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

        public FormFacturaVenta(Cliente usuario, List<Venta> listaVentas)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.listaVentas = listaVentas;
            CargarDataGridView(listaVentas);
            labelDirecccion.Text = "Direcion: " + usuario.Direccion;
            labelNombre.Text = "Nombre del Cliente  " + usuario.Nombre;
            labelID.Text = "ID: " + usuario.ID;
            DateTime fechaActual = DateTime.Now;
            labelFechaActual.Text = "Fecha actual " + fechaActual.ToString();
            labelTotal.Text = "Haz click y conoceras el total de gastos";
        }
        public void CargarDataGridView(List<Venta> listaDeVentas)
        {

            foreach (Venta producto in listaDeVentas)
            {

                dataGridView1.Rows.Add(producto.ProductoVendido.Nombre, producto.ProductoVendido.Precio, producto.CantidadDeUnidades, producto.ProductoVendido * producto.CantidadDeUnidades);



            }
        }

            /// <summary>
            /// 
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
                    if (producto.ProductoVendido.Nombre == dataGridView1.Rows[n].Cells[0].Value.ToString() &&
                        producto.ProductoVendido.Precio == (float)dataGridView1.Rows[n].Cells[1].Value //&&
                        /*producto.ProductoVendido == (float)dataGridView1.Rows[n].Cells[2].Value*/)
                    {

                        productoSeleccionado = producto;
                        MessageBox.Show(producto.MostrarDetallesDeVenta());
                        break;
                    }

                }

            }
        }

        private void labelDirecccion_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

            labelTotal.Text = "TOTAL " + Negocio.RetornaPrecioTotalFactura(listaVentas).ToString();

        }

        private void ButtonRegresar_Click(object sender, EventArgs e)
        {
            FormVentaDeCarne formVentaDeCarne = new FormVentaDeCarne(usuario);
            formVentaDeCarne.Show();
            this.Hide();
        }

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
    }
}