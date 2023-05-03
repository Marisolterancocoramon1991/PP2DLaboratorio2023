using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class FormCerdo : Form
    {
        Cliente? usuario;
        Queue<Cliente> colaClientes;
        List<Carne> listaDeProductos;
        Carne productoSeleccioando;

        public FormCerdo(Cliente? usuario,
            Queue<Cliente> colaClientes, List<Carne> listaDeProductos)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.colaClientes = colaClientes;
            this.listaDeProductos = listaDeProductos;
            CargarDataGridView(Negocio.RetornarProductos());
            if (usuario is not null)
            {
                labelNombre.Text = usuario.Nombre;
                labelDinero.Text = usuario.Saldo.ToString();
            }


        }

        private void groupCerdo_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {




            }
        }
        public void CargarDataGridView(List<Carne> listaDeProductos)
        {

            foreach (Carne producto in listaDeProductos)
            {

                dataGridView1.Rows.Add(producto.Nombre, producto.Tipo, producto.Precio/*, producto.RazasDeCerdo*/);
            }
        }
        
    }
}
