﻿using System;
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

    public delegate double CalcularGastosDelegate(Cliente cliente, List<Venta> lista);
    public static class Negocio
    {
        private static List<Persona> usuariosRegistrados;
        private static List<Carne> listaDeProductos;
        private static Queue<Cliente> colaClientes;
        private static List<Venta> listaVentas;
        private static List<List<Venta>> listaDeListDeVentas;
        private static List<Cliente> listaCliente;
        private static List<Vendedor> listaVendedor;
        private static List<Vacuno> listaVacuno;
        private static List<Cerdo> listaCerdo;
        private static List<Ave> listaAve;
        private static Vendedor trabajador;
        static Negocio()
        {
            usuariosRegistrados = new List<Persona>();
            listaDeProductos = new List<Carne>();
            colaClientes = new Queue<Cliente>();
            listaVentas = new List<Venta>();

          //  CargarVendedor();
          //  CargarProductos();
           // CargarClientes();
        }

        /// <summary>
        /// Calcula los gastos totales realizados por un cliente en base a una lista de ventas.
        /// </summary>
        /// <param name="cliente">El cliente para el cual se calcularán los gastos.</param>
        /// <param name="listaVentas">La lista de ventas.</param>
        /// <returns>El valor total de los gastos realizados por el cliente.</returns>
        public static double CalcularGastosTotales(Cliente cliente, List<Venta> listaVentas)
        {
            double gastosTotales = 0;

            foreach (Venta venta in listaVentas)
            {
                if (venta.IDCliente1 == cliente.ID)
                {
                    gastosTotales += venta.PrecioTotal;
                }

            }

            return gastosTotales;
        }


        /// <summary>
        /// carga un trabajador en la aplicacion 
        /// </summary>
        /// <param name="vendedor"></param>

        public static void CargarTrabajadores(this Vendedor vendedor)
        {
            trabajador = vendedor;
        }
        /// <summary>
        /// retorna vendedor 
        /// </summary>
        /// <returns></returns>
        public static Vendedor RetornaVendedor ()
        {
            return trabajador; 

        }

        /// <summary>
        /// busca un usuario en una lista de "usuariosRegistrados" a través de su correo electrónico y 
        ///   devuelve el objeto "Persona" correspondiente si se encuentra una coincidencia.
        /// </summary>
        /// <param name="corrreoElectornico"></param>
        /// <param name="contraseña"></param>
        /// <returns></returns> objeto Persona
        public static Persona? LogearUsuario(string corrreoElectronico,
            string contraseña, List<Cliente> listapersona, List<Vendedor> listaVendedores)
        {
            if (Validaciones.ValidarCamposIngresados(corrreoElectronico, contraseña))
            {
                
                    foreach (Persona item in listapersona)
                    {
                        if (item.CorreoElectronico.Trim().ToLower() == corrreoElectronico.Trim().ToLower()
                            && item.Contraseña == contraseña) //Dejo diferencia de mayus y espacios.
                        {
                            return item;
                        }
                    }
                
               
                foreach (Persona item in listaVendedores)
                {
                    if (item.CorreoElectronico.Trim().ToLower() == corrreoElectronico.Trim().ToLower()
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
                if (item.Tipo == Tipo)
                {
                    retorno++;
                }
            }

            return retorno;
        }
        /// <summary>
        /// calcula gastos totales 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static double CalcularGastosTotales(Cliente cliente)
        {
            double gastosTotales = 0;

            foreach (Venta venta in listaVentas)
            { 
                if(venta.IDCliente1 == cliente.ID)
                {
                    gastosTotales += venta.PrecioTotal;
                }
            
            }

            return gastosTotales;
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
        /// actualiza la lista de vendedores por medio de la lista que llega por parametro
        /// </summary>
        /// <param name="lisVendedorParametro"></param>
        public static void CargarListaTrabajadores(List<Vendedor> lisVendedorParametro)
        {
            listaVendedor = lisVendedorParametro;

        }
        /// <summary>
        /// cargar lista de cliente a traves de la que llega por parametro
        /// </summary>
        /// <param name="listaClienteParametro"></param>
        public static void CargaListaClientes(List<Cliente> listaClienteParametro)
        {

            listaCliente = listaClienteParametro;
        
        }

        /// <summary>
        /// carga la lista de la aplicacion por medio de la que llega por parametro
        /// </summary>
        /// <param name="listaAveParametro"></param>
        public static void CargaListaAves(List<Ave> listaAveParametro)
        {

            listaAve = listaAveParametro;

        }
        /// <summary>
        /// carga la lista de cerdos por medio de la que llega por parameto
        /// </summary>
        /// <param name="listaCerdoParametro"></param>
        public static void CargaListaCerdo(List<Cerdo> listaCerdoParametro)
        {

            listaCerdo = listaCerdoParametro;

        }
        /// <summary>
        /// caga lissta de vacuno por medio de la lista que llega or parametro 
        /// </summary>
        /// <param name="listaVacunoParametro"></param>
        public static void CargaListaVacuno(List<Vacuno> listaVacunoParametro)
        {

            listaVacuno = listaVacunoParametro;

        }
        /// <summary>
        /// retorna lista de vendedores 
        /// </summary>
        /// <returns>lista de vendedor</returns>
        public static List<Vendedor> RetornarListaVendedores()
        {
            return listaVendedor;

        }
        /// <summary>
        /// retorna lista de clientes 
        /// </summary>
        /// <returns>lista de cliente</returns>
        public static List<Cliente> RetornaListaClientes() 
        { 
            return listaCliente;
        }

        /// <summary>
        /// retorna lista de vacuno
        /// </summary>
        /// <returns>lista vacuno </returns>
        public static List<Vacuno> RetornarListaVacuno()
        {
            return listaVacuno;
        }
        /// <summary>
        /// retorna lista de ave
        /// </summary>
        /// <returns>retorna lista de ave</returns>
        public static List<Ave> RetornarListaAve()
        {
            return listaAve;
        }

        /// <summary>
        /// retorna lista de cerdo
        /// </summary>
        /// <returns>lista de ventas </returns>
        public static List<Cerdo> RetornarListaCerdo()
        {
            return listaCerdo;
        }

        /// <summary>
        /// en esta funcion se carga una lista de lista de ventas
        /// y al no hacerlo directamente la lista con la otra no se solapan
        /// </summary>
        /// <param name="listaDeVentas">lista de ventas</param> lista de ventas;
        public static void CargarVenta(List<Venta> listaDeVentas)
        {
            List<Venta> nuevaListaDeVentas = new List<Venta>(listaDeVentas);
            List<List<Venta>> listaDeListDeVentas = new List<List<Venta>>();
            listaDeListDeVentas.Add(nuevaListaDeVentas);

        }

        /// <summary>
        /// /agrega a la lista venta una venta
        /// </summary>
        /// <param name="listaVenta">lista de venta</param> lista de venta
        /// <param name="venta">instancia de venta</param> venta
        public static void CargarVenta(List<Venta> listaVenta, Venta venta)
        {
            listaVenta.Add(venta);
        }


        /// <summary>
        /// va iterando y sumando hasta obtener las ganancias totales
        /// </summary>
        /// <returns>ganacias </returns>
        public static double GananciaTotal()
        {
            double retorno = 0;

            foreach (Venta item in listaVentas)
            {
                if (item.MetodoPago == eMetodoPago.TarjetaDeCredito)
                {
                    double resultadoMasImpuesto = (item.Precio * item.CantidadDeUnidades) * 0.05;
                    retorno += (item.Precio * item.CantidadDeUnidades) + resultadoMasImpuesto;
                }
                else
                    retorno += (item.Precio * item.CantidadDeUnidades);
            }

            return retorno;
        }

        /// <summary>
        /// retorna la lista venta 
        /// </summary>
        /// <returns>lista de venta</returns> lista 
        public static List<Venta> RetornarListaDeVentas()
        {
            return listaVentas;
        }
        /// <summary>
        /// retorna lista de ventas para un cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>lista de venta </returns>
        public static List<Venta> RetornarListaDeVentas(Cliente cliente)
        {
            List<Venta> list = new();
            foreach (Venta venta in listaVentas)
            {
                if (cliente == venta.IDCliente1)
                    list.Add(venta);
            }
            return list;
        }



        /// <summary>
        ///  retorna el precio total de la factura por cliente
        /// </summary>
        /// <param name="listaVenta"></param> lista de venta creada
        /// <returns>ganancia total</returns> float 
        public static double GananciaTotal(Cliente usuario)
        {
            double resultado = 0;

            foreach (Venta venta in listaVentas)
            {
                if (usuario == venta.IDCliente1 && venta.MetodoPago == eMetodoPago.TarjetaDeCredito)
                {
                    double resultadoMasImpuesto = (venta.Precio * venta.CantidadDeUnidades) * 0.05;
                    resultado += (venta.Precio * venta.CantidadDeUnidades) + resultadoMasImpuesto;
                }
                else if (usuario == venta.IDCliente1)
                    resultado += (venta.Precio * venta.CantidadDeUnidades);
            }


            return resultado;
        }
        /// <summary>
        /// actualiza en la base de datos clientes
        /// </summary>
        /// <param name="cliente">instancia cliente</param>
        public static void CargarGastoCliente(Cliente cliente) 
        {
            HanblerCliente usuariosHandler = new HanblerCliente();
            usuariosHandler.Modificar(cliente);
            Negocio.CargaListaClientes(usuariosHandler.Leer());

        }
        /// <summary>
        /// carga en la base datos vacuno
        /// </summary>
        /// <param name="vacuno">instancia vacuno</param>
        public static void CargarModificacionesProducto(Vacuno vacuno)
        {
            HanblerVacuno handlerVacuno = new HanblerVacuno();
            handlerVacuno.Modificar(vacuno);
            Negocio.CargaListaVacuno(handlerVacuno.Leer());

        }
        /// <summary>
        /// carga las modificaciones en una base de datos de un ave 
        /// </summary>
        /// <param name="Ave">instancia de ave</param>
        public static void CargarModificacionesProducto(Ave Ave)
        {
            HandlerAve handlerAve = new HandlerAve();
            handlerAve.Modificar(Ave);
            Negocio.CargaListaAves(handlerAve.Leer());

        }

        /// <summary>
        /// carga en la base de datos las modificciones de un cerdo 
        /// </summary>
        /// <param name="cerdo">instancia cerdo</param>
        public static void CargarModificacionesProducto(Cerdo cerdo)
        {
            handlerCerdo handlerCerdo = new handlerCerdo();
            handlerCerdo.Modificar(cerdo);
            Negocio.CargaListaCerdo(handlerCerdo.Leer());

        }
        /// <summary>
        /// gastos totales de un cliente
        /// </summary>
        /// <param name="listaVenta">lista de venta creada en la compra</param>
        /// <param name="usuario">instancia de cliente</param>
        /// <returns>double</returns>
        public static double GananciaTotal(List<Venta> listaVenta, Cliente usuario)
        {
            double resultado = 0;
           
            foreach (Venta venta in listaVenta)
            {
              if(venta.IDCliente1== usuario.ID)
                {
                    resultado += venta.Precio * venta.CantidadDeUnidades;

                }

            }


            return resultado;
        }
        /// <summary>
        /// carga la lista de ventas a la aplicacion
        /// </summary>
        public static void CargaListaDeVenta()
        {
            listaVentas = EscribirArchivo.CargarVentasDesdeArchivo();

        }
        /// <summary>
        /// entrega un cliente su id 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static int RetornaId(this Cliente cliente)
        {
            return cliente.id;
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


