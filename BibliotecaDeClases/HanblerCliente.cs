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
   
        public void Delete(int id)
        {
            string query = "DELETE FROM Clientes WHERE id = @id";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", id);
                EjecutarNonQuery(comando);
            }
        }

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
