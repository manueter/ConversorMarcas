using ConversorMarcas.Modelo;
using ConversorMarcas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMarcas.Datos.Listas
{
    public class RepoClientes : IRepositorio<Cliente>
    {
        private static RepoClientes instancia = new();
        private List<Cliente> clientes = new();
        public static RepoClientes GetInstancia() { return instancia; }
        private RepoClientes() { }
        public List<Cliente> GetClientes => clientes;
        public bool Alta(Cliente nuevo)
        {
            if (nuevo == null) return false;
            foreach (Cliente c in clientes)
            {
                if (c.Nombre == nuevo.Nombre) return false;
            }
            clientes.Add(nuevo);
            return true;
        }
        public bool Baja(Cliente nuevo)
        {
            if (nuevo == null) return false;
            foreach (Cliente c in clientes)

            {
                if (c.Nombre == nuevo.Nombre)
                    return clientes.Remove(c);
            }
            return false;
        }
        public Cliente BuscarXNombre(string nombre) { foreach (Cliente c in clientes) { if (c.Nombre == nombre) return c; } return null; }
        public Cliente BuscarXId(int id) { /*foreach (Cliente c in clientes) { if (c.Id == id) return c; } */return null; }
        public List<Cliente> TraerTodo() { return clientes; }
        public bool AgregarFormatoACliente(Formato f)
        {
            Cliente buscado = BuscarXNombre(f.GetCliente().Nombre);
            if (buscado == null) return false;
            return buscado.AgregarFormato(f);
        }
        public List<Formato> GetFormatosXCliente(Cliente cliente) 
        {
            foreach (Cliente c in clientes) 
            {
                if (c.Nombre == cliente.Nombre) 
                {
                    return c.GetFormatos();
                }
            }
            return null;
        }
    }
}
