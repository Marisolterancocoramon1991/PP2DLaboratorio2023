using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Vacuno : Carne
    {
        private eRazasDeVacas razasDeVacas;
        private eCategoria categoria;


        public Vacuno(int id,string nombre, string tipo, float precio, int cantidadEnInventarioKilos, eRazasDeVacas razasDeVacas, eCategoria categoria
            ) : base(id, nombre, tipo, precio, cantidadEnInventarioKilos)
        {
            this.categoria = categoria;
            this.razasDeVacas = razasDeVacas;
        }
        public Vacuno()
        { }

        public eRazasDeVacas RazasDeVacas { get => razasDeVacas; set => razasDeVacas = value; }
        public eCategoria Categoria { get => categoria; set => categoria = value; }

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
        public static List<Vacuno> ConvertirDataTableALista(DataTable dataTable)
        {
            List<Vacuno> listaVacas = new List<Vacuno>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Vacuno vacuno = new Vacuno();
                vacuno.Nombre = dataTable.Rows[i]["Nombre"].ToString();
                vacuno.Tipo = dataTable.Rows[i]["Tipo"].ToString();
                vacuno.Precio = Convert.ToSingle(dataTable.Rows[i]["Precio"]);
                vacuno.CantidadEnInventario = Convert.ToInt32(dataTable.Rows[i]["CantidadEnInventarioKilos"]);
                vacuno.RazasDeVacas = (eRazasDeVacas)Convert.ToInt32(dataTable.Rows[i]["RazaDeVacas"]);
                vacuno.Categoria = (eCategoria)Convert.ToInt32(dataTable.Rows[i]["Categoria"]);

                listaVacas.Add(vacuno);
            }

            return listaVacas;
        }

        /*   public static List<Vacuno> ConvertirDataTableALista(DataTable dataTable)
           {
               List<Vacuno> listaVacas = new List<Vacuno>();

               for (int i = 0; i < dataTable.Rows.Count; i++)
               {



                   // (Nombre, Apellido, Direccion, CorreoElectronico, Contraseña, TipoDeUsuarios)
                   Vacuno vacuno = new Vacuno();
                   vacuno.Nombre = Convert.ToInt32(dataTable.Rows[i]["id"]);
                   vacuno.Tipo = dataTable.Rows[i]["Nombre"].ToString();
                   vacuno.Precio = dataTable.Rows[i]["Apellido"].ToString();
                   vacuno.CantidadEnInventario = dataTable.Rows[i]["Direccion"].ToString();
                   vacuno.RazasDeVacas = dataTable.Rows[i]["CorreoElectronico"].ToString();
                   vacuno.Categoria = dataTable.Rows[i]["Contraseña"].ToString();
                   vacuno.tipoDeUsuario = (eTipoDeUsuario)Convert.ToInt32(dataTable.Rows[i]["TipoDeUsuario"]);
                   if (float.TryParse(dataTable.Rows[i]["saldo"].ToString(), out float saldo))
                   {
                       vacuno.saldo = saldo;
                   }
                   else
                   {
                       // Manejar el caso en que el valor no se pueda convertir a float
                       // Asignar un valor predeterminado o mostrar un mensaje de error
                       vacuno.saldo = 0.0f; // Por ejemplo, se asigna un saldo de 0.0 en caso de conversión fallida
                   }

                   usuario.numeroDeCuenta = dataTable.Rows[i]["numeroDeCuenta"].ToString();

                   listaVacas.Add(vacuno);
               }

               return listaUsuarios;
           }*/
    }
}
