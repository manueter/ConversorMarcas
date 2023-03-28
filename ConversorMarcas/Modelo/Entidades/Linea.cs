using System.Text.RegularExpressions;

namespace ConversorMarcas.Modelo.Entidades
{
    public class Linea
    {
        int numLinea;
        string valorLinea;
        int largo;
        Formato formato;
        string archivoOrigen;

        public Linea(int numLinea, string valorLinea, Formato formato)
        {
            this.numLinea = numLinea;
            this.valorLinea = valorLinea;
            this.formato = formato;
            archivoOrigen = "";
        }
        public Linea(int numLinea, string valorLinea, Formato formato, string archivoOrigen)
        {
            this.numLinea = numLinea;
            this.valorLinea = valorLinea;
            this.formato = formato;
            this.archivoOrigen = archivoOrigen;
        }

        public string Valor { get => valorLinea; set => valorLinea = value; }
        public Formato GetFormato() { return formato; }
        public string GetArchivoOrigen() { return archivoOrigen; }
        public int GetNumLinea() { return numLinea; }

        public bool ExisteParametroXNombre(Parametro parametro)
        {
            return formato.TieneParametroXNombre(parametro);
        }
        public List<Marca> ObtenerMarcas()
        {
            List<Marca> marcasObtenidas = new List<Marca>();
            List<Parametro> paramsHeaderMarca = new();


            string valorDelParamActual;
            if (formato.TieneHeader)
            {

                foreach (Parametro p in formato.GetHeader().GetParametros())
                {
                    // Conseguir un estandar

                    valorDelParamActual = valorLinea.Substring(p.Posicion - 1, p.CantDigitos);
                    p.Valor = valorDelParamActual;
                    Parametro paramHeaderNuevo = new Parametro(p.Nombre, p.Valor);
                    paramsHeaderMarca.Add(paramHeaderNuevo);
                }

            }

            //Hay que verificar el largo total de la linea y comparar con largo de seccion body
            int largoSeccionBody = formato.GetBody().GetLargoSeccion();
            int largoLinea = valorLinea.Length;
            int posActual = formato.GetHeader().GetLargoSeccion();        //Quitar -1
            //int posActual = formato.GetBody().GetLargoSeccion();
            while (posActual + largoSeccionBody <= largoLinea)
            {
                List<Parametro> paramsMarca = new();
                if (formato.TieneHeader) paramsMarca.AddRange(paramsHeaderMarca);

                Marca nueva = new Marca();
                List<Parametro> paramsBodyMarca = new();
                foreach (Parametro p in formato.GetBody().GetParametros())
                {
                    //posActual=p.Posicion+posActual -1
                    //Corregir posicion con posicionActual
                    valorDelParamActual = valorLinea.Substring(p.Posicion + posActual - 1, p.CantDigitos);
                    p.Valor = valorDelParamActual;
                    Parametro paramBodyNuevo = new Parametro(p.Nombre, p.Valor);
                    paramsBodyMarca.Add(paramBodyNuevo);
                }
                paramsMarca.AddRange(paramsBodyMarca);
                if (nueva.AgregarParametros(paramsMarca)) marcasObtenidas.Add(nueva);
                else
                {
                    //Realizar un aviso si no se agrega la marca actual.. pero el recorrido sigue.
                    //Considerar que la linea ya fue validada.
                }
                posActual += largoSeccionBody;
            }

            return marcasObtenidas;
        }

        public bool ValidarLinea()
        {
            //if (linea == null) return false;
            if (valorLinea == null) return false;
            if (formato == null) return false;
            valorLinea = valorLinea.Trim();
            if (valorLinea.Length == 0) return false;
            int largoHeaderEsperado = 0;
            if (formato.TieneHeader) { largoHeaderEsperado += formato.GetHeader().GetLargoSeccion(); }
            if (valorLinea.Length <= largoHeaderEsperado) return false;
            int largoBodyEsperado = formato.GetBody().GetLargoSeccion();
            if ((valorLinea.Length - largoHeaderEsperado) % largoBodyEsperado != 0) { return false; } //Caso en que el largo del body no coincide
            // Al valor del body de la linea se le debe poder dividir en partes iguales y exactas del largoBodyEsperado
            // Porque pueden haber varios bodys en una linea
            string simbolosNoDeseados = "[!\"·$%&/()=¿¡?'_:;,|@#€*+.]";
            if (Regex.IsMatch(valorLinea, simbolosNoDeseados)) return false;
            return true;
        }
    }
}