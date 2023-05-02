using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static Carne operator +(Carne p1, int cantidadASumar)
        {
            p1.cantidadEnInventarioKilos = p1.cantidadEnInventarioKilos + cantidadASumar;

            return p1;
        }
        public static Carne operator ++(Carne p1)
        {
            p1.cantidadEnInventarioKilos++;

            return p1;
        }

        public static Carne operator --(Carne p1)
        {
            p1.cantidadEnInventarioKilos--;

            return p1;
        }

        
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
