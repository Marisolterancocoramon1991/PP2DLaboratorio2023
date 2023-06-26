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
using System.Data.SqlClient;
using System.Runtime.Intrinsics.X86;

namespace PrimerParcial
{
    public partial class FormVentaAlCliente : Form
    {
        List<Carne> ListaCarne;
        List<Cliente> listaCliente;
        List<Ave> listaAve;
        List<Cerdo> listaCerdo;
        List<Vacuno> listaVacuno;
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
        /// compara la impresiono del listbox a la seleccion de item
        /// y en la iteracion que sea cierta le pasa el espaco en memoria a clienteSeleccinado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem != null)
            {
                foreach (Persona usuario in listaCliente)
                {
                    if (usuario is Cliente)
                    {
                        Cliente cliente = (Cliente)usuario;
                        string clienteInfo = String.Format("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15}", cliente.Nombre, cliente.Apellido, cliente.ID, cliente.Saldo, cliente.NumeroDeCuenta, cliente.Direccion);
                        if (clienteInfo == listBoxClientes.SelectedItem.ToString())
                        {
                            clienteSeleccionado = cliente;
                            listaDeVentasClientesSeleccionado = Negocio.RetornarListaDeVentas(clienteSeleccionado);
                            CargarDataGridView2();
                            labelSaldo2.Text = Negocio.GananciaTotal(cliente).ToString();
                            // Aquí puedes utilizar la variable "clienteSeleccionado" para mostrar la información del cliente en la aplicación
                            labelMostrarSeleccion.Text = clienteSeleccionado.Mostrar();
                            break;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// crga todos los item para que pueda funcionar correctamente la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVentaAlCliente_Load(object sender, EventArgs e)
        {
            listaCliente = Negocio.RetornaListaClientes();
            listaAve = Negocio.RetornarListaAve();
            listaCerdo = Negocio.RetornarListaCerdo();
            listaVacuno = Negocio.RetornarListaVacuno();
            CargaListaBoxClientes();
            CargarDataGridView(listaAve);
            CargarDataGridView(listaCerdo);
            CargarDataGridView(listaVacuno);
            ventaTotal = Negocio.RetornarListaDeVentas();
            dataGridViewVaca.Visible = false;
            dataGridViewCerdo.Visible = false;
            dataGridView1.Visible = false;
        }

        /// <summary>
        /// carga los item necesarios al DataGridView
        /// </summary>
        public void CargarDataGridView2()
        {

            dataGridView2.Rows.Clear();
            foreach (Venta producto in ventaTotal)
            {
                if (clienteSeleccionado == producto.IDCliente1)
                {

                    dataGridView2.Rows.Add(producto.Nombre, producto.Tipo,
                        producto.Precio, producto.PrecioTotal);
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

        /// <summary>
        /// carga cada ite en la listabox
        /// </summary>
        private void CargaListaBoxClientes()
        {
            listBoxClientes.FormattingEnabled = true;
            // listBoxClientes.Items.AddRange(listaUsuarios.ToArray());
            foreach (Persona Usuario in listaCliente)
            {
                if (Usuario is Cliente)
                {
                    Cliente cliente = (Cliente)Usuario;
                    string clienteInfo = String.Format("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15}", cliente.Nombre, cliente.Apellido, cliente.ID, cliente.Saldo, cliente.NumeroDeCuenta, cliente.Direccion);
                    listBoxClientes.Items.Add(clienteInfo);

                }
            }



        }
        /// <summary>
        /// te devuelve a la ventana adinistracion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FormAdministracion formAdministracion = new();
            this.Hide();
            formAdministracion.Show();
        }

        /// <summary>
        /// se crea la venta por porducto a un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Agregar venta
            DialogResult confirmarVenta;
            float precioAGastar;

            if (Validaciones.IsNotNull(productoSeleccinadoDataUno) && Validaciones.NumeroMayorAcero(productoSeleccinadoDataUno.CantidadEnInventario) &&
                Validaciones.NumeroMayorAcero((int)numericUpDown1.Value) && productoSeleccinadoDataUno.CantidadEnInventario >= (int)numericUpDown1.Value &&
                Validaciones.IsNotNull(clienteSeleccionado))
            {
                precioAGastar = productoSeleccinadoDataUno.Precio * (int)numericUpDown1.Value;

                try
                {
                    clienteSeleccionado.ComprarProductoValidacion(precioAGastar);

                    if (radioButtonMarcadoPago.Checked || radioButtonTarjetaC.Checked || radioButtonTarjeteDebito.Checked)
                    {
                        confirmarVenta = MessageBox.Show("¿Desea confirmar la compra?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (confirmarVenta == DialogResult.Yes)
                        {
                            eMetodoPago metodoPago;

                            if (radioButtonMarcadoPago.Checked)
                            {
                                metodoPago = eMetodoPago.MercadoPago;
                            }
                            else if (radioButtonTarjetaC.Checked)
                            {
                                metodoPago = eMetodoPago.TarjetaDeCredito;
                            }
                            else
                            {
                                metodoPago = eMetodoPago.TarjetaDebito;
                            }
                            productoSeleccinadoDataUno = productoSeleccinadoDataUno - (int)numericUpDown1.Value;
                            Venta venta = new Venta(productoSeleccinadoDataUno.Nombre, productoSeleccinadoDataUno.Tipo,
                                productoSeleccinadoDataUno.Precio, precioAGastar, metodoPago, (int)numericUpDown1.Value, clienteSeleccionado.ID,
                                clienteSeleccionado.Nombre);
                            Negocio.CargarVenta(venta);
                            /*  productoSeleccioando.Nombre,productoSeleccioando.Tipo,
                                  productoSeleccioando.Precio, precioAGastar, metodoPago, 
                                  (int)numericUpDown1.Value, usuario.ID, usuario.Nombre*/


                            clienteSeleccionado = clienteSeleccionado - precioAGastar;

                            CargarDataGridView2();
                            listaCliente = Negocio.RetornaListaClientes();
                            listBoxClientes.Items.Clear();
                            CargaListaBoxClientes();
                            labelMostrarSeleccion.Text = clienteSeleccionado.Mostrar();
                            EscribirArchivo.ActualizarArchivo(ventaTotal);
                            Negocio.CargarGastoCliente(clienteSeleccionado);
                        }
                    }
                    else
                    {
                        MessageBox.Show("por favor seleccione el metodo de pago");
                    }
                }
                catch (SaldoInsuficienteException ex)
                {
                    MessageBox.Show($"{ex.Message}. No se pudo validar con el método {ex.TargetSite?.Name}, por favor agregar saldo...");
                }



            }
        }

        /// <summary>
        /// te lleva a la ventana login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button3_Click(object sender, EventArgs e)
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
        public void CargarDataGridView(List<Vacuno> listaDeProductos)
        {
            dataGridViewVaca.Rows.Clear();
            foreach (Vacuno producto in listaDeProductos)
            {
                dataGridViewVaca.Rows.Add(producto.Nombre, producto.Tipo, producto.Precio, producto.RazasDeVacas, producto.CantidadEnInventario);
            }
        }

        public void CargarDataGridView(List<Cerdo> listaDeProductos)
        {
            dataGridViewCerdo.Rows.Clear();
            foreach (Cerdo producto in listaDeProductos)
            {
                dataGridViewCerdo.Rows.Add(producto.Nombre, producto.Tipo, producto.Precio, producto.RazasDeCerdo, producto.CantidadEnInventario);
            }
        }


        /// <summary>
        /// carga la data necesaria en el DataGridView
        /// </summary>
        /// <param name="listaDeProductos"></param>
        public void CargarDataGridView(List<Ave> listaDeProductos)
        {

            dataGridView1.Rows.Clear();
            foreach (Ave producto in listaDeProductos)
            {

                dataGridView1.Rows.Add(producto.Nombre, producto.Tipo, producto.Precio, producto.TipoAve, producto.CantidadEnInventario);



                /*if (producto is Cerdo)
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
                }*/
            }
        }
        /// <summary>
        /// determina a traves de un click la seleccion de un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// determina a traves de un click la seleccion de un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                foreach (Ave producto in listaAve)
                {
                    if (producto.Nombre == dataGridView1.Rows[n].Cells[0].Value.ToString() &&
                        producto.Tipo == dataGridView1.Rows[n].Cells[1].Value.ToString() &&
                        producto.Precio == (float)dataGridView1.Rows[n].Cells[2].Value)
                    {
                        productoSeleccinadoDataUno = producto;

                        MessageBox.Show($"{productoSeleccinadoDataUno.MostrarDetallesDeProducto()}", "Producto seleccionado");
                        break;
                    }
                }
            }
        }

        private void labelMostrarSeleccion_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    dataGridView1.Visible = true;
                    dataGridViewCerdo.Visible = false;
                    dataGridViewVaca.Visible = false;

                    break;
                case 2:
                    dataGridView1.Visible = false;
                    dataGridViewCerdo.Visible = true;
                    dataGridViewVaca.Visible = false;

                    break;
                case 3:
                    dataGridView1.Visible = false;
                    dataGridViewCerdo.Visible = false;
                    dataGridViewVaca.Visible = true;

                    break;

                default:
                    dataGridView1.Visible = false;
                    dataGridViewCerdo.Visible = false;
                    dataGridViewVaca.Visible = false;


                    break;

            }
        }



        private void dataGridViewCerdo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            MessageBox.Show("he llegado");
            if (n != -1)
            {
                foreach (Cerdo producto in listaCerdo)
                {
                    if (producto.Nombre == dataGridViewCerdo.Rows[n].Cells[0].Value.ToString() &&
                        producto.Tipo == dataGridViewCerdo.Rows[n].Cells[1].Value.ToString() &&
                        producto.Precio == (float)dataGridViewCerdo.Rows[n].Cells[2].Value)
                    {
                        productoSeleccinadoDataUno = producto;
                        MessageBox.Show($"{productoSeleccinadoDataUno.MostrarDetallesDeProducto()}", "Producto seleccionado");

                        break;
                    }
                }
            }

        }


        private void dataGridViewVaca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                foreach (Vacuno producto in listaVacuno)
                {
                    if (producto.Nombre == dataGridViewVaca.Rows[n].Cells[0].Value.ToString() &&
                        producto.Tipo == dataGridViewVaca.Rows[n].Cells[1].Value.ToString() &&
                        producto.Precio == (float)dataGridViewVaca.Rows[n].Cells[2].Value)
                    {
                        productoSeleccinadoDataUno = producto;
                        MessageBox.Show($"{productoSeleccinadoDataUno.MostrarDetallesDeProducto()}", "Producto seleccionado");

                        break;
                    }
                }
            }

        }
    }
}
