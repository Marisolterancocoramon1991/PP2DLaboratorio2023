using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Parser
    {
     /*   public static List<Carne> ParseaProductos(List<string> productos)
        {
            List<Carne> listaProductos = new List<Carne>();

            foreach (string item in productos)
            {
                // Aquí puedes realizar la lógica para separar los valores del string y asignarlos correctamente a las propiedades de cada tipo de carne.
                // Por ejemplo, puedes separar los valores utilizando algún carácter delimitador, como la coma (',').
                // Luego, puedes crear la instancia correspondiente de la clase (Ave, Cerdo o Vacuno) y asignar los valores adecuados.

                string[] valores = item.Split(',');
                string tipoCarne = valores[0].Trim();

                if (tipoCarne == "Ave")
                {
                    // Ejemplo de creación de instancia de Ave y asignación de valores.
                    Ave ave = new Ave(valores[1].Trim(), valores[2].Trim(), float.Parse(valores[3].Trim()), int.Parse(valores[4].Trim()), (eTipoAve)Enum.Parse(typeof(eTipoAve), valores[5].Trim()));
                    listaProductos.Add(ave);
                }
                else if (tipoCarne == "Cerdo")
                {
                    // Ejemplo de creación de instancia de Cerdo y asignación de valores.
                    Cerdo cerdo = new Cerdo(valores[1].Trim(), valores[2].Trim(), float.Parse(valores[3].Trim()), int.Parse(valores[4].Trim()), (eRazasDeCerdo)Enum.Parse(typeof(eRazasDeCerdo), valores[5].Trim()));
                    listaProductos.Add(cerdo);
                }
                else if (tipoCarne == "Vacuno")
                {
                    // Ejemplo de creación de instancia de Vacuno y asignación de valores.
                    Vacuno vacuno = new Vacuno(valores[1].Trim(), valores[2].Trim(), float.Parse(valores[3].Trim()), int.Parse(valores[4].Trim()), (eRazasDeVacas)Enum.Parse(typeof(eRazasDeVacas), valores[5].Trim()), (eCategoria)Enum.Parse(typeof(eCategoria), valores[6].Trim()));
                    listaProductos.Add(vacuno);
                }
            }

            return listaProductos;
        }*/

        static public void ParsearProductos(List<string> listaStringVentas)
        {
            List<Venta> listaVentas = new List<Venta>();

            try
            {
                foreach (string item in listaStringVentas)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        string[] valores = item.Split(',');
                        float numeroPrecio;
                        float numeroPrecioTotal;
                        int cantidadUnidades;
                        int idCliente;

                        if (valores.Length == 8 && float.TryParse(valores[2], out numeroPrecio)
                            && float.TryParse(valores[3], out numeroPrecioTotal)
                            && int.TryParse(valores[5], out cantidadUnidades)
                            && int.TryParse(valores[6], out idCliente))
                        {
                            eMetodoPago value = (eMetodoPago)Enum.Parse(typeof(eMetodoPago), valores[4]);

                            Venta venta = new Venta(
                                valores[0],
                                valores[1],
                                numeroPrecio,
                                numeroPrecioTotal,
                                value,
                                cantidadUnidades,
                                idCliente,
                                valores[7]
                            );
                            Negocio.CargarVenta(venta);                        
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores aquí
                Console.WriteLine("Error al parsear productos: " + ex.Message);
            }

           
        }


        /*    static public List<Venta> ParsearProductos(List<string> listaStringVentas)
            {
                List<Venta> listaVentas = new List<Venta>();

                try
                {
                    foreach (string item in listaStringVentas)
                    {
                        if (!string.IsNullOrEmpty(item))
                        {
                            string[] valores = item.Split(',');
                            float numeroPrecio;
                            float numeroPrecioTotal;
                            int cantidadUnidades;
                            int idCliente;
                            eMetodoPago value = (eMetodoPago)Enum.Parse(typeof(eMetodoPago), item[4].ToString());

                            if (valores.Length == 7 && float.TryParse(valores[2], out numeroPrecio)
                                 && float.TryParse(valores[3], out numeroPrecioTotal) &&
                                 int.TryParse(item[5].ToString(),out cantidadUnidades) && 
                                int.TryParse(item[6].ToString(), out idCliente)) 
                                {
                                     Venta venta = (item[0].ToString(), item[1].ToString(), numeroPrecio,
                            numeroPrecioTotal, value, cantidadUnidades, idCliente, item[7].ToString());
                            listaVentas.Add(venta);

                                 }


                        }


                    }



                }




            }*/

    }
}
