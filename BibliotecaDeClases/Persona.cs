using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Persona
    {
        private string nombre;
        private int id;
        private string apellido;
        private string direccion;
        private string correoElectronico;
        private string contraseña;

        /// <summary>
        /// 
        /// </summary>
        public Persona() : this(" ", 0, " ", " "," ", " ")
        {
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="id"></param>
        /// <param name="apellido"></param>
        /// <param name="direccion"></param>
        /// <param name="correoElectronico"></param>
        /// <param name="contraseña"></param>
        /// 
        public Persona(string nombre, int id, string apellido, string direccion,
            string correoElectronico,string contraseña)
        {
            this.nombre = nombre;
            this.id = id;
            this.apellido = apellido;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
            this.contraseña = contraseña;

        }
        /// <summary>
        /// 
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }

        }
        /// <summary>
        /// 
        /// </summary>
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }



    }
}
