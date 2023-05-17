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
        //string[][] parametrosEditados;
        Parametro[] parametrosEditados;

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
                MostrarFormato(obtenido);
            }
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
            }
        }


        private void MostrarFormato(Formato formato) 
        {
            IniciarTablaParametros();
            int row = 0;
            int cantParametros = formatoSeleccionado.GetCantParametros();
            parametrosEditados = new Parametro[cantParametros + 1];
            //List<Formato> formatos = cliente.GetFormatos();

            foreach (Parametro p in formatoSeleccionado.GetParametros()) 
            {
                row++;
                //Se agrega la columna 0 para el Id del Parametro
                Parametro paraEdit = new Parametro(p.Nombre)
                {
                    Id = p.Id,
                    CantDigitos = p.CantDigitos,
                    Posicion = p.Posicion,
                    EsHeader = p.EsHeader
                };
                int column = 0;
                //parametrosEditados[row][column] = ""+p.Id;

                table_parametros.RowCount++;
                table_parametros.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                //Agregar HANDLERS Y FUNCIONES ASOCIADAS

                TextBox textBox_nombreParam = new TextBox() { Text=p.Nombre };
                textBox_nombreParam.TextChanged += new EventHandler(textChange_Handler);
                table_parametros.Controls.Add(textBox_nombreParam, column++, row);
                //parametrosEditados[row][column] = new string("");

                NumericUpDown numericUpDown_posIniParam = new NumericUpDown() { Value = p.Posicion };
                numericUpDown_posIniParam.ValueChanged += new EventHandler(numericUpDownPosIniChange_Handler);
                table_parametros.Controls.Add(numericUpDown_posIniParam, column++, row);
                //parametrosEditados[row][column] = new string("");

                NumericUpDown numericUpDown_cantDigParam = new NumericUpDown() { Value = p.CantDigitos };
                numericUpDown_cantDigParam.ValueChanged += new EventHandler(numericUpDownCantDigChange_Handler);
                table_parametros.Controls.Add(numericUpDown_cantDigParam, column++, row);
                //parametrosEditados[row][column] = new string("");

                CheckBox checkBox_esHeader = new CheckBox() { Checked = p.EsHeader };
                checkBox_esHeader.CheckedChanged += new EventHandler(checkBoxChange_Handler);
               
                table_parametros.Controls.Add(checkBox_esHeader, column++, row);
                //parametrosEditados[row][column] = new string("");
            }
            // La lista debe tener la misma cantidad que parametros.
            
        }

        private void editarParam(int id) 
        {
            if (parametrosEditados[id] == null)
            {
                parametrosEditados[id] = new Parametro(id);
                Parametro aEditar = formatoSeleccionado.ParamXId(id);
                parametrosEditados[id].Posicion = aEditar.Posicion;
                parametrosEditados[id].CantDigitos = aEditar.CantDigitos;
                parametrosEditados[id].Nombre = aEditar.Nombre;
                parametrosEditados[id].EsHeader = aEditar.EsHeader;
            }
        }

        private void numericUpDownCantDigChange_Handler(object sender, EventArgs e) 
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            TableLayoutPanelCellPosition cellPosition =  table_parametros.GetCellPosition(numericUpDown);
            editarParam(cellPosition.Row);
            parametrosEditados[cellPosition.Row].CantDigitos = (Int32)numericUpDown.Value; 
        }
        private void numericUpDownPosIniChange_Handler(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            TableLayoutPanelCellPosition cellPosition = table_parametros.GetCellPosition(numericUpDown);
            editarParam(cellPosition.Row);
            parametrosEditados[cellPosition.Row].Posicion = (Int32)numericUpDown.Value;
        }
        private void textChange_Handler(object sender, EventArgs e) 
        {
            TextBox textbox= (TextBox)sender;
            TableLayoutPanelCellPosition cellPosition = table_parametros.GetCellPosition(textbox);
            editarParam(cellPosition.Row);
            parametrosEditados[cellPosition.Row].Nombre = textbox.Text;
        }
        private void checkBoxChange_Handler(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            TableLayoutPanelCellPosition cellPosition = table_parametros.GetCellPosition(checkBox);
            editarParam(cellPosition.Row);
            parametrosEditados[cellPosition.Row].EsHeader = checkBox.Checked;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //Revisar lista de parametros y guardarlos en la informacion del FORMATO.
            formatoSeleccionado.GetParametros();
            RepoFormatos.GetInstancia().EditarFormato(formatoSeleccionado, parametrosEditados);
            cliente.EditarFormato(formatoSeleccionado);
            MessageBox mb = new MessageBox("OK", "Los cambios se guardaron con éxito.");
            mb.ShowDialog();

        }
    }
}
