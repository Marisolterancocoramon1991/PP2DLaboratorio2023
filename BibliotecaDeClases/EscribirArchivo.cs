using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Net.Http.Headers;

namespace BibliotecaDeClases
{
    public static class EscribirArchivo
    {

        public static void ActualizarArchivo(List<Venta> listaDeventas)
        {
            string nombreArchivo = "ventas.txt";
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", nombreArchivo);
            StreamWriter sw = new StreamWriter(rutaArchivo);
            try
            {
                foreach (var venta in listaDeventas)
                {
                    if (venta is not null)
                    {

                        sw.WriteLine($"{venta.ProductoVendido},{venta.Tipo},{venta.Precio},{venta.PrecioTotal}, " +
                            $"{venta.MetodoPago},{venta.CantidadDeUnidades},{venta.IDCliente1},{venta.Nombre}");
                    }

                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sw.Close();
            }       
        }

/*
         /// <summary>
         /// Actualiza el archivo "ventas.txt" con la información de la lista de ventas.
         /// </summary>
         /// <param name="listaDeventas">Lista de ventas a escribir en el archivo.</param>
        public static void ActualizarArchivo(List<Venta> listaDeventas)
        {
            List<string> listaStringVentas = new List<string>();

            foreach (var venta in listaDeventas)
            {
                if (venta is not null)
                {
                    Type ventaType = venta.GetType();
                    var properties = ventaType.GetProperties();

                    var propertyValues = properties.Select(prop => prop.GetValue(venta)?.ToString() ?? "null");
                    string ventaString = string.Join(",", propertyValues);
                    listaStringVentas.Add(ventaString);
                  listaStringVentas.Add(venta.ToString());

                }

            }
            string nombreArchivo = "ventas.txt";
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", nombreArchivo);
            string listadeventas = string.Join(Environment.NewLine, listaStringVentas.ToArray());
            if (!File.Exists(rutaArchivo))
            {
                File.Create(nombreArchivo);
                
                      File.WriteAllText(rutaArchivo, listadeventas);
                
              
            }
            else
            {
                File.WriteAllText(rutaArchivo, listadeventas);
            }


        }*/
       /*
               public static void ActualizarArchivo(List<Venta> listaDeventas)
               {
                   List<string> listaStringVentas = new List<string>();

                   foreach (var venta in listaDeventas)
                   {
                       if (venta is not null)
                       {
                           Type ventaType = venta.GetType();
                           var properties = ventaType.GetProperties();

                           var propertyValues = properties.Select(prop => prop.GetValue(venta)?.ToString() ?? "null");
                           string ventaString = string.Join(",", propertyValues);
                           listaStringVentas.Add(ventaString);
                       }
                   }

                   string nombreArchivo = "ventas.txt";
                   string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", nombreArchivo);
                   string listadeventas = string.Join(Environment.NewLine, listaStringVentas.ToArray());

                   string directoryPath = Path.GetDirectoryName(rutaArchivo);
                   if (!Directory.Exists(directoryPath))
                   {
                       Directory.CreateDirectory(directoryPath);
                   }

                   File.WriteAllText(rutaArchivo, listadeventas);
               }

          */
    }
}
