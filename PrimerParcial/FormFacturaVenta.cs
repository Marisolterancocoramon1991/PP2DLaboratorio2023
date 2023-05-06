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

        }
        public void CargarDataGridView(List<Venta> listaDeVentas)
        {

            foreach (Venta producto in listaDeVentas)
            {
              
                dataGridView1.Rows.Add(producto.ProductoVendido.Nombre, producto.ProductoVendido.Precio,producto.ProductoVendido* producto.CantidadDeUnidades);

           

            }
        }

        private void groupCarniceria_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
