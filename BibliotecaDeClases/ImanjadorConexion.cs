using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public interface ImanjadorConexion<T>
    {
        public List<T> Leer();

        public void Add(T entidad);

        public void Modificar(T entidad);

        public void Delete(int id);
    }
}
