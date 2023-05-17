namespace ConversorMarcas.Modelo.Entidades
{
    public class Funcionario
    {
        string nombre;
        int nro_tarjeta;
        
        public Funcionario(string nombre, int nro_tarjeta)
        {
            Nombre = nombre;
            NroTarjeta = nro_tarjeta;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroTarjeta { get => nro_tarjeta; set => nro_tarjeta = value; }
    }
}