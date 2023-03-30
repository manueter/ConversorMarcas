namespace ConversorMarcas.Modelo.Entidades
{
    public class Seccion
    {
        string nombre;
        List<Parametro> parametros = new();
        int largoSeccion = 0;
        int cantParametros = 0;
        Parametro mayorPosicion = null;
        public Seccion(string nombre) { Nombre = nombre; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Parametro GetMayorPosicion() { return mayorPosicion; }
        public int GetLargoSeccion() { return largoSeccion; }
        public List<Parametro> GetParametros() { return parametros; }
        public int GetCantParametros() { return cantParametros; }   
        public bool AgregarParametro(Parametro nuevo)
        {
            if (nuevo is null) return false;
            foreach (Parametro pl in parametros)
            {
                if (nuevo.Nombre == pl.Nombre)
                {
                    return false;
                }
                if (nuevo.Posicion >= pl.Posicion && nuevo.Posicion < pl.Posicion + pl.CantDigitos)
                {
                    return false;
                }
            }
            parametros.Add(nuevo);
            cantParametros++;

            if (mayorPosicion != null)
            {
                if (mayorPosicion.Posicion > nuevo.Posicion) return true;
            }
            mayorPosicion = nuevo;
            largoSeccion = nuevo.Posicion + nuevo.CantDigitos - 1;
            return true;
        }
        public bool QuitarParametro(Parametro aborrar)
        {
            if (aborrar is null) return false;
            foreach (Parametro pl in parametros)
            {
                if (aborrar.Nombre == pl.Nombre)
                {
                    largoSeccion -= pl.CantDigitos;

                    parametros.Remove(pl);
                    cantParametros--;
                    if (mayorPosicion.Posicion == pl.Posicion)
                    { ReasignarMayorPosicion(); }   // Esto se corrige si se arma una lista ordenada de Parametros> ListaParametro.class
                    return true;
                }
            }
            return false;
        }
        private void ReasignarMayorPosicion()
        {
            Parametro mayPos = parametros[0];

            foreach (Parametro p in parametros)
            {

                if (mayPos.Posicion < p.Posicion) { mayPos = p; }
            }
        }
        public Parametro ParametroXNombre(string nombreBuscado)
        {
            if (nombreBuscado is null) return null;
            foreach (Parametro param in parametros)
            {
                if (nombreBuscado == param.Nombre)
                {
                    return param;
                }
            }
            return null;
        }
    }
}