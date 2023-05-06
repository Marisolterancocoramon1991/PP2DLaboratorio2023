﻿using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace PrimerParcial
{
    public partial class FormVentaDeCarne : Form
    {
        Cliente usuario;
//Queue<Cliente> colaClientes;
        List<Carne> listaDeProductos;
        Carne productoSeleccioando;

        public FormVentaDeCarne(Cliente usuario/*, List<Carne> listaDeProductos*/) //: base (usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
//this.colaClientes = colaClientes;
             listaDeProductos = Negocio.RetornarProductos();
            CargarDataGridView(listaDeProductos);
            labelNombre.Text = usuario.Nombre;
            labelDinero.Text = usuario.Saldo.ToString();
            


        }

        private void groupCerdo_Enter(object sender, EventArgs e)
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
        public void CargarDataGridView(List<Carne> listaDeProductos)
        {

            foreach (Carne producto in listaDeProductos)
            {
                //   if (producto is Cerdo)
                // {
                //   Cerdo prodct = (Cerdo)producto;
                dataGridView1.Rows.Add(producto.Nombre, producto.Tipo, producto.Precio, producto.CantidadEnInventario);

                //                }

            }
        }
        /// <summary>
        /// sirve para hacer las compras 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirmarVenta;
            float precioAGastar;
            //  MessageBox.Show(productoSeleccioando.MostrarDetallesDeProducto());
            if (Validaciones.IsNotNull(productoSeleccioando) && productoSeleccioando.CantidadEnInventario > 0 && (int)numericUpDown1.Value > 0
                && productoSeleccioando.CantidadEnInventario
                >= (int)numericUpDown1.Value && Validaciones.IsNotNull(usuario) && usuario.Saldo >=
                productoSeleccioando.Precio * (int)numericUpDown1.Value)
            {
                if (radioButtonMarcadoPago.Checked == true || radioButtonTarjetaC.Checked == true
                    || radioButtonTarjeteDebito.Checked == true)
                {
                    confirmarVenta = MessageBox.Show("Desea confirmar la compra?",
                        "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmarVenta == DialogResult.Yes)
                    {
                        if (radioButtonMarcadoPago.Checked == true)
                        {
                            Venta venta = new Venta(productoSeleccioando,
                                Venta.eMetodoPago.MercadoPago, (int)numericUpDown1.Value);
                            Negocio.CargarVenta(venta);
                        }
                        else if (radioButtonTarjetaC.Checked == true)
                        {
                            Venta venta = new Venta(productoSeleccioando,
                                Venta.eMetodoPago.TarjetaDeCredito, (int)numericUpDown1.Value);
                            Negocio.CargarVenta(venta);
                        }
                        else
                        {
                            Venta venta = new Venta(productoSeleccioando,
                                Venta.eMetodoPago.TarjetaDebito, (int)numericUpDown1.Value);
                            Negocio.CargarVenta(venta);
                        }

                        productoSeleccioando = productoSeleccioando - (int)numericUpDown1.Value;

                        precioAGastar = productoSeleccioando * (int)numericUpDown1.Value;  
                        usuario = usuario - precioAGastar; 

                        labelDinero.Text = usuario.Saldo.ToString();


                    }

                }
                else
                {
                    MessageBox.Show("por favor seleccione el metodo de pago");
                }

            }
            else
            {

                MessageBox.Show("hubo un error en la compra");


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usuario is not null)
            {
                FormBuscadorCarnes frmVentas = new FormBuscadorCarnes(usuario);
                this.Hide();
                frmVentas.Show();
            }
            else
            {
                Application.Exit();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult confirmarVenta;
            confirmarVenta = MessageBox.Show("Desea logearse", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmarVenta == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Perfecto... siga con su compra");
            }
        }

        private void radioButtonMarcadoPago_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string searchTerm = textBuscador.Text;

            // Aquí se realiza la búsqueda utilizando una lista de objetos llamada "productos".
            List<Carne> productosEncontrados = listaDeProductos.Where(p => p.Nombre.Contains(searchTerm)).ToList();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = productosEncontrados;
            dataGridView1.Refresh();
        }

        private void buttonFactura_Click(object sender, EventArgs e)
        {
            FormFacturaVenta formFacturaVenta = new(usuario);
            
            this.Hide();
            formFacturaVenta.Show();
        }
    }
}

