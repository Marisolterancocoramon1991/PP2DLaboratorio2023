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
        private string  productoVendido;
        private eMetodoPago metodoDePago;
        private int cantidadDeUnidades;
        private int IDCliente;
        private string tipo;
        private string nombre;
        float precio;
        float precioTotal;
     

        public Venta(string productoVendido,string tipo, float precio , float precioTotal ,
            eMetodoPago metodoDePago, int cantidadDeUnidades, int iDCliente, string nombre)
        {
            this.PrecioTotal = precioTotal;
            this.Precio = precio;
            this.Nombre = nombre;
            this.Tipo = tipo;    
            this.productoVendido = productoVendido;
            this.metodoDePago = metodoDePago;
            this.CantidadDeUnidades = cantidadDeUnidades;
            IDCliente1 = iDCliente;
        }

        public Venta() 
        { }
        public string ProductoVendido
        {
            get { return productoVendido; }
        }
        public eMetodoPago MetodoPago
        { get => metodoDePago; set => metodoDePago = value; }
        public int CantidadDeUnidades { get => cantidadDeUnidades; set => cantidadDeUnidades = value; }
        public int IDCliente1 { get => IDCliente; set => IDCliente = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public float PrecioTotal { get => precioTotal; set => precioTotal = value; }


        /// <summary>
        /// muestra los detalles de la venta
        /// </summary>
        /// <returns></returns> string mensaje
        public virtual string MostrarDetallesDeVenta()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Muchas gracias por su compra de Productos de alta calidad");
            sb.AppendLine($"Producto : {Nombre}");
            sb.AppendLine($"Tipo de producto: {Tipo}");
            sb.AppendLine($"Precio : ${Precio}");
            sb.AppendLine($"precio total de este producto : {PrecioTotal}");


            return sb.ToString();
        }
    }

  
}

