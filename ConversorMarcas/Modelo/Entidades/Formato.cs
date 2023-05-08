namespace ConversorMarcas.Modelo.Entidades
{
    public class Formato
    {
        string nombre;
        string extension;
        Cliente cliente;
        Seccion body = new Seccion("Body");
        Seccion header = new Seccion("Header");
        int ultIdParametro = 0;
        bool tieneHeader;
        public Formato(string nombre, string ext, Cliente cliente, bool tieneHeader)
        {
            Nombre = nombre;
            this.cliente = cliente;
            this.tieneHeader = tieneHeader;
            if (!ext.StartsWith(".")) { ext = "." + ext; }
            extension = ext;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public Cliente GetCliente() { return cliente; }
        public string GetExtension() { return extension; }
        public bool SetExtension(string ext)
        {
            if (!ext.StartsWith(".")) { ext = "." + ext; }
            extension = ext; return true;
        }
        public bool TieneHeader { get => tieneHeader; set => tieneHeader = value; }
        public Seccion GetBody() { return body; }
        public Seccion GetHeader() { return header; }

        public bool AgregarParametro(string nombre, int posInicial, int cantDigitos, bool esHeader)
        {
            Parametro nuevo = new Parametro(nombre, posInicial, cantDigitos);
            //nuevo.SetId(++ultIdParametro);
            if (esHeader)
            {
                if (GetHeader().AgregarParametro(nuevo)) 
                {
                    nuevo.Id = ++ultIdParametro;
                    return true;
                } 
            }
            else 
            {
                if (GetBody().AgregarParametro(nuevo))
                {
                    nuevo.Id = ++ultIdParametro;
                    return true;
                }
            }
            return false;
        }
        public bool QuitarParametro(Parametro aBorrar)
        {
            if (aBorrar is null) return false;
            if (GetHeader().QuitarParametro(aBorrar))
            {
                //Ajustar ids ?
                return true;
            }
            else
            {
                if (GetBody().QuitarParametro(aBorrar))
                {
                //Ajustar ids ?
                return true;
                }
            }
            return false;
        }
        public List<Parametro> GetParametros()
        {
            List<Parametro> paramOut = new List<Parametro>();
            if (tieneHeader)
            {
                paramOut.AddRange(header.GetParametros());
            }
            paramOut.AddRange(body.GetParametros());
            return paramOut;
        }
        public int GetCantParametros() { return body.GetCantParametros() + header.GetCantParametros(); }
        public bool TieneParametroXNombre(Parametro buscado)
        {
            if (body.ParametroXNombre(buscado.Nombre) != null) return true;
            else
            {
                if (TieneHeader) { return header.ParametroXNombre(buscado.Nombre) != null; }
                return false;
            }
        }
        public bool Validar()
        {
            if(nombre.Trim()=="") return false;
            if(cliente == null) return false ;
            return true;

        }
    }
}