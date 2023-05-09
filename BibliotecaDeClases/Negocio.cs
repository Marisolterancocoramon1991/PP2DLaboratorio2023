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
    public  class Negocio
    {
        private static List<Persona> usuariosRegistrados;
        private static List<Carne> listaDeProductos;
        private static Queue<Cliente> colaClientes;
        private static List<Venta> listaVentas;
        private static List<List<Venta>> listaDeListDeVentas;
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
        

        /// <summary>
        /// instancia y agrega a la lista usuarios registrados los vendedores 
        /// </summary>
        private static void CargarVendedor()
        {
            usuariosRegistrados.Add(new Vendedor("Lucas", "Santos", "Combate de los Pozos",
                "LucasBriceño@gmial.com", "123456789", 154545, eTurno.tarde, eTipoDeUsuario.Vendedor));


        }


        /// <summary>
        /// instancia y agrega a la lista usuarios registrados los clientes
        /// </summary>
        private static void CargarClientes()
        {
            usuariosRegistrados.Add(new Cliente("Marisol", "Briceño", "capital"
                , "marienarg@gmail.com", "dwee2w12e", 21321, "878484", eTipoDeUsuario.Cliente));
            usuariosRegistrados.Add(new Cliente("Kervin", "Briceño", "Capital",
            "KervinBriceño@gmail.com", "123456", 156516, "6546546", eTipoDeUsuario.Cliente));
            usuariosRegistrados.Add(new Cliente("Vicente", "Briceño", "Capital",
                "VicenteBriceño@gmail.com", "1234fef6", 1560, "5465798", eTipoDeUsuario.Cliente));

        }


        /// <summary>
        /// instancia y agrega a la lista de productos todo el stock 
        /// </summary>
        private static void CargarProductos()
        {

            listaDeProductos.Add(new Vacuno("Osobuco", "Carne Roja", 1000, 30, eRazasDeVacas.Pardo, eCategoria.vaca));
            listaDeProductos.Add(new Vacuno("Cola de Cuadril", "Carne Roja", 1500, 25, eRazasDeVacas.Braford, eCategoria.ternero));
            listaDeProductos.Add(new Vacuno("Bife Ancho", "Carne Roja", 1200,50,eRazasDeVacas.Brangus,eCategoria.toro));
            listaDeProductos.Add(new Vacuno("Asado de Tira", "Carne Roja", 1300,300,eRazasDeVacas.Brangus,eCategoria.ternero));
            listaDeProductos.Add(new Vacuno("Falda", "Carne Roja", 1100,25,eRazasDeVacas.Pardo, eCategoria.novillos));
            listaDeProductos.Add(new Vacuno("Nalga", "Carne Roja", 1120,80,eRazasDeVacas.Pardo, eCategoria.novillos));
            listaDeProductos.Add(new Vacuno("Pecho", "Carne Roja", 2000,30,eRazasDeVacas.Braford, eCategoria.toro));
            listaDeProductos.Add(new Vacuno("Bife Vacio", "Carne Roja", 3000,50,eRazasDeVacas.Pardo, eCategoria.novillos));
            listaDeProductos.Add(new Vacuno("Bife Ancho con Hueso", "Carne Roja", 500,10,eRazasDeVacas.Pardo, eCategoria.ternero));
            listaDeProductos.Add(new Vacuno("Espinazo", "Carne Roja", 465,50,eRazasDeVacas.Braford, eCategoria.novillos));
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
            listaDeProductos.Add(new Ave("Huevos", "Cigoto", 20, 1000, eTipoAve.Huevo));
            listaDeProductos.Add(new Ave("Suprema", "Blanca", 900, 80, eTipoAve.Pollo));
            listaDeProductos.Add(new Ave("PATA y Muslo", "Blanca", 1500, 30, eTipoAve.Gallina));
            listaDeProductos.Add(new Ave("Huevos Grandes", "Cigoto", 30, 1200, eTipoAve.Huevo));
            listaDeProductos.Add(new Ave("Churrasquito", "Blanca", 900, 30, eTipoAve.Pollo));
            listaDeProductos.Add(new Ave("Milanesa", "Blanca", 900, 30, eTipoAve.Gallina));
        }

        /// <summary>
        /// busca un usuario en una lista de "usuariosRegistrados" a través de su correo electrónico y 
        ///   devuelve el objeto "Persona" correspondiente si se encuentra una coincidencia.
        /// </summary>
        /// <param name="corrreoElectornico"></param>
        /// <param name="contraseña"></param>
        /// <returns></returns> objeto Persona
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
        /// <summary>
        /// retorna lista e productos 
        /// </summary>
        /// <returns></returns> lista e productos 
        public static List<Carne> RetornarProductos()
        {
            return listaDeProductos;
        }
       



        /// <summary>
        /// retorna cola de clientes 
        /// </summary>
        /// <returns></returns> cola clientes
        public static Queue<Cliente> RetornarClientesCompras()
        {
            return colaClientes;
        }


        /// <summary>
        /// retorna la lista de usuarios
        /// </summary>
        /// <returns></returns> lista
        public static List<Persona> RetornaListaUsuarios()
        {
            return usuariosRegistrados;
        }

        /// <summary>
        ///  agrega un objeto Cliente a una cola de clientes.
        /// </summary>
        /// <param name="cliente"></param> parámetro un objeto Cliente
        public static void CargarColaClientes(Cliente cliente)
        {
            colaClientes.Enqueue(cliente);
        }
        /// <summary>
        ///  devuelve una lista de objetos de la clase Carne que estén dentro del rango de precios especificado.
        /// </summary>
        /// <param name="precioMinimo"></param> precio minimo 
        /// <param name="precioMaximo"></param> precio Maximo
        /// <returns></returns> retorna la lista
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


        /// <summary>
        /// La función BuscarPorTipo recibe un parámetro categoria y busca en la lista de productos listaDeProductos) 
        /// los productos que tengan un tipo que contenga la cadena categoria (si es que se especificó una)
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
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
        /// <summary>
        /// retorna cantida de ventas
        /// </summary>
        /// <returns></returns> un entero
        public static int RetornarCantidadVentas()
        {
            int ret = 0;

            foreach (Venta item in listaVentas)
            {
                ret++;
            }
            return ret;
        }

        /// <summary>
        /// Esta función recibe como parámetro un string Tipo, y cuenta cuántas ventas se 
        /// realizado de un producto con ese tipo en particular, dentro de la lista de ventas listaVentas.
        /// </summary>
        /// <param name="Tipo"></param>
        /// <returns></returns>
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


        /// <summary>
        /// carga una venta a la lista de ventas
        /// </summary>
        /// <param name="venta"></param>
        public static void CargarVenta(Venta venta)
        {
            listaVentas.Add(venta);
        }


        /// <summary>
        /// en esta funcion se carga una lista de lista de ventas
        /// y al no hacerlo directamente la lista con la otra no se solapan
        /// </summary>
        /// <param name="listaDeVentas"></param> lista de ventas;
        public static void CargarVenta(List<Venta> listaDeVentas)
        {
            List<Venta> nuevaListaDeVentas = new List<Venta>(listaDeVentas);
            List<List<Venta>> listaDeListDeVentas = new List<List<Venta>>();
            listaDeListDeVentas.Add(nuevaListaDeVentas);
           
        }

        /// <summary>
        /// /agrega a la lista venta una venta
        /// </summary>
        /// <param name="listaVenta"></param> lista de venta
        /// <param name="venta"></param> venta
        public static void CargarVenta(List<Venta> listaVenta, Venta venta)
        {
            listaVenta.Add(venta);
        }


        /// <summary>
        /// va iterando y sumando hasta obtener las ganancias totales
        /// </summary>
        /// <returns></returns>
        public static double GananciaTotal()
        {
            double retorno = 0;
       
            foreach (Venta item in listaVentas)
            {
                retorno += (item.ProductoVendido.Precio* item.CantidadDeUnidades);
            }

            return retorno;
        }

        /// <summary>
        /// retorna la lista venta 
        /// </summary>
        /// <returns></returns> lista 
        public static List<Venta> RetornarListaDeVentas()
        {
            return listaVentas;
        }

        /// <summary>
        ///  retorna el precio total de la factura
        /// </summary>
        /// <param name="listaVenta"></param> lista de venta creada
        /// <returns></returns> float 
        public static float RetornaPrecioTotalFactura(List<Venta> listaVenta)
        {
            float resultado = 0;

            foreach(Venta venta in listaVenta)
            {
                resultado += (venta.ProductoVendido.Precio * venta.CantidadDeUnidades);

            }
    

        return resultado;
        }


        /*    public static double GananciaPorMercadoPago(Cliente cliente)
            {
                double retorno = 0;

                foreach (Venta item in listaVentas)
                {
                    if (item.ProductoVendido. == producto.ProductoVendido.MetodoPago)
                    {
                        retorno += item.ProductoVendido.Precio;
                    }
                }

                return retorno;
            }
        */
    }
}


