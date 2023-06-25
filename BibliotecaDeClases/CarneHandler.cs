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
        public void Add(Carne entidad)
        {
            string query = "INSERT INTO productos (Nombre,Tipo,Precio,CantidadEnInventarioKilos" +
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

        public void Delete(int id)
        {
            string query = "DELETE FROM Carnes WHERE id = @id";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", id);
                EjecutarNonQuery(comando);
            }
        }

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
