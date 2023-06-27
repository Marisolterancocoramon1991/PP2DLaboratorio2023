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
using System.Diagnostics;

namespace PrimerParcial
{
    public partial class FormVentaDeCarne : Form
    {
        Cliente usuario;
        string tipoListaMostrar;
        //  Queue<Cliente> colaClientes;
        List<Ave> listaDeAve;
        List<Cerdo> listaDeCerdo;
        List<Vacuno> listaDeVacuno;
        Carne productoSeleccioando;
        List<Venta> listVentaCliente;
        List<Venta> ventaTotal;
        public FormVentaDeCarne(Cliente usuario, string tipoListaMostrar)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.tipoListaMostrar = tipoListaMostrar;
            RegistroAcceso registro = new RegistroAcceso(usuario.Nombre, "formulario factura");
            this.Load += registro.OnFrmAbierto;
            this.FormClosed += registro.OnFrmCerrado;

        }

        /// <summary>
        /// carga todos los elementos de l ventana
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void FormVentaDeCarne_Load(object sender, EventArgs e)
        {
            listaDeAve = Negocio.RetornarListaAve();
            listaDeCerdo = Negocio.RetornarListaCerdo();
            listaDeVacuno = Negocio.RetornarListaVacuno();
            CargarDataGridView(listaDeAve);
            CargarDataGridView(listaDeCerdo);
            CargarDataGridView(listaDeVacuno);
            labelNombre.Text = usuario.Nombre;
            labelDinero.Text = usuario.Saldo.ToString();
            listVentaCliente = new List<Venta>();
            switch (tipoListaMostrar)
            {
                case "Cerdo":
                    dataGridViewVacuno.Visible = false;
                    dataGridViewCerdo.Visible = true;
                    dataGridView1.Visible = false;
                    comboBox1.SelectedIndex = 1;
                    break;
                case "Vaca":
                    dataGridViewVacuno.Visible = true;
                    dataGridViewCerdo.Visible = false;
                    dataGridView1.Visible = false;
                    comboBox1.SelectedIndex = 2;
                    break;
                case "Ave":
                    dataGridViewVacuno.Visible = false;
                    dataGridViewCerdo.Visible = false;
                    dataGridView1.Visible = true;
                    comboBox1.SelectedIndex = 0;
                    break;


            }
        }
        /// <summary>
        /// carga el producto a traves de un click 
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int n = e.RowIndex;

            if (n != -1 && listaDeAve != null)
            {
                DataGridViewRow selectedRow;
                try
                {
                    selectedRow = dataGridView1.Rows[n];
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al seleccionar la fila.");
                    return;
                }


                DataGridViewCell nombreCell = selectedRow.Cells[0];
                DataGridViewCell tipoCell = selectedRow.Cells[1];
                DataGridViewCell precioCell = selectedRow.Cells[2];

                if (nombreCell.Value != null && tipoCell.Value != null && precioCell.Value != null)
                {
                    string nombre = nombreCell.Value.ToString();
                    string tipo = tipoCell.Value.ToString();

                    if (float.TryParse(precioCell.Value.ToString(), out float precio))
                    {
                        foreach (Ave producto in listaDeAve)
                        {
                            if (producto.Nombre == nombre && producto.Tipo == tipo && producto.Precio == precio)
                            {
                                productoSeleccioando = producto;
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor del precio no es válido.");
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó un producto válido.");
                }
            }
            else
            {
                MessageBox.Show("Debes elegir un tipo de lista antes de editar el producto.");
            }
        }


        public void CargarDataGridView(List<Cerdo> listaDeCerdo)
        {

            dataGridViewCerdo.Rows.Clear();
            foreach (Cerdo cerdo in listaDeCerdo)
            {

                dataGridViewCerdo.Rows.Add(cerdo.Nombre, cerdo.Tipo, cerdo.Precio, cerdo.RazasDeCerdo);

            }
        }

        /// <summary>
        /// recibe una lista de objetos de la clase padre Carne y muestra los datos de estos objetos en un DataGridView. 
        /// Además, verifica si los objetos de la lista son de las clases hijas Cerdo, Ave o Vacuno
        /// </summary>
        /// <param name="listaDeProductos"></param>  es una lista de objetos de la clase padre Carne.
        public void CargarDataGridView(List<Ave> listaDeAve)
        {

            dataGridView1.Rows.Clear();
            foreach (Ave ave in listaDeAve)
            {

                dataGridView1.Rows.Add(ave.Nombre, ave.Tipo, ave.Precio, ave.TipoAve);
            }
        }

        public void CargarDataGridView(List<Vacuno> listaDeVaca)
        {

            dataGridViewVacuno.Rows.Clear();
            foreach (Vacuno vaca in listaDeVaca)
            {
                dataGridViewVacuno.Rows.Add(vaca.Nombre, vaca.Tipo, vaca.Precio, vaca.RazasDeVacas);
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

            if (Validaciones.IsNotNull(productoSeleccioando) && Validaciones.NumeroMayorAcero(productoSeleccioando.CantidadEnInventario) && Validaciones.NumeroMayorAcero((int)numericUpDown1.Value) && productoSeleccioando.CantidadEnInventario >= (int)numericUpDown1.Value && Validaciones.IsNotNull(usuario))
            {
                precioAGastar = productoSeleccioando.Precio * (int)numericUpDown1.Value;

                try
                {
                    usuario.ComprarProductoValidacion(precioAGastar);

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
                            precioAGastar = productoSeleccioando.Precio * (int)numericUpDown1.Value;
                            Venta venta = new Venta(productoSeleccioando.Nombre, productoSeleccioando.Tipo,
                                productoSeleccioando.Precio, precioAGastar, metodoPago,
                                (int)numericUpDown1.Value, usuario.ID, usuario.Nombre);
                            Negocio.CargarVenta(venta);
                            Negocio.CargarVenta(listVentaCliente, venta);
                            // List<Venta> listaCompletaVenta = Negocio.RetornarListaDeVentas();
                            ventaTotal = Negocio.RetornarListaDeVentas();
                            productoSeleccioando = productoSeleccioando - (int)numericUpDown1.Value;

                            usuario = usuario - precioAGastar;
                            labelDinero.Text = usuario.Saldo.ToString();
                            EscribirArchivo.ActualizarArchivo(listVentaCliente);
                            Negocio.CargarGastoCliente(usuario);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione el método de pago.");
                    }
                }
                catch (SaldoInsuficienteException ObjetoException)
                {
                    MessageBox.Show($"{ObjetoException.Message}. No se pudo validar con el método {ObjetoException.TargetSite?.Name}, por favor agregar saldo...");
                }
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
            switch (comboBox1.SelectedIndex)
            {
                case 0:  // Aquí se realiza la búsqueda utilizando una lista de objetos llamada "productos".
                    List<Ave> productosEncontradosAve = listaDeAve.Where(p => p.Nombre.Contains(TerminoABuscar)).ToList();
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = productosEncontradosAve;
                    dataGridView1.Refresh();

                    break;
                case 1:
                    List<Cerdo> productosEncontradosCerdo = listaDeCerdo.Where(p => p.Nombre.Contains(TerminoABuscar)).ToList();
                    dataGridViewCerdo.Columns.Clear();
                    dataGridViewCerdo.DataSource = productosEncontradosCerdo;
                    dataGridViewCerdo.Refresh();
                    break;
                case 2:
                    List<Vacuno> productosEncontradosVaca = listaDeVacuno.Where(p => p.Nombre.Contains(TerminoABuscar)).ToList();
                    dataGridViewVacuno.Columns.Clear();
                    dataGridViewVacuno.DataSource = productosEncontradosVaca;
                    dataGridViewVacuno.Refresh();
                    break;

            }

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

        private void groupCerdo_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridViewVacuno.Visible = false;
                    dataGridViewCerdo.Visible = false;
                    dataGridView1.Visible = true;
                    break;
                case 1:
                    dataGridViewVacuno.Visible = false;
                    dataGridViewCerdo.Visible = true;
                    dataGridView1.Visible = false;
                    break;

                case 2:
                    dataGridViewVacuno.Visible = true;
                    dataGridViewCerdo.Visible = false;
                    dataGridView1.Visible = false;
                    break;



            }
        }

        private void dataGridViewVacuno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1 && listaDeVacuno != null)
            {
                DataGridViewRow selectedRow;
                try
                {
                    selectedRow = dataGridViewVacuno.Rows[n];
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al seleccionar la fila.");
                    return;
                }


                DataGridViewCell nombreCell = selectedRow.Cells[0];
                DataGridViewCell tipoCell = selectedRow.Cells[1];
                DataGridViewCell precioCell = selectedRow.Cells[2];

                if (nombreCell.Value != null && tipoCell.Value != null && precioCell.Value != null)
                {
                    string nombre = nombreCell.Value.ToString();
                    string tipo = tipoCell.Value.ToString();

                    if (float.TryParse(precioCell.Value.ToString(), out float precio))
                    {
                        foreach (Vacuno producto in listaDeVacuno)
                        {
                            if (producto.Nombre == nombre && producto.Tipo == tipo && producto.Precio == precio)
                            {
                                productoSeleccioando = producto;

                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor del precio no es válido.");
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó un producto válido.");
                }
            }
            else
            {
                MessageBox.Show("Debes elegir un tipo de lista antes de editar el producto.");
            }

        }

        private void dataGridViewCerdo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1 && listaDeVacuno != null)
            {
                DataGridViewRow selectedRow;
                try
                {
                    selectedRow = dataGridViewCerdo.Rows[n];
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al seleccionar la fila.");
                    return;
                }


                DataGridViewCell nombreCell = selectedRow.Cells[0];
                DataGridViewCell tipoCell = selectedRow.Cells[1];
                DataGridViewCell precioCell = selectedRow.Cells[2];

                if (nombreCell.Value != null && tipoCell.Value != null && precioCell.Value != null)
                {
                    string nombre = nombreCell.Value.ToString();
                    string tipo = tipoCell.Value.ToString();

                    if (float.TryParse(precioCell.Value.ToString(), out float precio))
                    {
                        foreach (Cerdo producto in listaDeCerdo)
                        {
                            if (producto.Nombre == nombre && producto.Tipo == tipo && producto.Precio == precio)
                            {
                                productoSeleccioando = producto;

                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor del precio no es válido.");
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó un producto válido.");
                }
            }
            else
            {
                MessageBox.Show("Debes elegir un tipo de lista antes de editar el producto.");
            }

        }
    }
}


