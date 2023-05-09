using BibliotecaDeClases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PrimerParcial
{
    public partial class FormVentaAlCliente : Form
    {
        List<Carne> ListaCarne;
        List<Persona> listaUsuarios;
        Cliente clienteSeleccionado;
        public FormVentaAlCliente()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem != null)
            {
                foreach (Persona usuario in listaUsuarios)
                {
                    if (usuario is Cliente)
                    {
                        Cliente cliente = (Cliente)usuario;
                        string clienteInfo = String.Format("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15}", cliente.Nombre, cliente.Apellido, cliente.ID, cliente.Saldo, cliente.NumeroDeCuenta, cliente.Direccion);
                        if (clienteInfo == listBoxClientes.SelectedItem.ToString())
                        {
                            clienteSeleccionado = cliente;
                            // Aquí puedes utilizar la variable "clienteSeleccionado" para mostrar la información del cliente en la aplicación
                            labelMostrarSeleccion.Text = clienteSeleccionado.Mostrar();
                            break;
                        }
                    }
                }
            }
        }

        private void FormVentaAlCliente_Load(object sender, EventArgs e)
        {
            listaUsuarios = Negocio.RetornaListaUsuarios();
            ListaCarne = Negocio.RetornarProductos();
            CargaListaBoxClientes();
            CargarDataGridView(ListaCarne);
        }
        private void CargaListaBoxClientes()
        {
            listBoxClientes.FormattingEnabled = true;
            // listBoxClientes.Items.AddRange(listaUsuarios.ToArray());
            foreach (Persona Usuario in listaUsuarios)
            {
                if (Usuario is Cliente)
                {
                    Cliente cliente = (Cliente)Usuario;
                    string clienteInfo = String.Format("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15}", cliente.Nombre, cliente.Apellido, cliente.ID, cliente.Saldo, cliente.NumeroDeCuenta, cliente.Direccion);
                    listBoxClientes.Items.Add(clienteInfo);

                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdministracion formAdministracion = new();
            this.Hide();
            formAdministracion.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea Logearse", "Atencion", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Puede seguir trabajando, tu labor es motivo de orgullo y excelencia");

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void CargarDataGridView(List<Carne> listaDeProductos)
        {

            dataGridView1.Rows.Clear();
            foreach (Carne producto in listaDeProductos)
            {
                if (producto is Cerdo)
                {
                    Cerdo cerdo = (Cerdo)producto;
                    dataGridView1.Rows.Add(cerdo.Nombre, cerdo.Tipo, cerdo.Precio, cerdo.RazasDeCerdo, cerdo.CantidadEnInventario);
                }
                else if (producto is Ave)
                {
                    Ave ave = (Ave)producto;
                    dataGridView1.Rows.Add(ave.Nombre, ave.Tipo, ave.Precio, ave.TipoAve, ave.CantidadEnInventario);
                }
                else if (producto is Vacuno)
                {
                    Vacuno vaca = (Vacuno)producto;
                    dataGridView1.Rows.Add(vaca.Nombre, vaca.Tipo, vaca.Precio, vaca.RazasDeVacas, vaca.CantidadEnInventario);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
