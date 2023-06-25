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
        public static List<Cerdo> ConectarProductosCerdoDB()
        {
            List<Cerdo> listaProductos = new List<Cerdo>();
            ConexionSql conexionSQL = new ConexionSql();
            conexionSQL.Abrir();
            handlerCerdo productosHandlre = new handlerCerdo();
            listaProductos = productosHandlre.Leer();
            return listaProductos;
        }

        public static List<Vacuno> ConectarProductosVacunoDB()
        {
            List<Vacuno> listaProductos = new List<Vacuno>();
            ConexionSql conexionSQL = new ConexionSql();
            conexionSQL.Abrir();
            HanblerVacuno productosHandlre = new HanblerVacuno();
            listaProductos = productosHandlre.Leer();
            return listaProductos;
        }

        public static List<Ave> ConectarProductosAveDB()
        {
            List<Ave> listaProductos = new List<Ave>();
            ConexionSql conexionSQL = new ConexionSql();
            conexionSQL.Abrir();
            HandlerAve productosHandlre = new HandlerAve();
            listaProductos = productosHandlre.Leer();
            return listaProductos;
        }

        public static List<Cliente> ConectarUsuariosClienteDB()
        {
            List<Cliente> listaUsuarios = new List<Cliente>();
            ConexionSql conexionSQL = new ConexionSql();
            conexionSQL.Abrir();
            HanblerCliente usuariosHandler = new HanblerCliente();
            listaUsuarios = usuariosHandler.Leer();
            return listaUsuarios;
        }
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
