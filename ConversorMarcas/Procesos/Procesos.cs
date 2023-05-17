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

        public string TransformarMarcas_UnArchivo(FileInfo fileIn, string nameFileOut, string folderOut, Formato formatoIn,Formato formatoOut)
        {
            //validar nombre archivo. 
            //validar nombre y ruta carpeta           
            List<Marca> marcas = ControlArchivos.ObtenerMarcas(fileIn,formatoIn);

            // Si quisiera guardar las marcas en el cliente:
            //sesion.GetCliente().AgregarMarcas(marcas);
            RepoMarcas.GetInstancia().Alta(marcas);


            return TransformarMarcas(marcas, nameFileOut, folderOut, formatoOut);
        }
        public string TransformarMarcas_VariosArchivos(string folderIn, string nameFileOut, string folderOut, Formato formatoIn, Formato formatoOut) 
        {
            DirectoryInfo dir = new DirectoryInfo(folderIn);
            List<Marca> marcas = ControlArchivos.ObtenerMarcas(dir,formatoIn);
            return TransformarMarcas(marcas, nameFileOut, folderOut, formatoOut);
        }

        
        private string TransformarMarcas(List<Marca> marcasATransformar, string nameFileOut, string folderOut, Formato formatoOut) 
        {
            List<Linea> lineasTransformadas = RepoMarcas.GetInstancia().GetLineasXFormato(marcasATransformar,formatoOut);
            if (lineasTransformadas == null) { return "No se pudieron convertir las marcas al formato solicitado."; }
            if (lineasTransformadas.Count == 0) { return "No se convirtio ninguna marca."; }
            ControlArchivos.GenerarArchivoDeSalida(folderOut, nameFileOut, formatoOut.GetExtension(), lineasTransformadas);
            return "OK";
        }

        public string BuscarMarcas
            (FileInfo fileIn, string nameFileOut, string folderOut, Formato formatoIn, Formato formatoOut, bool filtrarNroFunc, int numFuncionario, bool filtrarDateIni, DateTime dateIni, bool filtrarDateFin, DateTime dateFin)
        {
            return "No implementado";
        }
        public string BuscarMarcasXFuncionario(int numFuncionario, FileInfo fileIn, string nameFileOut, string folderOut, Formato formatoIn, Formato formatoOut)
        {       
            List<Marca> marcas = ControlArchivos.ObtenerMarcas(fileIn, formatoIn);
            //sesion.GetCliente().AgregarMarcas(marcas);
            RepoMarcas.GetInstancia().Alta(marcas);
            List<Marca> marcasXFuncionario = RepoMarcas.GetInstancia().GetMarcasXFuncionario(numFuncionario);

            return TransformarMarcas(marcasXFuncionario, nameFileOut, folderOut, formatoOut);
        }
    }
}
