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

        private void btnVentasXML_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreArchivo = "ventas.xml";
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", nombreArchivo);
                var Serializador = new Serializador<List<Venta>>();
                Serializador.SerializarXML(listaVenta, rutaArchivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo ocurrio en la carga de XML");
            }

        }

        private void btnCSVDeVentas_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreArchivo = "ventas.csv";
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", nombreArchivo);
                var Serializador = new Serializador<List<Venta>>();
                Serializador.SerializarCSV(listaVenta, rutaArchivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo ocurrio en la carga de Csv");
            }


        }

        private void btnVentasJASON_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreArchivo = "ventas.json";
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", nombreArchivo);
                var Serializador = new Serializador<List<Venta>>();
                Serializador.SerializarJSON(listaVenta, rutaArchivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo ocurrio en la carga json");
            }

        }

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

        private void buttonRegresa_Click(object sender, EventArgs e)
        {
            FormAdministracion formAdministracion = new FormAdministracion();
            this.Hide();
            formAdministracion.Show();
        }
    }
}
