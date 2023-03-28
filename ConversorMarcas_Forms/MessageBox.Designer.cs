namespace ConversorMarcas_Forms
{
    partial class MessageBox
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
            this.label_MessageBox = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label_titulo_MessageBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_MessageBox
            // 
            this.label_MessageBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_MessageBox.AutoSize = true;
            this.label_MessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_MessageBox.Location = new System.Drawing.Point(35, 66);
            this.label_MessageBox.Name = "label_MessageBox";
            this.label_MessageBox.Size = new System.Drawing.Size(121, 20);
            this.label_MessageBox.TabIndex = 0;
            this.label_MessageBox.Text = "Error o Mensaje";
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_OK.AutoSize = true;
            this.btn_OK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_OK.FlatAppearance.BorderSize = 10;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_OK.Location = new System.Drawing.Point(277, 103);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(77, 32);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label_titulo_MessageBox
            // 
            this.label_titulo_MessageBox.AutoSize = true;
            this.label_titulo_MessageBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_titulo_MessageBox.ForeColor = System.Drawing.Color.Firebrick;
            this.label_titulo_MessageBox.Location = new System.Drawing.Point(12, 9);
            this.label_titulo_MessageBox.Name = "label_titulo_MessageBox";
            this.label_titulo_MessageBox.Size = new System.Drawing.Size(93, 32);
            this.label_titulo_MessageBox.TabIndex = 2;
            this.label_titulo_MessageBox.Text = "ERROR";
            // 
            // MessageBox
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CancelButton = this.btn_OK;
            this.ClientSize = new System.Drawing.Size(381, 161);
            this.Controls.Add(this.label_titulo_MessageBox);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label_MessageBox);
            this.Name = "MessageBox";
            this.Text = "Mensaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_MessageBox;
        private Button btn_OK;
        private Label label_titulo_MessageBox;
    }
}