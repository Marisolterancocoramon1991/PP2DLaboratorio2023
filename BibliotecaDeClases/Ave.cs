using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Cerdo;

namespace BibliotecaDeClases
{
    internal class Ave : Carne
    {
        public enum eTipoAve 
        {
            Huevo,
            Pollo,
            Gallina  
        }
        private eTipoAve tipoAve;
        public Ave(string nombre, string tipo, float precio, int cantidadEnInventarioKilos, eTipoAve tipoAve)
            : base(nombre, tipo, precio, cantidadEnInventarioKilos)
        {
            this.tipoAve= tipoAve;
        }

        public eTipoAve TipoAve { get => tipoAve; }


        /// <summary>
        /// muestra los datos del tipo de producto de manera polimorfica
        /// </summary>
        /// <returns></returns> retorna de forma de string toda la informacion
        public override string MostrarCarnes()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDetallesDeProducto());
            sb.AppendLine($"Articulo de ave : {tipoAve}");

            return sb.ToString();


        }
    }
}
