namespace ConversorMarcas.Modelo.Entidades
{
    public class Parametro
    {
        int id;
        string nombre;
        int posicion;
        int cantDigitos;
        string valor;

        public Parametro(int id,string nombre)
        {
            Nombre = nombre;
        }
        public Parametro(int id,string nombre, int posicion, int cantDigitos)
        {
            Nombre = nombre;
            Posicion = posicion;
            CantDigitos = cantDigitos;
        }
        public Parametro(int id, string nombre, string valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
        public int CantDigitos { get => cantDigitos; set => cantDigitos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Posicion { get => posicion; set => posicion = value; }
        public string Valor { get => valor; set => valor = value; }
        public int GetId() { return id; }
    }
}