namespace JanelasMDI
{
    partial class Frm_CadastrarAluno
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
            this.label2 = new System.Windows.Forms.Label();
            this.ttp1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCPFinvalido = new System.Windows.Forms.Label();
            this.txtboxCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskBoxDDD = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskBoxCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.cmboxgenero = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataNas = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.mskBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskBoxCpfAluno = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(143, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 57);
            this.label2.TabIndex = 39;
            this.label2.Text = "Cadastrar Novo Aluno";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::JanelasMDI.Properties.Resources.icons8_vassoura_40;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(57, 267);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(41, 35);
            this.btnLimpar.TabIndex = 150;
            this.ttp1.SetToolTip(this.btnLimpar, "Limpar todos os campos");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = global::JanelasMDI.Properties.Resources.icons8_adicionar_usuário_masculino_40;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Location = new System.Drawing.Point(524, 267);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(41, 35);
            this.btnCadastrar.TabIndex = 149;
            this.ttp1.SetToolTip(this.btnCadastrar, "Salvar um novo Cadastro");
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblCPFinvalido);
            this.panel1.Controls.Add(this.txtboxCodigo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mskBoxDDD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.mskBoxCpfCliente);
            this.panel1.Controls.Add(this.cmboxgenero);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpDataNas);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.mskBoxTelefone);
            this.panel1.Controls.Add(this.mskBoxCpfAluno);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtBoxEmail);
            this.panel1.Controls.Add(this.txtBoxNome);
            this.panel1.Controls.Add(this.label9);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(42, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 322);
            this.panel1.TabIndex = 40;
            // 
            // lblCPFinvalido
            // 
            this.lblCPFinvalido.AutoSize = true;
            this.lblCPFinvalido.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFinvalido.ForeColor = System.Drawing.Color.Red;
            this.lblCPFinvalido.Location = new System.Drawing.Point(239, 100);
            this.lblCPFinvalido.Name = "lblCPFinvalido";
            this.lblCPFinvalido.Size = new System.Drawing.Size(87, 14);
            this.lblCPFinvalido.TabIndex = 547;
            this.lblCPFinvalido.Text = "CPF invalido !!!";
            this.lblCPFinvalido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCPFinvalido.Visible = false;
            // 
            // txtboxCodigo
            // 
            this.txtboxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCodigo.Location = new System.Drawing.Point(413, 76);
            this.txtboxCodigo.Name = "txtboxCodigo";
            this.txtboxCodigo.ReadOnly = true;
            this.txtboxCodigo.Size = new System.Drawing.Size(82, 21);
            this.txtboxCodigo.TabIndex = 546;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 169;
            this.label5.Text = "Codigo do Responsavel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(58, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 167;
            this.label1.Text = "CPF do aluno";
            // 
            // mskBoxDDD
            // 
            this.mskBoxDDD.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mskBoxDDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBoxDDD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskBoxDDD.Location = new System.Drawing.Point(321, 212);
            this.mskBoxDDD.Mask = "00";
            this.mskBoxDDD.Name = "mskBoxDDD";
            this.mskBoxDDD.Size = new System.Drawing.Size(32, 21);
            this.mskBoxDDD.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(54, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(511, 13);
            this.label4.TabIndex = 165;
            this.label4.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(54, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 13);
            this.label3.TabIndex = 164;
            this.label3.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // mskBoxCpfCliente
            // 
            this.mskBoxCpfCliente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mskBoxCpfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBoxCpfCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskBoxCpfCliente.Location = new System.Drawing.Point(242, 76);
            this.mskBoxCpfCliente.Mask = "999.999.999-99";
            this.mskBoxCpfCliente.Name = "mskBoxCpfCliente";
            this.mskBoxCpfCliente.Size = new System.Drawing.Size(145, 21);
            this.mskBoxCpfCliente.TabIndex = 2;
            this.mskBoxCpfCliente.Leave += new System.EventHandler(this.mskBoxCpfCliente_Leave);
            // 
            // cmboxgenero
            // 
            this.cmboxgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxgenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmboxgenero.FormattingEnabled = true;
            this.cmboxgenero.Items.AddRange(new object[] {
            "Homem",
            "Mulher",
            "Prefiro nem comentar"});
            this.cmboxgenero.Location = new System.Drawing.Point(456, 146);
            this.cmboxgenero.Name = "cmboxgenero";
            this.cmboxgenero.Size = new System.Drawing.Size(93, 23);
            this.cmboxgenero.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(453, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 142;
            this.label8.Text = "Gênero";
            // 
            // dtpDataNas
            // 
            this.dtpDataNas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNas.Location = new System.Drawing.Point(320, 148);
            this.dtpDataNas.Name = "dtpDataNas";
            this.dtpDataNas.Size = new System.Drawing.Size(92, 21);
            this.dtpDataNas.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(56, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 138;
            this.label11.Text = "Nome Completo";
            // 
            // mskBoxTelefone
            // 
            this.mskBoxTelefone.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mskBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBoxTelefone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskBoxTelefone.Location = new System.Drawing.Point(360, 212);
            this.mskBoxTelefone.Mask = "99900-0000";
            this.mskBoxTelefone.Name = "mskBoxTelefone";
            this.mskBoxTelefone.Size = new System.Drawing.Size(88, 21);
            this.mskBoxTelefone.TabIndex = 7;
            // 
            // mskBoxCpfAluno
            // 
            this.mskBoxCpfAluno.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mskBoxCpfAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBoxCpfAluno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskBoxCpfAluno.Location = new System.Drawing.Point(58, 76);
            this.mskBoxCpfAluno.Mask = "999.999.999-99";
            this.mskBoxCpfAluno.Name = "mskBoxCpfAluno";
            this.mskBoxCpfAluno.Size = new System.Drawing.Size(132, 21);
            this.mskBoxCpfAluno.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(326, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 139;
            this.label13.Text = "Telefone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(58, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 16);
            this.label14.TabIndex = 140;
            this.label14.Text = "E-mail";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(317, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 16);
            this.label15.TabIndex = 141;
            this.label15.Text = "Data de Nascimento";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxEmail.Location = new System.Drawing.Point(58, 212);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(227, 21);
            this.txtBoxEmail.TabIndex = 5;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxNome.Location = new System.Drawing.Point(57, 150);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(242, 21);
            this.txtBoxNome.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(239, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 136;
            this.label9.Text = "CPF do Responsavel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-9, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 10);
            this.panel2.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel4.Location = new System.Drawing.Point(577, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 10);
            this.panel4.TabIndex = 42;
            // 
            // Frm_CadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 462);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Frm_CadastrarAluno";
            this.Text = "Cadastrar Novo Aluno";
            this.Load += new System.EventHandler(this.Frm_CadastrarAluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip ttp1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox mskBoxCpfCliente;
        private System.Windows.Forms.ComboBox cmboxgenero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataNas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskBoxTelefone;
        private System.Windows.Forms.MaskedTextBox mskBoxCpfAluno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskBoxDDD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxCodigo;
        private System.Windows.Forms.Label lblCPFinvalido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}