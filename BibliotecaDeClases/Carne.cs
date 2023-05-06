using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Cliente;
using System.Linq;

namespace BibliotecaDeClases
{
    public abstract class Carne
    {
        private string nombre = string.Empty;
        private string tipos = string.Empty;
        private float precio;
        private int cantidadEnInventarioKilos;

        private List<Carne> carnes;

        public Carne(string nombre, string tipo, float precio, int cantidadEnInventarioKilos) : this()
        {
            this.Nombre = nombre;
            this.Tipo = tipo;

            this.Precio = precio;
            this.cantidadEnInventarioKilos = cantidadEnInventarioKilos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipos; set => tipos = value; }
        public float Precio { get => precio; set => precio = value; }
        public int CantidadEnInventario
        {
            get => cantidadEnInventarioKilos;
            set => cantidadEnInventarioKilos = value;
        }

        public Carne()
        {
            carnes = new List<Carne>();

        }
        public void AgregarCarnes(Carne carne)
        {
            carnes.Add(carne);

        }
            
        /// <summary>
        /// muestra la informacion general del producto
        /// </summary>
        /// <returns></returns> string
        public virtual string MostrarCarnes()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Carne carne in carnes)
            {
                sb.AppendLine($"  Carne  {nombre}");
                sb.AppendLine($"tipo de carne{tipos}");
                sb.AppendLine($"el del producto precio {precio}");

            }


            return sb.ToString();

        }


        /// <summary>
        /// suma la cantidad de unidades agregadas en el stock
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="cantidadASumar"></param>
        /// <returns></returns> retorna el objeto de carne
        public static Carne operator +(Carne p1, int cantidadASumar)
        {
            p1.cantidadEnInventarioKilos = p1.cantidadEnInventarioKilos + cantidadASumar;

            return p1;
        }

        /// <summary>
        /// suma el stock de forma progresiva
        /// </summary>
        /// <param name="p1"></param>
        /// <returns></returns> retorna el objeto
        public static Carne operator ++(Carne p1)
        {
            p1.cantidadEnInventarioKilos++;

            return p1;
        }


        /// <summary>
        /// resta de forma progresiva la cantida de inventario
        /// </summary>
        /// <param name="p1"></param>
        /// <returns></returns> regresa el objeto
        public static Carne operator --(Carne p1)
        {
            p1.cantidadEnInventarioKilos--;

            return p1;
        }
        /// <summary>
        /// resta la cantidad necesaria de stock del producto
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="CantidadARestar"></param>
        /// <returns></returns> retorna objeto 
        public static Carne operator -(Carne p1, int CantidadARestar)
        {
            p1.cantidadEnInventarioKilos-= CantidadARestar;

            return p1;
        }
        
        /// <summary>
        /// multiplica el precio por la unidades establecidas
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="multiplicador"></param>
        /// <returns></returns> retorna un flotante
        public static float operator *(Carne p1, int multiplicador)
        {
            float resultado = p1.precio * multiplicador;

            return resultado;
        }


        /// <summary>
        /// muestra los detalles del producto
        /// </summary>
        /// <returns></returns> retorna un string
        public virtual string MostrarDetallesDeProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Corte : {nombre}");
            sb.AppendLine($"Tipo de producto: {tipos}");
            sb.AppendLine($"Precio : ${precio}");
            sb.AppendLine($"inventario por kilos : {cantidadEnInventarioKilos}");


            return sb.ToString();
        }
    }



}
