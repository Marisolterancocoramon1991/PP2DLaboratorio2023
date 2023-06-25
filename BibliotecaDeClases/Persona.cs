using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Persona;

namespace BibliotecaDeClases
{
    public class Persona
    {
        protected string nombre;
        protected int id;
        protected string apellido;
        protected string direccion;
        protected string correoElectronico;
        protected string contraseña;
        protected eTipoDeUsuario  tipoDeUsuario;

       

        public Persona()
        { 
        //constructor vacio para conectarse a la base de datos
        
        }
      
        public Persona(int id, string nombre, string apellido, string direccion,
            string correoElectronico, string contraseña, eTipoDeUsuario tipoDeUsuario)
        {
            this.nombre = Validaciones.CargarPalabra(nombre);
            this.id = id;
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
        public virtual List<Persona> ConvertirDataTableALista(DataTable dataTable)
        {
            List<Persona> listaUsuarios = new List<Persona>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
               // (Nombre, Apellido, Direccion, CorreoElectronico" +
               // "Contraseña,TipoDeUsuarios)
                Persona usuario = new Persona();
                usuario.id = Convert.ToInt32(dataTable.Rows[i]["id"]);
                usuario.Nombre = dataTable.Rows[i]["Nombre"].ToString();
                usuario.Apellido = dataTable.Rows[i]["Apellido"].ToString();
                usuario.Direccion = dataTable.Rows[i]["Direccion"].ToString();
                usuario.correoElectronico = dataTable.Rows[i]["CorreoElectronico"].ToString();
                usuario.contraseña = dataTable.Rows[i]["Contraseña"].ToString();
                usuario.tipoDeUsuario = (eTipoDeUsuario)Convert.ToInt32(dataTable.Rows[i]["TipoDeUsuario"]);

                listaUsuarios.Add(usuario);
            }
            return listaUsuarios;


        }


    }
}
