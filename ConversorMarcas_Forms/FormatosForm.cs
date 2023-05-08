using ConversorMarcas.Datos.Listas;
using ConversorMarcas.Modelo.Entidades;
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
            Formato obtenido = cliente.GetFormatoXNombre(cb.Text);
            if (obtenido != null) 
            {
                formatoSeleccionado = obtenido;
            }
            MostrarFormato(obtenido);
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
        private void MostrarFormato(Formato formato) 
        {
            IniciarTablaParametros();
            int row = 0;
            int cantParametros = formatoSeleccionado.GetCantParametros();
            parametrosEditados = new string[cantParametros+1][];
            
            //parametrosEditados = new string[cantParametros][];
            foreach (Parametro p in formatoSeleccionado.GetParametros()) 
            {
                row++;
                parametrosEditados[row] = new string[table_parametros.ColumnCount+1];
                //Se agrega la columna 0 para el Id del Parametro
                
                int column = 0;
                parametrosEditados[row][column] = ""+p.GetId();

                table_parametros.RowCount++;
                table_parametros.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                //Agregar HANDLERS Y FUNCIONES ASOCIADAS

                TextBox textBox_nombreParam = new TextBox() { Text=p.Nombre };
                textBox_nombreParam.TextChanged += new EventHandler(textChange_Handler);
                //lista_tuplaParametros.Add((column, NombreColumna.nombre));

                
                table_parametros.Controls.Add(textBox_nombreParam, column++, row);
                parametrosEditados[row][column] = new string("");

                NumericUpDown numericUpDown_posIniParam = new NumericUpDown() { Value = p.Posicion };
                numericUpDown_posIniParam.ValueChanged += new EventHandler(numericUpDownChenge_Handler);
                //lista_tuplaParametros.Add((column, NombreColumna.posIni));
                table_parametros.Controls.Add(numericUpDown_posIniParam, column++, row);
                parametrosEditados[row][column] = new string("");

                NumericUpDown numericUpDown_cantDigParam = new NumericUpDown() { Value = p.CantDigitos };
                numericUpDown_cantDigParam.ValueChanged += new EventHandler(numericUpDownChenge_Handler);
                //lista_tuplaParametros.Add((column, NombreColumna.cantDigitos));
                table_parametros.Controls.Add(numericUpDown_cantDigParam, column++, row);
                parametrosEditados[row][column] = new string("");

                CheckBox checkBox_esHeader = new CheckBox() { Checked = false };
                checkBox_esHeader.CheckedChanged += new EventHandler(checkBoxChange_Handler);
                //lista_tuplaParametros.Add((column, NombreColumna.cantDigitos));
                
                table_parametros.Controls.Add(checkBox_esHeader, column++, row);
                parametrosEditados[row][column] = new string("");
            }
            // La lista debe tener la misma cantidad que parametros.
            
        }

        private void numericUpDownChenge_Handler(object sender, EventArgs e) 
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            TableLayoutPanelCellPosition cellPosition =  table_parametros.GetCellPosition(numericUpDown);

            parametrosEditados[cellPosition.Row][cellPosition.Column+1] = numericUpDown.Value.ToString(); 
        }
        private void textChange_Handler(object sender, EventArgs e) 
        {
            TextBox textbox= (TextBox)sender;
            TableLayoutPanelCellPosition cellPosition = table_parametros.GetCellPosition(textbox);

            //lista_tuplaParametros[cellPosition.Row][] = (numericUpDown.Value)
            parametrosEditados[cellPosition.Row][cellPosition.Column+1] = textbox.Text;
        }
        private void checkBoxChange_Handler(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            TableLayoutPanelCellPosition cellPosition = table_parametros.GetCellPosition(checkBox);

            //lista_tuplaParametros[cellPosition.Row][] = (numericUpDown.Value)
            string valor = "false";
            if (checkBox.Checked) valor = "true";
            //parametrosEditados[cellPosition.Row][cellPosition.Column] = new string(valor);
            parametrosEditados[cellPosition.Row][cellPosition.Column+1] = valor;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //Revisar lista de parametros y guardarlos en la informacion del FORMATO.
            int r = 1;
            int rows = parametrosEditados.Length;
            int columns = parametrosEditados[r].Length;

            formatoSeleccionado.GetParametros();
            while (r < rows) 
            {
                if (parametrosEditados[r].Length > 0) 
                {
                    int c = 1;
                    while (c < parametrosEditados[r].Length) 
                    {
                        string valorModificado = parametrosEditados[r][c];
                        if (valorModificado != "")
                        {
                            //Obtener id de parametro = r;
                            bool esHeader = false;
                            if (parametrosEditados[r][3]!="")
                            {
                                string str_esHeader = parametrosEditados[r][3];
                                if (str_esHeader == "true") 
                                { 
                                   // esHeader = true;
                                }
                            }
                            else
                            {
                                CheckBox checkBox_esHeader = (CheckBox)table_parametros.GetControlFromPosition(3, r);
                               // if (checkBox_esHeader.Checked) esHeader= true;
                            }

                            Parametro paramAEditar;
                            int id = Int32.Parse(parametrosEditados[r][0]) ; 
                            if (esHeader)
                            {
                                paramAEditar = formatoSeleccionado.GetHeader().ParametroXId(id);
                            }
                            else 
                            {
                                paramAEditar = formatoSeleccionado.GetBody().ParametroXId(id);
                                //paramAEditar. = parametrosEditados[r][0];
                            }

                            if (paramAEditar != null) 
                            {
                                if (parametrosEditados[r][1] != "") paramAEditar.Nombre = parametrosEditados[r][1];
                                if (parametrosEditados[r][2] != "") paramAEditar.Posicion = Int32.Parse(parametrosEditados[r][2]);
                                if (parametrosEditados[r][3] != "") paramAEditar.CantDigitos = Int32.Parse(parametrosEditados[r][3]);
                            }
                            //valorModificado;
                        }
                        c++;
                    }
                }
                r++;
            }
        }
    }
}
