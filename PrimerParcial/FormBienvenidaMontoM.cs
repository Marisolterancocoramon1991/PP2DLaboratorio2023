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
using System.IO;

namespace PrimerParcial
{
    public partial class FormBienvenidaMontoM : Form
    {
        Cliente? cliente;
        FormVentas formVentas;
        public FormBienvenidaMontoM(Persona usuario)
        {
            InitializeComponent();
        //    if (usuario is not null) {
                this.cliente = (Cliente)usuario;
        //    }
           

        }

        private void FormBienvenidaMontoM_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*     string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
                 string rutaRelativa = "Resources/sonidoAplicacion.wav";
                 string rutaCompleta = Path.Combine(rutaBase, rutaRelativa);
                 SoundPlayer sonido = new SoundPlayer(rutaCompleta);

                 sonido.Play();*/

            // Ruta relativa del archivo de sonido
            string relativePath = @".\sonidoAplicacion.wav";

            // Ruta completa del archivo de sonido
            string fullPath = Path.Combine(Application.StartupPath, relativePath);

            // Verificar si el archivo existe en la ruta especificada
            if (File.Exists(fullPath))
            {
                // Crear un objeto SoundPlayer con la ruta del archivo
                SoundPlayer player = new SoundPlayer(fullPath);

                // Reproducir el archivo de sonido
                player.Play();
            }
            else
            {
                // Mostrar espera ya que el archvo no pudo abrir...
                MessageBox.Show("...espere unos instantes");
            }





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
