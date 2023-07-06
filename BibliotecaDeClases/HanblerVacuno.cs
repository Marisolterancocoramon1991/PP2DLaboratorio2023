using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class HanblerVacuno: ComandoSQL, ImanjadorConexion<Vacuno>
    {
        /// <summary>
        /// Agrega un vacuno a la base de datos.
        /// </summary>
        /// <param name="entidad">Objeto de tipo Vacuno con los datos a agregar.</param>
        public void Add(Vacuno entidad)
        {
            string query = @"INSERT INTO Vacunos (Nombre, Tipo, Precio, CantidadEnInventarioKilos, RazaDeVacas, Categoria)
                       VALUES (@Nombre, @Tipo, @Precio, @CantidadEnInventarioKilos, @RazaDeVacas, @Categoria)";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@Tipo", entidad.Tipo);
                comando.Parameters.AddWithValue("@Precio", entidad.Precio);
                comando.Parameters.AddWithValue("@CantidadEnInventarioKilos", entidad.CantidadEnInventario);
                comando.Parameters.AddWithValue("@RazaDeVacas", entidad.RazasDeVacas); // Convertir la enumeración a entero
                comando.Parameters.AddWithValue("@Categoria", entidad.Categoria); // Convertir la enumeración a entero
              
                EjecutarNonQuery(comando);
            }
        }

        /// <summary>
        /// Elimina un vacuno de la base de datos.
        /// </summary>
        /// <param name="id">ID del vacuno a eliminar.</param>
        public void Delete(int id)
        {
            string query = "DELETE FROM Vacunos WHERE id = @id";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", id);
                EjecutarNonQuery(comando);
            }
        }
        /// <summary>
        /// Lee todos los vacunos de la base de datos.
        /// </summary>
        /// <returns>Lista de objetos de tipo Vacuno con los vacunos leídos.</returns>
        public List<Vacuno> Leer()
        {
            string query = "SELECT * FROM Vacunos";

            using (SqlCommand comando = CrearComando(query))
            {
                List<Vacuno> listaUsuarios = new List<Vacuno>();
                DataTable dataTable = EjecutarReader(comando);
                listaUsuarios = Vacuno.ConvertirDataTableALista(dataTable);
                return listaUsuarios;
            }
        }
        /// <summary>
        /// Modifica un vacuno en la base de datos.
        /// </summary>
        /// <param name="entidad">Objeto de tipo Vacuno con los datos actualizados.</param>
        public void Modificar(Vacuno entidad)
        {
            string query = "UPDATE Vacunos SET Nombre =@Nombre, Tipo = @Tipo, Precio = @Precio," +
                " CantidadEnInventarioKilos = @CantidadEnInventarioKilos, RazaDeVacas = @RazaDeVacas, Categoria = @Categoria WHERE id = @id";

            using (SqlCommand comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@Tipo", entidad.Tipo);
                comando.Parameters.AddWithValue("@Precio", entidad.Precio);
                comando.Parameters.AddWithValue("@CantidadEnInventarioKilos", entidad.CantidadEnInventario);
                comando.Parameters.AddWithValue("@RazaDeVacas", entidad.RazasDeVacas); // Convertir la enumeración a entero
                comando.Parameters.AddWithValue("@Categoria", entidad.Categoria); // Convertir la enumeración a entero
                comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                comando.Parameters.AddWithValue("@Id", entidad.Id);

                EjecutarNonQuery(comando);
            }
        }

        /*  public void Modificar(Vacuno entidad)
          {
              string query = "UPDATE Vacunos SET nombre = @nombre, mail = @mail, password = @password, EsAdministrador = @EsAdministrador  WHERE id = @id";

              using (SqlCommand comando = CrearComando(query))
              {
                  comando.Parameters.AddWithValue("@Nombre", entidad.Nombre);
                  comando.Parameters.AddWithValue("@Tipo", entidad.Tipo);
                  comando.Parameters.AddWithValue("@Precio", entidad.Precio);
                  comando.Parameters.AddWithValue("@CantidadEnInventarioKilos", entidad.CantidadEnInventario);
                  comando.Parameters.AddWithValue("@RazaDeVacas", entidad.RazasDeVacas); // Convertir la enumeración a entero
                  comando.Parameters.AddWithValue("@Categoria", entidad.Categoria); // Convertir la enumeración a entero
                  EjecutarNonQuery(comando);
              }
          }*/
    }
}
