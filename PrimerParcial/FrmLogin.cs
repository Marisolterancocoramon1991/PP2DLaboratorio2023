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
            // mostramos la contrase�a
            textBoxContrase�a.PasswordChar = '*';

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pictureOcultar.BringToFront();
            //
            textBoxContrase�a.PasswordChar = '\0';
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            auxiliar = Negocio.LogearUsuario(textBoxCorreo.Text, textBoxContrase�a.Text);

            if (auxiliar != null)
            {
               
                if (auxiliar.TipoDeUsuario == Persona.eTipoDeUsuario.Cliente)
                {
                    formBienvenidaMonto = new FormBienvenidaMontoM();
                    labelContrase�a.Text = "CASA";
                    
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
                textBoxCorreo.Text = "KervinBrice�o@gmail.com";
                textBoxContrase�a.Text = "123456";
            }
            else
            {
                textBoxCorreo.Text = "LucasBrice�o@gmial.com";
                textBoxContrase�a.Text = "123456789";

            }
        }
    }
}