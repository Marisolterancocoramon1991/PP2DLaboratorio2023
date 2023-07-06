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
    public partial class informesVentasForm1 : Form
    {
        List<Venta> listaVenta;

        public informesVentasForm1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Ventas XML".
        /// Serializa la lista de ventas en un archivo XML.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnVentasXML_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreArchivo = "ventas.xml";
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", nombreArchivo);
                var Serializador = new Serializador<List<Venta>>();
                Serializador.SerializarXML(listaVenta, rutaArchivo);
                MessageBox.Show("la accion se ha ejecutado Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo ocurrio en la carga de XML");
            }

        }

        /// <summary>
        /// Maneja el evento de clic en el botón "CSV de Ventas".
        /// Serializa la lista de ventas en un archivo CSV.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnCSVDeVentas_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreArchivo = "ventas.csv";
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", nombreArchivo);
                var Serializador = new Serializador<List<Venta>>();
                Serializador.SerializarCSV(listaVenta, rutaArchivo);
                MessageBox.Show("la accion se ha ejecutado Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo ocurrio en la carga de Csv");
            }


        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Ventas JSON".
        /// Serializa la lista de ventas en un archivo JSON.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnVentasJASON_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreArchivo = "ventas.json";
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", nombreArchivo);
                var Serializador = new Serializador<List<Venta>>();
                Serializador.SerializarJSON(listaVenta, rutaArchivo);
                MessageBox.Show("la accion se ha ejecutado Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo ocurrio en la carga json");
            }

        }
        /// <summary>
        /// Maneja el evento de carga del formulario "informesVentasForm1".
        /// Carga la lista de ventas desde el negocio.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void informesVentasForm1_Load(object sender, EventArgs e)
        {
            try
            {
                listaVenta = Negocio.RetornarListaDeVentas();
            }
            catch (Exception)
            {
                MessageBox.Show("algo ocurrio en la carga de la lista");
            }

        }

        /// <summary>
        /// Maneja el evento de clic del botón "Regresa".
        /// Muestra el formulario "FormAdministracion" y oculta el formulario actual.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void buttonRegresa_Click(object sender, EventArgs e)
        {
            FormAdministracion formAdministracion = new FormAdministracion();
            this.Hide();
            formAdministracion.Show();
        }
    }
}
