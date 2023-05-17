using ConversorMarcas.Modelo;
using ConversorMarcas.Modelo.Entidades;

namespace ConversorMarcas.Datos.Listas
{
    public class RepoMarcas : IRepositorio<Marca>
    {
        private static RepoMarcas instancia = new RepoMarcas();
        private List<Marca> marcas = new List<Marca>();
        private List<Marca> marcasFiltradas = new List<Marca>();
        public static RepoMarcas GetInstancia() { return instancia; }

        //considerar una verificacion de marca repetida.
        public bool Alta(List<Marca> marcas)
        { 
            if (marcas == null) return false; if (marcas.Count == 0) return false; this.marcas = marcas; 
            return true; 
        }
        public bool Alta(Marca marca)
        {
            if (marca == null) return false;
            marcas.Add(marca); return true;
        }
        public bool Baja(Marca marca)
        {
            if (marca == null) return false;
            return marcas.Remove(marca);
        }
        public List<Marca> TraerTodo() { return marcas; }
        public Marca BuscarXNombre(string nombre) 
        { return null; }
        public Marca BuscarXId(int id) 
        { foreach (Marca m in marcas) { if (m.Id == id) return m; } return null; }
        public List<Linea> GetLineasXFormato(Formato formato)
        {
            return GetLineasXFormato(this.marcas,formato);
        }
        public List<Linea> GetLineasXFormato(List<Marca> marcasATransformar,Formato formato)
        {
            List<Linea> lineas = new List<Linea>();
            int numLinea = 0;
            foreach (Marca m in marcasATransformar)
            {
                string valorLinea = m.ToString(formato);
                Linea l = new Linea(numLinea++, valorLinea, formato);
                numLinea++;
                lineas.Add(l);
            }
            return lineas;
        }


        public List<Marca> GetMarcasXFuncionarioYFecha(Funcionario funcionario, DateTime inicio, DateTime fin)
        {
            return GetMarcasXFecha(GetMarcasXFuncionario(funcionario), inicio, fin);
        }
        public List<Marca> GetMarcasXFuncionario(Funcionario funcionario)
        {
            List<Marca> encontradas = new List<Marca>();

            string nro_actual_str = "";
            foreach (Marca m in marcas)
            {
                nro_actual_str += m.ParametroXNombre("nroTarjeta");
                int nro_actual;
                Int32.TryParse(nro_actual_str, out nro_actual);
                if (nro_actual == funcionario.NroTarjeta)
                {
                    encontradas.Add(m);
                }
            }
            return encontradas;
        }
        public List<Marca> GetMarcasXFuncionario(int nroFunc)
        {
            List<Marca> encontradas = new List<Marca>();
            string nroBuscado = ""+nroFunc;
            string nroActual = "";
            foreach (Marca m in marcas)
            {
                nroActual += m.ParametroXNombre("nroTarjeta");
                if (nroActual == nroBuscado)
                {
                    encontradas.Add(m);
                }
            }
            return encontradas;
        }
        public List<Marca> GetMarcasXFecha(DateTime inicio, DateTime fin)
        {
            List<Marca> encontradas = new List<Marca>();
            // Validar fechas
            string fechaInicio = inicio.Date.ToString();
            string fechaFin = fin.Date.ToString();
            //string nroActual = "";
            foreach (Marca m in marcasFiltradas)
            {
                //string to date
                //if( m.getFecha() between fechaInicio && fechaFin) encontradas.Add(m);
            }
            return encontradas;
        }
        public List<Marca> GetMarcasXFecha(List<Marca> marcasFiltradas, DateTime inicio, DateTime fin)
        {
            List<Marca> encontradas = new List<Marca>();
            // Validar fechas
            if (marcasFiltradas == null)
            {
                marcasFiltradas = marcas;
            }

            string fechaInicio = inicio.Date.ToString();
            string fechaFin = fin.Date.ToString();
            //string nroActual = "";
            foreach (Marca m in marcasFiltradas)
            {
                //string to date
                //if( m.getFecha() between fechaInicio && fechaFin) encontradas.Add(m);
            }
            return encontradas;
        }
    }
}