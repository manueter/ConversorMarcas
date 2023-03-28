namespace ConversorMarcas.Modelo.Entidades
{
    public class Marca
    {
        int id;
        static int ultId = 0;
        Seccion seccionMarca = new Seccion("Body");
        public int Id { get => id; set => id = value; }

        public Marca()
        {
            Id = ++ultId;
        }
        public Marca(string reloj, string fecha, char tipo, string hora, string nroTarjeta)
        {
            Id = ++ultId;

            ParametrosBase();
            ParametroXNombre("reloj").Valor = reloj;
            ParametroXNombre("fecha").Valor = fecha;
            ParametroXNombre("tipo").Valor = "" + tipo;
            ParametroXNombre("hora").Valor = hora;
            ParametroXNombre("nroTarjeta").Valor = nroTarjeta;
        }

        //private int ultPos;
        public Seccion GetSeccion() => seccionMarca;
        public void ParametrosBase()
        {
            seccionMarca.AgregarParametro(new Parametro("reloj"));
            seccionMarca.AgregarParametro(new Parametro("fecha"));
            seccionMarca.AgregarParametro(new Parametro("hora"));
            seccionMarca.AgregarParametro(new Parametro("tipo"));
            seccionMarca.AgregarParametro(new Parametro("nroTarjeta"));
        }

        public bool AgregarParametros(List<Parametro> parametrosNuevos)
        {
            foreach (Parametro nuevo in parametrosNuevos)
            {
                if (!seccionMarca.AgregarParametro(nuevo)) return false;
            }
            return true;
        }

        public Parametro ParametroXNombre(string nombre)
        {
            foreach (Parametro p in seccionMarca.GetParametros())
            {
                if (p.Nombre == nombre)
                {
                    return p;
                }
            }
            return null;
        }

        public string FormatearNroTarjetaparaGIRH()
        {

            int cantidadDigitos = ParametroXNombre("nroTarjeta").CantDigitos;
            int cantCeros = 14 - cantidadDigitos;
            string ceros = "";

            while (cantCeros != 0)
            {
                ceros += "0";
                cantCeros--;
            }
            return ceros + ParametroXNombre("nroTarjeta").Valor;
        }
        public string ToString(Formato formato)
        {
            string outString = "";
            int mayorPos;
            string[] arrayValores;
            Parametro pMarca;

            if (formato.TieneHeader) // Esto se ignora si el formato no tiene Header.
            {
                // El array se arma para almacenar los parametros por posicion. 
                // Cada posicion del array corresponde a la posicion del parametro, y su valor interno se debe rellenar con el de la marca.
                // Se suma uno, +1, para que coincida posicion de array con la del parametro.
                //     > la posicion de los parametros comienza en 1 y la posicion de un array comienza en 0
                mayorPos = formato.GetBody().GetMayorPosicion().Posicion + 1;
                arrayValores = new string[mayorPos];
                foreach (Parametro paramFormato in formato.GetHeader().GetParametros())
                {
                    pMarca = ParametroXNombre(paramFormato.Nombre);
                    if (pMarca != null) { arrayValores[paramFormato.Posicion] = pMarca.Valor; }
                }
                foreach (string s in arrayValores)
                {
                    if (s != null) outString += s.Trim();
                }
            }

            // Mismo proceso pero para Body. 

            // El formato puede tener menos parametros, tambien puede tener mas parametros que la marca en si.
            // Si tiene mas, se rellena vacio
            // Si tiene menos no se busca no se agrega nada.
            mayorPos = formato.GetBody().GetMayorPosicion().Posicion + 1;
            arrayValores = new string[mayorPos];
            foreach (Parametro paramFormato in formato.GetBody().GetParametros())
            {
                pMarca = seccionMarca.ParametroXNombre(paramFormato.Nombre);
                if (pMarca != null)
                {
                    if (pMarca != null) { arrayValores[paramFormato.Posicion] = pMarca.Valor; }
                }
            }
            foreach (string s in arrayValores)
            {
                if (s != null) outString += s.Trim();
            }
            return outString;
        }

        //Pasar formato para precarga de datos?
        public string ToStringGIRH()
        {
            string strout = "";

            strout += ParametroXNombre("reloj").Valor;
            strout += ParametroXNombre("fecha").Valor;
            strout += ParametroXNombre("tipo").Valor;
            strout += ParametroXNombre("hora").Valor;
            string tarjetaFormatoGIRH = FormatearNroTarjetaparaGIRH();

            strout += tarjetaFormatoGIRH;

            //FORMATO GIRH
            // Nro tarjeta son 14 digitos rellenando con ceros a la izquierda
            // rrffffffthhhhnnnnnnnnnnnnnn

            return strout;

        }

    }
}
