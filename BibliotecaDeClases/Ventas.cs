using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Venta
    {
        private Carne productoVendido;
        private eMetodoPago metodoDePago;
        public enum eMetodoPago
        {
            TarjetaDeCredito,
            MercadoPago,
            TarjetaDebito
        }


    
        public Venta(Carne productoVendido, eMetodoPago metodoDePago)
        {
            this.productoVendido = productoVendido;
            this.metodoDePago = metodoDePago;   
        }


        public Carne ProductoVendido
        {
            get { return productoVendido; }
        }
        public eMetodoPago MetodoPago
        { get => metodoDePago; }

    }
}
