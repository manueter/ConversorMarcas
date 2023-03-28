using ConversorMarcas.Modelo;
using ConversorMarcas.Modelo.Entidades;

namespace ConversorMarcas.Datos.Listas
{
    public class RepoFormatos : IRepositorio<Formato>
    {
        private static RepoFormatos instancia = new RepoFormatos();
        private List<Formato> formatos = new();
        public static RepoFormatos GetInstancia() { return instancia; }
        private RepoFormatos() { }

        public bool Alta(Formato nuevo)
        {
            if (!nuevo.Validar()) { return false; }
            if(!RepoClientes.GetInstancia().AgregarFormatoACliente(nuevo)) return false;
            formatos.Add(nuevo);
            return true;
        }
        public bool Baja(Formato aBorrar)
        {
            if (aBorrar == null) return false;
            if(formatos.Count()==0) return false;
            return formatos.Remove(aBorrar);
        }
        public List<Formato> TraerTodo()
        {
            return formatos;
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
        public Formato BuscarXId(int id) 
        {
            /*
            foreach (Formato f in formatos)
            {
                if (f.Id == id)
                {
                    return f;
                }
            }
            */
            return null;
        }
        public Formato GetFormatoXExtension(string extension)
        {
            if (extension == null) return null;
            if (extension == "") return null;
            if (!extension.StartsWith(".")) { extension = "." + extension; }

            bool formatoBack = false;

            if (int.TryParse(extension.Substring(1), out int extensionComoInt))
            {
                formatoBack = true;
                Console.WriteLine(extensionComoInt);
            }
            else
            {
                //Console.WriteLine("String could not be parsed.");
            }

            foreach (Formato f in formatos)
            {
                if (formatoBack && f.GetExtension().ToLower() == ".dat") return f;
                if (f.GetExtension().ToLower() == extension.ToLower())
                {
                    return f;
                }
            }
            return null;
        }
    }
}