using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Cerdo : Carne
    {


        public enum eRazasDeCerdo
        {
            Ibericos,
            Mallorquinos,
            Lanbrace,
            Duroc
        }

        private eRazasDeCerdo razasDeCerdo;



        public Cerdo(string nombre, string tipo, float precio, int cantidadEnInventarioKilos, eRazasDeCerdo razasDeCerdo
            ) : base(nombre, tipo, precio, cantidadEnInventarioKilos)
        {

            this.razasDeCerdo = razasDeCerdo;
        }

        public eRazasDeCerdo RazasDeCerdo { get => razasDeCerdo; }


        public override string MostrarCarnes()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDetallesDeProducto());
            sb.AppendLine($"Raza del cerdo: {razasDeCerdo}");

            return sb.ToString();


        }
    }

}

