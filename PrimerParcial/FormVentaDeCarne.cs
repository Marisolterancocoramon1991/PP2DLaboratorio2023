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
using System.Linq;

namespace PrimerParcial
{
    public partial class FormVentaDeCarne : Form
    {
        Cliente usuario;
        //  Queue<Cliente> colaClientes;
        List<Carne> listaDeProductos;
        Carne productoSeleccioando;
        List<Venta> listVentaCliente;

        public FormVentaDeCarne(Cliente usuario) 
        {
            InitializeComponent();
            this.usuario = usuario;


        }

        /// <summary>
        /// carga todos los elementos de l ventana
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void FormVentaDeCarne_Load(object sender, EventArgs e)
        {
            listaDeProductos = Negocio.RetornarProductos();
            CargarDataGridView(listaDeProductos);
            labelNombre.Text = usuario.Nombre;
            labelDinero.Text = usuario.Saldo.ToString();
            listVentaCliente = new List<Venta>();
        }
        /// <summary>
        /// carga el producto a traves de un click 
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
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
        /// sirve para hacer las compras 
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirmarVenta;
            float precioAGastar;
            //  MessageBox.Show(productoSeleccioando.MostrarDetallesDeProducto());
            if (Validaciones.IsNotNull(productoSeleccioando) && productoSeleccioando.CantidadEnInventario > 0 && (int)numericUpDown1.Value > 0
                && productoSeleccioando.CantidadEnInventario
                >= (int)numericUpDown1.Value && Validaciones.IsNotNull(usuario) && usuario.Saldo >=
                productoSeleccioando.Precio * (int)numericUpDown1.Value)
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
                            Venta venta = new Venta(productoSeleccioando,
                              Venta.eMetodoPago.MercadoPago, (int)numericUpDown1.Value, usuario.ID);
                            Negocio.CargarVenta(venta);
                            Negocio.CargarVenta(listVentaCliente, venta);
                        }
                        else if (radioButtonTarjetaC.Checked == true)
                        {
                            Venta venta = new Venta(productoSeleccioando,
                                Venta.eMetodoPago.TarjetaDeCredito, (int)numericUpDown1.Value,usuario.ID);
                            Negocio.CargarVenta(venta);
                            Negocio.CargarVenta(listVentaCliente, venta);

                        }
                        else
                        {
                            Venta venta = new Venta(productoSeleccioando,
                                Venta.eMetodoPago.TarjetaDebito, (int)numericUpDown1.Value, usuario.ID);
                            Negocio.CargarVenta(venta);
                            Negocio.CargarVenta(listVentaCliente, venta);
                        }

                        productoSeleccioando = productoSeleccioando - (int)numericUpDown1.Value;

                        precioAGastar = productoSeleccioando * (int)numericUpDown1.Value;
                        usuario = usuario - precioAGastar;
                        labelDinero.Text = usuario.Saldo.ToString();


                    }

                }
                else
                {
                    MessageBox.Show("por favor seleccione el metodo de pago");
                }

            }
            else
            {

                MessageBox.Show("hubo un error en la compra");


            }


        }
        /// <summary>
        /// abre la ventaa buscador de ventana 
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void button2_Click(object sender, EventArgs e)
        {
            if (usuario is not null)
            {
                FormBuscadorCarnes frmVentas = new FormBuscadorCarnes(usuario);
                this.Hide();
                frmVentas.Show();
            }
            else
            {
                Application.Exit();
            }

        }

        /// <summary>
        /// logea al usuario 
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
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


        /// <summary>
        /// busca en la lista de productos coincidencias y las imprime en la data 
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string TerminoABuscar = textBuscador.Text;

            // Aquí se realiza la búsqueda utilizando una lista de objetos llamada "productos".
            List<Carne> productosEncontrados = listaDeProductos.Where(p => p.Nombre.Contains(TerminoABuscar)).ToList();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = productosEncontrados;
            dataGridView1.Refresh();
        }
        /// <summary>
        /// carga cola cliente y abre la ventana de factura
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void buttonFactura_Click(object sender, EventArgs e)
        {
            FormFacturaVenta formFacturaVenta = new(usuario, listVentaCliente);
            Negocio.CargarColaClientes(usuario);
            this.Hide();
            formFacturaVenta.Show();
        }

     
    }
}


