using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class MovimientosUsuariosHandler : ComandoSQL
    {
        /// <summary>
        /// funcion add a la db de movimientosUsuarios
        /// </summary>
        /// <param name="usuario">nombre del usuario</param>
        /// <param name="accion">accion que realizo el usuario</param>
        /// <param name="nombreFrm">nombre del frm donde se encuentra el usuario</param>
        public void add(string usuario, string accion, string nombreFrm)
        {
            string query = "INSERT INTO movimientosUsuarios (usuario,accion,nombreFrm)" +
                            "VALUES (@usuario,@accion,@nombreFrm)";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@accion", accion);
                comando.Parameters.AddWithValue("@nombreFrm", nombreFrm);
                EjecutarNonQuery(comando);
            }
        }
    }
}
