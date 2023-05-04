using ConversorMarcas.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMarcas.Procesos
{
    internal class Sistema
    {
        private static Sistema instancia = new Sistema();
        public static Sistema GetInstancia() { return instancia; }
        private Sistema() { }
    }
}
