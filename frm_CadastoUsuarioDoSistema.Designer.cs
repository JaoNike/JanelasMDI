namespace JanelasMDI
{
    partial class frm_CadastoUsuarioDoSistema
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadastoUsuarioDoSistema));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cmboxCargo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.ttp2 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbExibir = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login de Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo";
            // 
            // txtBoxNomeUsuario
            // 
            this.txtBoxNomeUsuario.Location = new System.Drawing.Point(192, 100);
            this.txtBoxNomeUsuario.Name = "txtBoxNomeUsuario";
            this.txtBoxNomeUsuario.Size = new System.Drawing.Size(251, 20);
            this.txtBoxNomeUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(192, 145);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(251, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // cmboxCargo
            // 
            this.cmboxCargo.FormattingEnabled = true;
            this.cmboxCargo.Items.AddRange(new object[] {
            "Coordenador",
            "Atendimento"});
            this.cmboxCargo.Location = new System.Drawing.Point(191, 258);
            this.cmboxCargo.Name = "cmboxCargo";
            this.cmboxCargo.Size = new System.Drawing.Size(185, 21);
            this.cmboxCargo.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 374);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cadastro de Usuario";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.BackgroundImage")));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(310, 302);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(49, 46);
            this.btnCadastrar.TabIndex = 38;
            this.ttp2.SetToolTip(this.btnCadastrar, "Salvar um novo Cadastro");
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(192, 192);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = '*';
            this.txtSenha2.Size = new System.Drawing.Size(251, 20);
            this.txtSenha2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Confirma Senha";
            // 
            // ckbExibir
            // 
            this.ckbExibir.AutoSize = true;
            this.ckbExibir.Location = new System.Drawing.Point(191, 218);
            this.ckbExibir.Name = "ckbExibir";
            this.ckbExibir.Size = new System.Drawing.Size(85, 17);
            this.ckbExibir.TabIndex = 42;
            this.ckbExibir.Text = "Exibir Senha";
            this.ckbExibir.UseVisualStyleBackColor = true;
            this.ckbExibir.CheckedChanged += new System.EventHandler(this.ckbExibir_CheckedChanged);
            // 
            // frm_CadastoUsuarioDoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(513, 374);
            this.Controls.Add(this.ckbExibir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmboxCargo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtBoxNomeUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frm_CadastoUsuarioDoSistema";
            this.Text = "frm_CadastoUsuarioDoSistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNomeUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox cmboxCargo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ToolTip ttp2;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbExibir;
    }
}