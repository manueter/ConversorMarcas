﻿using ConversorMarcas.Modelo.Entidades;
using ConversorMarcas.Datos.Listas;
using ConversorMarcas.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorMarcas_Forms
{
    public partial class Inicio : Form
    {
        Sesion sesion;

        string nombreArchivoOut;
        string nombreArchivoIn;
        string folderIN;
        string folderOUT;

        Formato formatoIn;
        Formato formatoOut;
        // Si es true, se prepara para buscar un solo archivo, 
        // Si es false, busca varios archuvos en una carpeta.
        bool unSoloArchivo = true;

        // Si es true, se prepara para buscar marcas en archivos en vez de convertir
        bool buscarMarcas = false;

        int filtro_nroFunc=0;
        DateTime filtro_fechaIni;
        DateTime filtro_fechaFin;

        public Inicio(Sesion sesion)
        {
            this.sesion = sesion;
            InitializeComponent();
            CargarClientes();
            panel_filtrosBuscar.Enabled = false;
            panel_filtrosBuscar.Visible = false;
            chkBox_BuscarMarcas.Enabled = true;


            SendMessage(this.clientes_comboBox.Handle, CB_SETCUEBANNER, 0, "Elegir cliente...");
            //lbl_tituloPrograma.Select();

        }
        public void CargarClientes()
        {
            List<Cliente> clientes = RepoClientes.GetInstancia().GetClientes;
            clientes_comboBox.Items.Clear();
            //clientes_comboBox.Items.Insert(0, "Elegir cliente...");
            foreach (Cliente c in clientes)
            {
                clientes_comboBox.Items.Add(c.Nombre);
            }
        }

        void CargarFormatos()
        {

            List<Formato> formatos = sesion.GetCliente().GetFormatos();
            comboBox_formatoIN.Items.Clear();
            comboBox_formatoOUT.Items.Clear();
            foreach (Formato f in formatos)
            {
                RepoFormatos.GetInstancia().Alta(f);
                comboBox_formatoIN.Items.Add(f.Nombre);
                comboBox_formatoOUT.Items.Add(f.Nombre);
            }
        }

        private void clientes_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            Cliente cliente = RepoClientes.GetInstancia().BuscarXNombre(cmb.Text);
            sesion.SetCliente(cliente);
            CargarFormatos();
            btn_ir_Formatos.Enabled = true;
            btn_ir_Formatos.ForeColor = SystemColors.ActiveCaption;
        }
        private void clientes_comboBox_DoubleClicked(object sender, EventArgs e)
        {
            clientes_comboBox.Visible = false;
        }
        private void btn_selectCliente_Click(object sender, EventArgs e)
        {
            clientes_comboBox.Visible = true;
            List<Formato> formatosCliente = sesion.GetCliente().GetFormatos();
        }

        private void formatoIN_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            formatoIn = RepoFormatos.GetInstancia().BuscarXNombre(cmb.Text);
        }
        private void formatoOUT_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            formatoOut = RepoFormatos.GetInstancia().BuscarXNombre(cmb.Text);
        }

        private void txt_ArchivoIN_Clicked(object sender, EventArgs e)
        {
            if (txt_archivoIN.Text == "")
            {
                txt_ArchivoIN_DoubleClicked(sender, e);
            }
        }
        private void txt_ArchivoIN_DoubleClicked(object sender, EventArgs e)
        {
            //openFileDialog_entrada.ShowDialog = "Elegir carpeta de origen...";
            //openFileDialog_entrada.RootFolder = Environment.SpecialFolder.Desktop;
            //openFileDialog_entrada.SelectedPath = selectPath_origenXDefecto;
            if (openFileDialog_IN.ShowDialog() == DialogResult.OK)
            {
                txt_archivoIN_TextChanged(sender, e);
            }
        }
        private void txt_archivoIN_TextChanged(object sender, EventArgs e)
        {
            txt_archivoIN.Text = openFileDialog_IN.FileName;
            nombreArchivoIn = txt_archivoIN.Text;
        }
        private void txt_folderIN_Clicked(object sender, EventArgs e)
        {
            if (txt_folderIN.Text == "")
            {
                txt_folderIN_DoubleClicked(sender, e);
            }
        }
        private void txt_folderIN_DoubleClicked(object sender, EventArgs e)
        {
            folderDialog_IN.RootFolder = Environment.SpecialFolder.Desktop;
            //folderDialog_IN.SelectedPath = selectPath_origenXDefecto;
            if (folderDialog_IN.ShowDialog() == DialogResult.OK)
            {
                txt_folderIN_TextChanged(sender, e);
            }
        }
        private void txt_folderIN_TextChanged(object sender, EventArgs e)
        {
            txt_folderIN.Text = folderDialog_IN.SelectedPath;
            folderIN = txt_folderIN.Text;
        }

        private void txt_archivoOUT_Entered(object sender, EventArgs e)
        {
            txt_archivoOUT.ForeColor = SystemColors.MenuHighlight;
            nombreArchivoOut = txt_archivoOUT.Text;
        }
        private void txt_folderOUT_DoubleClicked(object sender, EventArgs e)
        {
            folderDialog_OUT.RootFolder = Environment.SpecialFolder.Desktop;

            if (folderDialog_OUT.ShowDialog() == DialogResult.OK)
            {
                txt_folderOUT_TextChanged(sender, e);
            }
        }
        private void txt_folderOUT_TextChanged(object sender, EventArgs e)
        {
            txt_folderOUT.Text = folderDialog_OUT.SelectedPath;
            folderOUT = txt_folderOUT.Text;
        }
        private void btn_ConvertirMarcas_Click(object sender, EventArgs e)
        {
            string msgOut = "";
            MessageBox messageBox;
            btn_ConvertirMarcas.ForeColor = Color.Yellow;
            if (sesion != null)
            {
                if (sesion.GetCliente() != null)
                {
                    Procesos procesos = new Procesos(sesion);
                    if (nombreArchivoOut != "" && nombreArchivoOut != null &&
                       ((nombreArchivoIn != "" && nombreArchivoIn != null) || (folderIN != "" && folderIN != null)) &&
                            folderOUT != "" && folderOUT!=null
                       )
                    {
                        if (unSoloArchivo && nombreArchivoIn != null)
                        {
                            FileInfo fileIN = new FileInfo(nombreArchivoIn);
                            if (!buscarMarcas)
                            {
                                msgOut = procesos.TransformarMarcas_UnArchivo(fileIN, nombreArchivoOut, folderOUT, formatoIn, formatoOut);
                            }
                            else
                            {

                                bool filtraDateFin = this.chkBox_filtroDateFin.Checked;
                                bool filtraDateIni = this.chkBox_filtroDateIni.Checked;
                                bool filtraNroFunc = this.chkBox_filtroNroTarjeta.Checked;

                                msgOut = procesos.BuscarMarcas
                                    (fileIN,
                                    nombreArchivoOut, folderOUT,
                                    formatoIn, formatoOut,
                                    filtraNroFunc, filtro_nroFunc,
                                    filtraDateIni, filtro_fechaIni,
                                    filtraDateFin, filtro_fechaFin);
                            }
                        }
                        else
                        {
                            if (!buscarMarcas)
                            {
                                msgOut = procesos.TransformarMarcas_VariosArchivos(folderIN, nombreArchivoOut, folderOUT, formatoIn, formatoOut);
                            }

                        }

                        if (msgOut != null)
                        {
                            if (msgOut != "OK")
                            {
                                messageBox = new MessageBox("ERROR", msgOut);
                            }
                            else
                            {
                                messageBox = new MessageBox("EXITO", "Se convirtieron las marcas.");

                            }
                            messageBox.ShowDialog();
                        }
                    }
                    else
                    {
                        if (nombreArchivoIn == "" || folderIN == "")
                        {
                            msgOut += "Seleccionar carpeta o archivo inicial. \n";
                        }
                    }

                    if (folderOUT == "" || folderOUT == null) { msgOut += "Seleccionar carpeta de salida. \n"; }
                    if (nombreArchivoOut == "" || nombreArchivoOut == null) { msgOut += "Seleccionar archivo salida. \n"; }
                    messageBox = new MessageBox("ERROR", msgOut);
                    messageBox.ShowDialog();
                }
                else
                {
                    if (folderIN == null || folderIN == "") { msgOut += "Debe seleccionar un cliente. \n"; }
                    messageBox = new MessageBox("ERROR", msgOut);
                    messageBox.ShowDialog();
                }
            }
            btn_ConvertirMarcas.ForeColor = Color.White;
        }

        private void radioBtn_archivoIN_CheckedChanged(object sender, EventArgs e)
        {
            if (!unSoloArchivo) unSoloArchivo = true;
            txt_folderIN.Enabled = false;
            txt_folderIN.BackColor = Color.MidnightBlue;
            txt_archivoIN.Enabled = true;
            txt_archivoIN.BackColor = Color.LightBlue;
        }

        private void radioBtn_folderIN_CheckedChanged(object sender, EventArgs e)
        {
            if (unSoloArchivo) unSoloArchivo = false;
            txt_archivoIN.Enabled = false;
            txt_archivoIN.BackColor = Color.MidnightBlue;
            txt_folderIN.Enabled = true;
            txt_folderIN.BackColor = Color.LightBlue;
        }

        private void chkBox_BuscarMarcas_CheckedChanged(object sender, EventArgs e)
        {
            if (buscarMarcas)
            {
                //buscarMarcas = false;
                btn_ConvertirMarcas.Text = "Convertir Marcas";;
                ocultarFiltrosParaBuscarMarcas();
            }
            else
            {
                //buscarMarcas = true;  
                btn_ConvertirMarcas.Text = "Buscar Marcas";
                mostrarFiltrosParaBuscarMarcas();
            }
            buscarMarcas = !buscarMarcas;
        }

        void mostrarFiltrosParaBuscarMarcas()
        {
            panel_filtrosBuscar.Size = new Size(465, 100);
            panel_filtrosBuscar.Visible = true;
            panel_filtrosBuscar.Enabled = true;
            panel_filtrosBuscar.Controls.Add(this.tableFiltros);
            this.tableLayoutPanel_main.Controls.Add(this.panel_filtrosBuscar, 1, 2);
        }
        void ocultarFiltrosParaBuscarMarcas()
        {
            panel_filtrosBuscar.Size = new Size(0, 0);
            panel_filtrosBuscar.Visible = false;
            tableLayoutPanel_main.Controls.Remove(panel_filtrosBuscar);
        }
        private void filtro_NroTarjeta_Changed(object sender, EventArgs e)
        {
            if (chkBox_filtroNroTarjeta.Checked)
            {
                TextBox textBox = (TextBox)sender;
                if (Int32.TryParse(textBox.Text, out int r)) 
                {
                    filtro_nroFunc = r;
                }
            }
        }
        private void filtro_DateInicial_Changed(object sender, EventArgs e)
        {
            if (chkBox_filtroDateIni.Checked) 
            {
                DateTimePicker dateTime = (DateTimePicker)sender;
                filtro_fechaIni = dateTime.Value;
            }
        }
        private void filtro_DateFinal_Changed(object sender, EventArgs e)
        {
            if (chkBox_filtroDateFin.Checked)
            {
                DateTimePicker dateTime = (DateTimePicker)sender;
                filtro_fechaFin = dateTime.Value;
            }
        }

        private void btn_ir_Clientes_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm(sesion);
            if (clientesForm.ShowDialog()==DialogResult.OK) 
            {
                MessageBox msg = new MessageBox("OK","OK");
                CargarClientes();
                comboBox_formatoIN.Items.Clear();
                comboBox_formatoOUT.Items.Clear();
            }
        }

        private void btn_ir_Formatos_Click(object sender, EventArgs e)
        {
            FormatosForm formatosForm = new FormatosForm(sesion.GetCliente());
            formatosForm.ShowDialog();
        }
    }
}
