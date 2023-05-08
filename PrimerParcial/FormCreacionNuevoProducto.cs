﻿using BibliotecaDeClases;
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
            comboBoxTipoAve.DataSource = Enum.GetValues(typeof(Ave.eTipoAve));
            comboBoxRVacuno.DataSource = Enum.GetValues(typeof(Vacuno.eRazasDeVacas));
            comboBoxCategoria.DataSource = Enum.GetValues(typeof(Vacuno.eCategoria));
            comboBoxRCerdo.DataSource = Enum.GetValues(typeof(Cerdo.eRazasDeCerdo));
        }

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

        private void FormCreacionNuevoProducto_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdministracion formAdministracion = new();
            this.Hide();
            formAdministracion.Show();
        }

        private Carne CrearProducto()
        {
            Carne nuevoProducto = null;
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
                        nuevoProducto = new Ave(textBoxNombre.Text, textBoxTipoCarne.Text,
                   precio, cantidadEnInventarioKilos, (Ave.eTipoAve)comboBoxTipoAve.SelectedItem);


                        break;
                    case 2:
                        nuevoProducto = new Cerdo(textBoxNombre.Text, textBoxTipoCarne.Text, precio, cantidadEnInventarioKilos, (Cerdo.eRazasDeCerdo)comboBoxRCerdo.SelectedItem);

                        break;
                    case 3:
                        nuevoProducto = new Vacuno(textBoxNombre.Text, textBoxTipoCarne.Text,
                        precio, cantidadEnInventarioKilos,
                        (Vacuno.eRazasDeVacas)comboBoxRVacuno.SelectedItem,
                        (Vacuno.eCategoria)comboBoxCategoria.SelectedItem);
                        break;

                }




            }
            return nuevoProducto;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRazasVacuno_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCategoria_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxCarneCerdo_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrearProducto_Click(object sender, EventArgs e)
        {
            List<Carne> lista = Negocio.RetornarProductos();
            Carne nuevoProducto = CrearProducto();
            DialogResult Respuesta = new();
            if (nuevoProducto != null)
            {
                lista.Add(nuevoProducto);
                Respuesta = MessageBox.Show("Desea logearse o seguir creando productos", "Atencion", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (Respuesta == DialogResult.Yes)
                {
                    this.Hide();
                    FrmLogin login = new();
                    login.Show();

                }

            }
        }
    }
}
