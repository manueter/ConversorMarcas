namespace ConversorMarcas.Modelo.Entidades
{
    public class Funcionario
    {
        string nombre;
        string nroTarjeta;
        // Horario horario;
        
        public Funcionario(string nombre, string nroTarjeta)
        {
            Nombre = nombre;
            NroTarjeta = nroTarjeta;
        }
        public string Nombre { get => nroTarjeta; set => nroTarjeta = value; }
        public string NroTarjeta { get => nroTarjeta; set => nroTarjeta = value; }
    }
}