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

        public FormFacturaVenta(Cliente usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            listaVentas = Negocio.RetornarListaDeVentas();
            CargarDataGridView(listaVentas);
        }
        public void CargarDataGridView(List<Venta> listaDeVentas)
        {

            foreach (Venta producto in listaDeVentas)
            {

                dataGridView1.Rows.Add(producto.ProductoVendido.Nombre, producto.ProductoVendido.Precio, producto.CantidadDeUnidades, producto.ProductoVendido * producto.CantidadDeUnidades);



            }
        }

        private void groupCarniceria_Enter(object sender, EventArgs e)
        {

        }

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
    }
}
