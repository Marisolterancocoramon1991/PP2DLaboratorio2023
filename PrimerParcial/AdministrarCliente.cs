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

namespace PrimerParcial
{
    public partial class AdministrarCliente : Form
    {
        List<Cliente> Listaclientes;
        Persona clienteSeleccionado;
        List<Vendedor> ListaTrabajadores;
        Vendedor vendedor;
        Cliente cliente;
        public int Indice { get; set; }
        public AdministrarCliente()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    GrpCrearCliente.Visible = true;
                    GrpCrearVendedores.Visible = false;
                    GrpEditar.Visible = false;

                    break;
                case 2:
                    GrpCrearCliente.Visible = false;
                    GrpCrearVendedores.Visible = true;
                    GrpEditar.Visible = false;
                    break;
                case 3:
                    GrpEditar.Visible = true;
                    GrpCrearCliente.Visible = false;
                    GrpCrearVendedores.Visible = false;

                    break;

                default:
                    GrpCrearCliente.Visible = false;
                    GrpCrearVendedores.Visible = false;
                    GrpEditar.Visible = false;

                    break;

            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex != -1 && Listaclientes != null)
            {
                try
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                    // Obtener las celdas individuales de la fila seleccionada
                    DataGridViewCell nombreCell = selectedRow.Cells[0];
                    DataGridViewCell apellidoCell = selectedRow.Cells[1];
                    DataGridViewCell direccionCell = selectedRow.Cells[2];
                    DataGridViewCell correoCell = selectedRow.Cells[3];
                    DataGridViewCell contraseñaCell = selectedRow.Cells[4];
                    DataGridViewCell saldoCell = selectedRow.Cells[5];
                    DataGridViewCell numeroDeCuentaCell = selectedRow.Cells[6];
                    DataGridViewCell tipoUsuarioCell = selectedRow.Cells[7];

                    // Verificar que todas las celdas necesarias contengan valores no nulos
                    if (nombreCell.Value != null && apellidoCell.Value != null && direccionCell.Value != null
                        && correoCell.Value != null && contraseñaCell.Value != null && saldoCell.Value != null
                        && numeroDeCuentaCell.Value != null && tipoUsuarioCell.Value != null)
                    {
                        // Obtener los valores de las celdas
                        string nombre = nombreCell.Value.ToString();
                        string apellido = apellidoCell.Value.ToString();
                        string direccion = direccionCell.Value.ToString();
                        string correo = correoCell.Value.ToString();
                        string contraseña = contraseñaCell.Value.ToString();
                        float saldo;
                        if (!float.TryParse(saldoCell.Value.ToString(), out saldo))
                        {
                            MessageBox.Show("El valor del saldo no es válido.", "Error de formato");
                            return;
                        }
                        string numeroDeCuenta = numeroDeCuentaCell.Value.ToString();
                        string tipoUsuarioStr = tipoUsuarioCell.Value.ToString();

                        // Buscar el cliente seleccionado en la lista de clientes
                        Cliente clienteSeleccionado = Listaclientes.FirstOrDefault(cliente =>
                            cliente.Nombre == nombre && cliente.Apellido == apellido && cliente.Direccion == direccion
                            && cliente.CorreoElectronico == correo && cliente.Contraseña == contraseña && cliente.Saldo == saldo
                            && cliente.NumeroDeCuenta == numeroDeCuenta && cliente.TipoDeUsuario == eTipoDeUsuario.Cliente);

                        if (clienteSeleccionado != null)
                        {
                            // Guardar el ID del cliente seleccionado en la variable Indice
                            Indice = clienteSeleccionado.ID;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente seleccionado.", "Cliente no encontrado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se seleccionó un cliente válido.", "Cliente inválido");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al seleccionar la fila: " + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Debes elegir una lista de clientes antes de editar el cliente.", "Selección incorrecta");
            }
        }

        /*     private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
             {
                 int rowIndex = e.RowIndex;

                 if (rowIndex != -1 && Listaclientes != null)
                 {
                     try
                     {
                         DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                         DataGridViewCell nombreCell = selectedRow.Cells[0];
                         DataGridViewCell apellidoCell = selectedRow.Cells[1];
                         DataGridViewCell direccionCell = selectedRow.Cells[2];
                         DataGridViewCell correoCell = selectedRow.Cells[3];
                         DataGridViewCell contraseñaCell = selectedRow.Cells[4];
                         DataGridViewCell saldoCell = selectedRow.Cells[5];
                         DataGridViewCell numeroDeCuentaCell = selectedRow.Cells[6];
                         DataGridViewCell tipoUsuarioCell = selectedRow.Cells[7];

                         if (nombreCell.Value != null && apellidoCell.Value != null && direccionCell.Value != null
                             && correoCell.Value != null && contraseñaCell.Value != null && saldoCell.Value != null
                             && numeroDeCuentaCell.Value != null && tipoUsuarioCell.Value != null)
                         {
                             string nombre = nombreCell.Value.ToString();
                             string apellido = apellidoCell.Value.ToString();
                             string direccion = direccionCell.Value.ToString();
                             string correo = correoCell.Value.ToString();
                             string contraseña = contraseñaCell.Value.ToString();
                             float saldo;
                             if (!float.TryParse(saldoCell.Value.ToString(), out saldo))
                             {
                                 MessageBox.Show("El valor del saldo no es válido.", "Error de formato");
                                 return;
                             }
                             string numeroDeCuenta = numeroDeCuentaCell.Value.ToString();
                             string tipoUsuarioStr = tipoUsuarioCell.Value.ToString();

                                 Cliente clienteSeleccionado = Listaclientes.FirstOrDefault(cliente =>
                                     cliente.Nombre == nombre && cliente.Apellido == apellido && cliente.Direccion == direccion
                                     && cliente.CorreoElectronico == correo && cliente.Contraseña == contraseña && cliente.Saldo == saldo
                                     && cliente.NumeroDeCuenta == numeroDeCuenta && cliente.TipoDeUsuario == eTipoDeUsuario.Cliente);

                                 if (clienteSeleccionado != null)
                                 {
                                     foreach (Cliente cliente in Listaclientes)
                                     {
                                         if (cliente.Nombre == nombre && cliente.Apellido == apellido && cliente.Direccion == direccion
                                             && cliente.CorreoElectronico == correo && cliente.Contraseña == contraseña && cliente.Saldo == saldo
                                             && cliente.NumeroDeCuenta == numeroDeCuenta && cliente.TipoDeUsuario == eTipoDeUsuario.Cliente)
                                         {
                                             Indice = cliente.ID;
                                             break;
                                         }
                                     }

                                 }
                                 else
                                 {
                                     MessageBox.Show("No se encontró el cliente seleccionado.", "Cliente no encontrado");
                                 }

                         }
                         else
                         {
                             MessageBox.Show("No se seleccionó un cliente válido.", "Cliente inválido");
                         }
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Ha ocurrido un error al seleccionar la fila: " + ex.Message, "Error");
                     }
                 }
                 else
                 {
                     MessageBox.Show("Debes elegir una lista de clientes antes de editar el cliente.", "Selección incorrecta");
                 }
             }*/


        /*  private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
              int rowIndex = e.RowIndex;

              if (rowIndex != -1 && Listaclientes != null)
              {
                  try
                  {
                      DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                      string nombre = selectedRow.Cells[0].Value?.ToString();
                      string apellido = selectedRow.Cells[1].Value?.ToString();
                      string direccion = selectedRow.Cells[2].Value?.ToString();
                      string correo = selectedRow.Cells[3].Value?.ToString();
                      string contraseña = selectedRow.Cells[4].Value?.ToString();
                      string saldoStr = selectedRow.Cells[5].Value?.ToString();
                      string numeroDeCuenta = selectedRow.Cells[6].Value?.ToString();
                      string tipoUsuarioStr = selectedRow.Cells[7].Value?.ToString();

                      if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(direccion)
                          && !string.IsNullOrEmpty(correo) && !string.IsNullOrEmpty(contraseña) && !string.IsNullOrEmpty(saldoStr)
                          && !string.IsNullOrEmpty(numeroDeCuenta) && !string.IsNullOrEmpty(tipoUsuarioStr))
                      {
                          float saldo;
                          if (!float.TryParse(saldoStr, out saldo))
                          {
                              MessageBox.Show("El valor del saldo no es válido.", "Error de formato");
                              return;
                          }

                          if (int.TryParse(tipoUsuarioStr, out int tipoUsuario) && tipoUsuario == 0 || tipoUsuario == 1)
                          {
                              MessageBox.Show("El valor del tipo de usuario no es válido.", "Error de formato");
                              return;
                          }

                          Cliente clienteSeleccionado = Listaclientes.FirstOrDefault(cliente =>
                              cliente.Nombre == nombre && cliente.Apellido == apellido && cliente.Direccion == direccion
                              && cliente.CorreoElectronico == correo && cliente.Contraseña == contraseña && cliente.Saldo == saldo
                              && cliente.NumeroDeCuenta == numeroDeCuenta && cliente.TipoDeUsuario == (eTipoDeUsuario)tipoUsuario);

                          if (clienteSeleccionado != null)
                          {
                              // Realiza las acciones necesarias con el cliente seleccionado
                          }
                          else
                          {
                              MessageBox.Show("No se encontró el cliente seleccionado.", "Cliente no encontrado");
                          }
                      }
                      else
                      {
                          MessageBox.Show("No se seleccionó un cliente válido.", "Cliente inválido");
                      }
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show("Ha ocurrido un error al seleccionar la fila: " + ex.Message, "Error");
                  }
              }
              else
              {
                  MessageBox.Show("Debes elegir una lista de clientes antes de editar el cliente.", "Selección incorrecta");
              }
          }*/

        private void AdministrarCliente_Load(object sender, EventArgs e)
        {
            Listaclientes = Negocio.RetornaListaClientes();
            CargarDataGridView(Listaclientes, cliente);

        }

        public void CargarDataGridView(List<Cliente> listaCliente, Cliente cliente)
        {
            foreach (Cliente clientes in listaCliente)
            {
                if (clientes is Cliente)
                {
                    cliente = (Cliente)clientes;
                    dataGridView1.Rows.Add(cliente.Nombre, cliente.Apellido,
                        cliente.Direccion, cliente.CorreoElectronico, cliente.Contraseña,
                        cliente.saldo, cliente.NumeroDeCuenta, cliente.TipoDeUsuario);
                }
            }
        }

        private void GrpCrearVendedores_Enter(object sender, EventArgs e)
        {

        }

        private void GrpEditar_Enter(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           try {
               
                string nombreUsuario = txtNombreUsuario.Text;
                string ApellidoUsuario = txtApellidoUsuario.Text;
                string DireccionUsuario = txtDireccioUsuario.Text;
                string correo = txtCorreoUsuario.Text;
                string contraseña = txtContraseñaUsuario.Text;
                float saldo = Validaciones.DeStringANumero(txtSaldoUsuario.Text);
                string cuenta;
                if (Validaciones.EsNumero(txtCuentaUsuario.Text))
                {
                    cuenta = txtCuentaUsuario.Text;
                }else
                {
                    MessageBox.Show("nummero de cuenta debe establecerse como numero");
                    return;

                }




                Validaciones.ValidarCamposLoggin(nombreUsuario, correo, contraseña);
                List<Cliente> listaUsuarios = new List<Cliente>();
                listaUsuarios = Negocio.RetornaListaClientes();
                Cliente auxUsuario = new Cliente(Indice, nombreUsuario, 
                    ApellidoUsuario, DireccionUsuario, correo,
                    contraseña, saldo, cuenta, eTipoDeUsuario.Cliente);
                HanblerCliente usuariosHandler = new HanblerCliente();
                usuariosHandler.Modificar(auxUsuario);
                 Negocio.CargaListaClientes(usuariosHandler.Leer());
                CargarDataGridView(Listaclientes, cliente);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
