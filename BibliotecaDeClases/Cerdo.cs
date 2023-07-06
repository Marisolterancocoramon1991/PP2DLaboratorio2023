using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Cerdo : Carne
    {
        private eRazasDeCerdo razasDeCerdo;
        public Cerdo(int id, string nombre, string tipo, float precio, int cantidadEnInventarioKilos, eRazasDeCerdo razasDeCerdo
            ) : base( id,nombre, tipo, precio, cantidadEnInventarioKilos)
        {
            this.razasDeCerdo = razasDeCerdo;
        }
        public Cerdo()
        { }
        public eRazasDeCerdo RazasDeCerdo { get => razasDeCerdo; set => razasDeCerdo = value; }


        /// <summary>
        /// muestra las caracteristicias esenciales ademas de alguna especificas
        /// </summary>
        /// <returns></returns>
        public override string MostrarCarnes()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDetallesDeProducto());
            sb.AppendLine($"Raza del cerdo: {razasDeCerdo}");

            return sb.ToString();


        }
        /// <summary>
        /// Convierte un DataTable de cerdos a una lista de objetos Cerdo.
        /// </summary>
        /// <param name="dataTable">DataTable con los datos de los cerdos.</param>
        /// <returns>Lista de objetos Cerdo.</returns>
        public static List<Cerdo> ConvertirDataTableCerdoALista(DataTable dataTable)
        {
            List<Cerdo> listaCerdos = new List<Cerdo>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Cerdo cerdo = new Cerdo();

                cerdo.Nombre = dataTable.Rows[i]["Nombre"].ToString();
                cerdo.Tipo = dataTable.Rows[i]["Tipo"].ToString();
                cerdo.Precio = Convert.ToSingle(dataTable.Rows[i]["Precio"]);
                cerdo.CantidadEnInventario = Convert.ToInt32(dataTable.Rows[i]["CantidadEnInventarioKilos"]);
                cerdo.RazasDeCerdo = (eRazasDeCerdo)Convert.ToInt32(dataTable.Rows[i]["RazaDeCerdo"]);
                cerdo.Id = Convert.ToInt32(dataTable.Rows[i]["Id"]);

                listaCerdos.Add(cerdo);
            }

            return listaCerdos;
        }
    }
    


}

