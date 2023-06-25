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
            var Serializador = new Serializador<List<Venta>>();
            Serializador.SerializarXML(listaVenta,"ventas.xml");
        }

        private void btnCSVDeVentas_Click(object sender, EventArgs e)
        {
            var Serializador = new Serializador<List<Venta>>();
            Serializador.SerializarCSV(listaVenta, "ventas.xml");

        }

        private void btnVentasJASON_Click(object sender, EventArgs e)
        {
            var Serializador = new Serializador<List<Venta>>();
            Serializador.SerializarJSON(listaVenta, "ventas.xml");
        }

        private void informesVentasForm1_Load(object sender, EventArgs e)
        {
            listaVenta=Negocio.RetornarListaDeVentas();
        }
    }
}
