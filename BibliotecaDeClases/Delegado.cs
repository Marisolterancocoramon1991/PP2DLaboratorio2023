using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public delegate double CalcularGastosDelegate(Cliente cliente, List<Venta> lista);
    public class Delegado
    {        
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
    }
}
