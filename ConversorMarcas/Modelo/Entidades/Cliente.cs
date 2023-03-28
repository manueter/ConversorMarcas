using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMarcas.Modelo.Entidades
{
    public class Cliente
    {
        string nombre;
        List<Formato> formatos = new List<Formato> ();
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Formato> GetFormatos(){ return this.formatos;}
        public Cliente(string nombre)
        {
            Nombre = nombre;
        }
        public bool AgregarFormato(Formato formato) 
        { 
            if(formato == null) return false;
            foreach (Formato f in formatos) 
            {
                if (formato.Nombre == f.Nombre) return false;
            }
            formatos.Add(formato); return true;
        }
        public bool QuitarFormato(Formato formato)
        {
            if (formato == null) return false;
            return formatos.Remove(formato); 
        }
        public void VaciarFormatos()
        {
            formatos = new List<Formato>();
        }
    }
}
