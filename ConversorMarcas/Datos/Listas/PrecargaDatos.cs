using ConversorMarcas.Modelo;
using ConversorMarcas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMarcas.Datos.Listas
{
    internal class PrecargaDatos
    {
        public static void CargarDatos() 
        { CargarDatos_INCA(); CargarDatos_IMPO(); }
        static void CargarDatos_IMPO() 
        {
            Cliente impo = new Cliente("IMPO");
            RepoClientes.GetInstancia().Alta(impo);
            //TRN
            Formato formato_TRN_impo = new Formato("TRN", ".trn", impo, false);

            formato_TRN_impo.AgregarParametro("fecha", 1, 6,false);
            formato_TRN_impo.AgregarParametro("hora", 8, 4, false);
            formato_TRN_impo.AgregarParametro("nroTarjeta", 12,10, false);
            formato_TRN_impo.AgregarParametro("tipo", 7, 1, false);
            RepoFormatos.GetInstancia().Alta(formato_TRN_impo);
            //Se agrega formato.

            //DAT
            Formato formato_DAT_impo = new Formato("DAT", ".dat", impo, true);
            formato_DAT_impo.AgregarParametro("reloj", 1, 2, true);
            formato_DAT_impo.AgregarParametro("fecha", 11, 6, true);
            formato_DAT_impo.AgregarParametro("hora", 19, 4,true);
            //formato_DAT_impo.GetBody().AgregarParametro(new Parametro("segundos", 23, 2));
            formato_DAT_impo.AgregarParametro("tipo", 1, 1,false);
            formato_DAT_impo.AgregarParametro("nroTarjeta", 5, 5,false);
            RepoFormatos.GetInstancia().Alta(formato_DAT_impo);

            //Se agrega formato.
        }
        static void CargarDatos_INCA()    //    INCA
        {
            Cliente inca = new Cliente("INCA");
            RepoClientes.GetInstancia().Alta(inca);
            //TRN
            Formato formato_TRN_inca = new Formato("TRN_INCA", ".trn", inca, false);
            formato_TRN_inca.AgregarParametro("reloj", 1, 2, false);
            formato_TRN_inca.AgregarParametro("fecha", 3, 6, false);
            formato_TRN_inca.AgregarParametro("hora", 10, 4, false);
            formato_TRN_inca.AgregarParametro("nroTarjeta", 14, 5, false);
            formato_TRN_inca.AgregarParametro("tipo", 9, 1, false);
            RepoFormatos.GetInstancia().Alta(formato_TRN_inca);
            //Se agrega formato.

            //DAT
            Formato formato_DAT_inca = new Formato("DAT_INCA", ".dat", inca, true);
            formato_DAT_inca.AgregarParametro("reloj", 1, 2,true);
            formato_DAT_inca.AgregarParametro("fecha", 11, 6,true);
            formato_DAT_inca.AgregarParametro("hora", 19, 4,false);
            formato_DAT_inca.AgregarParametro("segundos", 23, 2, false);
            formato_DAT_inca.AgregarParametro("tipo", 1, 1, false);
            formato_DAT_inca.AgregarParametro("nroTarjeta", 5, 5, false);
            RepoFormatos.GetInstancia().Alta(formato_DAT_inca);
            //Se agrega formato.
        }


    }
}
