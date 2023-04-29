using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    internal class Negocio
    {

    }
}
/*
 *  #region Atributos
        private static List<Usuario> usuariosRegistrados;
        private static List<Producto> listaDeProductos;
        private static Queue<Cliente> colaClientes;
        private static List<Venta> listaVentas;
        #endregion

        #region Constructores
        static Negocio()
        {
            usuariosRegistrados = new List<Usuario>();
            listaDeProductos = new List<Producto>();
            colaClientes = new Queue<Cliente>();
            listaVentas = new List<Venta>();

            CargarUsuarios();
            CargarProductos();
            CargarClientes();
        }
        #endregion

        #region Metodos
        private static void CargarUsuarios()
        {
            usuariosRegistrados.Add(new Usuario("Ignacio Fadon", "fadon@vendedor.com", "contraseña", Usuario.eTipoDeUsuario.Vendedor));
            usuariosRegistrados.Add(new Usuario("Valentin Peralta", "peralta@peralta.com", "contraseña", Usuario.eTipoDeUsuario.Dueño));
            usuariosRegistrados.Add(new Usuario("José Martinez de Hoz", "contador@contador.com","contraseña", Usuario.eTipoDeUsuario.Contador));
        }
        private static void CargarProductos()
        {
            listaDeProductos.Add(new Procesador("Procesador", "AMD", "Ryzen 5 3600g", 35000, "Gamer", 3, 4, 3.6, "AM4"));
            listaDeProductos.Add(new Notebook("Notebook", "Asus", "X515EA", 105000, "Escritorio", 2, 8, 256, "Intel I3 1115g"));
            listaDeProductos.Add(new MemoriaRam("Memoria Ram", "Corsair","ValueSelect" , 18100, "Gamer", 1, 16, "DDR4", 2400));
            listaDeProductos.Add(new PlacaDeVideo("Placa De Video", "Asus", "GeForce GTX 1630", 95000, "Escritorio", 3, "GTX 1630", 4, 75));
        }

        private static void CargarClientes()
        {
            colaClientes.Enqueue(new Cliente("Lautaro Martinez", 85000, Cliente.eMetodoPago.MercadoPago));
            colaClientes.Enqueue(new Cliente("Daniela Perez", 160000, Cliente.eMetodoPago.Efectivo));
            colaClientes.Enqueue(new Cliente("Juan Basquez", 35000, Cliente.eMetodoPago.TarjetaDeCredito));
            colaClientes.Enqueue(new Cliente("Ludmila Fernandez", 85000, Cliente.eMetodoPago.TarjetaDeCredito));
        }

        public static void CargarVenta(Venta venta)
        {
            listaVentas.Add(venta);
        }

        public static bool ValidarCamposIngresados(string email, string contraseña)
        {
            if(string.IsNullOrEmpty(email.Trim()) || string.IsNullOrEmpty(contraseña))
            {
                return false;
            }
            return true;
        }

        public static Usuario LogearUsuario(string email, string contraseña)
        {
            if(ValidarCamposIngresados(email, contraseña))
            {
                foreach(Usuario item in usuariosRegistrados)
                {
                    if(item.Email.Trim().ToLower() == email.Trim().ToLower() 
                        && item.Contraseña == contraseña) //Dejo diferencia de mayus y espacios.
                    {
                        return item;
                    }
                }
            }
            return null;

        }

        public static List<Producto> RetornarProductos()
        {
            return listaDeProductos;
        }

        public static Queue<Cliente> RetornarClientes()
        {
            return colaClientes;
        }



        public static List<Producto> BuscarPorPrecio(double precioMinimo, double precioMaximo)
        {
            List<Producto> lista = new List<Producto>();

            foreach (Producto item in listaDeProductos)
            {
                if(item.Precio > precioMinimo && item.Precio < precioMaximo)
                {
                    lista.Add(item);
                }
            }

            return lista;
        }

        public static List<Producto> BuscarPorCategoria(string categoria)
        {
            List<Producto> lista = new List<Producto>();

            foreach (Producto item in listaDeProductos)
            {
                if (item.Categoria.ToLower().Trim().Contains(categoria.ToLower().Trim()) || categoria == "")
                {
                    lista.Add(item);
                }
            }

            return lista;
        }

        public static int RetornarCantidadVentas()
        {
            int ret = 0;

            foreach(Venta item in listaVentas)
            {
                ret++;
            }
            return ret;
        }

        public static List<String> DevuelveCategorias()
        {
            List<String> categorias = new List<String>();

            foreach(Venta item in listaVentas)
            {
                if(categorias.Contains(item.ProductoVendido.Categoria) == false)
                {
                    categorias.Add(item.ProductoVendido.Categoria);
                }
            }
            return categorias;
        }



        public static int ContadorCategoriasVendidas(string categoria)
        {
            int retorno = 0;

            foreach(Venta item in listaVentas)
            {
                if(item.ProductoVendido.Categoria == categoria)
                {
                    retorno++;
                }
            }

            return retorno;
        }

        public static double GananciaTotal()
        {
            double retorno = 0;

            foreach(Venta item in listaVentas)
            {
                retorno += item.ProductoVendido.Precio;
            }

            return retorno;
        }

        public static double GananciaPorTag(string categoria)
        {
            double retorno = 0;

            foreach(Venta item in listaVentas)
            {
                 if(item.ProductoVendido.Categoria == categoria)
                 {
                    retorno += item.ProductoVendido.Precio;
                 }
            }

            return retorno;
        }


        #endregion


*/