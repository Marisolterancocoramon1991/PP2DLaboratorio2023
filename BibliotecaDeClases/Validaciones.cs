using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Validaciones
    {

        /// <summary>
        /// recorre un string y usando el TryParse se asegura de que la cadena sean solo
        /// numeros
        /// </summary>
        /// <param name="nummeroAValidar"></param> string a validar
        /// <returns></returns> retorna verdadero y todos los caracteres son numeros 
        /// de lo contrario devuelve falso
        public static bool EsNumero(string nummeroAValidar)
        {
            int numero;

            return int.TryParse(nummeroAValidar, out numero);

        }


        /// <summary>
        /// recorrre un string y verifica que todos los caracteres sean letras
        /// </summary>
        /// <param name="texto"></param> string para validar
        /// <returns></returns> retorna verdadero si todo es letra y falso 
        /// si hay numeros u otros caracteres
        public static bool EsLetra(string texto)
        {

            foreach (char c in texto)
            {
                if (char.IsLetter(c) == false)
                {
                    return false;
                }

            }
            return true;
        }

        /// <summary>
        /// se valida que un numero flotante sea mayor a cero
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns> verdadero si es mayor a cero de lo contrario retorna 
        /// falso 
        public static bool NumeroMayorAcero(float numero)
        {
            if ((float)numero > 0)
            {
                return true;

            }
            else
            {

                return false;
            }


        }


        /// <summary>
        /// se valida que un numero entero sea mayor a cero
        /// </summary>
        /// <param name="numero"></param> numero entero 
        /// <returns></returns> verdadero si es mayor a cero de lo contrario retorna 
        /// falso 
        public static bool NumeroMayorAcero(int numero)
        {
            if ((float)numero > 0)
            {
                return true;

            }
            else
            {

                return false;
            }

        }
        /// <summary>
        /// Valida si es nombre dependiendo de las condiciones 
        /// no es vacio ni nulo, solo contiene letras y espacios en blanco
        /// y no contiene solo es pacios en blanco
        /// </summary>
        /// <param name="nombre"></param> parametro string 
        /// <returns></returns> retorna falso si es vacio, null o tiene caracteres
        /// por fuera de las letras de lo contrario verdadero
        public static bool EsNombre(string nombre)
        {
            // este metodo de string verifica si viene nulo o vacia la cadena
            if (string.IsNullOrEmpty(nombre))
            {
                return false;
            }

            // se recocorre caracter por caracter y se verifica 
            // si alguno de los caracteres es invalido
            foreach (char c in nombre)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }

            // Verificar si el nombre contiene solo espacios en blanco
            if (nombre.Trim().Length == 0)
            {
                return false;
            }

            // El nombre es válido
            return true;
        }
        public static string CargarPalabra(string cadenaCaracteres)
        {

            if (Validaciones.EsNombre(cadenaCaracteres))
            {
                return cadenaCaracteres;
            }
            else
            {
                return "hubo un error en la carga de datos";
            }


        }

        public static string CargarNumero(string cadenaCaracteres)
        {
            if(EsNumero(cadenaCaracteres))
            {
                return cadenaCaracteres;

            }
            else 
            {
                return "error en la carga de numero de cuenta";
            
            }

        }
        public static bool ValidarCamposIngresados(string email, string contraseña)
        {
            if (string.IsNullOrEmpty(email.Trim()) || string.IsNullOrEmpty(contraseña))
            {
                return false;
            }
            return true;
        }

        public static int CargaID()
        {
            
            Random rnd = new Random();
            int id = rnd.Next(1000000, 9999999);

            return id;
        }

        public static float DeStringANumero(string numero)
        {
            float auxiliar;
           
            if (EsNumero(numero))
            {
                 float.TryParse(numero, out auxiliar);
                return auxiliar;
            }

            return 0;
        }
    }
}