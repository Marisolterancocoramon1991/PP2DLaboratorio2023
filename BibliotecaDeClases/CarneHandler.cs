using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    internal class CarneHandler:ComandoSQL , ImanjadorConexion<Carne>
    {
        /// <summary>
        /// Agrega una entidad de tipo Carne a la base de datos.
        /// </summary>
        /// <param name="entidad">Entidad de tipo Carne a agregar.</param>
        public void Add(Carne entidad)
        {
            string query = "INSERT INTO Carnes (Nombre,Tipo,Precio,CantidadEnInventarioKilos" +
             "VALUES (Nombre = @Nombre, Tipo=@Tipo,Precio=@Precio," +
             "CantidadEnInventarioKilos=@CantidadEnInventarioKilos)";


            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@Tipo", entidad.Tipo);
                comando.Parameters.AddWithValue("@Precio", entidad.Precio);
                comando.Parameters.AddWithValue
                    ("@CantidadEnInventarioKilos", entidad.CantidadEnInventario);
                EjecutarNonQuery(comando);
            }
        }

        /// <summary>
        /// Elimina una entidad de la base de datos según su ID.
        /// </summary>
        /// <param name="id">ID de la entidad a eliminar.</param>
        public void Delete(int id)
        {
            string query = "DELETE FROM Carnes WHERE id = @id";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", id);
                EjecutarNonQuery(comando);
            }
        }

        /// <summary>
        /// Lee y devuelve una lista de todas las entidades de tipo Carne en la base de datos.
        /// </summary>
        /// <returns>Lista de entidades de tipo Carne.</returns>
        public List<Carne> Leer()
        {
            string query = "SELECT * FROM Carnes";

            using (SqlCommand comando = CrearComando(query))
            {
                List<Carne> listaProductos = new List<Carne>();
                DataTable dataTable = EjecutarReader(comando);
                listaProductos = Carne.ConvertirDataTableALista(dataTable);
                return listaProductos;
            }
        }
        /// <summary>
        /// Modifica una entidad de tipo Carne en la base de datos.
        /// </summary>
        /// <param name="entidad">Entidad de tipo Carne a modificar.</param>
        public void Modificar(Carne entidad)
        {
            string query = "UPDATE Carnes SET Nombre = @Nombre, Tipo=@Tipo,Precio=@Precio,"+
            "CantidadEnInventarioKilos=@CantidadEnInventarioKilos)";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@Tipo", entidad.Tipo);
                comando.Parameters.AddWithValue("@Precio", entidad.Precio);
                comando.Parameters.AddWithValue
                    ("@CantidadEnInventarioKilos", entidad.CantidadEnInventario);

                EjecutarNonQuery(comando);
            }
        }
    }
}
