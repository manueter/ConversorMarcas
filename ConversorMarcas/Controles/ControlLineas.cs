using ConversorMarcas.Modelo.Entidades;

namespace ConversorMarcas.Controles
{
    public class ControlLineas
    {
        private static ControlLineas instancia = new ControlLineas();
        private List<Linea> lineas = new List<Linea>();
        public static ControlLineas GetInstancia() { return instancia; }
        private ControlLineas() { }
        public List<Marca> ObtenerMarcas()
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
        public List<Linea> GetLineas() { return lineas; }
        public bool AgregarLineas(List<Linea> nuevas)
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
        public string LineasString()
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
        public bool ResetearLineas()
        {
            lineas = new List<Linea>();
            return true;
        }

    }
}