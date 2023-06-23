using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;

namespace BibliotecaDeClases
{
    public static class LecturaArchivo
    {
        /// <summary>
        /// Funcion que lee el archivo de Productos
        /// </summary>
        /// <returns>string con los Productos leidos</returns>
        public static string leerArchivosVentas() 
        {
            string nombreArchivo = "ventas.txt";
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", nombreArchivo);
            string textoEnBrutoVenta = File.ReadAllText(rutaArchivo);

            return textoEnBrutoVenta;
        }

        /// <summary>
        /// Crea una lista de strings con el string de de venta recibido por parametro
        /// </summary>
        /// <param name="textoArchivoProdcutos">El string leido en la funcion que lee los productos</param>
        /// <returns>La lista de string de Productos</returns>
        public static List<string> CrearListasStringVentas(string textoArchivoVenta) 
        {
            List<string> listaVentaProductos = new List<string>();
            string[] linea = textoArchivoVenta.Split(Environment.NewLine);

            for (int i = 0; i < linea.Length; i++) 
            {
                listaVentaProductos.Add(linea[i]);
            
            }
            return listaVentaProductos;
        
        }


   
    }

}

