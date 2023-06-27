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
        List<Cliente> listaCliente;
        List<Vendedor> listaVendedores;
        List<Ave> listaAve;
        List<Cerdo> listaCerdo;
        List<Vacuno> listaVacuno;
        FormBienvenidaMontoM? formBienvenidaMonto;
        public FrmLogin()
        {
            InitializeComponent();
            string stringVentas = LecturaArchivo.leerArchivosVentas();
            List<string> listaStringVenta = LecturaArchivo.CrearListasStringVentas(stringVentas);
            Parser.ParsearProductos(listaStringVenta);
            if (listaCliente is null || listaAve is null || listaCerdo is null
                || listaVacuno is null || listaVendedores is null) 
            {
               try
              {
                    listaAve = ControllerConexion.ConectarProductosAveDB();
                    listaCerdo = ControllerConexion.ConectarProductosCerdoDB();
                    listaVacuno =ControllerConexion.ConectarProductosVacunoDB();
                    listaCliente = ControllerConexion.ConectarUsuariosClienteDB();
                    listaVendedores = ControllerConexion.ConectarUsuariosTrabajadorDB();
                    Negocio.CargaListaClientes(listaCliente);
                    Negocio.CargarListaTrabajadores(listaVendedores);
                    Negocio.CargaListaAves(listaAve);
                    Negocio.CargaListaCerdo(listaCerdo);
                    Negocio.CargaListaVacuno(listaVacuno);


               }
                catch (Exception) 
                {
                    MessageBox.Show("hubo un error en ña carga de la lista");
                }
                

            }
           
            
          

        }
        /// <summary>
        /// boton para ocultar la clave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //imagen mostrar la mandamos al frente
            pictureMostrar.BringToFront();
            // mostramos la contraseña
            textBoxContraseña.PasswordChar = '*';

        }
        /// <summary>
        /// boton para mostrar la clave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pictureOcultar.BringToFront();
            //
            textBoxContraseña.PasswordChar = '\0';
        }
        /// <summary>
        /// llama una funcion que compara contraseña y correo y si es cierto t abre la ventana 
        /// especial para vendedor o cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            auxiliar = Negocio.LogearUsuario(textBoxCorreo.Text, textBoxContraseña.Text, listaCliente,listaVendedores);
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

                if (auxiliar.TipoDeUsuario == eTipoDeUsuario.Cliente)
                {
                    formBienvenidaMonto = new FormBienvenidaMontoM(auxiliar);
                    formBienvenidaMonto.Show();
                    this.Hide();//oculta esta ventana
                    //  this.Close();
                }
                if (auxiliar.TipoDeUsuario == eTipoDeUsuario.Vendedor)
                {
                    Vendedor vendedor = (Vendedor)auxiliar;
                    vendedor.CargarTrabajadores();
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


        /// <summary>
        /// depende de lo que se elija se auto completa textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


                textBoxCorreo.Text = "martaFb@hotmail.com";
                textBoxContraseña.Text = "21321deded";
            }
            else
            {

                textBoxCorreo.Text = "laCabrasMortal@gmail.com";
                textBoxContraseña.Text = "losSueñs1";

            }
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}