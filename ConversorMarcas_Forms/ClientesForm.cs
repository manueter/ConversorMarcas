using ConversorMarcas.Datos.Listas;
using ConversorMarcas.Modelo.Entidades;
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
    public partial class ClientesForm : Form
    {
        Sesion sesion;
        public ClientesForm(Sesion sesion)
        {
            this.sesion = sesion;
            InitializeComponent();
            CargarClientes();
        }
        Button btnAgregarCliente;
        Button btnConfirmar;
        public void CargarClientes() 
        {
            // Add: CONTROL / COLUMN / ROW

            List<Cliente> clientes = RepoClientes.GetInstancia().GetClientes;
            table_clientes.Controls.Clear();
            int row = -1;
            int cantRow = clientes.Count;
            table_clientes.RowCount = cantRow + 1;

            //COLUMNAS
            table_clientes.ColumnCount = 3;
            table_clientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            table_clientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            table_clientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));


            //table_clientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 00F));
            //table_clientes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            foreach (Cliente c in clientes)
            {
                int column = -1;
                ++row;
                table_clientes.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
                Label lblID = new Label() { Text = "Id", TextAlign = ContentAlignment.MiddleCenter, AutoSize = true};
               
                lblID.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                table_clientes.Controls.Add(lblID, ++column, row);

                Button lblNombre = new Button() { Text = c.Nombre, TextAlign = ContentAlignment.MiddleCenter, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
                lblNombre.Anchor = (AnchorStyles.Top  | AnchorStyles.Left | AnchorStyles.Right);
                table_clientes.Controls.Add(lblNombre, ++column, row);

                Button btn_eliminarCliente = new Button() { Text = "Eliminar", Name = c.Nombre, TextAlign = ContentAlignment.MiddleCenter , AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
                btn_eliminarCliente.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                btn_eliminarCliente.Click += btn_eliminarCliente_Click;
                table_clientes.Controls.Add(btn_eliminarCliente, ++column, row); 
            }
            crear_btnAgregarCliente(++row);
            crear_btnConfirmar(++row);
        }

        private void btn_eliminarCliente_Click(object sender, EventArgs e)
        {
            Button btn_eliminarCliente = (Button)sender;
            MessageBox messageBox = new MessageBox("CONFIRMAR", "Estas seguro de eliminar " + btn_eliminarCliente.Name);
            if (messageBox.ShowDialog()==DialogResult.OK) 
            {
                Cliente c = null;
                if (btn_eliminarCliente.Name!= null) 
                { c = RepoClientes.GetInstancia().BuscarXNombre(btn_eliminarCliente.Name); }
                
                if (c != null) 
                { RepoClientes.GetInstancia().Baja(c); CargarClientes(); }
                
            }
        }

        public void btn_eliminarCliente_Clicked(object sender, EventArgs e) 
        { 
        }
        public void crear_btnAgregarCliente(int row)
        {
            if (btnAgregarCliente != null) { btnAgregarCliente.Dispose(); }
            
            table_clientes.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            btnAgregarCliente = new Button() { Text = "Agregar nuevo", Name = "btn_addCliente2",BackColor=Color.White,TextAlign = ContentAlignment.MiddleCenter, AutoSize = true,AutoSizeMode = AutoSizeMode.GrowAndShrink };
            btnAgregarCliente.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            btnAgregarCliente.Click += new EventHandler(btn_agregarCliente_Click);
            table_clientes.Controls.Add(btnAgregarCliente, 1, row);
        }
        public void crear_btnConfirmar(int row) 
        {
            if (btnConfirmar!=null) { btnConfirmar.Dispose(); }
            table_clientes.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            btnConfirmar = new Button() { Text = "Confirmar", Name = "btn_confirmar", BackColor = Color.Bisque, TextAlign = ContentAlignment.MiddleCenter, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            btnConfirmar.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            btnConfirmar.Click += new EventHandler(btn_confirmarCliente_Click);
            table_clientes.Controls.Add(btnConfirmar, 2, row);

            this.DialogResult = DialogResult.OK;
        }

        public void btn_agregarCliente_Click(object sender, EventArgs e) 
        {
            btnAgregarCliente.Dispose();
            btnConfirmar.Dispose();

            table_clientes.RowCount++;
            table_clientes.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            TextBox txtBoxNuevo = new TextBox() { TextAlign = HorizontalAlignment.Center };
            
            txtBoxNuevo.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            table_clientes.Controls.Add(txtBoxNuevo, 1, table_clientes.RowCount - 2);

            crear_btnAgregarCliente(table_clientes.RowCount - 1);
            crear_btnConfirmar(table_clientes.RowCount - 1);
        }
        public void btn_confirmarCliente_Click(object sender, EventArgs e) 
        {
            this.Dispose(true);
        }
    }
}
