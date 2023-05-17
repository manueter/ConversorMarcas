namespace ConversorMarcas.Modelo.Entidades
{
    public class Formato
    {
        int id;
        string nombre;
        string extension;
        Cliente cliente;
        Seccion body = new Seccion("Body");
        Seccion header = new Seccion("Header");
        bool tieneHeader;
        int ultIdParam = 0;
        List<int> ids_param_sin_usar = new List<int>();

        public Formato(string nombre, string extension, Cliente cliente, bool tieneHeader)
        {
            this.nombre = nombre;
            if (!extension.StartsWith(".")) { extension = "." + extension; }
            this.extension = extension;
            this.cliente = cliente;
            this.tieneHeader = tieneHeader;
        }
        public int Id { get => id; set => id = value; }
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
            Parametro nuevo = new Parametro(nombre, posInicial, cantDigitos, esHeader);
            if (ids_param_sin_usar.Count() != 0)
            {
                nuevo.Id = ids_param_sin_usar[0];
                ids_param_sin_usar.Remove(ids_param_sin_usar[0]);
            }
            else
            {
                ultIdParam++;
                nuevo.Id = ultIdParam;
            }

            if (esHeader)
            {
                return GetHeader().AgregarParametro(nuevo);
            }
            else 
            {
                return GetBody().AgregarParametro(nuevo);
            }
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
        public Parametro ParamXNombre(string nombre)
        {
            if (body.ParamXNombre(nombre) != null) return body.ParamXNombre(nombre);
            if (TieneHeader) { if (header.ParamXNombre(nombre) != null) return header.ParamXNombre(nombre); }

            return null;
            
        }
        public Parametro ParamXId(int id)
        {
            Parametro p = this.body.ParamXId(id);
            if (p != null) return p;
            return this.header.ParamXId(id);
        }
        public Formato Editar(Parametro[] parametrosAEditar) 
        {
            foreach (Parametro pEdit in parametrosAEditar)
            {
                if (pEdit != null)
                {
                    ParamXId(pEdit.Id).Posicion = pEdit.Posicion;
                    ParamXId(pEdit.Id).CantDigitos = pEdit.CantDigitos;
                }
            }
            return this;
        }
        public bool EditarParametros(Parametro[] parametrosAEditar) 
        {
            foreach (Parametro pEdit in parametrosAEditar) 
            {
                if (pEdit != null) 
                {
                    Parametro p = ParamXId(pEdit.Id);
                    if (p == null) return false;
                    p = pEdit;
                    p.Posicion = pEdit.Posicion;
                    p.CantDigitos= pEdit.CantDigitos;
                }
            }
            return true;
        }
        public bool Validar()
        {
            if(nombre.Trim()=="") return false;
            if(cliente == null) return false ;
            return true;
        }
    }
}