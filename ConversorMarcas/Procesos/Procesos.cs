using ConversorMarcas.Controles;
using ConversorMarcas.Datos.Listas;
using ConversorMarcas.Modelo.Entidades;

namespace ConversorMarcas.Procesos
{
    public class Procesos
    {
        Sesion sesion;
        public Procesos(Sesion sesion) 
        {
            this.sesion = sesion;
        }
        public string LeerDatosPrueba(string nombreArchivo, string rutaCarpeta) { return ControlArchivos.LeerDatosPrueba(nombreArchivo, rutaCarpeta); }

        private string ObtenerExtensionDeNombreArchivo(string nombreArchivo) 
        {
            int largonombre = nombreArchivo.Length;
            while (largonombre >= 0) 
            {
                if (nombreArchivo.Substring(largonombre - 1).StartsWith(".")) return nombreArchivo.Substring(largonombre - 1);
                largonombre--;
            }
            return "";
        }
        public string TransformarMarcas_UnArchivo(FileInfo fileIn, string nombreArchivoOut, string folderOut)
        {
            //validar nombre archivo. 
            //validar nombre y ruta carpeta
            List<Linea> lineas = ControlArchivos.ObtenerLineas_UnArchivoXCarpeta(fileIn);
            return TransformarMarcas(lineas,nombreArchivoOut,folderOut);
        }
        public string TransformarMarcas_VariosArchivos(string folderIn, string nombreArchivoOut, string folderOut) 
        {
            List<Linea> lineas = ControlArchivos.ObtenerLineas_VariosArchivosXCarpeta(folderIn);
            return TransformarMarcas(lineas, nombreArchivoOut, folderOut);
        }
        string TransformarMarcas(List<Linea> lineasATransformar, string nombreArchivoOut, string folderOut) 
        {
            
            if (lineasATransformar == null) { return "No hay lineas para convertir"; }
            if (lineasATransformar.Count == 0) { return "No hay lineas para convertir"; }
            if (!ControlLineas.GetInstancia().AgregarLineas(lineasATransformar)) return "Hubo un error al guardar las lineas iniciales."; ;

            List<Marca> marcas = ControlLineas.GetInstancia().ObtenerMarcas();
            if (marcas == null) return "No se obtuvieron marcas";
            if (marcas.Count == 0) return "No se obtuvieron marcas";

            if (!RepoMarcas.GetInstancia().Alta(marcas)) return "No se pudieron guardar las marcas";

            string extensionSalida = ObtenerExtensionDeNombreArchivo(nombreArchivoOut);
            Formato formatoSalida = RepoFormatos.GetInstancia().GetFormatoXExtension(extensionSalida);
            if (formatoSalida == null) { return "No se obtuvo un formato de salida correcto"; }
            lineasATransformar = RepoMarcas.GetInstancia().GetLineasXFormato(formatoSalida);
            if (lineasATransformar == null) { return "No se pudieron convertir las marcas al formato solicitado."; }
            if (lineasATransformar.Count == 0) { return "No se convirtio ninguna marca."; }
            if (!ControlLineas.GetInstancia().ResetearLineas()) return "No se pudo hacer sobreescribir la informacion.";
            if (!ControlLineas.GetInstancia().AgregarLineas(lineasATransformar)) return "Hubo un error al guardar las lineas con las marcas convertidas.";

            string stringSalida = ControlLineas.GetInstancia().LineasString();
            if (stringSalida == null) { return "Se obtuvo una salida vacia."; }
            ControlArchivos.GenerarArchivoDeSalida(folderOut, nombreArchivoOut, formatoSalida.GetExtension(), stringSalida);
            return "OK";
        }
    }
}
