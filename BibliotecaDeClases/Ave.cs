using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Cerdo;

namespace BibliotecaDeClases
{
    public class Ave : Carne
    {
      
        private eTipoAve tipoAve;
        public Ave(int id, string nombre, string tipo, float precio, int cantidadEnInventarioKilos, eTipoAve tipoAve)
            : base(id, nombre, tipo, precio, cantidadEnInventarioKilos)
        {
            this.tipoAve= tipoAve;
        }
        public Ave(string nombre, string tipo, float precio, int cantidadEnInventarioKilos, eTipoAve tipoAve)
        : base(nombre, tipo, precio, cantidadEnInventarioKilos)
        {
            this.tipoAve = tipoAve;
        }
        public Ave()
        {

        }
        public eTipoAve TipoAve { get => tipoAve; set => tipoAve = value ; }


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
        public static List<Ave> ConvertirDataTableAveALista(DataTable dataTable)
        {
            List<Ave> listaAves = new List<Ave>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Ave ave = new Ave();
                ave.Nombre = dataTable.Rows[i]["Nombre"].ToString();
                ave.Tipo = dataTable.Rows[i]["Tipo"].ToString();
                ave.Precio = Convert.ToSingle(dataTable.Rows[i]["Precio"]);
                ave.CantidadEnInventario = Convert.ToInt32(dataTable.Rows[i]["CantidadEnInventarioKilos"]);
                ave.TipoAve = (eTipoAve)Convert.ToInt32(dataTable.Rows[i]["TipoAve"]);
                ave.Id = Convert.ToInt32(dataTable.Rows[i]["Id"]);

                listaAves.Add(ave);
            }

            return listaAves;
        }
    }
}
