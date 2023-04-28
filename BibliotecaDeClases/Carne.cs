using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    internal class Carne
    {
        private string nombre = string.Empty;
        private string tipos = string.Empty;
        private float precio;
        private int cantidadEnInventario;
        private List<Carne> carnes;

        public Carne(string nombre, string tipo, float precio, int cantidadEnInventario):this()
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Precio = precio;
            this.CantidadEnInventario = cantidadEnInventario;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipos; set => tipos = value; }
        public float Precio { get => precio; set => precio = value; }
        public int CantidadEnInventario
        {
            get => cantidadEnInventario;
            set => cantidadEnInventario = value;
        }

        public Carne()
        {
            carnes = new List<Carne>();

        }
        public void AgregarCarnes (Carne carne)
        {
            carnes.Add(carne);

        }

        public void MostrarCarnes() 
        {
            
        
        
        }

    }



}
