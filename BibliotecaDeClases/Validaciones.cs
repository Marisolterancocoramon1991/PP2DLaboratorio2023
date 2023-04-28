using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    internal class Validaciones
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
    }
}