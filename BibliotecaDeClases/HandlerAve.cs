using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class HandlerAve : ComandoSQL, ImanjadorConexion<Ave>
    {

        public void Add(Ave entidad)
        {
            string query = "INSERT INTO Aves (Nombre, Tipo, Precio, CantidadEnInventarioKilos, TipoAve) " +
                           "VALUES (@Nombre, @Tipo, @Precio, @CantidadEnInventarioKilos, @TipoAve)";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@Tipo", entidad.Tipo);
                comando.Parameters.AddWithValue("@Precio", entidad.Precio);
                comando.Parameters.AddWithValue("@CantidadEnInventarioKilos", entidad.CantidadEnInventario);
                comando.Parameters.AddWithValue("@TipoAve", entidad.TipoAve);

                EjecutarNonQuery(comando);
            }
        }


        public void Modificar(Ave entidad)
        {
            string query = "UPDATE Aves SET Tipo = @Tipo, Precio = @Precio, CantidadEnInventarioKilos = @CantidadEnInventarioKilos, TipoAve = @TipoAve WHERE Nombre = @Nombre";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@Tipo", entidad.Tipo);
                comando.Parameters.AddWithValue("@Precio", entidad.Precio);
                comando.Parameters.AddWithValue("@CantidadEnInventarioKilos", entidad.CantidadEnInventario);
                comando.Parameters.AddWithValue("@TipoAve", (int)entidad.TipoAve); // Convertir la enumeración a entero
                comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);

                EjecutarNonQuery(comando);
            }
        }
        public void Delete(int id)
        {
            string query = "DELETE FROM Aves WHERE id = @id";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", id);
                EjecutarNonQuery(comando);
            }
        }

        public List<Ave> Leer()
        {
            string query = "SELECT * FROM Aves";

            using (SqlCommand comando = CrearComando(query))
            {
                List<Ave> listaPersonas = new List<Ave>();
                DataTable dataTable = EjecutarReader(comando);
                // Cliente  cliente = new Cliente();
                //  Persona persona = new Persona();    
                //   Vendedor trabajador = new Vendedor();
                //   listaPersonas = cliente.ConvertirDataTableALista(dataTable);

                listaPersonas = Ave.ConvertirDataTableAveALista(dataTable);
                //  listaPersonas = trabajador.ConvertirDataTableALista(dataTable);
                return listaPersonas;
            }
        }
    }

}

