using BibliotecaDeClases;
//using FrmParcial;
using System.Windows.Forms.VisualStyles;
using System.Media;
using System.ComponentModel.Design.Serialization;

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
            SoundPlayer sonido = new SoundPlayer();
            sonido.SoundLocation = "C:/Users/kervi/source/repos/PP2DLaboratorio/sonidoAplicacion.wav";
            sonido.Play();
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

                    MessageBox.Show("gracias por tu trabajo");

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
            if (resultado == false)
            {
                SoundPlayer sonido = new SoundPlayer();
                sonido.SoundLocation = "C:/Users/kervi/source/repos/PP2DLaboratorio/sonidoAplicacion.wav";
                sonido.Play();
                textBoxCorreo.Text = "KervinBriceño@gmail.com";
                textBoxContraseña.Text = "123456";
            }
            else
            {
                SoundPlayer sonido = new SoundPlayer();
                sonido.SoundLocation = "C:/Users/kervi/source/repos/PP2DLaboratorio/sonidoAplicacion.wav";
                sonido.Play();
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