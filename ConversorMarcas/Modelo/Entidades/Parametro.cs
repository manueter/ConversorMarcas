namespace ConversorMarcas.Modelo.Entidades
{
    public class Parametro
    {
        int id;
        string nombre;
        int posicion;
        int cantDigitos;
        bool esHeader;
        string valor;

        public Parametro(string nombre)
        {
            //Id = id;
            Nombre = nombre;
        }
        public Parametro(int id)
        {
            Id = id;
        }
        public Parametro(string nombre, int posicion, int cantDigitos,bool esHeader)
        {
            //Id = id;
            Nombre = nombre;
            Posicion = posicion;
            CantDigitos = cantDigitos;
            EsHeader = esHeader;
        }
        public Parametro(string nombre, string valor)
        {
            //Id = id;
            Nombre = nombre;
            Valor = valor;
        }
        public int Id { get => id; set => id = value; }
        public int CantDigitos { get => cantDigitos; set => cantDigitos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Posicion { get => posicion; set => posicion = value; }
        public string Valor { get => valor; set => valor = value; }
        public bool EsHeader { get => esHeader; set => esHeader = value; }  
    }
}