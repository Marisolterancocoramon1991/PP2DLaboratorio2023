using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public  class Persona
    {
        private string nombre;
        private int id;
        private string apellido;
        private string direccion;
        private string correoElectronico;
        private string contraseña;
        private eTipoDeUsuario  tipoDeUsuario;

        public enum eTipoDeUsuario
        {
            Cliente,
            Vendedor

        }

      
        public Persona(string nombre, string apellido, string direccion,
            string correoElectronico, string contraseña, eTipoDeUsuario tipoDeUsuario)
        {
            this.nombre = Validaciones.CargarPalabra(nombre);
            this.id = Validaciones.CargaID();
            this.apellido = Validaciones.CargarPalabra(apellido);
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
            this.contraseña = contraseña;
            this.tipoDeUsuario=tipoDeUsuario;
        }
     
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
            }
        }

       
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
      
        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
            }

        }
        
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

        public string Contraseña
        {
            get { return contraseña; }
            set
            {
                contraseña = value;
            }

        }

        public eTipoDeUsuario TipoDeUsuario
        {
            get { return this.tipoDeUsuario; }
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
