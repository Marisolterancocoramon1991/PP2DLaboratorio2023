using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class FormAdministracion : Form
    {
        public FormAdministracion()
        {
            InitializeComponent();
        }

        private void buttonCrearProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCreacionNuevoProducto formCreacionNuevoProducto = new();
            formCreacionNuevoProducto.Show();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEditarProductoYStock formEditarProductoYStock = new();
            formEditarProductoYStock.Show();
        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentaAlCliente formVentaAlCliente =new();
            formVentaAlCliente.Show();  
        }

        private void buttonHeladera_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHeladera formHeladera = new();
            formHeladera.Show();    
        }

        private void buttonLogearte_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin formLogin = new();
            formLogin.Show();
        }
    }
}
