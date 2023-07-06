using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{
    public class ConexionSql
    {
        protected SqlConnection _connection;
        protected static string _connectionString;

        static ConexionSql()
        {
            _connectionString = "Server=.;Database=UTN_PROYECTO;Trusted_Connection=True;";
        }

        /// <summary>
        /// Abre la conexión con la base de datos.
        /// </summary>
        public void Abrir()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }
        /// <summary>
        /// Cierra la conexión con la base de datos.
        /// </summary>
        public void Cerrar()
        {
            _connection.Close();
        }
    }
}
