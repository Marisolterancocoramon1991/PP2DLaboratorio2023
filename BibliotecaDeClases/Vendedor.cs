using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Vendedor : Persona
    {
        private float sueldo;
        public enum eTurno
        {
            mañana,
            tarde,
            noche
        }
        private eTurno turno;

        public float Sueldo { get => sueldo; set => sueldo = value; }
        public eTurno Turno { get => turno; set => turno = value; }

        public Vendedor(string nombre, string apellido, string direccion,
            string correoElectronico,   string contraseña, float  sueldo, eTurno turno,eTipoDeUsuario tipoDeUsuario) : 
            base(nombre, apellido, direccion, correoElectronico, contraseña, tipoDeUsuario)
        {
            this.Turno = turno; 
            this.Sueldo = sueldo;   
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

    }
}
