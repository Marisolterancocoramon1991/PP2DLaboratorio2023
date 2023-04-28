using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Cliente : Persona
    {
        private float saldo;
        private string numeroDeCuenta;
        //   private LinkedList<Persona> lista;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="iD"></param>
        /// <param name="apellido"></param>
        /// <param name="direccion"></param>
        /// <param name="saldo"></param>
        /// <param name="numeroDeCuenta"></param>
        public Cliente(string nombre, int iD,
            string apellido, string direccion, string correoElectornico, string contraseña,
            float saldo, string numeroDeCuenta)
            : base(nombre, iD, apellido, direccion, correoElectornico, contraseña)
        {
            this.saldo = saldo;
            this.numeroDeCuenta = numeroDeCuenta;

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
                if (Validaciones.EsNumero(numeroDeCuenta) == true)
                {
                    numeroDeCuenta = value;
                }
            }
        }



    }
}
