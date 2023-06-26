using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaDeClases.Cerdo;

namespace PrimerParcial
{
    public partial class FormCreacionNuevoProducto : Form
    {
        public FormCreacionNuevoProducto()
        {
            InitializeComponent();
            comboBoxTipoAve.DataSource = Enum.GetValues(typeof(eTipoAve));
            comboBoxRVacuno.DataSource = Enum.GetValues(typeof(eRazasDeVacas));
            comboBoxCategoria.DataSource = Enum.GetValues(typeof(eCategoria));
            comboBoxRCerdo.DataSource = Enum.GetValues(typeof(eRazasDeCerdo));
        }


        /// <summary>
        /// hace visible un grupo que se ha elegido por medio combox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    groupBoxAve.Visible = true;
                    groupBoxCarneCerdo.Visible = false;
                    groupBoxCarneVacuno.Visible = false;

                    break;
                case 2:
                    groupBoxAve.Visible = false;
                    groupBoxCarneCerdo.Visible = true;
                    groupBoxCarneVacuno.Visible = false;
                    break;
                case 3:
                    groupBoxAve.Visible = false;
                    groupBoxCarneCerdo.Visible = false;
                    groupBoxCarneVacuno.Visible = true;
                    break;

            }
        }

        /// <summary>
        /// te lleva a la ventana login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        /// <summary>
        /// te lleva a la ventana de administracion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FormAdministracion formAdministracion = new();
            this.Hide();
            formAdministracion.Show();
        }

        /// <summary>
        /// valida, intancia y agrega un producto nuevo
        /// </summary>
        /// <returns></returns>
        private void CrearProducto()
        {
            
            float precio;
            int cantidadEnInventarioKilos;


            if (comboBox1.Text != "Tipo de Producto" &&
               !(string.IsNullOrEmpty(textBoxNombre.Text))
                && !(string.IsNullOrEmpty(textBoxTipoCarne.Text)) &&
                float.TryParse(textBoxPrecio.Text, out precio) &&
                int.TryParse(textBoxUnidades.Text, out cantidadEnInventarioKilos)
                && cantidadEnInventarioKilos > 0)
            {
                //  MessageBox.Show("llega nulo");
                switch (comboBox1.SelectedIndex)
                {
                    case 1:
                        Ave  nuevoProductoAve = new Ave(0,textBoxNombre.Text, textBoxTipoCarne.Text,
                   precio, cantidadEnInventarioKilos, (eTipoAve)comboBoxTipoAve.SelectedItem);
                        HandlerAve handlerAve = new HandlerAve();
                        handlerAve.Add(nuevoProductoAve);

                        break;
                    case 2:
                        Cerdo nuevoProductoCerdo = new Cerdo(0,textBoxNombre.Text, 
                            textBoxTipoCarne.Text, precio, cantidadEnInventarioKilos, 
                            (eRazasDeCerdo)comboBoxRCerdo.SelectedItem);
                        handlerCerdo handlerCerdo = new handlerCerdo();
                        handlerCerdo.Add(nuevoProductoCerdo);

                        break;
                    case 3:
                        Vacuno nuevoProductoVaca = new Vacuno(0, textBoxNombre.Text, textBoxTipoCarne.Text,
                        precio, cantidadEnInventarioKilos,
                        (eRazasDeVacas)comboBoxRVacuno.SelectedItem,
                        (eCategoria)comboBoxCategoria.SelectedItem);
                        HanblerVacuno hanblerVacuno = new HanblerVacuno();
                        hanblerVacuno.Add(nuevoProductoVaca);
                        
                        break;

                }




            }
        
        }


        /// <summary>
        /// este boton le da el acepte para poder crar el producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCrearProducto_Click(object sender, EventArgs e)
        {
            List<Carne> lista = Negocio.RetornarProductos();
            Carne nuevoProducto = CrearProducto();
            DialogResult Respuesta = new();
            if (nuevoProducto != null)
            {
                lista.Add(nuevoProducto);
                
                Respuesta = MessageBox.Show("Ha editado exitosamente, desea logearse o seguir", "Atencion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (Respuesta == DialogResult.Yes)
                {
                    this.Hide();
                    FrmLogin login = new();
                    login.Show();

                }

            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
