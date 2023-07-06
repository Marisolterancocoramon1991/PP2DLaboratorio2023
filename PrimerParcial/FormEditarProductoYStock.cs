using BibliotecaDeClases;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerParcial
{

    public partial class FormEditarProductoYStock : Form
    {

        private int indice { get; set; }
        Carne productoSeleccioando;
        List<Ave> listaDeAve;
        List<Cerdo> listaDeCerdo;
        List<Vacuno> listaDeVacuno;
        public FormEditarProductoYStock()
        {
            InitializeComponent();

        }


        /// <summary>
        /// carga todos los iten para que pueda trabajar la ventana
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void FormEditarProductoYStock_Load(object sender, EventArgs e)
        {
            comboBoxTipoAve.DataSource = Enum.GetValues(typeof(eTipoAve));
            comboBoxRazaVacuno.DataSource = Enum.GetValues(typeof(eRazasDeVacas));
            comboBoxCategoria.DataSource = Enum.GetValues(typeof(eCategoria));
            comboBoxRCerdo.DataSource = Enum.GetValues(typeof(eRazasDeCerdo));
            listaDeVacuno = Negocio.RetornarListaVacuno();
            listaDeCerdo = Negocio.RetornarListaCerdo();
            listaDeAve = Negocio.RetornarListaAve();
            CargarDataGridView(listaDeAve);
            CargarDataGridView(listaDeVacuno);
            CargarDataGridView(listaDeCerdo);
        }


        /// <summary>
        /// oculta y hace visible los grupos
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
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

        /// <summary>
        /// determina en que parte de data se hico el click y se entrega el producto seleccinado
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int n = e.RowIndex;

            if (n != -1 && listaDeAve != null)
            {
                DataGridViewRow selectedRow;
                try
                {
                    selectedRow = dataGridView1.Rows[n];
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al seleccionar la fila.");
                    return;
                }


                DataGridViewCell nombreCell = selectedRow.Cells[0];
                DataGridViewCell tipoCell = selectedRow.Cells[1];
                DataGridViewCell precioCell = selectedRow.Cells[2];

                if (nombreCell.Value != null && tipoCell.Value != null && precioCell.Value != null)
                {
                    string nombre = nombreCell.Value.ToString();
                    string tipo = tipoCell.Value.ToString();

                    if (float.TryParse(precioCell.Value.ToString(), out float precio))
                    {
                        foreach (Ave producto in listaDeAve)
                        {
                            if (producto.Nombre == nombre && producto.Tipo == tipo && producto.Precio == precio)
                            {
                                productoSeleccioando = producto;
                                indice = producto.Id;
                                MessageBox.Show($"eleccioon {producto.Id}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor del precio no es válido.");
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó un producto válido.");
                }
            }
            else
            {
                MessageBox.Show("Debes elegir un tipo de lista antes de editar el producto.");
            }
        }

        /// <summary>
        /// determina en que parte de data se hico el click y se entrega el producto seleccinado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int n = e.RowIndex;



            if (n != -1 && listaDeCerdo != null)
            {
                DataGridViewRow selectedRow;
                try
                {
                    selectedRow = dataGridView2.Rows[n];
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al seleccionar la fila.");
                    return;
                }


                DataGridViewCell nombreCell = selectedRow.Cells[0];
                DataGridViewCell tipoCell = selectedRow.Cells[1];
                DataGridViewCell precioCell = selectedRow.Cells[2];

                if (nombreCell.Value != null && tipoCell.Value != null && precioCell.Value != null)
                {
                    string nombre = nombreCell.Value.ToString();
                    string tipo = tipoCell.Value.ToString();

                    if (float.TryParse(precioCell.Value.ToString(), out float precio))
                    {
                        foreach (Cerdo producto in listaDeCerdo)
                        {
                            if (producto.Nombre == nombre && producto.Tipo == tipo && producto.Precio == precio)
                            {
                                productoSeleccioando = producto;
                                indice = producto.Id;
                                MessageBox.Show($"eleccioon {indice}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor del precio no es válido.");
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó un producto válido.");
                }
            }
            else
            {
                MessageBox.Show("Debes elegir un tipo de lista antes de editar el producto.");
            }
            ////////////////
            /*

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
            }*/
        }


        /// <summary>
        ///  determina en que parte de data se hico el click y se entrega el producto seleccinado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int n = e.RowIndex;

            if (n != -1 && listaDeVacuno != null)
            {
                DataGridViewRow selectedRow;
                try
                {
                    selectedRow = dataGridViewVacuno.Rows[n];
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al seleccionar la fila.");
                    return;
                }


                DataGridViewCell nombreCell = selectedRow.Cells[0];
                DataGridViewCell tipoCell = selectedRow.Cells[1];
                DataGridViewCell precioCell = selectedRow.Cells[2];

                if (nombreCell.Value != null && tipoCell.Value != null && precioCell.Value != null)
                {
                    string nombre = nombreCell.Value.ToString();
                    string tipo = tipoCell.Value.ToString();

                    if (float.TryParse(precioCell.Value.ToString(), out float precio))
                    {
                        foreach (Vacuno producto in listaDeVacuno)
                        {
                            if (producto.Nombre == nombre && producto.Tipo == tipo && producto.Precio == precio)
                            {
                                productoSeleccioando = producto;
                                indice = producto.Id;
                                MessageBox.Show($"eleccioon {producto.MostrarCarnes()}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor del precio no es válido.");
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó un producto válido.");
                }
            }
            else
            {
                MessageBox.Show("Debes elegir un tipo de lista antes de editar el producto.");
            }
        }


        /*  private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
              int n = e.RowIndex;
              if (n != -1  && listaDeProductos != null)
              {
                  if (n != -1)
                  {
                      foreach (Carne producto in listaDeProductos)
                      {
                          try
                          {
                              if (producto.Nombre == dataGridView1.Rows[n].Cells[0].Value.ToString() &&
                                                          producto.Tipo == dataGridView1.Rows[n].Cells[1].Value.ToString() &&
                                                          producto.Precio == (float)dataGridView1.Rows[n].Cells[2].Value)
                              {

                                  productoSeleccioando = producto;
                                  break;
                              }

                          }
                          catch (ArgumentOutOfRangeException objetoExeception) 
                          {

                              MessageBox.Show(objetoExeception.Message);

                          }

                      }
                  }
              }
              else
              {
                  MessageBox.Show("debes elegir un tipo de lista antes de editar el producto");
              }
          }*/

        /// <summary>
        /// te lleva a la ventana login
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
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


        /// <summary>
        /// carga el data necesaria  en el dataGridView
        /// </summary>
        /// <param name="listaDeProductos"></param>
        /// <param name="Ave"></param>
        public void CargarDataGridView(List<Ave> listaDeProductos)
        {
            dataGridView1.Rows.Clear();
            foreach (Ave producto in listaDeProductos)
            {
                

                dataGridView1.Rows.Add(producto.Nombre, producto.Tipo, producto.Precio, producto.TipoAve);


            }
        }


        /// <summary>
        /// carga el data necesaria  en el dataGridView
        /// </summary>
        /// <param name="listaDeProductos"></param>
        /// <param name="CarneCerdo"></param>
        public void CargarDataGridView(List<Cerdo> listaDeProductos)
        {
            dataGridView2.Rows.Clear();
            foreach (Cerdo producto in listaDeProductos)
            {

                dataGridView2.Rows.Add(producto.Nombre, producto.Tipo,
                    producto.Precio, producto.RazasDeCerdo);

            }
        }
        /// <summary>
        /// carga el data necesaria  en el dataGridView
        /// </summary>
        /// <param name="listaDeProductos"></param>
        /// <param name="ProductoVaca"></param>
        public void CargarDataGridView(List<Vacuno> listaDeProductos)
        {
            dataGridViewVacuno.Rows.Clear();
            foreach (Vacuno producto in listaDeProductos)
            {

                dataGridViewVacuno.Rows.Add(producto.Nombre, producto.Tipo,
                     producto.Precio, producto.RazasDeVacas);

            }
        }
        /// <summary>
        /// edita el producto depende de lo generado
        /// </summary>
        /*    private void EditarProducto()
            {
                // Carne nuevoProducto = null;
                float precio;
                //       int cantidadEnInventarioKilos;

                if (productoSeleccioando is not null && (comboBoxTipoProducto.Text == "Ave" ||
                    comboBoxTipoProducto.Text == "Cerdo" || comboBoxTipoProducto.Text == "Vacuno"))
                {
                    if (Validaciones.EsNombre(textBoxNombre.Text))
                        productoSeleccioando.Nombre = textBoxNombre.Text;
                    if (Validaciones.EsNombre(textBoxTipo.Text))
                        productoSeleccioando.Tipo = textBoxTipo.Text;
                    if ((float.TryParse(textBoxPrecio.Text, out precio)))
                    switch (comboBoxTipoProducto.SelectedIndex)
                    {
                        case 1:

                            if (productoSeleccioando is Ave)
                            {
                                List<Ave> listaControlAve = new List<Ave>();

                                Ave productoModificarAve= new Ave(indice, textBoxNombre.Text,textBoxTipo.Text,precio, productoSeleccioando.CantidadEnInventario,
                                    (eTipoAve)comboBoxTipoAve.SelectedItem);
                                HandlerAve handlerAve = new HandlerAve();
                                handlerAve.Modificar(productoModificarAve);
                                Negocio.CargaListaAves(handlerAve.Leer());
                                MessageBox.Show($"Ha editado correctamente ahora el producto\n" +
                                $" {productoModificarAve.MostrarDetallesDeProducto()}");


                            }
                            break;
                        case 2:
                            if (productoSeleccioando is Cerdo)
                            {
                                Cerdo ProductoC = (Cerdo)productoSeleccioando;
                                ProductoC.RazasDeCerdo = (eRazasDeCerdo)comboBoxRCerdo.SelectedItem;
                                handlerCerdo handlerCerdo = new handlerCerdo();
                                handlerCerdo.Modificar(ProductoC);
                                Negocio.CargaListaCerdo(handlerCerdo.Leer());
                                MessageBox.Show($"Ha editado correctamente ahora el producto\n" +
                                      $" {ProductoC.MostrarDetallesDeProducto()}");
                            }
                            break;
                        case 3:
                            if (productoSeleccioando is Vacuno)
                            {
                                Vacuno ProductoV = (Vacuno)productoSeleccioando;
                                ProductoV.RazasDeVacas = (eRazasDeVacas)comboBoxRazaVacuno.SelectedItem;
                                HanblerVacuno hanblerVacuno = new HanblerVacuno();
                                hanblerVacuno.Modificar(ProductoV);
                                Negocio.CargaListaVacuno(hanblerVacuno.Leer());
                                MessageBox.Show($"Ha editado correctamente ahora el producto\n" +
                                $" {ProductoV.MostrarDetallesDeProducto()}");
                            }
                            break;

                    }

                }
                else
                    MessageBox.Show("no ha seleccionado ningun producto para editar");
            }*/
        /*   private void EditarProducto()
           {
               float precio;

               if (productoSeleccioando != null && (comboBoxTipoProducto.Text == "Ave" ||
                   comboBoxTipoProducto.Text == "Cerdo" || comboBoxTipoProducto.Text == "Vacuno"))
               {
                   if (Validaciones.EsNombre(textBoxNombre.Text))
                       productoSeleccioando.Nombre = textBoxNombre.Text;
                   if (Validaciones.EsNombre(textBoxTipo.Text))
                       productoSeleccioando.Tipo = textBoxTipo.Text;
                   if (float.TryParse(textBoxPrecio.Text, out precio))
                   {
                       switch (comboBoxTipoProducto.SelectedIndex)
                       {
                           case 1:
                               if (productoSeleccioando is Ave)
                               {

                                   List<Ave> lisAve = Negocio.RetornarListaAve();
                                   Ave ave = new Ave(productoSeleccioando.Id, textBoxNombre.Text, textBoxTipo.Text, precio, 
                                       productoSeleccioando.CantidadEnInventario, (eTipoAve)comboBoxTipoAve.SelectedItem);

                                   HandlerAve handlerAve = new HandlerAve();
                                   handlerAve.Modificar(ave);
                                   Negocio.CargaListaAves(handlerAve.Leer());
                                   MessageBox.Show($"Ha editado correctamente el producto:\n" +
                                       $"{ave.MostrarDetallesDeProducto()}");
                               }
                               break;
                           case 2:
                               if (productoSeleccioando is Cerdo)
                               {
                                   Cerdo productoModificarCerdo = (Cerdo)productoSeleccioando;
                                   productoModificarCerdo.Precio = precio;
                                   productoModificarCerdo.RazasDeCerdo = (eRazasDeCerdo)comboBoxRCerdo.SelectedItem;
                                   handlerCerdo handlerCerdo = new handlerCerdo();
                                   handlerCerdo.Modificar(productoModificarCerdo);
                                   Negocio.CargaListaCerdo(handlerCerdo.Leer());
                                   MessageBox.Show($"Ha editado correctamente el producto:\n" +
                                       $"{productoModificarCerdo.MostrarDetallesDeProducto()}");
                               }
                               break;
                           case 3:
                               if (productoSeleccioando is Vacuno)
                               {
                                   Vacuno productoModificarVacuno = (Vacuno)productoSeleccioando;
                                   productoModificarVacuno.Precio = precio;
                                   productoModificarVacuno.RazasDeVacas = (eRazasDeVacas)comboBoxRazaVacuno.SelectedItem;
                                   HanblerVacuno handlerVacuno = new HanblerVacuno();
                                   handlerVacuno.Modificar(productoModificarVacuno);
                                   Negocio.CargaListaVacuno(handlerVacuno.Leer());
                                   MessageBox.Show($"Ha editado correctamente el producto:\n" +
                                       $"{productoModificarVacuno.MostrarDetallesDeProducto()}");
                               }
                               break;
                       }
                   }
                   else
                   {
                       MessageBox.Show("El precio ingresado no es válido.");
                   }
               }
               else
               {
                   MessageBox.Show("No ha seleccionado ningún producto para editar.");
               }
           }*/

        /// <summary>
        /// Método para editar un producto seleccionado en base a los valores ingresados en los campos de texto.
        /// Valida los valores ingresados y realiza las modificaciones correspondientes en el producto seleccionado.
        /// Actualiza la información en la base de datos y muestra un mensaje de éxito.
        /// </summary>
        private void EditarProducto()
        {
            float precio;

            if (productoSeleccioando != null && (comboBoxTipoProducto.Text == "Ave" || comboBoxTipoProducto.Text == "Cerdo" || comboBoxTipoProducto.Text == "Vacuno"))
            {
                if (Validaciones.EsNombre(textBoxNombre.Text))
                    productoSeleccioando.Nombre = textBoxNombre.Text;
                if (Validaciones.EsNombre(textBoxTipo.Text))
                    productoSeleccioando.Tipo = textBoxTipo.Text;
                if (float.TryParse(textBoxPrecio.Text, out precio))
                {
                    switch (comboBoxTipoProducto.SelectedIndex)
                    {
                        case 1:
                            if (productoSeleccioando is Ave)
                            {
                                Ave ave = (Ave)productoSeleccioando;
                                ave.Precio = precio;
                                ave.TipoAve = (eTipoAve)comboBoxTipoAve.SelectedItem;
                                
                                Negocio.CargarModificacionesProducto(ave);
                                MessageBox.Show($"Ha editado correctamente el producto:\n" +
                                    $"{ave.MostrarDetallesDeProducto()}");
                                CargarDataGridView(listaDeAve);

                            }
                            break;
                        case 2:
                            if (productoSeleccioando is Cerdo)
                            {
                                Cerdo cerdo = (Cerdo)productoSeleccioando;
                                cerdo.Precio = precio;
                                cerdo.RazasDeCerdo = (eRazasDeCerdo)comboBoxRCerdo.SelectedItem;
                                Negocio.CargarModificacionesProducto(cerdo);
                                MessageBox.Show($"Ha editado correctamente el producto:\n" +
                                    $"{cerdo.MostrarDetallesDeProducto()}");

                                CargarDataGridView(listaDeCerdo);
                            }
                            break;
                        case 3:
                            if (productoSeleccioando is Vacuno)
                            {
                                Vacuno vacuno = (Vacuno)productoSeleccioando;
                                vacuno.Precio = precio;
                                vacuno.RazasDeVacas = (eRazasDeVacas)comboBoxRazaVacuno.SelectedItem;
                                Negocio.CargarModificacionesProducto(vacuno);
                                CargarDataGridView(listaDeVacuno);
                                MessageBox.Show($"Ha editado correctamente el producto:\n" +
                                    $"{vacuno.MostrarDetallesDeProducto()}");
                            }
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("El precio ingresado no es válido.");
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningún producto para editar.");
            }
        }



        /// <summary>
        /// agrega un cartel de aviso
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void comboBoxTipoProducto_MouseHover_1(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(this.comboBoxTipoProducto, "aqui se selecciona y se cambian los elementos\n" +
                "que estan en la agrupacion, aseegurese de que todo este integrado correctamente \n");
        }

        /// <summary>
        /// llama al metodo editar producto
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void buttonEditar_Click(object sender, EventArgs e)
        {

            try
            {
                EditarProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo ha sucedido con la modificacion del producto");
            }

        }


        /// <summary>
        /// agrega y valida la cantidar a sumar en stock
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void buttonCantidad_Click(object sender, EventArgs e)
        {


            if (productoSeleccioando is not null && Validaciones.EsNumero(textBoxCantidad.Text))
            {
                MessageBox.Show($"{productoSeleccioando.CantidadEnInventario}");
                productoSeleccioando = productoSeleccioando + int.Parse(textBoxCantidad.Text);
                MessageBox.Show($"{productoSeleccioando.CantidadEnInventario}");
            }



        }

        /// <summary>
        /// instancia una ventana y la levanta la ventana de administracion
        /// </summary>
        /// <param name="sender"></param> contralodoor del evento
        /// <param name="e"></param> informacion adicional del evento
        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            FormAdministracion formAdministracion = new();
            this.Hide();
            formAdministracion.Show();
        }

        private void groupBoxCerdo_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxVacuno_Enter(object sender, EventArgs e)
        {

        }
    }
}



