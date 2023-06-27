using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Validaciones
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


        /// <summary>
        /// verifica si lo que se ha ingresado es una palabra
        /// </summary>
        /// <param name="cadenaCaracteres"></param>
        /// <returns></returns>
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
        /// <summary>
        /// car numero y valida si lo es...
        /// </summary>
        /// <param name="cadenaCaracteres"></param> es un string 
        /// <returns></returns>
        public static string CargarNumero(string cadenaCaracteres)
        {
            if (EsNumero(cadenaCaracteres))
            {
                return cadenaCaracteres;

            }
            else
            {
                return "error en la carga de numero de cuenta";

            }

        }
        /// <summary>
        /// valida si no viene vaco alguno de estos campos
        /// </summary>
        /// <param name="email"></param> string
        /// <param name="contraseña"></param> string
        /// <returns></returns>
        public static bool ValidarCamposIngresados(string email, string contraseña)
        {
            if (string.IsNullOrEmpty(email.Trim()) || string.IsNullOrEmpty(contraseña))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// carga el ID de la persona de forma aleatoria
        /// </summary>
        /// <returns></returns>
        public static int CargaID(string nombre)
        {
            int id;
            if (nombre == "Kervin")
            {
                id = 7628199;
                return id;

            }
            Random rnd = new Random();
            id = rnd.Next(1000000, 9999999);

            return id;
        }
        /// <summary>
        /// verifica si es numero
        /// </summary>
        /// <param name="numero"></param> string
        /// <returns></returns>
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
        /// <summary>
        /// verifica si un objero no es null 
        /// </summary>
        /// <param name="obj"></param> cualquier objeto...
        /// <returns></returns> retrona un bool
        public static bool IsNotNull(object obj)
        {
            return obj != null;
        }
        /// <summary>
        /// Control que se Encarga de llamar a todas la funciones que validan a los Usuario para que se puedan loggear
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="mail">Mail</param>
        /// <param name="password">password</param>
        public static void ValidarCamposLoggin(string nombre, string mail, string password)
        {
            ValidadCamposNoVacios(nombre, mail, password);
            ValidadMail(mail);
        }



        /// <summary>
        /// Valida que ninguno de los campos este vacio al momento de dar de alta un Usuario
        /// </summary>
        /// <param name="nombre">nombre</param>
        /// <param name="mail">mail</param>
        /// <param name="password">password</param>
        /// <exception cref="CamposVaciosException">Excepcion Propia</exception>
        public static void ValidadCamposNoVacios(string nombre, string mail, string password)
        {
            if (nombre.Length <= 0 || mail.Length <= 0 || password.Length <= 0)
            {
                throw new CamposVaciosException("Hay que Completar todos los Campos");
            }
        }
        /// <summary>
        /// Valida que el mail Ingredado contega @
        /// </summary>
        /// <param name="mail">mail</param>
        /// <exception cref="ContieneArrobaException">Excepcion Propia</exception>
        public static void ValidadMail(string mail)
        {
            if (mail.Contains('@') == false)
            {
                throw new ContieneArrobaException("El debe contener @");
            }
        }
        /// <summary>
        /// Valida que inguno de  los campos  esten vacion al momento de dar de alta un Producto
        /// </summary>
        /// <param name="nombreProdcuto">nombreProducto</param>
        /// <param name="precioProdcuto">precioProducto</param>
        /// <param name="cantdiadProdcuto">cantidadProducto</param>
        /// <param name="codigoBarras">codigoBarras</param>
        /// <exception cref="CamposVaciosException">Excepcion Propia</exception>
        public static void validarCamposNoVaciosProdcuto(string nombreProdcuto, int precioProdcuto, int cantdiadProdcuto)
        {
            string precioProdcutoString = precioProdcuto.ToString();
            string cantidadProductoString = cantdiadProdcuto.ToString();

            if (nombreProdcuto.Length <= 0 || precioProdcutoString.Length <= 0 || cantidadProductoString.Length <= 0)
            {
                throw new CamposVaciosException("Hay que Completar todos los Campos");
            }
        }

        public static bool SalarioMayorA(this Vendedor vendedor, float salarioMinimo)
        {
            return vendedor.Sueldo > salarioMinimo;
        }


    }
}
