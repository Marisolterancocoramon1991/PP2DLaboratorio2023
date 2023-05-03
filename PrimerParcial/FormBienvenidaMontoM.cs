using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class FormBienvenidaMontoM : Form
    {
        Cliente? cliente;
        FormVentas formVentas;
        public FormBienvenidaMontoM(Persona usuario)
        {
            InitializeComponent();
            if (usuario is not null) {
                cliente = (Cliente)usuario;
            }
           

        }

        private void FormBienvenidaMontoM_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer();
            sonido.SoundLocation = "C:/Users/kervi/source/repos/PP2DLaboratorio/sonidoAplicacion.wav";
            sonido.Play();
            
            if (Validaciones.DeStringANumero(textBoxAgregarMonto.Text) > 0)
            {
                if (cliente is not null) {
                    cliente.Saldo = Validaciones.DeStringANumero(textBoxAgregarMonto.Text);
                    MessageBox.Show(cliente.Mostrar());
                    formVentas = new FormVentas(cliente);
                    formVentas.Show();
                    this.Hide();
                }
            }

        }

        private void groupBienvenida_Enter(object sender, EventArgs e)
        {

        }
    }
}
