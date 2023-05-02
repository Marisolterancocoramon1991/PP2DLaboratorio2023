using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Persona;
using static BibliotecaDeClases.Vendedor;
using static BibliotecaDeClases.Venta;

namespace BibliotecaDeClases
{
    public static class Negocio
    {
        private static List<Persona> usuariosRegistrados;
        private static List<Carne> listaDeProductos;
        private static Queue<Cliente> colaClientes;
        private static List<Venta> listaVentas;

        static Negocio()
        {
            usuariosRegistrados = new List<Persona>();
            listaDeProductos = new List<Carne>();
            colaClientes = new Queue<Cliente>();
            listaVentas = new List<Venta>();

             CargarVendedor();
           //  CargarProductos();
            CargarClientes();
        }

        private static void CargarVendedor()
        {
            usuariosRegistrados.Add(new Vendedor("Lucas", "Santos", "Combate de los Pozos",
                "LucasBriceño@gmial.com", "123456789", 154545,eTurno.tarde, eTipoDeUsuario.Vendedor));


        }

        private static void CargarClientes() 
        {
            usuariosRegistrados.Add(new Cliente("Marisol", "Briceño", "capital"
                , "marienarg@gmail.com", "dwee2w12e", 0, "878484", eTipoDeUsuario.Cliente));
                usuariosRegistrados.Add(new Cliente("Kervin", "Briceño", "Capital",
                "KervinBriceño@gmail.com", "123456", 156516, "6546546", eTipoDeUsuario.Cliente));
            usuariosRegistrados.Add(new Cliente("Vicente", "Briceño", "Capital",
                "VicenteBriceño@gmail.com", "1234fef6", 1560, "5465798", eTipoDeUsuario.Cliente));

        }
        public static Persona? LogearUsuario(string corrreoElectornico, string contraseña)
        {
            if (Validaciones.ValidarCamposIngresados(corrreoElectornico, contraseña))
            {
                foreach (Persona item in usuariosRegistrados)
                {
                    if (item.CorreoElectronico.Trim().ToLower() == corrreoElectornico.Trim().ToLower()
                        && item.Contraseña == contraseña) //Dejo diferencia de mayus y espacios.
                    {
                        return item;
                    }
                }
            }
            return null;

        }
        public static List<Carne> RetornarProductos()
        {
            return listaDeProductos;
        }

        public static Queue<Cliente> RetornarClientes()
        {
            return colaClientes;
        }

        public static List<Carne> BuscarPorPrecio(double precioMinimo, double precioMaximo)
        {
            List<Carne> lista = new List<Carne>();

            foreach (Carne item in listaDeProductos)
            {
                if (item.Precio > precioMinimo && item.Precio < precioMaximo)
                {
                    lista.Add(item);
                }
            }

            return lista;
        }

        public static List<Carne> BuscarPorTipo(string categoria)
        {
            List<Carne> lista = new List<Carne>();

            foreach (Carne item in listaDeProductos)
            {
                if (item.Tipo.ToLower().Trim().Contains(categoria.ToLower().Trim()) || categoria == "")
                {
                    lista.Add(item);
                }
            }

            return lista;
        }

        public static int RetornarCantidadVentas()
        {
            int ret = 0;

            foreach (Venta item in listaVentas)
            {
                ret++;
            }
            return ret;
        }


        public static int ContadorTiposVendidas(string Tipo)
        {
            int retorno = 0;

            foreach (Venta item in listaVentas)
            {
                if (item.ProductoVendido.Tipo == Tipo)
                {
                    retorno++;
                }
            }

            return retorno;
        }

        public static double GananciaTotal()
        {
            double retorno = 0;

            foreach (Venta item in listaVentas)
            {
                retorno += item.ProductoVendido.Precio;
            }

            return retorno;
        }
        public static double GananciaPorMercadoPago(eMetodoPago metodoPago)
        {
            double retorno = 0;

            foreach (Venta item in listaVentas)
            {
                if (item.MetodoPago == metodoPago)
                {
                    retorno += item.ProductoVendido.Precio;
                }
            }

            return retorno;
        }

    }
}


