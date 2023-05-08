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
        FormBuscadorCarnes formVentas;
        public FormBienvenidaMontoM(Persona usuario)
        {
            InitializeComponent();

            this.cliente = (Cliente)usuario;



        }


        /// <summary>
        /// valida si la informacion ingresada es mayor a 1000 y si 
        /// es numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

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

            if (Validaciones.DeStringANumero(textBoxAgregarMonto.Text) > 1000)
            {


                if (cliente is not null)
                {

                    cliente.Saldo = Validaciones.DeStringANumero(textBoxAgregarMonto.Text);
                    MessageBox.Show(cliente.Mostrar());
                    formVentas = new FormBuscadorCarnes(cliente);
                    formVentas.Show();
                    this.Hide();


                }

            }
        }


    }
}
