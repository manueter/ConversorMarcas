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
    public partial class MessageBox : Form
    {
        public MessageBox(string titulo, string mensaje)
        {
            InitializeComponent();
            if (titulo == "ERROR") { label_titulo_MessageBox.ForeColor = Color.Red; }
            else if(titulo == "OK") { label_titulo_MessageBox.ForeColor = Color.GreenYellow; }
            label_MessageBox.Text = mensaje;
            label_titulo_MessageBox.Text=titulo;
            this.Text = titulo;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
