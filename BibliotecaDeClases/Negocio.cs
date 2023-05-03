using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Cerdo;
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
            CargarProductos();
            CargarClientes();
        }

        private static void CargarVendedor()
        {
            usuariosRegistrados.Add(new Vendedor("Lucas", "Santos", "Combate de los Pozos",
                "LucasBriceño@gmial.com", "123456789", 154545, eTurno.tarde, eTipoDeUsuario.Vendedor));


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

        private static void CargarProductos()
        {

            listaDeProductos.Add(new Vacuno("Osobuco", "Carne Roja", 1000, 30, Vacuno.eRazasDeVacas.Pardo, Vacuno.eCategoria.vaca));
            listaDeProductos.Add(new Vacuno("Cola de Cuadril", "Carne Roja", 1500, 25, Vacuno.eRazasDeVacas.Braford, Vacuno.eCategoria.ternero));
            listaDeProductos.Add(new Vacuno("Bife Ancho", "Carne Roja", 1200,50,Vacuno.eRazasDeVacas.Brangus,Vacuno.eCategoria.toro));
            listaDeProductos.Add(new Vacuno("Asado de Tira", "Carne Roja", 1300,300,Vacuno.eRazasDeVacas.Brangus,Vacuno.eCategoria.ternero));
            listaDeProductos.Add(new Vacuno("Falda", "Carne Roja", 1100,25,Vacuno.eRazasDeVacas.Pardo,Vacuno.eCategoria.novillos));
            listaDeProductos.Add(new Vacuno("Nalga", "Carne Roja", 1120,80,Vacuno.eRazasDeVacas.Pardo,Vacuno.eCategoria.novillos));
            listaDeProductos.Add(new Vacuno("Pecho", "Carne Roja", 2000,30,Vacuno.eRazasDeVacas.Braford,Vacuno.eCategoria.toro));
            listaDeProductos.Add(new Vacuno("Bife Vacio", "Carne Roja", 3000,50,Vacuno.eRazasDeVacas.Pardo,Vacuno.eCategoria.novillos));
            listaDeProductos.Add(new Vacuno("Bife Ancho con Hueso", "Carne Roja", 500,10,Vacuno.eRazasDeVacas.Pardo,Vacuno.eCategoria.ternero));
            listaDeProductos.Add(new Vacuno("Espinazo", "Carne Roja", 465,50,Vacuno.eRazasDeVacas.Braford,Vacuno.eCategoria.novillos));
            listaDeProductos.Add(new Cerdo("Pechito","Carne Semi",800,30,eRazasDeCerdo.Ibericos));
            listaDeProductos.Add(new Cerdo("Bondiola", "Carne Semi", 1000, 10, eRazasDeCerdo.Mallorquinos));
            listaDeProductos.Add(new Cerdo("Costillita", "Carne Semi", 2200, 20, eRazasDeCerdo.Ibericos));
            listaDeProductos.Add(new Cerdo("Matambrito", "Carne Semi", 3200, 310, eRazasDeCerdo.Lanbrace));
            listaDeProductos.Add(new Cerdo("Milanesa", "Carne Semi", 1500, 350, eRazasDeCerdo.Mallorquinos));
            listaDeProductos.Add(new Cerdo("Carrè", "Carne Semi", 1800, 10, eRazasDeCerdo.Ibericos));
            listaDeProductos.Add(new Cerdo("Cuadril", "Carne Semi", 2000, 20, eRazasDeCerdo.Lanbrace));
            listaDeProductos.Add(new Cerdo("Paletilla", "Carne Semi", 1100, 90, eRazasDeCerdo.Ibericos));
            listaDeProductos.Add(new Cerdo("Solomillo", "Carne Semi", 1300, 50, eRazasDeCerdo.Mallorquinos));
            listaDeProductos.Add(new Cerdo("Pecho", "Carne Semi", 1800, 40, eRazasDeCerdo.Ibericos));
            listaDeProductos.Add(new Cerdo("Costillar", "Carne Semi", 900, 30, eRazasDeCerdo.Lanbrace));
            listaDeProductos.Add(new Ave("Huevos", "Cigoto", 20, 1000, Ave.eTipoAve.Huevo));
            listaDeProductos.Add(new Ave("Suprema", "Blanca", 900, 80, Ave.eTipoAve.Pollo));
            listaDeProductos.Add(new Ave("PATA y Muslo", "Blanca", 1500, 30, Ave.eTipoAve.Gallina));
            listaDeProductos.Add(new Ave("Huevos Grandes", "Cigoto", 30, 1200, Ave.eTipoAve.Huevo));
            listaDeProductos.Add(new Ave("Churrasquito", "Blanca", 900, 30, Ave.eTipoAve.Pollo));
            listaDeProductos.Add(new Ave("Milanesa", "Blanca", 900, 30, Ave.eTipoAve.Gallina));
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


