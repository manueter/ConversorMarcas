using ConversorMarcas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMarcas.Controles
{
    internal class ControlFormatos
    {
        List<Formato> formatos= new List<Formato>();
        List<Formato> formatosEditados= new List<Formato>();

        public ControlFormatos(){}
        public bool AgregarFormato(Formato nuevo)
        {
            if (!nuevo.Validar()) { return false; }
           
            formatos.Add(nuevo);
            return true;
        }
        public bool BorrarFormato(Formato aBorrar)
        {
            if (aBorrar == null) return false;
            if (formatos.Count() == 0) return false;
            return formatos.Remove(aBorrar);
        }
        public List<Formato> TraerFormatos()
        {
            return formatos;
        }
        public List<Formato> TraerFormatosEditados()
        {
            return formatosEditados;
        }
        public Formato BuscarXNombre(string nombre)
        {
            foreach (Formato f in formatos)
            {
                if (f.Nombre == nombre)
                {
                    return f;
                }
            }
            return null;
        }
        
    }
}
