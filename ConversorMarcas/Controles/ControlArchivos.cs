using ConversorMarcas.Datos.Listas;
using ConversorMarcas.Modelo.Entidades;

namespace ConversorMarcas.Controles
{
    public static class ControlArchivos
    {
        //static List<Archivo> archivos = new();
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
        private static IEnumerable<FileInfo> ArchivosEnCarpeta(DirectoryInfo dir)
        {
            //DirectoryInfo dir = new DirectoryInfo(rutaCarpeta);
            
            if (dir.Exists)
            {
                IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
                return fileList;
            }
            return null;
        }

        public static List<Marca> ObtenerMarcas(DirectoryInfo dir, Formato formato) 
        {
            IEnumerable<FileInfo> fileList = ArchivosEnCarpeta(dir);
            if (fileList == null) return null;

            List<Marca> marcas = new List<Marca>();

            foreach (FileInfo file in fileList)
            {
                marcas.AddRange(ObtenerMarcas(file, formato));
            }
            return marcas;
        }

        public static List<Marca> ObtenerMarcas(FileInfo file,Formato formato)
        {
            StreamReader sr;
            string lineastr;
            
            List<Marca> marcasObtenidas = new List<Marca>();
            Linea linea;

            sr = new StreamReader(file.FullName);
            lineastr = sr.ReadLine();
   
            int numLinea = 0;
            while (lineastr != null)
            {
                lineastr.Trim();
                //Hay que validar la linea
                numLinea++;
                linea = new Linea(numLinea, lineastr, formato, file.FullName);

                marcasObtenidas.AddRange(linea.ObtenerMarcas());

                lineastr = sr.ReadLine();
            }
            sr.Close();
            
            return marcasObtenidas;
        }

        public static string LineasToString(List<Linea> lineas)
        {
            string strout = "";
            if (lineas == null) return strout;
            foreach (Linea l in lineas)
            {
                strout += l.Valor;
                strout += Environment.NewLine;
            }
            return strout;
        }

        public static FileInfo GenerarArchivoDeSalida(string outFolder, string nombre, string extension, List<Linea> lineas) 
        {
            string datosString = LineasToString(lineas);
            return GenerarArchivoDeSalida(outFolder, nombre, extension, datosString);
        }

        public static FileInfo GenerarArchivoDeSalida(string outFolder, string nombre, string extension, string datosString)
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
                    FileInfo fi = new FileInfo(salida);
                    sw.Close();
                    sw.Dispose();
                    return fi;
                }
                catch (Exception e)
                {
                    // Console.WriteLine("Exception: " + e.Message);
                    
                }
                finally { }
                
            }
            return null;
        }
        private static FileInfo UnificarArchivos(string startFolder, string outFolder, string nombre, string extension)
        {
            DirectoryInfo dir = new DirectoryInfo(startFolder);
            IEnumerable<FileInfo> archivos = ArchivosEnCarpeta(dir);
            StreamReader sr;
            string lineasalida = "";
            if (archivos != null)
            {
                foreach (FileInfo archivo in archivos)
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
            return GenerarArchivoDeSalida(outFolder, nombre, extension, lineasalida);
        }
    }

}