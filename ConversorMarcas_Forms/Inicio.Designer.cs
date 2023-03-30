namespace ConversorMarcas_Forms
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        private void InitializeComponent()
        {
            this.clientes_comboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog_IN = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.folderDialog_IN = new System.Windows.Forms.FolderBrowserDialog();
            this.folderDialog_OUT = new System.Windows.Forms.FolderBrowserDialog();
            this.panelEntrada = new System.Windows.Forms.Panel();
            this.radioBtn_folderIN = new System.Windows.Forms.RadioButton();
            this.radioBtn_archivoIN = new System.Windows.Forms.RadioButton();
            this.txt_folderIN = new System.Windows.Forms.TextBox();
            this.txt_archivoIN = new System.Windows.Forms.TextBox();
            this.lbl_formatoIN = new System.Windows.Forms.Label();
            this.comboBox_formatoIN = new System.Windows.Forms.ComboBox();
            this.panel_salida = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_folderOUT = new System.Windows.Forms.TextBox();
            this.txt_archivoOUT = new System.Windows.Forms.TextBox();
            this.comboBox_formatoOUT = new System.Windows.Forms.ComboBox();
            this.lbl_formatoOUT = new System.Windows.Forms.Label();
            this.btn_ir_Clientes = new System.Windows.Forms.Button();
            this.btn_ir_Formatos = new System.Windows.Forms.Button();
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ConvertirMarcas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_CheckBuscarMarcas = new System.Windows.Forms.Panel();
            this.chkBox_BuscarMarcas = new System.Windows.Forms.CheckBox();
            this.panel_filtrosBuscar = new System.Windows.Forms.Panel();
            this.tableFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelEntrada.SuspendLayout();
            this.panel_salida.SuspendLayout();
            this.tableLayoutPanel_main.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_CheckBuscarMarcas.SuspendLayout();
            this.tableFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientes_comboBox
            // 
            this.clientes_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clientes_comboBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.clientes_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientes_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clientes_comboBox.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientes_comboBox.FormattingEnabled = true;
            this.clientes_comboBox.Location = new System.Drawing.Point(3, 30);
            this.clientes_comboBox.Name = "clientes_comboBox";
            this.clientes_comboBox.Size = new System.Drawing.Size(176, 26);
            this.clientes_comboBox.TabIndex = 1;
            this.clientes_comboBox.SelectedIndexChanged += new System.EventHandler(this.clientes_comboBox_SelectedIndexChanged);
            this.clientes_comboBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.clientes_comboBox_DoubleClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 4);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 350);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(950, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 350);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumPurple;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(954, 4);
            this.panel4.TabIndex = 12;
            // 
            // panelEntrada
            // 
            this.panelEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEntrada.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEntrada.Controls.Add(this.radioBtn_folderIN);
            this.panelEntrada.Controls.Add(this.radioBtn_archivoIN);
            this.panelEntrada.Controls.Add(this.txt_folderIN);
            this.panelEntrada.Controls.Add(this.txt_archivoIN);
            this.panelEntrada.Controls.Add(this.lbl_formatoIN);
            this.panelEntrada.Controls.Add(this.comboBox_formatoIN);
            this.panelEntrada.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelEntrada.Location = new System.Drawing.Point(3, 79);
            this.panelEntrada.Name = "panelEntrada";
            this.panelEntrada.Size = new System.Drawing.Size(465, 219);
            this.panelEntrada.TabIndex = 7;
            // 
            // radioBtn_folderIN
            // 
            this.radioBtn_folderIN.AutoSize = true;
            this.radioBtn_folderIN.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtn_folderIN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioBtn_folderIN.Location = new System.Drawing.Point(30, 158);
            this.radioBtn_folderIN.Name = "radioBtn_folderIN";
            this.radioBtn_folderIN.Size = new System.Drawing.Size(162, 24);
            this.radioBtn_folderIN.TabIndex = 7;
            this.radioBtn_folderIN.TabStop = true;
            this.radioBtn_folderIN.Text = "Carpeta Entrada";
            this.radioBtn_folderIN.UseVisualStyleBackColor = true;
            this.radioBtn_folderIN.CheckedChanged += new System.EventHandler(this.radioBtn_folderIN_CheckedChanged);
            // 
            // radioBtn_archivoIN
            // 
            this.radioBtn_archivoIN.AutoSize = true;
            this.radioBtn_archivoIN.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtn_archivoIN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioBtn_archivoIN.Location = new System.Drawing.Point(31, 110);
            this.radioBtn_archivoIN.Name = "radioBtn_archivoIN";
            this.radioBtn_archivoIN.Size = new System.Drawing.Size(162, 24);
            this.radioBtn_archivoIN.TabIndex = 6;
            this.radioBtn_archivoIN.TabStop = true;
            this.radioBtn_archivoIN.Text = "Archivo Entrada\r\n";
            this.radioBtn_archivoIN.UseVisualStyleBackColor = true;
            this.radioBtn_archivoIN.CheckedChanged += new System.EventHandler(this.radioBtn_archivoIN_CheckedChanged);
            // 
            // txt_folderIN
            // 
            this.txt_folderIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_folderIN.BackColor = System.Drawing.Color.MidnightBlue;
            this.txt_folderIN.Enabled = false;
            this.txt_folderIN.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_folderIN.Location = new System.Drawing.Point(230, 159);
            this.txt_folderIN.Name = "txt_folderIN";
            this.txt_folderIN.Size = new System.Drawing.Size(198, 23);
            this.txt_folderIN.TabIndex = 5;
            this.txt_folderIN.Click += new System.EventHandler(this.txt_folderIN_Clicked);
            this.txt_folderIN.TextChanged += new System.EventHandler(this.txt_folderIN_TextChanged);
            this.txt_folderIN.DoubleClick += new System.EventHandler(this.txt_folderIN_DoubleClicked);
            // 
            // txt_archivoIN
            // 
            this.txt_archivoIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_archivoIN.BackColor = System.Drawing.Color.MidnightBlue;
            this.txt_archivoIN.Enabled = false;
            this.txt_archivoIN.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_archivoIN.Location = new System.Drawing.Point(230, 111);
            this.txt_archivoIN.Name = "txt_archivoIN";
            this.txt_archivoIN.Size = new System.Drawing.Size(198, 23);
            this.txt_archivoIN.TabIndex = 4;
            this.txt_archivoIN.Click += new System.EventHandler(this.txt_ArchivoIN_Clicked);
            this.txt_archivoIN.TextChanged += new System.EventHandler(this.txt_archivoIN_TextChanged);
            this.txt_archivoIN.DoubleClick += new System.EventHandler(this.txt_ArchivoIN_DoubleClicked);
            // 
            // lbl_formatoIN
            // 
            this.lbl_formatoIN.AutoSize = true;
            this.lbl_formatoIN.Font = new System.Drawing.Font("Ubuntu Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_formatoIN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_formatoIN.Location = new System.Drawing.Point(19, 36);
            this.lbl_formatoIN.Name = "lbl_formatoIN";
            this.lbl_formatoIN.Size = new System.Drawing.Size(192, 25);
            this.lbl_formatoIN.TabIndex = 2;
            this.lbl_formatoIN.Text = "Formato Entrada";
            // 
            // comboBox_formatoIN
            // 
            this.comboBox_formatoIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_formatoIN.BackColor = System.Drawing.Color.LightBlue;
            this.comboBox_formatoIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_formatoIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_formatoIN.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_formatoIN.FormattingEnabled = true;
            this.comboBox_formatoIN.Location = new System.Drawing.Point(230, 33);
            this.comboBox_formatoIN.Name = "comboBox_formatoIN";
            this.comboBox_formatoIN.Size = new System.Drawing.Size(83, 28);
            this.comboBox_formatoIN.TabIndex = 3;
            // 
            // panel_salida
            // 
            this.panel_salida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_salida.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_salida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_salida.Controls.Add(this.label2);
            this.panel_salida.Controls.Add(this.label1);
            this.panel_salida.Controls.Add(this.txt_folderOUT);
            this.panel_salida.Controls.Add(this.txt_archivoOUT);
            this.panel_salida.Controls.Add(this.comboBox_formatoOUT);
            this.panel_salida.Controls.Add(this.lbl_formatoOUT);
            this.panel_salida.Location = new System.Drawing.Point(474, 79);
            this.panel_salida.Name = "panel_salida";
            this.panel_salida.Size = new System.Drawing.Size(465, 219);
            this.panel_salida.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(85, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Carpeta Salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(24, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre Archivo Salida";
            // 
            // txt_folderOUT
            // 
            this.txt_folderOUT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_folderOUT.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_folderOUT.Location = new System.Drawing.Point(241, 159);
            this.txt_folderOUT.Name = "txt_folderOUT";
            this.txt_folderOUT.Size = new System.Drawing.Size(197, 23);
            this.txt_folderOUT.TabIndex = 7;
            this.txt_folderOUT.Click += new System.EventHandler(this.txt_folderOUT_DoubleClicked);
            this.txt_folderOUT.TextChanged += new System.EventHandler(this.txt_folderOUT_TextChanged);
            this.txt_folderOUT.DoubleClick += new System.EventHandler(this.txt_folderOUT_DoubleClicked);
            // 
            // txt_archivoOUT
            // 
            this.txt_archivoOUT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_archivoOUT.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_archivoOUT.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_archivoOUT.Location = new System.Drawing.Point(241, 113);
            this.txt_archivoOUT.Name = "txt_archivoOUT";
            this.txt_archivoOUT.Size = new System.Drawing.Size(197, 23);
            this.txt_archivoOUT.TabIndex = 6;
            this.txt_archivoOUT.Text = "archivo.out";
            this.txt_archivoOUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_archivoOUT.TextChanged += new System.EventHandler(this.txt_archivoOUT_Entered);
            this.txt_archivoOUT.Enter += new System.EventHandler(this.txt_archivoOUT_Entered);
            // 
            // comboBox_formatoOUT
            // 
            this.comboBox_formatoOUT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_formatoOUT.BackColor = System.Drawing.Color.PaleTurquoise;
            this.comboBox_formatoOUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_formatoOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_formatoOUT.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_formatoOUT.FormattingEnabled = true;
            this.comboBox_formatoOUT.Location = new System.Drawing.Point(241, 33);
            this.comboBox_formatoOUT.Name = "comboBox_formatoOUT";
            this.comboBox_formatoOUT.Size = new System.Drawing.Size(83, 28);
            this.comboBox_formatoOUT.TabIndex = 5;
            // 
            // lbl_formatoOUT
            // 
            this.lbl_formatoOUT.AutoSize = true;
            this.lbl_formatoOUT.Font = new System.Drawing.Font("Ubuntu Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_formatoOUT.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_formatoOUT.Location = new System.Drawing.Point(24, 36);
            this.lbl_formatoOUT.Name = "lbl_formatoOUT";
            this.lbl_formatoOUT.Size = new System.Drawing.Size(180, 25);
            this.lbl_formatoOUT.TabIndex = 4;
            this.lbl_formatoOUT.Text = "Formato Salida";
            // 
            // btn_ir_Clientes
            // 
            this.btn_ir_Clientes.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_ir_Clientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ir_Clientes.FlatAppearance.BorderSize = 10;
            this.btn_ir_Clientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_ir_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ir_Clientes.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ir_Clientes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ir_Clientes.Location = new System.Drawing.Point(185, 13);
            this.btn_ir_Clientes.Name = "btn_ir_Clientes";
            this.btn_ir_Clientes.Size = new System.Drawing.Size(131, 61);
            this.btn_ir_Clientes.TabIndex = 14;
            this.btn_ir_Clientes.Text = "Gestion Clientes";
            this.btn_ir_Clientes.UseVisualStyleBackColor = false;
            this.btn_ir_Clientes.Click += new System.EventHandler(this.btn_ir_Clientes_Click);
            // 
            // btn_ir_Formatos
            // 
            this.btn_ir_Formatos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_ir_Formatos.Enabled = false;
            this.btn_ir_Formatos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ir_Formatos.FlatAppearance.BorderSize = 10;
            this.btn_ir_Formatos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_ir_Formatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ir_Formatos.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ir_Formatos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_ir_Formatos.Location = new System.Drawing.Point(322, 13);
            this.btn_ir_Formatos.Name = "btn_ir_Formatos";
            this.btn_ir_Formatos.Size = new System.Drawing.Size(133, 61);
            this.btn_ir_Formatos.TabIndex = 15;
            this.btn_ir_Formatos.Text = "Gestion Formatos";
            this.btn_ir_Formatos.UseVisualStyleBackColor = false;
            this.btn_ir_Formatos.Click += new System.EventHandler(this.btn_ir_Formatos_Click);
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_main.AutoSize = true;
            this.tableLayoutPanel_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_main.ColumnCount = 2;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_main.Controls.Add(this.panel_salida, 1, 1);
            this.tableLayoutPanel_main.Controls.Add(this.btn_ConvertirMarcas, 1, 2);
            this.tableLayoutPanel_main.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel_main.Controls.Add(this.panel_CheckBuscarMarcas, 0, 2);
            this.tableLayoutPanel_main.Controls.Add(this.panelEntrada, 0, 1);
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(8, 4);
            this.tableLayoutPanel_main.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 3;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(942, 346);
            this.tableLayoutPanel_main.TabIndex = 16;
            // 
            // btn_ConvertirMarcas
            // 
            this.btn_ConvertirMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ConvertirMarcas.AutoSize = true;
            this.btn_ConvertirMarcas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ConvertirMarcas.BackColor = System.Drawing.Color.Indigo;
            this.btn_ConvertirMarcas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ConvertirMarcas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ConvertirMarcas.FlatAppearance.BorderSize = 10;
            this.btn_ConvertirMarcas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_ConvertirMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_ConvertirMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ConvertirMarcas.Font = new System.Drawing.Font("Ubuntu Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ConvertirMarcas.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_ConvertirMarcas.Location = new System.Drawing.Point(474, 304);
            this.btn_ConvertirMarcas.Name = "btn_ConvertirMarcas";
            this.btn_ConvertirMarcas.Size = new System.Drawing.Size(465, 39);
            this.btn_ConvertirMarcas.TabIndex = 0;
            this.btn_ConvertirMarcas.Text = "Convertir Marcas";
            this.btn_ConvertirMarcas.UseVisualStyleBackColor = false;
            this.btn_ConvertirMarcas.Click += new System.EventHandler(this.btn_ConvertirMarcas_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.clientes_comboBox);
            this.panel5.Controls.Add(this.btn_ir_Clientes);
            this.panel5.Controls.Add(this.btn_ir_Formatos);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(463, 70);
            this.panel5.TabIndex = 17;
            // 
            // panel_CheckBuscarMarcas
            // 
            this.panel_CheckBuscarMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_CheckBuscarMarcas.AutoSize = true;
            this.panel_CheckBuscarMarcas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_CheckBuscarMarcas.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_CheckBuscarMarcas.Controls.Add(this.chkBox_BuscarMarcas);
            this.panel_CheckBuscarMarcas.Location = new System.Drawing.Point(3, 304);
            this.panel_CheckBuscarMarcas.Name = "panel_CheckBuscarMarcas";
            this.panel_CheckBuscarMarcas.Size = new System.Drawing.Size(465, 39);
            this.panel_CheckBuscarMarcas.TabIndex = 6;
            // 
            // chkBox_BuscarMarcas
            // 
            this.chkBox_BuscarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBox_BuscarMarcas.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBox_BuscarMarcas.Location = new System.Drawing.Point(15, 11);
            this.chkBox_BuscarMarcas.Name = "chkBox_BuscarMarcas";
            this.chkBox_BuscarMarcas.Size = new System.Drawing.Size(145, 24);
            this.chkBox_BuscarMarcas.TabIndex = 9;
            this.chkBox_BuscarMarcas.Text = "Buscar Marcas";
            this.chkBox_BuscarMarcas.UseVisualStyleBackColor = true;
            this.chkBox_BuscarMarcas.CheckedChanged += new System.EventHandler(this.chkBox_BuscarMarcas_CheckedChanged);
            // 
            // panel_filtrosBuscar
            // 
            this.panel_filtrosBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_filtrosBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_filtrosBuscar.Location = new System.Drawing.Point(3, 353);
            this.panel_filtrosBuscar.Name = "panel_filtrosBuscar";
            this.panel_filtrosBuscar.Size = new System.Drawing.Size(0, 0);
            this.panel_filtrosBuscar.TabIndex = 18;
            // 
            // tableFiltros
            // 
            this.tableFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableFiltros.ColumnCount = 3;
            this.tableFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableFiltros.Controls.Add(this.checkBox1, 2, 2);
            this.tableFiltros.Controls.Add(this.checkBox4, 2, 0);
            this.tableFiltros.Controls.Add(this.checkBox5, 2, 1);
            this.tableFiltros.Controls.Add(this.button1, 1, 2);
            this.tableFiltros.Controls.Add(this.label6, 0, 2);
            this.tableFiltros.Controls.Add(this.label7, 0, 1);
            this.tableFiltros.Controls.Add(this.button2, 1, 1);
            this.tableFiltros.Controls.Add(this.textBox1, 1, 0);
            this.tableFiltros.Controls.Add(this.label8, 0, 0);
            this.tableFiltros.Location = new System.Drawing.Point(0, 0);
            this.tableFiltros.Name = "tableFiltros";
            this.tableFiltros.RowCount = 3;
            this.tableFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableFiltros.Size = new System.Drawing.Size(462, 95);
            this.tableFiltros.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.Location = new System.Drawing.Point(445, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(14, 27);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox4.AutoSize = true;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.Location = new System.Drawing.Point(445, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(14, 25);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.Location = new System.Drawing.Point(445, 34);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(14, 25);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(224, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(3, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha Fin";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(3, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha Inicio";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(224, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(224, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "Filtrar x nro Tarjeta";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(954, 358);
            this.Controls.Add(this.tableLayoutPanel_main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Conversor de Marcas";
            this.panelEntrada.ResumeLayout(false);
            this.panelEntrada.PerformLayout();
            this.panel_salida.ResumeLayout(false);
            this.panel_salida.PerformLayout();
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.tableLayoutPanel_main.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel_CheckBuscarMarcas.ResumeLayout(false);
            this.tableFiltros.ResumeLayout(false);
            this.tableFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox clientes_comboBox;
        private OpenFileDialog openFileDialog_IN;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private FolderBrowserDialog folderDialog_IN;
        private FolderBrowserDialog folderDialog_OUT;
        private Panel panelEntrada;
        private RadioButton radioBtn_folderIN;
        private RadioButton radioBtn_archivoIN;
        private TextBox txt_folderIN;
        private TextBox txt_archivoIN;
        private Label lbl_formatoIN;
        private ComboBox comboBox_formatoIN;
        private Panel panel_salida;
        private Label label2;
        private Label label1;
        private TextBox txt_folderOUT;
        private TextBox txt_archivoOUT;
        private ComboBox comboBox_formatoOUT;
        private Label lbl_formatoOUT;
        private Button btn_ir_Clientes;
        private Button btn_ir_Formatos;
        private TableLayoutPanel tableLayoutPanel_main;
        private Panel panel_filtrosBuscar;
        private TableLayoutPanel tableFiltros;
        private CheckBox checkBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Button button1;
        private Label label6;
        private Label label7;
        private Button button2;
        private TextBox textBox1;
        private Label label8;
        private Panel panel5;
        private Button btn_ConvertirMarcas;
        private Panel panel_CheckBuscarMarcas;
        private CheckBox chkBox_BuscarMarcas;
    }
}