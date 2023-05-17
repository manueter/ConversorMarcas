namespace ConversorMarcas_Forms
{
    partial class FormatosForm
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
        private void InitializeComponent()
        {
            this.table_parametros = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_esHeader = new System.Windows.Forms.Label();
            this.lbl_cantDigitos = new System.Windows.Forms.Label();
            this.lbl_posicion = new System.Windows.Forms.Label();
            this.lbl_nombreParam = new System.Windows.Forms.Label();
            this.comboBox_formatos = new System.Windows.Forms.ComboBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.table_parametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_parametros
            // 
            this.table_parametros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_parametros.AutoSize = true;
            this.table_parametros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table_parametros.ColumnCount = 4;
            this.table_parametros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.table_parametros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.table_parametros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.table_parametros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.table_parametros.Controls.Add(this.lbl_esHeader, 3, 0);
            this.table_parametros.Controls.Add(this.lbl_cantDigitos, 2, 0);
            this.table_parametros.Controls.Add(this.lbl_posicion, 1, 0);
            this.table_parametros.Controls.Add(this.lbl_nombreParam, 0, 0);
            this.table_parametros.Location = new System.Drawing.Point(20, 86);
            this.table_parametros.Name = "table_parametros";
            this.table_parametros.RowCount = 1;
            this.table_parametros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.table_parametros.Size = new System.Drawing.Size(400, 65);
            this.table_parametros.TabIndex = 0;
            // 
            // lbl_esHeader
            // 
            this.lbl_esHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_esHeader.AutoSize = true;
            this.lbl_esHeader.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_esHeader.Location = new System.Drawing.Point(306, 23);
            this.lbl_esHeader.Name = "lbl_esHeader";
            this.lbl_esHeader.Size = new System.Drawing.Size(88, 18);
            this.lbl_esHeader.TabIndex = 3;
            this.lbl_esHeader.Text = "Es Header?";
            this.lbl_esHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cantDigitos
            // 
            this.lbl_cantDigitos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_cantDigitos.AutoSize = true;
            this.lbl_cantDigitos.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cantDigitos.Location = new System.Drawing.Point(206, 14);
            this.lbl_cantDigitos.Name = "lbl_cantDigitos";
            this.lbl_cantDigitos.Size = new System.Drawing.Size(88, 36);
            this.lbl_cantDigitos.TabIndex = 2;
            this.lbl_cantDigitos.Text = "Cantidad de Digitos";
            this.lbl_cantDigitos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_posicion
            // 
            this.lbl_posicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_posicion.AutoSize = true;
            this.lbl_posicion.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_posicion.Location = new System.Drawing.Point(114, 14);
            this.lbl_posicion.Name = "lbl_posicion";
            this.lbl_posicion.Size = new System.Drawing.Size(72, 36);
            this.lbl_posicion.TabIndex = 1;
            this.lbl_posicion.Text = "Posicion Inicial";
            this.lbl_posicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nombreParam
            // 
            this.lbl_nombreParam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nombreParam.AutoSize = true;
            this.lbl_nombreParam.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombreParam.Location = new System.Drawing.Point(10, 23);
            this.lbl_nombreParam.Name = "lbl_nombreParam";
            this.lbl_nombreParam.Size = new System.Drawing.Size(80, 18);
            this.lbl_nombreParam.TabIndex = 0;
            this.lbl_nombreParam.Text = "Parametro";
            this.lbl_nombreParam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_formatos
            // 
            this.comboBox_formatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_formatos.Font = new System.Drawing.Font("Ubuntu Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_formatos.FormattingEnabled = true;
            this.comboBox_formatos.Location = new System.Drawing.Point(267, 20);
            this.comboBox_formatos.Name = "comboBox_formatos";
            this.comboBox_formatos.Size = new System.Drawing.Size(146, 37);
            this.comboBox_formatos.TabIndex = 1;
            this.comboBox_formatos.SelectedIndexChanged += new System.EventHandler(this.comboBox_formatos_SelectedIndexChanged);
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Ubuntu Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cliente.Location = new System.Drawing.Point(22, 27);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(96, 25);
            this.lbl_cliente.TabIndex = 2;
            this.lbl_cliente.Text = "CLIENTE";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Confirmar.Location = new System.Drawing.Point(277, 168);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(129, 44);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar cambios";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // FormatosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(426, 224);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.comboBox_formatos);
            this.Controls.Add(this.table_parametros);
            this.Font = new System.Drawing.Font("Ubuntu Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormatosForm";
            this.Text = "Formatos";
            this.table_parametros.ResumeLayout(false);
            this.table_parametros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel table_parametros;
        private ComboBox comboBox_formatos;
        private Label lbl_esHeader;
        private Label lbl_cantDigitos;
        private Label lbl_posicion;
        private Label lbl_nombreParam;
        private Label lbl_cliente;
        private Button btn_Confirmar;
    }
}