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
        List<Venta> ventaTotal;
        Carne productoSeleccinadoDataUno;
        Carne productoSeleccinadoDataDos;
        Cliente clienteSeleccionado;
        List<Venta> listaDeVentasClientesSeleccionado = new();
        public FormVentaAlCliente()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            listaDeVentasClientesSeleccionado = Negocio.RetornarListaDeVentas(cliente);
                            CargarDataGridView(listaDeVentasClientesSeleccionado);
                            labelSaldo2.Text = Negocio.GananciaTotal(cliente).ToString();
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
            ventaTotal = Negocio.RetornarListaDeVentas();
        }


        public void CargarDataGridView(List<Venta> listaDeVenta)
        {

            dataGridView2.Rows.Clear();
            foreach (Venta producto in ventaTotal)
            {
                if (clienteSeleccionado == producto.IDCliente1)
                {

                    dataGridView2.Rows.Add(producto.ProductoVendido.Nombre, producto.ProductoVendido.Tipo,
                        producto.ProductoVendido.Precio, (producto.ProductoVendido.Precio * producto.CantidadDeUnidades));
                    //         Negocio.CargarVenta(listaDeVenta, producto);
                }
            }

            /*      dataGridView2.Rows.Clear();
                  List<Venta> ventasParaCargar = new List<Venta>();
                  foreach (Venta producto in listaDeVenta)
                  {
                      if (clienteSeleccionado == producto.IDCliente1)
                      {
                          ventasParaCargar.Add(producto);
                      }
                  }

                  foreach (Venta ventaParaCargar in ventasParaCargar)
                  {
                      Negocio.CargarVenta(listaDeVenta, ventaParaCargar);
                  }*/
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
            ///Agregar venta 
            DialogResult confirmarVenta;
            float precioAGastar;
            //  MessageBox.Show(productoSeleccioando.MostrarDetallesDeProducto());
            if (Validaciones.IsNotNull(productoSeleccinadoDataUno) && productoSeleccinadoDataUno.CantidadEnInventario > 0 && (int)numericUpDown1.Value > 0
                && productoSeleccinadoDataUno.CantidadEnInventario
                >= (int)numericUpDown1.Value && Validaciones.IsNotNull(clienteSeleccionado) && clienteSeleccionado.Saldo >=
                productoSeleccinadoDataUno.Precio * (int)numericUpDown1.Value)
            {
                if (radioButtonMarcadoPago.Checked == true || radioButtonTarjetaC.Checked == true
                    || radioButtonTarjeteDebito.Checked == true)
                {
                    confirmarVenta = MessageBox.Show("Desea confirmar la compra?",
                        "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmarVenta == DialogResult.Yes)
                    {
                        if (radioButtonMarcadoPago.Checked == true)
                        {
                            Venta venta = new Venta(productoSeleccinadoDataUno,
                              Venta.eMetodoPago.MercadoPago, (int)numericUpDown1.Value, clienteSeleccionado.ID);
                            Negocio.CargarVenta(venta);

                        }
                        else if (radioButtonTarjetaC.Checked == true)
                        {
                            Venta venta = new Venta(productoSeleccinadoDataUno,
                                Venta.eMetodoPago.TarjetaDeCredito, (int)numericUpDown1.Value, clienteSeleccionado.ID);
                            Negocio.CargarVenta(venta);


                        }
                        else
                        {
                            Venta venta = new Venta(productoSeleccinadoDataUno,
                                Venta.eMetodoPago.TarjetaDebito, (int)numericUpDown1.Value, clienteSeleccionado.ID);
                            Negocio.CargarVenta(venta);
                        }

                        productoSeleccinadoDataUno = productoSeleccinadoDataUno - (int)numericUpDown1.Value;

                        precioAGastar = productoSeleccinadoDataUno * (int)numericUpDown1.Value;
                        clienteSeleccionado = clienteSeleccionado - precioAGastar;

                    }
                }
            }
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
            int n = e.RowIndex;

            if (n != -1)
            {
                foreach (Carne producto in ListaCarne)
                {
                    if (producto.Nombre == dataGridView1.Rows[n].Cells[0].Value.ToString() &&
                        producto.Tipo == dataGridView1.Rows[n].Cells[1].Value.ToString() &&
                        producto.Precio == (float)dataGridView1.Rows[n].Cells[2].Value)
                    {
                        productoSeleccinadoDataDos = producto;
                        MessageBox.Show(productoSeleccinadoDataDos.MostrarDetallesDeProducto());


                        break;
                    }
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                foreach (Carne producto in ListaCarne)
                {
                    if (producto.Nombre == dataGridView1.Rows[n].Cells[0].Value.ToString() &&
                        producto.Tipo == dataGridView1.Rows[n].Cells[1].Value.ToString() &&
                        producto.Precio == (float)dataGridView1.Rows[n].Cells[2].Value)
                    {
                        productoSeleccinadoDataUno = producto;


                        break;
                    }
                }
            }
        }
    }
}
