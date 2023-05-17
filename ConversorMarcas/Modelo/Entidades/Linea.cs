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

        //Una Linea si es nueva no tiene archivo de origen, su objetivo es escribirse en un archivo nuevo.
        public Linea(int numLinea, string valorLinea, Formato formato)
        {
            this.numLinea = numLinea;
            this.valorLinea = valorLinea;
            this.formato = formato;
            ObtenerMarcas();
        }
        public Linea(int numLinea, string valorLinea, Formato formato, string archivoOrigen)
        {
            this.numLinea = numLinea;
            this.valorLinea = valorLinea;
            this.formato = formato;            
            this.archivoOrigen = archivoOrigen;
            //ObtenerMarcas();
        }

        public string Valor { get => valorLinea; set => valorLinea = value; }
        public Formato GetFormato() { return formato; }
        public string GetArchivoOrigen() { return archivoOrigen; }
        public int GetNumLinea() { return numLinea; }

        public Parametro ParametroXNombre(string nombre)
        {
            return formato.ParamXNombre(nombre);
        }
        public List<Marca> ObtenerMarcas()
        {
            List<Marca> marcasObtenidas = new List<Marca>();
            List<Parametro> parametrosHeader = new List<Parametro>();
            int idParamMarca=0;

            string valorDelParamActual;
            if (formato.TieneHeader)
            {
                foreach (Parametro p in formato.GetHeader().GetParametros())
                {
                    // Conseguir un estandar
                    idParamMarca++;
                    valorDelParamActual = valorLinea.Substring(p.Posicion - 1, p.CantDigitos);
                    p.Valor = valorDelParamActual;
                    Parametro nuevoParamHeader = new Parametro(p.Nombre, p.Valor);
                    parametrosHeader.Add(nuevoParamHeader);
                }
            }

            //Hay que verificar el largo total de la linea y comparar con largo de seccion body
            int largoSeccionBody = formato.GetBody().GetLargoSeccion();
            int largoLinea = valorLinea.Length;
            int posActual = formato.GetHeader().GetLargoSeccion();        //Quitar -1
            int idActual = idParamMarca;

            while (posActual + largoSeccionBody <= largoLinea)
            {
                Marca nueva = new Marca(this);
                if(!nueva.AgregarParametros(parametrosHeader)) return null;
                
                foreach (Parametro p in formato.GetBody().GetParametros())
                {
                    idActual++;
                    //Corregir posicion con posicionActual
                    valorDelParamActual = valorLinea.Substring(p.Posicion + posActual - 1, p.CantDigitos);
                    p.Valor = valorDelParamActual;
                    if(!nueva.AgregarParametro(new Parametro(p.Nombre, p.Valor))) return null;
                }
                marcasObtenidas.Add(nueva);
                idActual = idParamMarca;
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