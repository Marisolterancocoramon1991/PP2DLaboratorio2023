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
            string correoElectronico,   string contraseña, float  sueldo, eTurno turno) : 
            base(nombre, apellido, direccion, correoElectronico, contraseña)
        {
            this.Turno = turno; 
            this.Sueldo = sueldo;   
        }

    }
}
