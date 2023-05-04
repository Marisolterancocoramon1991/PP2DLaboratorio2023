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

        public FormCerdo(Cliente usuario,
            Queue<Cliente> colaClientes, List<Carne> listaDeProductos) //: base (usuario)
        {
            InitializeComponent();
            if (usuario is not null)
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
                foreach (Carne producto in listaDeProductos)
                {
                    if (producto.Nombre == dataGridView1.Rows[n].Cells[0].Value.ToString() &&
                        producto.Tipo == dataGridView1.Rows[n].Cells[1].Value.ToString() &&
                        producto.Precio == (float)dataGridView1.Rows[n].Cells[2].Value)
                    {

                        productoSeleccioando = producto;
                        break;
                    }

                }




            }
        }
        public void CargarDataGridView(List<Carne> listaDeProductos)
        {

            foreach (Carne producto in listaDeProductos)
            {
                if (producto is Cerdo)
                {
                    Cerdo prodct = (Cerdo)producto;
                    dataGridView1.Rows.Add(prodct.Nombre, prodct.Tipo, prodct.Precio, prodct.RazasDeCerdo);

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    DialogResult confirmarVenta;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usuario is not null)
            {
                FormVentas frmVentas = new FormVentas(usuario);
                this.Hide();
                frmVentas.Show();
            }
            else
            {
                Application.Exit();
            }

        }

        private void button3_Click(object sender, EventArgs e)
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
                MessageBox.Show("Perfecto... siga con su compra");
            }
        }
    }
}
