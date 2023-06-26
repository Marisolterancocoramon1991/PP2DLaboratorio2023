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
        public void Modificar(Cerdo entidad)
        {
            string query = "UPDATE Cerdos SET Tipo = @Tipo, Precio = @Precio, CantidadEnInventarioKilos = @CantidadEnInventarioKilos, RazasDeCerdo = @RazasDeCerdo WHERE Nombre = @Nombre";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@Tipo", entidad.Tipo);
                comando.Parameters.AddWithValue("@Precio", entidad.Precio);
                comando.Parameters.AddWithValue("@CantidadEnInventarioKilos", entidad.CantidadEnInventario);
                comando.Parameters.AddWithValue("@RazasDeCerdo", (int)entidad.RazasDeCerdo);
                comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);

                EjecutarNonQuery(comando);
            }
        }
        public void Delete(int id)
        {
            string query = "DELETE FROM Cerdos WHERE id = @id";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", id);
                EjecutarNonQuery(comando);
            }
        }
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
