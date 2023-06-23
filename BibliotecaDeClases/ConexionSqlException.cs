using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{
    internal class ConexionSqlException : Exception
    {
        public ConexionSqlException() : base("No se pudo establecer la conexión con el archivo SQL.")
        {

        }

        public ConexionSqlException(string mensaje) : base(mensaje)
        {
        }

        public ConexionSqlException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }





        // usar cuando se este conectando a los archivos sql

        /* 
         public void Conectar()
         {
             try
             {
                 // Intentar establecer la conexión con el archivo SQL

                 if (!ConexionExitosa)
                 {
                     throw new ConexionSqlException("No se pudo establecer la conexión con el archivo SQL.");
                 }
             }
             catch (ConexionSqlException ex)
             {
                 // Manejar la excepción de conexión SQL
                 Console.WriteLine(ex.Message);
             }
         }
        */
/*
        public void Conectar()
        {
            try
            {
                // Intentar establecer la conexión con el archivo SQL

                if (!ConexionExitosa)
                {
                    throw new ConexionSqlException("No se pudo establecer la conexión con el archivo SQL.", new Exception("Error interno de conexión."));
                }
            }
            catch (ConexionSqlException ex)
            {
                // Manejar la excepción de conexión SQL
                Console.WriteLine(ex.Message);
                Console.WriteLine("Excepción interna: " + ex.InnerException?.Message);
            }
        }

        */

        // Otros métodos y propiedades de la clase
    }
      


}
