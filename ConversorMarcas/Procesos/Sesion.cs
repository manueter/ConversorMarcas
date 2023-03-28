using ConversorMarcas.Datos.Listas;
using ConversorMarcas.Modelo.Entidades;

namespace ConversorMarcas.Procesos
{
    public class Sesion
    {
        Cliente cliente=null;
        public Sesion() 
        {
            PrecargaDatos.CargarDatos();
        }
        public void SetCliente(Cliente c) { this.cliente = c; }
        public Cliente GetCliente() { return this.cliente; }

    }
}
