﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Cliente;
using System.Linq;
using static BibliotecaDeClases.Persona;
using System.Data;

namespace BibliotecaDeClases
{
    public class Carne
    {
        private string nombre = string.Empty;
        private string tipos = string.Empty;
        private float precio;
        private int cantidadEnInventarioKilos;
        protected int id;
        public Carne()
        {
            //constructor vacio para la conexion en sql base de datos         
        }
        public Carne(int id, string nombre, string tipo, float precio, int cantidadEnInventarioKilos)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.id = id;
            this.Precio = precio;
            this.cantidadEnInventarioKilos = cantidadEnInventarioKilos;
        }
        public Carne(string nombre, string tipo, float precio, int cantidadEnInventarioKilos)
        {
            this.Tipo = tipo;
            this.Nombre = nombre;
            this.Precio = precio;
            this.cantidadEnInventarioKilos = cantidadEnInventarioKilos;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipos; set => tipos = value; }
        public float Precio { get => precio; set => precio = value; }
        public int CantidadEnInventario
        {
            get => cantidadEnInventarioKilos;
            set => cantidadEnInventarioKilos = value;
        }
        public int Id { get => id; set => id = value; }



        /// <summary>
        /// muestra la informacion general del producto
        /// </summary>
        /// <returns></returns> string
        public virtual string MostrarCarnes()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine($"  Carne  {nombre}");
            sb.AppendLine($"tipo de carne{tipos}");
            sb.AppendLine($"el del producto precio {precio}");



            return sb.ToString();

        }


        /// <summary>
        /// suma la cantidad de unidades agregadas en el stock
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="cantidadASumar"></param>
        /// <returns></returns> retorna el objeto de carne
        public static Carne operator +(Carne p1, int cantidadASumar)
        {
            p1.cantidadEnInventarioKilos = p1.cantidadEnInventarioKilos + cantidadASumar;

            return p1;
        }
        /// <summary>
        /// En este caso, se sobrecarga el operador "+" 
        /// para que funcione con objetos de la clase "Carne" y un número en punto flotante.
        /// devuelve un flotante
        /// </summary>
        /// <param name="p1"></param> objeto
        /// <param name="cantidadASumar"></param> flotante
        /// <returns></returns> flotante 
        public static float operator +(Carne p1, float cantidadASumar)
        {

            return p1.precio + (p1.precio * cantidadASumar);
        }

        /// <summary>
        /// suma el stock de forma progresiva
        /// </summary>
        /// <param name="p1"></param>
        /// <returns></returns> retorna el objeto
        public static Carne operator ++(Carne p1)
        {
            p1.cantidadEnInventarioKilos++;

            return p1;
        }


        /// <summary>
        /// resta de forma progresiva la cantida de inventario
        /// </summary>
        /// <param name="p1"></param> objeto 
        /// <returns></returns> regresa el objeto
        public static Carne operator --(Carne p1)
        {
            p1.cantidadEnInventarioKilos--;

            return p1;
        }
        /// <summary>
        /// resta la cantidad necesaria de stock del producto
        /// </summary>
        /// <param name="p1"></param> objeto
        /// <param name="CantidadARestar"></param> entero
        /// <returns></returns> retorna objeto 
        public static Carne operator -(Carne p1, int CantidadARestar)
        {
            p1.cantidadEnInventarioKilos -= CantidadARestar;

            return p1;
        }

        /// <summary>
        /// multiplica el precio por la unidades establecidas
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="multiplicador"></param>
        /// <returns></returns> retorna un flotante
        public static float operator *(Carne p1, int multiplicador)
        {
            float resultado = p1.precio * multiplicador;

            return resultado;
        }



        /// <summary>
        /// muestra los detalles del producto
        /// </summary>
        /// <returns></returns> retorna un string
        public virtual string MostrarDetallesDeProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Corte : {nombre}");
            sb.AppendLine($"Tipo de producto: {tipos}");
            sb.AppendLine($"Precio : ${precio}");
            sb.AppendLine($"inventario por kilos : {cantidadEnInventarioKilos}");


            return sb.ToString();
        }


        /// <summary>
        /// /crea desde la tabla una lista del producto
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static List<Carne> ConvertirDataTableALista(DataTable dataTable)
        {
            List<Carne> listaProducto = new List<Carne>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                // (Nombre, Apellido, Direccion, CorreoElectronico" +
                // "Contraseña,TipoDeUsuarios)
                Carne producto = new Carne();

                producto.Nombre = dataTable.Rows[i]["Nombre"].ToString();
                producto.Tipo = dataTable.Rows[i]["Tipo"].ToString();
                producto.Precio = Convert.ToInt32(dataTable.Rows[i]["Precio"]);
                producto.cantidadEnInventarioKilos = Convert.ToInt32(dataTable.Rows[i]["CantidadPorKilos"]);

                listaProducto.Add(producto);
            }
            return listaProducto;


        }

        

    }



}
