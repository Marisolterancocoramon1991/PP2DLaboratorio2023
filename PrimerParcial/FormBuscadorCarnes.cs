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
    public partial class FormBuscadorCarnes : Form
    {
        Cliente? usuario;
     //   Queue<Cliente> colaClientes;
        List<Carne> listaDeProductos;

        public FormBuscadorCarnes(Cliente cliente)
        {
            InitializeComponent();
            usuario = cliente;
            Validaciones.IsNotNull(usuario);
            listaDeProductos = Negocio.RetornarProductos();
         //   colaClientes = Negocio.RetornarClientes();
            this.usuario = cliente;

        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            FormVentaDeCarne ventanaCerdo = new FormVentaDeCarne(usuario);

            this.Hide();
            ventanaCerdo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            FormVentaDeCarne ventanaVentaCarne = new FormVentaDeCarne(usuario);

            this.Hide();
            ventanaVentaCarne.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
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
            FormVentaDeCarne ventanaVentaCarne = new FormVentaDeCarne(usuario);
            this.Hide();
            ventanaVentaCarne.Show();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxEleccion_Enter(object sender, EventArgs e)
        {

        }
    }
}
