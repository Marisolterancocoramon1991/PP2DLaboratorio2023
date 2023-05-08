using BibliotecaDeClases;
//using FrmParcial;
using System.Windows.Forms.VisualStyles;
using System.Media;
using System.ComponentModel.Design.Serialization;
using Microsoft.VisualBasic.ApplicationServices;
using PrimerParcial.Properties;
using System.Numerics;

namespace PrimerParcial

{
    public partial class FrmLogin : Form
    {
        Persona? auxiliar;

        FormBienvenidaMontoM? formBienvenidaMonto;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //imagen mostrar la mandamos al frente
            pictureMostrar.BringToFront();
            // mostramos la contraseña
            textBoxContraseña.PasswordChar = '*';

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pictureOcultar.BringToFront();
            //
            textBoxContraseña.PasswordChar = '\0';
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            auxiliar = Negocio.LogearUsuario(textBoxCorreo.Text, textBoxContraseña.Text);
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

            if (auxiliar != null)
            {

                if (auxiliar.TipoDeUsuario == Persona.eTipoDeUsuario.Cliente)
                {
                    formBienvenidaMonto = new FormBienvenidaMontoM(auxiliar);
                    formBienvenidaMonto.Show();
                    this.Hide();//oculta esta ventana
                    //  this.Close();
                }
                if (auxiliar.TipoDeUsuario == Persona.eTipoDeUsuario.Vendedor)
                {
                  
                    FormAdministracion formAdministracion = new();
                    MessageBox.Show("gracias por tu trabajo");
                    this.Hide();
                    formAdministracion.Show(); ;
                }


            }
            else
            {
                labelInformacionError.Text = "error, ingresar nuevamente";
            }
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool resultado = Usuario.Text.Equals("Trabajador");
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
            if (resultado == false)
            {


                textBoxCorreo.Text = "KervinBriceño@gmail.com";
                textBoxContraseña.Text = "123456";
            }
            else
            {

                textBoxCorreo.Text = "LucasBriceño@gmial.com";
                textBoxContraseña.Text = "123456789";

            }
        }

        private void Carniceria_Enter(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}