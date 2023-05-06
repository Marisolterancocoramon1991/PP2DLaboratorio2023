using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    internal class Vacuno : Carne
    {
        public enum eRazasDeVacas
        {
            Belga,
            Brangus,
            Braford,
            Pardo
        }
        public enum eCategoria
        {
            novillos,
            vaca,
            ternero,
            toro
        }

        private eRazasDeVacas razasDeVacas;
        private eCategoria categoria;


        public Vacuno(string nombre, string tipo, float precio, int cantidadEnInventarioKilos, eRazasDeVacas razasDeVacas, eCategoria categoria
            ) : base(nombre, tipo, precio, cantidadEnInventarioKilos)
        {
            this.categoria = categoria;
            this.razasDeVacas = razasDeVacas;
        }

        public eRazasDeVacas RazasDeVacas { get => razasDeVacas; }
        public eCategoria Categoria { get => categoria; }


        /// <summary>
        /// muestra las caracteristicas esenciales ademas de algunas especificas
        /// </summary>
        /// <returns></returns> string
        public override string MostrarCarnes()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDetallesDeProducto());
            sb.AppendLine($"Raza de la vaca: {razasDeVacas}");
            sb.AppendLine($"Cateogoria del animal : {categoria}");


            return sb.ToString();


        }
    }
}
