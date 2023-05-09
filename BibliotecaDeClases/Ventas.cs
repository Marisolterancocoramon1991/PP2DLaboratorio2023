using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Carne;

namespace BibliotecaDeClases
{
    public class Venta
    {
        private Carne productoVendido;
        private eMetodoPago metodoDePago;
        private int cantidadDeUnidades;
        private int IDCliente;
        public enum eMetodoPago
        {
            TarjetaDeCredito,
            MercadoPago,
            TarjetaDebito
        }



        public Venta(Carne productoVendido, eMetodoPago metodoDePago, int cantidadDeUnidades, int iDCliente)
        {
            this.productoVendido = productoVendido;
            this.metodoDePago = metodoDePago;
            this.CantidadDeUnidades = cantidadDeUnidades;
            IDCliente1 = iDCliente;
        }


        public Carne ProductoVendido
        {
            get { return productoVendido; }
        }
        public eMetodoPago MetodoPago
        { get => metodoDePago; }
        public int CantidadDeUnidades { get => cantidadDeUnidades; set => cantidadDeUnidades = value; }
        public int IDCliente1 { get => IDCliente; set => IDCliente = value; }


        /// <summary>
        /// muestra los detalles de la venta
        /// </summary>
        /// <returns></returns> string mensaje
        public virtual string MostrarDetallesDeVenta()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Muchas gracias por su compra de Productos de alta calidad");
            sb.AppendLine($"Producto : {ProductoVendido.Nombre}");
            sb.AppendLine($"Tipo de producto: {productoVendido.Tipo}");
            sb.AppendLine($"Precio : ${ProductoVendido.Precio}");
            sb.AppendLine($"precio total de este producto : {productoVendido * cantidadDeUnidades}");


            return sb.ToString();
        }
    }

  
}

