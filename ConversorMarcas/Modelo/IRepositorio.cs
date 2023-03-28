using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMarcas.Modelo
{
    internal interface IRepositorio<T>
    {
        public bool Alta(T obj);
        public bool Baja(T obj);
        public T BuscarXNombre(string nombre);
        public T BuscarXId(int id);
        public List<T> TraerTodo();
    }
}
