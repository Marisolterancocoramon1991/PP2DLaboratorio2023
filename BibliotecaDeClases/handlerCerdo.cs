using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class handlerCerdo: ComandoSQL, ImanjadorConexion<Cerdo>
    {
        /// <summary>
        /// Agrega un nuevo cerdo a la base de datos.
        /// </summary>
        /// <param name="entidad">El objeto Cerdo que se va a agregar.</param>
        public void Add(Cerdo entidad)
        {
            string query = "INSERT INTO Cerdos (Nombre, Tipo, Precio, CantidadEnInventarioKilos, RazaDeCerdo) " +
                           "VALUES (@Nombre, @Tipo, @Precio, @CantidadEnInventarioKilos, @RazasDeCerdo)";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@Tipo", entidad.Tipo);
                comando.Parameters.AddWithValue("@Precio", entidad.Precio);
                comando.Parameters.AddWithValue("@CantidadEnInventarioKilos", entidad.CantidadEnInventario);
                comando.Parameters.AddWithValue("@RazasDeCerdo", entidad.RazasDeCerdo);
           

                EjecutarNonQuery(comando);
            }
        }
        /// <summary>
        /// Modifica un cerdo existente en la base de datos.
        /// </summary>
        /// <param name="entidad">El objeto Cerdo con los nuevos valores a actualizar.</param>
        public void Modificar(Cerdo entidad)
        {
            string query = "UPDATE Cerdos SET Tipo = @Tipo, Precio = @Precio, CantidadEnInventarioKilos = @CantidadEnInventarioKilos, RazaDeCerdo = @RazasDeCerdo WHERE Nombre = @Nombre";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@Tipo", entidad.Tipo);
                comando.Parameters.AddWithValue("@Precio", entidad.Precio);
                comando.Parameters.AddWithValue("@CantidadEnInventarioKilos", entidad.CantidadEnInventario);
                comando.Parameters.AddWithValue("@RazasDeCerdo", (int)entidad.RazasDeCerdo);
                comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@Id", entidad.Id);

                EjecutarNonQuery(comando);
            }
        }
        /// <summary>
        /// Elimina un registro de cerdo de la base de datos.
        /// </summary>
        /// <param name="id">El ID del cerdo a eliminar.</param>
        public void Delete(int id)
        {
            string query = "DELETE FROM Cerdos WHERE id = @id";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", id);
                EjecutarNonQuery(comando);
            }
        }

        /// <summary>
        /// Obtiene todos los registros de cerdo de la base de datos.
        /// </summary>
        /// <returns>Una lista de objetos Cerdo.</returns>
        public List<Cerdo> Leer()
        {
            string query = "SELECT * FROM Cerdos";

            using (SqlCommand comando = CrearComando(query))
            {
                List<Cerdo> listaCerdos = new List<Cerdo>();
                DataTable dataTable = EjecutarReader(comando);

                listaCerdos = Cerdo.ConvertirDataTableCerdoALista(dataTable);

                return listaCerdos;
            }
        }


    }
}
