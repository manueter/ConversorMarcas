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
            this.chkBox_filtroDateFin = new System.Windows.Forms.CheckBox();
            this.chkBox_filtroNroTarjeta = new System.Windows.Forms.CheckBox();
            this.chkBox_filtroDateIni = new System.Windows.Forms.CheckBox();
            this.lbl_FechaFin = new System.Windows.Forms.Label();
            this.lbl_FechaIni = new System.Windows.Forms.Label();
            this.txtBox_nroTarjeta = new System.Windows.Forms.TextBox();
            this.lbl_NroTarjeta = new System.Windows.Forms.Label();
            this.dateTime_ini = new System.Windows.Forms.DateTimePicker();
            this.dateTime_fin = new System.Windows.Forms.DateTimePicker();
            this.panelEntrada.SuspendLayout();
            this.panel_salida.SuspendLayout();
            this.tableLayoutPanel_main.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_CheckBuscarMarcas.SuspendLayout();
            this.panel_filtrosBuscar.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 464);
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
            this.panel2.Size = new System.Drawing.Size(4, 460);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(950, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 460);
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
            this.comboBox_formatoIN.SelectedIndexChanged += new System.EventHandler(this.formatoIN_comboBox_SelectedIndexChanged);
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
            this.comboBox_formatoOUT.SelectedIndexChanged += new System.EventHandler(this.formatoOUT_comboBox_SelectedIndexChanged);
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
            this.tableLayoutPanel_main.Controls.Add(this.panel_filtrosBuscar, 1, 2);
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(8, 4);
            this.tableLayoutPanel_main.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 3;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(942, 427);
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
            this.btn_ConvertirMarcas.Location = new System.Drawing.Point(3, 410);
            this.btn_ConvertirMarcas.Name = "btn_ConvertirMarcas";
            this.btn_ConvertirMarcas.Size = new System.Drawing.Size(465, 14);
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
            this.panel_CheckBuscarMarcas.Size = new System.Drawing.Size(465, 100);
            this.panel_CheckBuscarMarcas.TabIndex = 6;
            // 
            // chkBox_BuscarMarcas
            // 
            this.chkBox_BuscarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBox_BuscarMarcas.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBox_BuscarMarcas.Location = new System.Drawing.Point(15, 42);
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
            this.panel_filtrosBuscar.Controls.Add(this.tableFiltros);
            this.panel_filtrosBuscar.Location = new System.Drawing.Point(474, 304);
            this.panel_filtrosBuscar.Name = "panel_filtrosBuscar";
            this.panel_filtrosBuscar.Size = new System.Drawing.Size(465, 100);
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
            this.tableFiltros.Controls.Add(this.chkBox_filtroDateFin, 2, 2);
            this.tableFiltros.Controls.Add(this.chkBox_filtroNroTarjeta, 2, 0);
            this.tableFiltros.Controls.Add(this.chkBox_filtroDateIni, 2, 1);
            this.tableFiltros.Controls.Add(this.lbl_FechaFin, 0, 2);
            this.tableFiltros.Controls.Add(this.lbl_FechaIni, 0, 1);
            this.tableFiltros.Controls.Add(this.txtBox_nroTarjeta, 1, 0);
            this.tableFiltros.Controls.Add(this.lbl_NroTarjeta, 0, 0);
            this.tableFiltros.Controls.Add(this.dateTime_ini, 1, 1);
            this.tableFiltros.Controls.Add(this.dateTime_fin, 1, 2);
            this.tableFiltros.Location = new System.Drawing.Point(0, 0);
            this.tableFiltros.Name = "tableFiltros";
            this.tableFiltros.RowCount = 3;
            this.tableFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableFiltros.Size = new System.Drawing.Size(462, 95);
            this.tableFiltros.TabIndex = 13;
            // 
            // chkBox_filtroDateFin
            // 
            this.chkBox_filtroDateFin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBox_filtroDateFin.AutoSize = true;
            this.chkBox_filtroDateFin.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBox_filtroDateFin.Location = new System.Drawing.Point(445, 65);
            this.chkBox_filtroDateFin.Name = "chkBox_filtroDateFin";
            this.chkBox_filtroDateFin.Size = new System.Drawing.Size(14, 27);
            this.chkBox_filtroDateFin.TabIndex = 15;
            this.chkBox_filtroDateFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBox_filtroDateFin.UseVisualStyleBackColor = true;
            // 
            // chkBox_filtroNroTarjeta
            // 
            this.chkBox_filtroNroTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBox_filtroNroTarjeta.AutoSize = true;
            this.chkBox_filtroNroTarjeta.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBox_filtroNroTarjeta.Location = new System.Drawing.Point(445, 3);
            this.chkBox_filtroNroTarjeta.Name = "chkBox_filtroNroTarjeta";
            this.chkBox_filtroNroTarjeta.Size = new System.Drawing.Size(14, 25);
            this.chkBox_filtroNroTarjeta.TabIndex = 14;
            this.chkBox_filtroNroTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBox_filtroNroTarjeta.UseVisualStyleBackColor = true;
            // 
            // chkBox_filtroDateIni
            // 
            this.chkBox_filtroDateIni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBox_filtroDateIni.AutoSize = true;
            this.chkBox_filtroDateIni.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBox_filtroDateIni.Location = new System.Drawing.Point(445, 34);
            this.chkBox_filtroDateIni.Name = "chkBox_filtroDateIni";
            this.chkBox_filtroDateIni.Size = new System.Drawing.Size(14, 25);
            this.chkBox_filtroDateIni.TabIndex = 15;
            this.chkBox_filtroDateIni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBox_filtroDateIni.UseVisualStyleBackColor = true;
            // 
            // lbl_FechaFin
            // 
            this.lbl_FechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FechaFin.AutoSize = true;
            this.lbl_FechaFin.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_FechaFin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_FechaFin.Location = new System.Drawing.Point(3, 62);
            this.lbl_FechaFin.Name = "lbl_FechaFin";
            this.lbl_FechaFin.Size = new System.Drawing.Size(215, 33);
            this.lbl_FechaFin.TabIndex = 12;
            this.lbl_FechaFin.Text = "Fecha Fin";
            this.lbl_FechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_FechaIni
            // 
            this.lbl_FechaIni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FechaIni.AutoSize = true;
            this.lbl_FechaIni.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_FechaIni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_FechaIni.Location = new System.Drawing.Point(3, 31);
            this.lbl_FechaIni.Name = "lbl_FechaIni";
            this.lbl_FechaIni.Size = new System.Drawing.Size(215, 31);
            this.lbl_FechaIni.TabIndex = 11;
            this.lbl_FechaIni.Text = "Fecha Inicio";
            this.lbl_FechaIni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBox_nroTarjeta
            // 
            this.txtBox_nroTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_nroTarjeta.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_nroTarjeta.Location = new System.Drawing.Point(224, 3);
            this.txtBox_nroTarjeta.Name = "txtBox_nroTarjeta";
            this.txtBox_nroTarjeta.Size = new System.Drawing.Size(215, 26);
            this.txtBox_nroTarjeta.TabIndex = 8;
            this.txtBox_nroTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_nroTarjeta.TextChanged += new System.EventHandler(this.filtro_NroTarjeta_Changed);
            // 
            // lbl_NroTarjeta
            // 
            this.lbl_NroTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NroTarjeta.AutoSize = true;
            this.lbl_NroTarjeta.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NroTarjeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_NroTarjeta.Location = new System.Drawing.Point(3, 0);
            this.lbl_NroTarjeta.Name = "lbl_NroTarjeta";
            this.lbl_NroTarjeta.Size = new System.Drawing.Size(215, 31);
            this.lbl_NroTarjeta.TabIndex = 10;
            this.lbl_NroTarjeta.Text = "Filtrar x nro Tarjeta";
            this.lbl_NroTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTime_ini
            // 
            this.dateTime_ini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTime_ini.Location = new System.Drawing.Point(224, 35);
            this.dateTime_ini.Name = "dateTime_ini";
            this.dateTime_ini.Size = new System.Drawing.Size(215, 23);
            this.dateTime_ini.TabIndex = 16;
            this.dateTime_ini.ValueChanged += new System.EventHandler(this.filtro_DateInicial_Changed);
            // 
            // dateTime_fin
            // 
            this.dateTime_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTime_fin.Location = new System.Drawing.Point(224, 67);
            this.dateTime_fin.Name = "dateTime_fin";
            this.dateTime_fin.Size = new System.Drawing.Size(215, 23);
            this.dateTime_fin.TabIndex = 17;
            this.dateTime_fin.ValueChanged += new System.EventHandler(this.filtro_DateFinal_Changed);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(954, 468);
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
            this.panel_filtrosBuscar.ResumeLayout(false);
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
        private CheckBox chkBox_filtroDateFin;
        private CheckBox chkBox_filtroNroTarjeta;
        private CheckBox chkBox_filtroDateIni;
        private TextBox txtBox_nroTarjeta;

        private Label lbl_FechaFin;
        private Label lbl_FechaIni;
        
        private Label lbl_NroTarjeta;
        private Panel panel5;
        private Button btn_ConvertirMarcas;
        private Panel panel_CheckBuscarMarcas;
        private CheckBox chkBox_BuscarMarcas;
        private DateTimePicker dateTime_ini;
        private DateTimePicker dateTime_fin;
    }
}