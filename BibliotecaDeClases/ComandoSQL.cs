using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;


namespace BibliotecaDeClases
{
    public class ComandoSQL : ConexionSql
    {
        /// <summary>
        /// Crea un objeto SqlCommand con la consulta SQL especificada.
        /// </summary>
        /// <param name="query">Consulta SQL.</param>
        /// <returns>Objeto SqlCommand.</returns>

        public SqlCommand CrearComando(string query)
        {
            Abrir();
            SqlCommand comando = new SqlCommand(query, _connection);
            return comando;
        }


        /// <summary>
        /// Ejecuta un comando SQL que devuelve un conjunto de resultados y lo carga en un DataTable.
        /// </summary>
        /// <param name="comando">Comando SQL a ejecutar.</param>
        /// <returns>DataTable con los resultados.</returns>
        public DataTable EjecutarReader(SqlCommand comando)
        {
            var reader = comando.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            return dataTable;
        }

        /// <summary>
        /// Ejecuta un comando SQL que no devuelve ningún resultado.
        /// </summary>
        /// <param name="comando">Comando SQL a ejecutar.</param>
        public void EjecutarNonQuery(SqlCommand comando)
        {
            comando.ExecuteNonQuery();
        }
    }


}
