using ConversorMarcas.Modelo.Entidades;

namespace ConversorMarcas.Controles
{
    public class ControlLineas
    {

        // Pasar de singleton a mantenter un listado de lineas.

        //private static ControlLineas instancia = new ControlLineas();
        private static List<Linea> lineas = new List<Linea>();
        private ControlLineas() { }
        public static List<Marca> ObtenerMarcas()
        {
            List<Marca> marcasObtenidas = new List<Marca>();
            if (lineas != null)
            {
                foreach (Linea linea in lineas)
                {
                    marcasObtenidas.AddRange(linea.ObtenerMarcas());
                }
                return marcasObtenidas;
            }
            return null;
        }
        public static List<Marca> MarcasXFuncionario(int numFuncionario) 
        {
            List<Marca> marcasObtenidas = ObtenerMarcas();
            List<Marca> marcasFiltradas = ObtenerMarcas();
            if (marcasObtenidas.Count> 0)
            {
                foreach (Marca marca in marcasObtenidas)
                {

                    /*
                    if (marca.Funcionario.getNumero() == numFuncionario) 
                    {
                        marcasFiltradas.Add(marca);
                    }*/
                }
                return marcasFiltradas;
            }
            return null;
        }
        public List<Linea> GetLineas() { return lineas; }
        public static bool AgregarLineas(List<Linea> nuevas)
        {
            if (nuevas == null) return false;

            foreach (Linea linea in nuevas)
            {
                if (linea.ValidarLinea()) lineas.Add(linea);
                else
                {
                    //Si alguna no valida enviar algun error o guardarla en algun lado.
                }

            }
            //if()
            return true;
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
        public static bool ResetearLineas()
        {
            lineas = new List<Linea>();
            return true;
        }

    }
}