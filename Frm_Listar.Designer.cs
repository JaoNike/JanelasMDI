namespace JanelasMDI
{
    partial class Frm_Listar
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCadastrados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 89);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(1045, 371);
            this.dgv.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(978, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Recarregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCadastrados
            // 
            this.lblCadastrados.AutoSize = true;
            this.lblCadastrados.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrados.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCadastrados.Location = new System.Drawing.Point(6, 28);
            this.lblCadastrados.Name = "lblCadastrados";
            this.lblCadastrados.Size = new System.Drawing.Size(395, 35);
            this.lblCadastrados.TabIndex = 3;
            this.lblCadastrados.Text = "Clientes Cadastrados";
            // 
            // Frm_ListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1069, 472);
            this.Controls.Add(this.lblCadastrados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Name = "Frm_ListarClientes";
            this.Text = "Agendar Consulta";
            this.Load += new System.EventHandler(this.Frm_ListarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCadastrados;
    }
}