﻿using ConversorMarcas.Modelo.Entidades;
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
    public partial class FormatosForm : Form
    {
        Cliente cliente;
        Formato formatoSeleccionado;

        
        (int, NombreColumna)[] lista_tuplaParametros;
        string[][] parametrosEditados;

        public FormatosForm(Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
            CargarFormatos();
        }
        void CargarFormatos() 
        {
            foreach (Formato f in cliente.GetFormatos())
            {
                comboBox_formatos.Items.Add(f.Nombre);  
            }
            this.lbl_cliente.Text = cliente.Nombre;
        }
        enum NombreColumna
        {
            nombre, posIni, cantDigitos, esHeader
        }
        private void comboBox_formatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            Formato obtenido = cliente.ObtenerFormatoXNombre(cb.Text);
            if (obtenido != null) 
            {
                formatoSeleccionado = obtenido;
            }
            MostrarFormato();
        }
        private void IniciarTablaParametros() 
        {
            //Se limpia formatos
            if (table_parametros.RowCount > 1)
            {
                int i = table_parametros.RowCount;
                while (i >= 0)
                {
                    int ii = table_parametros.ColumnCount;
                    while (ii >= 0)
                    {

                        Control aBorrar = table_parametros.GetControlFromPosition(ii, i);
                        if (aBorrar != null)
                        {
                            table_parametros.Controls.Remove(aBorrar);
                        }
                        ii--;
                    }
                    i--;
                }
                this.table_parametros.Controls.Add(this.lbl_esHeader, 3, 0);
                this.table_parametros.Controls.Add(this.lbl_cantDigitos, 2, 0);
                this.table_parametros.Controls.Add(this.lbl_posicion, 1, 0);
                this.table_parametros.Controls.Add(this.lbl_nombreParam, 0, 0);
                //IniciarTablaParametros();
            }
        }
        private void MostrarFormato() 
        {
            IniciarTablaParametros();
            int row = 0;
            
            int cantParametros = formatoSeleccionado.GetCantParametros();
            parametrosEditados = new string[cantParametros][];
            //parametrosEditados = new string[cantParametros][];
            foreach (Parametro p in formatoSeleccionado.GetParametros()) 
            {
                row++;
                int column = 0;
                table_parametros.RowCount++;
                table_parametros.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                
                //Agregar HANDLERS Y FUNCIONES ASOCIADAS

                TextBox textBox_nombreParam = new TextBox() { Text=p.Nombre };
                textBox_nombreParam.TextChanged += new EventHandler(textChange_Handler);
                //lista_tuplaParametros.Add((column, NombreColumna.nombre));
                table_parametros.Controls.Add(textBox_nombreParam, column++, row);
                

                NumericUpDown numericUpDown_posIniParam = new NumericUpDown() { Value = p.Posicion };
                numericUpDown_posIniParam.ValueChanged += new EventHandler(numericUpDownChenge_Handler);
                //lista_tuplaParametros.Add((column, NombreColumna.posIni));
                table_parametros.Controls.Add(numericUpDown_posIniParam, column++, row);
                
                
                NumericUpDown numericUpDown_cantDigParam = new NumericUpDown() { Value = p.CantDigitos };
                numericUpDown_cantDigParam.ValueChanged += new EventHandler(numericUpDownChenge_Handler);
                //lista_tuplaParametros.Add((column, NombreColumna.cantDigitos));
                table_parametros.Controls.Add(numericUpDown_cantDigParam, column++, row);
                parametrosEditados[row] = new string[column+1];
            }
            // La lista debe tener la misma cantidad que parametros.
            
        }

        private void numericUpDownChenge_Handler(object sender, EventArgs e) 
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            TableLayoutPanelCellPosition cellPosition =  table_parametros.GetCellPosition(numericUpDown);

            //lista_tuplaParametros[cellPosition.Row][] = (numericUpDown.Value)
            parametrosEditados[cellPosition.Row][cellPosition.Column] = numericUpDown.Value.ToString(); 
        }
        private void textChange_Handler(object sender, EventArgs e) 
        {
            TextBox textbox= (TextBox)sender;
            TableLayoutPanelCellPosition cellPosition = table_parametros.GetCellPosition(textbox);

            //lista_tuplaParametros[cellPosition.Row][] = (numericUpDown.Value)
            parametrosEditados[cellPosition.Row][cellPosition.Column] = textbox.Text;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //Revisar lista de parametros y guardarlos en la informacion del FORMATO.
            int rows = parametrosEditados.Length;
            int columns = parametrosEditados[0].Length;

            int r = 0;
            while (r < rows) 
            {
                if (parametrosEditados[r].Length > 0) 
                {
                    int c = 0;
                    while (c < parametrosEditados[r].Length) 
                    {
                        string valorModificado = parametrosEditados[r][c];
                    }
                }
                
            }
        }
    }
}