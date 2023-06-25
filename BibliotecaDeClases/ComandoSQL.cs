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
            public SqlCommand CrearComando(string query)
            {
                Abrir();
                SqlCommand comando = new SqlCommand(query, _connection);
                return comando;
            }

            public DataTable EjecutarReader(SqlCommand comando)
            {
                var reader = comando.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                return dataTable;
            }

            public void EjecutarNonQuery(SqlCommand comando)
            {
                comando.ExecuteNonQuery();
            }
     }


}
