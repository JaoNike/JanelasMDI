namespace JanelasMDI
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.ckbExibir = new System.Windows.Forms.CheckBox();
            this.btn__Entrar = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbExibir
            // 
            this.ckbExibir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ckbExibir.AutoSize = true;
            this.ckbExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbExibir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ckbExibir.Location = new System.Drawing.Point(189, 275);
            this.ckbExibir.Name = "ckbExibir";
            this.ckbExibir.Size = new System.Drawing.Size(101, 20);
            this.ckbExibir.TabIndex = 0;
            this.ckbExibir.Text = "Exibir Senha";
            this.ckbExibir.UseVisualStyleBackColor = true;
            this.ckbExibir.CheckedChanged += new System.EventHandler(this.ckbExibir_CheckedChanged);
            // 
            // btn__Entrar
            // 
            this.btn__Entrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn__Entrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn__Entrar.FlatAppearance.BorderSize = 0;
            this.btn__Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn__Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__Entrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn__Entrar.Location = new System.Drawing.Point(189, 224);
            this.btn__Entrar.Name = "btn__Entrar";
            this.btn__Entrar.Size = new System.Drawing.Size(227, 32);
            this.btn__Entrar.TabIndex = 1;
            this.btn__Entrar.Text = "Entrar";
            this.btn__Entrar.UseVisualStyleBackColor = false;
            this.btn__Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtLogin.Location = new System.Drawing.Point(189, 137);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(227, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSenha.Location = new System.Drawing.Point(189, 182);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(227, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(189, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(189, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::JanelasMDI.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(245, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(594, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btn__Entrar);
            this.Controls.Add(this.ckbExibir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(610, 370);
            this.MinimumSize = new System.Drawing.Size(610, 370);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbExibir;
        private System.Windows.Forms.Button btn__Entrar;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}