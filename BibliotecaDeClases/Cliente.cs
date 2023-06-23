using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Cerdo;

namespace BibliotecaDeClases
{
    public class Cliente : Persona
    {
        protected float saldo;
        private string numeroDeCuenta;
      
       
        public Cliente(string nombre,
            string apellido, string direccion, string correoElectronico, string contraseña,
            float saldo, string numeroDeCuenta, eTipoDeUsuario tipoDeUsuario)
            : base(nombre, apellido, direccion, correoElectronico, contraseña, tipoDeUsuario)
        {
            this.saldo = saldo;
            
            this.numeroDeCuenta = Validaciones.CargarNumero(numeroDeCuenta);

        }

        public float Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }
        public string NumeroDeCuenta
        {
            get { return numeroDeCuenta; }
            set
            {
                this.numeroDeCuenta = value;
            }
        }


        /// <summary>
        /// operador que resta el saldo que tiene la persona con el monto gastado
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="dineroADescontar"></param>
        /// <returns></returns> retorna el objeto cliente
        public static Cliente operator -(Cliente usuario, float dineroADescontar)
        {
            usuario.Saldo -= dineroADescontar;
            return usuario;

        }

        public void ComprarProductoValidacion(float precio)
        {
            if (precio > saldo)
            {
                throw new SaldoInsuficienteException(Saldo, precio);
            }
            
        }



        /// <summary>
        /// operadores boleanos que me entregan si el ID del cliente  
        /// no coincide con la marca de la venta ID
        /// </summary>
        /// <param name="clienteID"></param> Objeto
        /// <param name="ID"></param> int 
        /// <returns></returns> bool
        public static bool operator == (Cliente clienteID, int ID) 
        {
        
            return clienteID.ID == ID;
        
        
        }

        /// <summary>
        /// operadores boleanos que me entregan si el ID del cliente  
        /// no coincide con la marca de la venta ID
        /// </summary>
        /// <param name="clienteID"></param> Objeto
        /// <param name="ID"></param> int 
        /// <returns></returns> bool
        public static bool operator !=(Cliente clienteID, int ID)
        {

            return !(clienteID.ID == ID);


        }

        /// <summary>
        /// Muestra los datos esenciales de la categoria cliente
        /// </summary>
        /// <returns></returns> devuelve un string
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"saldo actual {saldo}");
            sb.AppendLine($"numero de cuenta {numeroDeCuenta}");


            return sb.ToString();

        }


    }
}
