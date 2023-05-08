using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerParcial
{

    public partial class FormEditarProductoYStock : Form
    {
        Carne productoSeleccioando;
        List<Carne> listaDeProductos;
        Ave productoAve;
        Cerdo productoCerdo;
        Vacuno productoVacuno;
        public FormEditarProductoYStock()
        {
            InitializeComponent();

        }
        private void FormEditarProductoYStock_Load(object sender, EventArgs e)
        {
            comboBoxTipoAve.DataSource = Enum.GetValues(typeof(Ave.eTipoAve));
            comboBoxRazaVacuno.DataSource = Enum.GetValues(typeof(Vacuno.eRazasDeVacas));
            comboBoxCategoria.DataSource = Enum.GetValues(typeof(Vacuno.eCategoria));
            comboBoxRCerdo.DataSource = Enum.GetValues(typeof(Cerdo.eRazasDeCerdo));
            listaDeProductos = Negocio.RetornarProductos();
            CargarDataGridView(listaDeProductos, productoAve);
            CargarDataGridView(listaDeProductos, productoVacuno);
            CargarDataGridView(listaDeProductos, productoCerdo);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTipoProducto.SelectedIndex)
            {
                case 1:
                    groupBoxAve.Visible = true;
                    groupBoxCerdo.Visible = false;
                    groupBoxVacuno.Visible = false;

                    break;
                case 2:
                    groupBoxAve.Visible = false;
                    groupBoxCerdo.Visible = true;
                    groupBoxVacuno.Visible = false;
                    break;
                case 3:
                    groupBoxAve.Visible = false;
                    groupBoxCerdo.Visible = false;
                    groupBoxVacuno.Visible = true;
                    break;

                default:
                    groupBoxAve.Visible = false;
                    groupBoxCerdo.Visible = false;
                    groupBoxVacuno.Visible = false;

                    break;

            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                foreach (Carne producto in listaDeProductos)
                {
                    if (producto.Nombre == dataGridView1.Rows[n].Cells[0].Value.ToString() &&
                        producto.Tipo == dataGridView1.Rows[n].Cells[1].Value.ToString() &&
                        producto.Precio == (float)dataGridView1.Rows[n].Cells[2].Value)
                    {

                        productoSeleccioando = producto;
                        break;
                    }
                }
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                foreach (Carne producto in listaDeProductos)
                {
                    if (producto.Nombre == dataGridView1.Rows[n].Cells[0].Value.ToString() &&
                        producto.Tipo == dataGridView1.Rows[n].Cells[1].Value.ToString() &&
                        producto.Precio == (float)dataGridView1.Rows[n].Cells[2].Value)
                    {

                        productoSeleccioando = producto;
                        break;
                    }
                }
            }
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                foreach (Carne producto in listaDeProductos)
                {
                    if (producto.Nombre == dataGridView1.Rows[n].Cells[0].Value.ToString() &&
                        producto.Tipo == dataGridView1.Rows[n].Cells[1].Value.ToString() &&
                        producto.Precio == (float)dataGridView1.Rows[n].Cells[2].Value)
                    {

                        productoSeleccioando = producto;
                        break;
                    }
                }
            }
        }

        private void groupBoxCerdo_Enter(object sender, EventArgs e)
        {

        }

        private void buttonlogearte_Click(object sender, EventArgs e)
        {

            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea Logearse", "Atencion", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Puede seguir trabajando, tu labor es motivo de orgullo y excelencia");

            }

        }

        public void CargarDataGridView(List<Carne> listaDeProductos, Ave Ave)
        {

            foreach (Carne producto in listaDeProductos)
            {
                if (producto is Ave)
                {
                    Ave = (Ave)producto;
                    dataGridView1.Rows.Add(Ave.Nombre, Ave.Tipo, Ave.Precio, Ave.TipoAve);
                }

            }
        }
        public void CargarDataGridView(List<Carne> listaDeProductos, Cerdo CarneCerdo)
        {
            foreach (Carne producto in listaDeProductos)
            {
                if (producto is Cerdo)
                {
                    CarneCerdo = (Cerdo)producto;
                    dataGridView2.Rows.Add(CarneCerdo.Nombre, CarneCerdo.Tipo,
                        CarneCerdo.Precio, CarneCerdo.RazasDeCerdo);
                }
            }
        }

        public void CargarDataGridView(List<Carne> listaDeProductos, Vacuno ProductoVaca)
        {
            foreach (Carne producto in listaDeProductos)
            {
                if (producto is Vacuno)
                {
                    ProductoVaca = (Vacuno)producto;
                    dataGridViewVacuno.Rows.Add(ProductoVaca.Nombre, ProductoVaca.Tipo,
                         ProductoVaca.Precio, ProductoVaca.RazasDeVacas);
                }
            }
        }

        private void EditarProducto()
        {
            // Carne nuevoProducto = null;
            float precio;
            //       int cantidadEnInventarioKilos;

            if (productoSeleccioando is not null)
            {
                if (Validaciones.EsNombre(textBoxNombre.Text))
                    productoSeleccioando.Nombre = textBoxNombre.Text;
                if (Validaciones.EsNombre(textBoxTipo.Text))
                    productoSeleccioando.Tipo = textBoxTipo.Text;
                if ((float.TryParse(textBoxPrecio.Text, out precio)))
                    productoSeleccioando.Precio = precio;
                switch (comboBoxTipoProducto.SelectedIndex)
                {
                    case 1:

                        if (productoSeleccioando is Ave)
                        {
                            Ave ProductoA = (Ave)productoSeleccioando;
                            ProductoA.TipoAve = (Ave.eTipoAve)comboBoxTipoAve.SelectedItem;

                        }
                        break;
                    case 2:
                        if (productoSeleccioando is Cerdo)
                        {
                            Cerdo ProductoC = (Cerdo)productoSeleccioando;
                            ProductoC.RazasDeCerdo = (Cerdo.eRazasDeCerdo)comboBoxRCerdo.SelectedItem;
                        }
                        break;
                    case 3:
                        if (productoSeleccioando is Vacuno)
                        {
                            Vacuno ProductoV = (Vacuno)productoSeleccioando;
                            ProductoV.RazasDeVacas = (Vacuno.eRazasDeVacas)comboBoxRazaVacuno.SelectedItem;
                        }
                        break;

                }

            }
            else
                MessageBox.Show("no ha seleccionado ningun producto para editar");
        }

        private void comboBoxTipoProducto_MouseHover_1(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(this.comboBoxTipoProducto, "aqui se selecciona y se cambian los elementos\n" +
                "que estan en la agrupacion, aseegurese de que todo este integrado correctamente \n");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarProducto();
        }

        private void buttonCantidad_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"{productoSeleccioando.CantidadEnInventario}");
            if (productoSeleccioando is not null && Validaciones.EsNumero(textBoxCantidad.Text))
            {
                productoSeleccioando = productoSeleccioando + int.Parse(textBoxCantidad.Text);
                MessageBox.Show($"{productoSeleccioando.CantidadEnInventario}");
            }



        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            FormAdministracion formAdministracion = new();
            this.Hide();
            formAdministracion.Show();
        }
    }
}



