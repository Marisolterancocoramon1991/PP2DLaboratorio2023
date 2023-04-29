using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Persona
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
        public Persona() : this(" ", " ", " ", " ", " ")
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
        public Persona(string nombre, string apellido, string direccion,
            string correoElectronico, string contraseña)
        {
            this.nombre = Validaciones.CargarPalabra(nombre);
            this.id = Validaciones.CargaID();
            this.apellido = Validaciones.CargarPalabra(apellido);
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
            set
            {
                nombre = value;
            }
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
            set
            {
                apellido = value;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set
            {
                correoElectronico = value;
            }
        }
        /// <summary>
        /// muestra los datos esenciales del modelo de negocios
        /// en cualquuier persona
        /// </summary>
        /// <returns></returns> devuelve un string 
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Usuario {nombre} {apellido}");
            sb.AppendLine($"id de la cuenta es {id}");
            sb.AppendLine($"direccion {direccion}");

            return sb.ToString();

        }


    }
}
