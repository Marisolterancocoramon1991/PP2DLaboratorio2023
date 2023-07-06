using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{
   public class ControllerConexion
    {

        /// <summary>
        /// Conecta con la base de datos y obtiene una lista de productos de cerdo.
        /// </summary>
        /// <returns>Lista de objetos de tipo Cerdo.</returns>
        public static List<Cerdo> ConectarProductosCerdoDB()
        {
            List<Cerdo> listaProductos = new List<Cerdo>();
            ConexionSql conexionSQL = new ConexionSql();
            conexionSQL.Abrir();
            handlerCerdo productosHandlre = new handlerCerdo();
            listaProductos = productosHandlre.Leer();
            return listaProductos;
        }
        /// <summary>
        /// Conecta con la base de datos y obtiene una lista de productos de vacuno.
        /// </summary>
        /// <returns>Lista de objetos de tipo Vacuno.</returns>
        public static List<Vacuno> ConectarProductosVacunoDB()
        {
            List<Vacuno> listaProductos = new List<Vacuno>();
            ConexionSql conexionSQL = new ConexionSql();
            conexionSQL.Abrir();
            HanblerVacuno productosHandlre = new HanblerVacuno();
            listaProductos = productosHandlre.Leer();
            return listaProductos;
        }
        /// <summary>
        /// Conecta con la base de datos y obtiene una lista de productos de ave.
        /// </summary>
        /// <returns>Lista de objetos de tipo Ave.</returns>
        public static List<Ave> ConectarProductosAveDB()
        {
            List<Ave> listaProductos = new List<Ave>();
            ConexionSql conexionSQL = new ConexionSql();
            conexionSQL.Abrir();
            HandlerAve productosHandlre = new HandlerAve();
            listaProductos = productosHandlre.Leer();
            return listaProductos;
        }
        /// <summary>
        /// Conecta con la base de datos y obtiene una lista de usuarios cliente.
        /// </summary>
        /// <returns>Lista de objetos de tipo Cliente.</returns>
        public static List<Cliente> ConectarUsuariosClienteDB()
        {
            List<Cliente> listaUsuarios = new List<Cliente>();
            ConexionSql conexionSQL = new ConexionSql();
            conexionSQL.Abrir();
            HanblerCliente usuariosHandler = new HanblerCliente();
            listaUsuarios = usuariosHandler.Leer();
            return listaUsuarios;
        }

        /// <summary>
        /// Conecta con la base de datos y obtiene una lista de usuarios trabajador.
        /// </summary>
        /// <returns>Lista de objetos de tipo Vendedor.</returns>
        public static List<Vendedor> ConectarUsuariosTrabajadorDB()
        {
            List<Vendedor> listaUsuarios = new List<Vendedor>();
            ConexionSql conexionSQL = new ConexionSql();
            conexionSQL.Abrir();
            HandlerVendedor usuariosHandler = new HandlerVendedor();
            listaUsuarios = usuariosHandler.Leer();
            return listaUsuarios;
        }
    }
}
