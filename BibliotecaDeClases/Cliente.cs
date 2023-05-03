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

        private List<Carne> lista;

        /// <summary>
        /// constructor 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="iD"></param>
        /// <param name="apellido"></param>
        /// <param name="direccion"></param>
        /// <param name="saldo"></param>
        /// <param name="numeroDeCuenta"></param>
        public Cliente(string nombre,
            string apellido, string direccion, string correoElectronico, string contraseña,
            float saldo, string numeroDeCuenta,eTipoDeUsuario tipoDeUsuario)
            : base(nombre, apellido, direccion, correoElectronico, contraseña, tipoDeUsuario)
        {
            this.saldo = saldo;

            this.numeroDeCuenta = Validaciones.CargarNumero(numeroDeCuenta);
            lista = new List<Carne>();
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
