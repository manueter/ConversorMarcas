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
        List<Marca> marcas = new List<Marca> ();
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Formato> GetFormatos(){ return this.formatos;}
        public List<Marca> Marcas { get => this.marcas; }  
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
        public Formato GetFormatoXNombre(string nombre) 
        {
            foreach (Formato f in formatos)
            {
                if (nombre == f.Nombre) return f;
            }
            return null;
        }

        public bool AgregarMarcas(List<Marca> marcasNuevas) 
        {
            if (marcasNuevas == null) return false;
            marcas.AddRange(marcasNuevas); return true;
        }
        public void VaciarFormatos()
        {
            formatos = new List<Formato>();
        }
    }
}
