﻿using ConversorMarcas.Modelo;
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
            formato_TRN_impo.GetBody().AgregarParametro(new("fecha", 1, 6));
            formato_TRN_impo.GetBody().AgregarParametro(new("hora", 8, 4));
            formato_TRN_impo.GetBody().AgregarParametro(new("nroTarjeta", 12,10));
            formato_TRN_impo.GetBody().AgregarParametro(new("tipo", 7, 1));
            RepoFormatos.GetInstancia().Alta(formato_TRN_impo);
            //Se agrega formato.

            //DAT
            Formato formato_DAT_impo = new Formato("DAT", ".dat", impo, true);
            formato_DAT_impo.GetHeader().AgregarParametro(new Parametro("reloj", 1, 2));
            formato_DAT_impo.GetHeader().AgregarParametro(new Parametro("fecha", 11, 6));
            formato_DAT_impo.GetBody().AgregarParametro(new Parametro("hora", 19, 4));
            //formato_DAT_impo.GetBody().AgregarParametro(new Parametro("segundos", 23, 2));
            formato_DAT_impo.GetBody().AgregarParametro(new Parametro("tipo", 1, 1));
            formato_DAT_impo.GetBody().AgregarParametro(new Parametro("nroTarjeta", 5, 5));
            RepoFormatos.GetInstancia().Alta(formato_DAT_impo);

            //Se agrega formato.
        }
        static void CargarDatos_INCA()    //    INCA
        {
            Cliente inca = new Cliente("INCA");
            RepoClientes.GetInstancia().Alta(inca);
            //TRN
            Formato formato_TRN_inca = new Formato("TRN_INCA", ".trn", inca, false);
            formato_TRN_inca.GetBody().AgregarParametro(new("reloj", 1, 2));
            formato_TRN_inca.GetBody().AgregarParametro(new("fecha", 3, 6));
            formato_TRN_inca.GetBody().AgregarParametro(new("hora", 10, 4));
            formato_TRN_inca.GetBody().AgregarParametro(new("nroTarjeta", 14, 5));
            formato_TRN_inca.GetBody().AgregarParametro(new("tipo", 9, 1));
            RepoFormatos.GetInstancia().Alta(formato_TRN_inca);
            //Se agrega formato.

            //DAT
            Formato formato_DAT_inca = new Formato("DAT_INCA", ".dat", inca, true);
            formato_DAT_inca.GetHeader().AgregarParametro(new Parametro("reloj", 1, 2));
            formato_DAT_inca.GetHeader().AgregarParametro(new Parametro("fecha", 11, 6));
            formato_DAT_inca.GetBody().AgregarParametro(new Parametro("hora", 19, 4));
            formato_DAT_inca.GetBody().AgregarParametro(new Parametro("segundos", 23, 2));
            formato_DAT_inca.GetBody().AgregarParametro(new Parametro("tipo", 1, 1));
            formato_DAT_inca.GetBody().AgregarParametro(new Parametro("nroTarjeta", 5, 5));
            RepoFormatos.GetInstancia().Alta(formato_DAT_inca);
            //Se agrega formato.
        }


    }
}