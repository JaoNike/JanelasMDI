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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastrarAluno));
            this.label2 = new System.Windows.Forms.Label();
            this.ttp1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmboxEstado = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.txtBoxCidade = new System.Windows.Forms.TextBox();
            this.txtBoxBairro = new System.Windows.Forms.TextBox();
            this.txtboxRua = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxCep = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.txtBoxMatricula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(280, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 33);
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
            this.btnLimpar.Location = new System.Drawing.Point(52, 380);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(41, 35);
            this.btnLimpar.TabIndex = 150;
            this.ttp1.SetToolTip(this.btnLimpar, "Limpar todos os campos");
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.BackgroundImage")));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Location = new System.Drawing.Point(565, 380);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(41, 35);
            this.btnCadastrar.TabIndex = 149;
            this.ttp1.SetToolTip(this.btnCadastrar, "Salvar um novo Cadastro");
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.CmboxEstado);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtBoxNumero);
            this.panel1.Controls.Add(this.txtBoxCidade);
            this.panel1.Controls.Add(this.txtBoxBairro);
            this.panel1.Controls.Add(this.txtboxRua);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBoxCep);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label10);
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
            this.panel1.Controls.Add(this.txtBoxMatricula);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(63, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 423);
            this.panel1.TabIndex = 40;
            // 
            // CmboxEstado
            // 
            this.CmboxEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.CmboxEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CmboxEstado.FormattingEnabled = true;
            this.CmboxEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.CmboxEstado.Location = new System.Drawing.Point(313, 287);
            this.CmboxEstado.Name = "CmboxEstado";
            this.CmboxEstado.Size = new System.Drawing.Size(40, 21);
            this.CmboxEstado.TabIndex = 166;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Location = new System.Drawing.Point(59, 286);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 22);
            this.textBox2.TabIndex = 165;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(59, 268);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 16);
            this.label19.TabIndex = 164;
            this.label19.Text = "Pais";
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxNumero.Location = new System.Drawing.Point(417, 336);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(47, 22);
            this.txtBoxNumero.TabIndex = 162;
            // 
            // txtBoxCidade
            // 
            this.txtBoxCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxCidade.Location = new System.Drawing.Point(367, 286);
            this.txtBoxCidade.Name = "txtBoxCidade";
            this.txtBoxCidade.Size = new System.Drawing.Size(198, 22);
            this.txtBoxCidade.TabIndex = 161;
            // 
            // txtBoxBairro
            // 
            this.txtBoxBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBairro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxBairro.Location = new System.Drawing.Point(272, 336);
            this.txtBoxBairro.Name = "txtBoxBairro";
            this.txtBoxBairro.Size = new System.Drawing.Size(131, 22);
            this.txtBoxBairro.TabIndex = 160;
            // 
            // txtboxRua
            // 
            this.txtboxRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxRua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtboxRua.Location = new System.Drawing.Point(59, 336);
            this.txtboxRua.Name = "txtboxRua";
            this.txtboxRua.Size = new System.Drawing.Size(190, 22);
            this.txtboxRua.TabIndex = 159;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(310, 268);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 16);
            this.label16.TabIndex = 158;
            this.label16.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(367, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 157;
            this.label3.Text = "Cidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(414, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 156;
            this.label12.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(274, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 155;
            this.label4.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(59, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 154;
            this.label5.Text = "Rua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(200, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 153;
            this.label6.Text = "CEP";
            // 
            // txtBoxCep
            // 
            this.txtBoxCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxCep.Location = new System.Drawing.Point(203, 286);
            this.txtBoxCep.Name = "txtBoxCep";
            this.txtBoxCep.Size = new System.Drawing.Size(85, 22);
            this.txtBoxCep.TabIndex = 152;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(55, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 16);
            this.label17.TabIndex = 151;
            this.label17.Text = "Endereço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(54, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(511, 13);
            this.label10.TabIndex = 163;
            this.label10.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // mskBoxCpfCliente
            // 
            this.mskBoxCpfCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mskBoxCpfCliente.Location = new System.Drawing.Point(189, 68);
            this.mskBoxCpfCliente.Mask = "999.999.999-99";
            this.mskBoxCpfCliente.Name = "mskBoxCpfCliente";
            this.mskBoxCpfCliente.Size = new System.Drawing.Size(111, 20);
            this.mskBoxCpfCliente.TabIndex = 148;
            // 
            // cmboxgenero
            // 
            this.cmboxgenero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmboxgenero.FormattingEnabled = true;
            this.cmboxgenero.Items.AddRange(new object[] {
            "Mulher",
            "Homem",
            "Prefiro nem comentar"});
            this.cmboxgenero.Location = new System.Drawing.Point(489, 134);
            this.cmboxgenero.Name = "cmboxgenero";
            this.cmboxgenero.Size = new System.Drawing.Size(93, 21);
            this.cmboxgenero.TabIndex = 143;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(486, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 142;
            this.label8.Text = "Gênero";
            // 
            // dtpDataNas
            // 
            this.dtpDataNas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNas.Location = new System.Drawing.Point(334, 134);
            this.dtpDataNas.Name = "dtpDataNas";
            this.dtpDataNas.Size = new System.Drawing.Size(92, 20);
            this.dtpDataNas.TabIndex = 147;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(57, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 138;
            this.label11.Text = "Nome Completo";
            // 
            // mskBoxTelefone
            // 
            this.mskBoxTelefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mskBoxTelefone.Location = new System.Drawing.Point(304, 191);
            this.mskBoxTelefone.Mask = "(99) 99900-0000";
            this.mskBoxTelefone.Name = "mskBoxTelefone";
            this.mskBoxTelefone.Size = new System.Drawing.Size(187, 20);
            this.mskBoxTelefone.TabIndex = 146;
            // 
            // mskBoxCpfAluno
            // 
            this.mskBoxCpfAluno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mskBoxCpfAluno.Location = new System.Drawing.Point(58, 68);
            this.mskBoxCpfAluno.Mask = "999.999.999-99";
            this.mskBoxCpfAluno.Name = "mskBoxCpfAluno";
            this.mskBoxCpfAluno.Size = new System.Drawing.Size(99, 20);
            this.mskBoxCpfAluno.TabIndex = 145;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(301, 171);
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
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(58, 171);
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
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(334, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 16);
            this.label15.TabIndex = 141;
            this.label15.Text = "Data de Nascimento";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxEmail.Location = new System.Drawing.Point(58, 191);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(227, 20);
            this.txtBoxEmail.TabIndex = 144;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxNome.Location = new System.Drawing.Point(58, 132);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(242, 20);
            this.txtBoxNome.TabIndex = 134;
            // 
            // txtBoxMatricula
            // 
            this.txtBoxMatricula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxMatricula.Location = new System.Drawing.Point(334, 68);
            this.txtBoxMatricula.Name = "txtBoxMatricula";
            this.txtBoxMatricula.Size = new System.Drawing.Size(92, 20);
            this.txtBoxMatricula.TabIndex = 137;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(185, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 136;
            this.label9.Text = "CPF do Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(57, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 135;
            this.label7.Text = "CPF do Aluno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(331, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 133;
            this.label1.Text = "Matrícula do Aluno";
            // 
            // Frm_CadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::JanelasMDI.Properties.Resources.Fundoman;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Frm_CadastrarAluno";
            this.Text = "Cadastrar Novo Aluno";
            this.Load += new System.EventHandler(this.Frm_CadastrarAnimal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip ttp1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CmboxEstado;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.TextBox txtBoxCidade;
        private System.Windows.Forms.TextBox txtBoxBairro;
        private System.Windows.Forms.TextBox txtboxRua;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxCep;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.TextBox txtBoxMatricula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}