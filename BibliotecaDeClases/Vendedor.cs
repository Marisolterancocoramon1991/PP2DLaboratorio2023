using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Vendedor : Persona
    {
        public float sueldo;
       
        public eTurno turno;

        public float Sueldo { get => sueldo; set => sueldo = value; }
        public eTurno Turno { get => turno; set => turno = value; }

        public Vendedor(int id,string nombre, string apellido, string direccion,
            string correoElectronico,   string contraseña, float  sueldo, eTurno turno,eTipoDeUsuario tipoDeUsuario) : 
            base(id, nombre, apellido, direccion, correoElectronico, contraseña, tipoDeUsuario)
        {
            this.Turno = turno; 
            this.Sueldo = sueldo;   
        }
        public Vendedor() 
        {
        }

        /// <summary>
        /// muestra las caractristicas ensenciales del trabajador 
        /// </summary>
        /// <returns></returns> string mensaje
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Sueldo del Trabajador {Sueldo}");
            sb.AppendLine($"Turno de trabajo {Turno}");
         

            return sb.ToString();

        }
        public static  List<Vendedor> ConvertirDataTableALista(DataTable dataTable)
        {
            List<Vendedor> listaUsuarios = new List<Vendedor>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                // (Nombre, Apellido, Direccion, CorreoElectronico, Contraseña, TipoDeUsuarios)
                Vendedor usuario = new Vendedor();
                usuario.id = Convert.ToInt32(dataTable.Rows[i]["id"]);
                usuario.Nombre = dataTable.Rows[i]["Nombre"].ToString();
                usuario.Apellido = dataTable.Rows[i]["Apellido"].ToString();
                usuario.Direccion = dataTable.Rows[i]["Direccion"].ToString();
                usuario.correoElectronico = dataTable.Rows[i]["CorreoElectronico"].ToString();
                usuario.contraseña = dataTable.Rows[i]["Contraseña"].ToString();
                if (float.TryParse(dataTable.Rows[i]["sueldo"].ToString(), out float sueldo))
                {
                    usuario.sueldo = sueldo;
                }
                else
                {
                    // Manejar el caso en que el valor no se pueda convertir a float
                    // Asignar un valor predeterminado o mostrar un mensaje de error
                    usuario.sueldo = 0.0f; // Por ejemplo, se asigna un sueldo de 0.0 en caso de conversión fallida
                }

                if (Enum.TryParse(dataTable.Rows[i]["Turno"].ToString(), out eTurno turno))
                {
                    usuario.Turno = turno;
                }
               

                listaUsuarios.Add(usuario);
            }

            return listaUsuarios;
        }


    }
}
