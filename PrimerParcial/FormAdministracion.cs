using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class FormAdministracion : Form
    {
        Vendedor vendedor;
        public FormAdministracion()
        {
            InitializeComponent();
            vendedor = Negocio.RetornaVendedor();
        }


        /// <summary>
        ///  oculta esta ventana y levanta la ventana de nuevos productos
        ///  /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void buttonCrearProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCreacionNuevoProducto formCreacionNuevoProducto = new();
            formCreacionNuevoProducto.Show();

        }
        /// <summary>
        ///  oculta esta ventana y levanta y levanta editar producto
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEditarProductoYStock formEditarProductoYStock = new();
            formEditarProductoYStock.Show();
        }
        /// <summary>
        /// oculta esta ventana y levanta la ventan del cliente
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void buttonVender_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentaAlCliente formVentaAlCliente = new();
            formVentaAlCliente.Show();
        }

        /// <summary>
        /// oculta esta ventana y levanta la ventan de heladera
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void buttonHeladera_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHeladera formHeladera = new();
            formHeladera.Show();
        }

        /// <summary>
        /// oculta esta ventana y levanta la ventan del login
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void buttonLogearte_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin formLogin = new();
            formLogin.Show();
        }
        /// <summary>
        /// si le das click entrega las ventas totales del negocio
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void labelMontoVentasTotales_Click(object sender, EventArgs e)
        {
            labelMontoVentasTotales.Text = "Ganancias totales del mes"
                + Negocio.GananciaTotal().ToString();
        }

        /// <summary>
        /// carga la ventana
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void FormAdministracion_Load(object sender, EventArgs e)
        {
            labelMontoVentasTotales.Text = "haz clock aqui para conocer las ganancias totales";
        }
        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "button1".
        /// Oculta el formulario actual y muestra el formulario de administración de clientes.
        /// </summary>
        /// <param name="sender">Objeto que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarCliente administrarCliente = new();
            administrarCliente.Show();
        }
        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "buttonArchivo".
        /// Oculta el formulario actual y muestra el formulario de informes de ventas.
        /// </summary>
        /// <param name="sender">Objeto que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void buttonArchivo_Click(object sender, EventArgs e)
        {
            this.Hide();
            informesVentasForm1 informes = new();
            informes.Show();
        }
        /// <summary>
        /// Evento que se ejecuta al hacer clic en el control "label1".
        /// Actualiza el texto del control con el resultado de la comprobación del salario del vendedor.
        /// </summary>
        /// <param name="sender">Objeto que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = vendedor.SalarioMayorA(10000).ToString();
        }
    }
}
