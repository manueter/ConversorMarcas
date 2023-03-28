using ConversorMarcas.Datos.Listas;
using ConversorMarcas.Modelo.Entidades;

namespace ConversorMarcas.Controles
{
    public static class ControlArchivos
    {
        public static string LeerDatosPrueba(string nombreArchivo, string rutaCarpeta)
        {
            DirectoryInfo dir = new DirectoryInfo(rutaCarpeta);

            if (dir.Exists)
            {
                IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
                foreach (FileInfo f in fileList)
                {
                    string s = "";
                    s += f.Name;
                    s += f.Extension;
                    return s;
                }
            }

            return null;
        }
        private static FileInfo ArchivoXNombreYRuta(string nombreArchivo, string rutaCarpeta)
        {
            DirectoryInfo dir = new DirectoryInfo(rutaCarpeta);

            if (dir.Exists)
            {
                IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
                foreach (FileInfo f in fileList)
                {
                    if (f.Name == nombreArchivo) return f;
                }
            }

            return null;
        }

        // No se guardan los archivos, la idea es devolver la lineas.

        private static IEnumerable<FileInfo> ListaArchivosEnCarpeta(string rutaCarpeta)
        {
            DirectoryInfo dir = new DirectoryInfo(rutaCarpeta);

            if (dir.Exists)
            {
                IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
                return fileList;
            }
            return null;
        }

        public static List<Linea> ObtenerLineas_UnArchivoXCarpeta(FileInfo archivo)
        {

            //FileInfo archivo = ArchivoXNombreYRuta(nombreArchivo, rutaCarpeta);
            List<FileInfo> listaArchivos = new List<FileInfo>();
            listaArchivos.Add(archivo);
            /*
            List<Linea> obtenidas = new List<Linea>();
            Linea linea;
            StreamReader sr = new StreamReader(archivo.FullName);
            string lineastr = sr.ReadLine().Trim();
            int numLinea = 0;
            Formato formato = ControlFormatos.GetInstancia().GetFormatoXExtension(archivo.Extension);
            while (lineastr != null)
            {
                // Hay que verificar que CADA LINEA cumpla el FORMATO que le corresponde.
                if (formato.ValidarLinea(lineastr))
                { numLinea++; linea = new Linea(numLinea, lineastr, formato, archivo.FullName); obtenidas.Add(linea); }
                lineastr = sr.ReadLine();
            }
            sr.Close();
            return obtenidas;
            */
            return ObtenerLineas_ListaArchivos(listaArchivos);
        }
        //Metodo guarda las lineas en la lista global en ControlLineas
        public static List<Linea> ObtenerLineas_VariosArchivosXCarpeta(string startFolder)
        {
            return ObtenerLineas_ListaArchivos(ListaArchivosEnCarpeta(startFolder));
        }
        private static List<Linea> ObtenerLineas_ListaArchivos(IEnumerable<FileInfo> listaArchivos)
        {
            StreamReader sr;
            string lineastr;
            Linea linea;
            List<Linea> obtenidas = new List<Linea>();
            if (listaArchivos == null) return null;
            foreach (FileInfo archivo in listaArchivos)
            {
                sr = new StreamReader(archivo.FullName);
                lineastr = sr.ReadLine().Trim();
                int numLinea = 0;
                Formato formato = RepoFormatos.GetInstancia().GetFormatoXExtension(archivo.Extension);
                while (lineastr != null)
                {
                    //Hay que validar la linea
                    numLinea++;
                    linea = new Linea(numLinea, lineastr, formato, archivo.FullName);
                    obtenidas.Add(linea);
                    lineastr = sr.ReadLine();
                }
                sr.Close();
            }
            return obtenidas;
        }
        public static void GenerarArchivoDeSalida(string outFolder, string nombre, string extension, string datosString)
        {
            if (extension != null)
            {
                extension = extension.Trim();
                if (!extension.Substring(0, 1).Equals(".")) { extension = "." + extension; }
                try
                {
                    if (nombre.IndexOf(extension) == -1) 
                    {
                        nombre = nombre + extension;
                    }
                    string salida = outFolder + "\\" + nombre;
                    StreamWriter sw = new StreamWriter(salida);
                    sw.WriteLine(datosString);
                    sw.Close();
                    sw.Dispose();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally { }
            }
        }
        private static void UnificarArchivos(string startFolder, string outFolder, string nombre, string extension)
        {
            IEnumerable<FileInfo> listaArchivos = ListaArchivosEnCarpeta(startFolder);
            StreamReader sr;
            string lineasalida = "";
            if (listaArchivos != null)
            {
                foreach (FileInfo archivo in listaArchivos)
                {
                    sr = new StreamReader(archivo.FullName);
                    string lineastr = sr.ReadLine().Trim();
                    while (lineastr != null)
                    {
                        lineastr += Environment.NewLine;
                        lineastr += sr.ReadLine().Trim();
                    }
                    sr.Close();
                    if (lineastr != null)
                    {
                        lineasalida += Environment.NewLine;
                        lineasalida += lineastr;
                    }
                }
            }
            nombre = nombre.Trim();
            extension = extension.Trim();
            if (!extension.Substring(0, 1).Equals("."))
            {
                extension = "." + extension;
            }
            GenerarArchivoDeSalida(outFolder, nombre, extension, lineasalida);
        }
    }

}