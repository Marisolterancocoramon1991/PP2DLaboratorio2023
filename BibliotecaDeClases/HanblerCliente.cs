using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;

namespace BibliotecaDeClases
{
    public class HanblerCliente : ComandoSQL , ImanjadorConexion<Cliente>
    {
        /// <summary>
        /// Agrega un nuevo cliente a la base de datos.
        /// </summary>
        /// <param name="entidad">Objeto de tipo Cliente.</param>
        public void Add(Cliente entidad)
          {
            string query = "INSERT INTO Clientes (Nombre, Apellido, Direccion, CorreoElectronico, Contraseña, TipoDeUsuario, Saldo, NumeroDeCuenta) " +
              "VALUES (@Nombre, @Apellido, @Direccion, @CorreoElectronico, @Contraseña, @TipoDeUsuario, @Saldo, @NumeroDeCuenta)";



            using (SqlCommand comando = CrearComando(query))
              {
                 
                      comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                      comando.Parameters.AddWithValue("@Apellido", entidad.Apellido);
                      comando.Parameters.AddWithValue("@Direccion", entidad.Direccion);
                      comando.Parameters.AddWithValue("@CorreoElectronico", entidad.CorreoElectronico);
                      comando.Parameters.AddWithValue("@Contraseña", entidad.Contraseña);
                      comando.Parameters.AddWithValue("@TipoDeUsuario", entidad.TipoDeUsuario);
                      comando.Parameters.AddWithValue("@Saldo", entidad.saldo);
                      comando.Parameters.AddWithValue("@NumeroDeCuenta", entidad.NumeroDeCuenta);





                EjecutarNonQuery(comando);
             }
          }
        /// <summary>
        /// Elimina un cliente de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID del cliente a eliminar.</param>
        public void Delete(int id)
        {
            string query = "DELETE FROM Clientes WHERE id = @id";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", id);
                EjecutarNonQuery(comando);
            }
        }
        /// <summary>
        /// Lee todos los clientes desde la base de datos y los devuelve en una lista.
        /// </summary>
        /// <returns>Lista de objetos de tipo Cliente.</returns>
        public List<Cliente> Leer()
        {
            string query = "SELECT * FROM Clientes";

            using (SqlCommand comando = CrearComando(query))
            {
                List<Cliente> listaPersonas = new List<Cliente>();
                DataTable dataTable = EjecutarReader(comando);
              // Cliente  cliente = new Cliente();
              //  Persona persona = new Persona();    
             //   Vendedor trabajador = new Vendedor();
             //   listaPersonas = cliente.ConvertirDataTableALista(dataTable);

                listaPersonas = Cliente.ConvertirDataTableALista(dataTable);
              //  listaPersonas = trabajador.ConvertirDataTableALista(dataTable);
                return listaPersonas;
            }
        }

        /// <summary>
        /// Modifica los datos de un cliente en la base de datos.
        /// </summary>
        /// <param name="entidad">Objeto de tipo Cliente con los nuevos datos.</param>
        public void Modificar(Cliente entidad)
        {
            string query = "UPDATE Clientes SET nombre = @Nombre, Apellido = @Apellido, " +
                 "Direccion = @Direccion, CorreoElectronico = @CorreoElectronico, " +
                 "Contraseña = @Contraseña, TipoDeUsuario = @TipoDeUsuario, " +
                 "Saldo = @Saldo, NumeroDeCuenta = @NumeroDeCuenta WHERE Id = @Id";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@Apellido", entidad.Apellido);
                comando.Parameters.AddWithValue("@Direccion", entidad.Direccion);
                comando.Parameters.AddWithValue("@CorreoElectronico", entidad.CorreoElectronico);
                comando.Parameters.AddWithValue("@Contraseña", entidad.Contraseña);
                comando.Parameters.AddWithValue("@TipoDeUsuario", entidad.TipoDeUsuario);
                comando.Parameters.AddWithValue("@Saldo", entidad.saldo);
                comando.Parameters.AddWithValue("@NumeroDeCuenta", entidad.NumeroDeCuenta);
                comando.Parameters.AddWithValue("@Id", entidad.ID);

                EjecutarNonQuery(comando);
            }
        }


    }
}
