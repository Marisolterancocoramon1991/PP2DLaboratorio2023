using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class HandlerVendedor: ComandoSQL, ImanjadorConexion<Vendedor>
    {
        public void Add(Vendedor entidad)
        {
            string query = "INSERT INTO Vendedores (Nombre, Apellido, Direccion, CorreoElectronico, Contraseña, Sueldo, Turno, TipoDeUsuario) " +
                "VALUES (@Nombre, @Apellido, @Direccion, @CorreoElectronico, @Contraseña, @Sueldo, @Turno, @TipoDeUsuario)";


            using (SqlCommand comando = CrearComando(query))
            {

                comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@Apellido", entidad.Apellido);
                comando.Parameters.AddWithValue("@Direccion", entidad.Direccion);
                comando.Parameters.AddWithValue("@CorreoElectronico", entidad.CorreoElectronico);
                comando.Parameters.AddWithValue("@Contraseña", entidad.Contraseña);
                comando.Parameters.AddWithValue("@TipoDeUsuario", entidad.TipoDeUsuario);
                comando.Parameters.AddWithValue("@Sueldo", entidad.Sueldo);
                comando.Parameters.AddWithValue("@Turno", entidad.Turno);





                EjecutarNonQuery(comando);
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Vendedores WHERE id = @id";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", id);
                EjecutarNonQuery(comando);
            }
        }

        public List<Vendedor> Leer()
        {
            string query = "SELECT * FROM Vendedores";

            using (SqlCommand comando = CrearComando(query))
            {
                List<Vendedor> listaPersonas = new List<Vendedor>();
                DataTable dataTable = EjecutarReader(comando);
                // Cliente  cliente = new Cliente();
                //  Persona persona = new Persona();    
                //   Vendedor trabajador = new Vendedor();
                //   listaPersonas = cliente.ConvertirDataTableALista(dataTable);

                listaPersonas = Vendedor.ConvertirDataTableALista(dataTable);
                //  listaPersonas = trabajador.ConvertirDataTableALista(dataTable);
                return listaPersonas;
            }
        }


        public void Modificar(Vendedor entidad)
        {
            string query = "UPDATE Vendedores SET nombre = @Nombre, Apellido = @Apellido, " +
                " Direccion = @Direccion, CorreoElectronico =@CorreoElectronico," +
                "Contraseña = @Contraseña,TipoDeUsuario =@TipoDeUsuario, " +
                "Sueldo =@Sueldo, Turno=@Turno WHERE id = @id";


            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@Apellido", entidad.Apellido);
                comando.Parameters.AddWithValue("@Direccion", entidad.Direccion);
                comando.Parameters.AddWithValue("@CorreoElectronico", entidad.Contraseña);
                comando.Parameters.AddWithValue("@Contraseña", entidad.Contraseña);
                comando.Parameters.AddWithValue("@TipoDeUsuario", entidad.TipoDeUsuario);
                comando.Parameters.AddWithValue("@Saldo", entidad.sueldo);
                comando.Parameters.AddWithValue("@Turno", entidad.Turno);
                EjecutarNonQuery(comando);
            }
        }

    }
}
