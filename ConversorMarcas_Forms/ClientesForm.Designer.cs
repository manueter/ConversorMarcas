namespace ConversorMarcas_Forms
{
    partial class ClientesForm
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
            this.table_clientes = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_nombreCliente_ejemplo = new System.Windows.Forms.Label();
            this.btn_eliminar_ejemplo = new System.Windows.Forms.Button();
            this.lbl_idCliente_ejemplo = new System.Windows.Forms.Label();
            this.btn_addCliente_ejemplo = new System.Windows.Forms.Button();
            this.table_clientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_clientes
            // 
            this.table_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_clientes.AutoScroll = true;
            this.table_clientes.AutoSize = true;
            this.table_clientes.ColumnCount = 3;
            this.table_clientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.791173F));
            this.table_clientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.8404F));
            this.table_clientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.8996F));
            this.table_clientes.Controls.Add(this.lbl_nombreCliente_ejemplo, 1, 0);
            this.table_clientes.Controls.Add(this.btn_eliminar_ejemplo, 2, 0);
            this.table_clientes.Controls.Add(this.lbl_idCliente_ejemplo, 0, 0);
            this.table_clientes.Controls.Add(this.btn_addCliente_ejemplo, 1, 1);
            this.table_clientes.Location = new System.Drawing.Point(14, 14);
            this.table_clientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.table_clientes.Name = "table_clientes";
            this.table_clientes.RowCount = 2;
            this.table_clientes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_clientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_clientes.Size = new System.Drawing.Size(323, 85);
            this.table_clientes.TabIndex = 0;
            // 
            // lbl_nombreCliente_ejemplo
            // 
            this.lbl_nombreCliente_ejemplo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombreCliente_ejemplo.AutoSize = true;
            this.lbl_nombreCliente_ejemplo.Location = new System.Drawing.Point(31, 0);
            this.lbl_nombreCliente_ejemplo.Name = "lbl_nombreCliente_ejemplo";
            this.lbl_nombreCliente_ejemplo.Size = new System.Drawing.Size(184, 39);
            this.lbl_nombreCliente_ejemplo.TabIndex = 0;
            this.lbl_nombreCliente_ejemplo.Text = "Nombre cliente";
            this.lbl_nombreCliente_ejemplo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_eliminar_ejemplo
            // 
            this.btn_eliminar_ejemplo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar_ejemplo.AutoSize = true;
            this.btn_eliminar_ejemplo.Location = new System.Drawing.Point(221, 4);
            this.btn_eliminar_ejemplo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_eliminar_ejemplo.Name = "btn_eliminar_ejemplo";
            this.btn_eliminar_ejemplo.Size = new System.Drawing.Size(99, 31);
            this.btn_eliminar_ejemplo.TabIndex = 1;
            this.btn_eliminar_ejemplo.Text = "Eliminar";
            this.btn_eliminar_ejemplo.UseVisualStyleBackColor = true;
            // 
            // lbl_idCliente_ejemplo
            // 
            this.lbl_idCliente_ejemplo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_idCliente_ejemplo.AutoSize = true;
            this.lbl_idCliente_ejemplo.Location = new System.Drawing.Point(3, 0);
            this.lbl_idCliente_ejemplo.Name = "lbl_idCliente_ejemplo";
            this.lbl_idCliente_ejemplo.Size = new System.Drawing.Size(22, 39);
            this.lbl_idCliente_ejemplo.TabIndex = 3;
            this.lbl_idCliente_ejemplo.Text = "0";
            this.lbl_idCliente_ejemplo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_addCliente_ejemplo
            // 
            this.btn_addCliente_ejemplo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addCliente_ejemplo.AutoSize = true;
            this.btn_addCliente_ejemplo.Location = new System.Drawing.Point(31, 43);
            this.btn_addCliente_ejemplo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addCliente_ejemplo.Name = "btn_addCliente_ejemplo";
            this.btn_addCliente_ejemplo.Size = new System.Drawing.Size(184, 38);
            this.btn_addCliente_ejemplo.TabIndex = 2;
            this.btn_addCliente_ejemplo.Text = "Agregar Nuevo";
            this.btn_addCliente_ejemplo.UseVisualStyleBackColor = true;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(351, 277);
            this.Controls.Add(this.table_clientes);
            this.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.table_clientes.ResumeLayout(false);
            this.table_clientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel table_clientes;
        private Label lbl_nombreCliente_ejemplo;
        private Button btn_eliminar_ejemplo;
        private Button btn_addCliente_ejemplo;
        private Label lbl_idCliente_ejemplo;
    }
}