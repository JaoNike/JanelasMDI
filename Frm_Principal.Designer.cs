namespace JanelasMDI
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastrarAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.agendarAtendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarAtendimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarEmCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mInimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCadastroDeClient = new System.Windows.Forms.ToolStripButton();
            this.tsbCadastrarAluno = new System.Windows.Forms.ToolStripButton();
            this.tsbSobre = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.ferramentasMenuItem,
            this.sistemaToolStripMenuItem,
            this.janelaToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.usuarioMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 0);
            this.menuStrip1.MdiWindowListItem = this.janelaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.salvarComoToolStripMenuItem.Text = "Fechar Todas as Janelas";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            this.exibirToolStripMenuItem.Click += new System.EventHandler(this.exibirToolStripMenuItem_Click);
            // 
            // ferramentasMenuItem
            // 
            this.ferramentasMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastrarUsuarioToolStripMenuItem,
            this.calculadoraToolStripMenuItem});
            this.ferramentasMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ferramentasMenuItem.Name = "ferramentasMenuItem";
            this.ferramentasMenuItem.Size = new System.Drawing.Size(96, 20);
            this.ferramentasMenuItem.Text = "Administração";
            this.ferramentasMenuItem.Click += new System.EventHandler(this.ferramentasToolStripMenuItem_Click);
            // 
            // CadastrarUsuarioToolStripMenuItem
            // 
            this.CadastrarUsuarioToolStripMenuItem.Name = "CadastrarUsuarioToolStripMenuItem";
            this.CadastrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CadastrarUsuarioToolStripMenuItem.Text = "Cadastrar Usuário";
            this.CadastrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.CadastrarUsuarioToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculadoraToolStripMenuItem.Text = "Visualizar Usuário";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.listarClientesToolStripMenuItem,
            this.buscarAnimalToolStripMenuItem,
            this.toolStripSeparator2,
            this.cadastrarAnimalToolStripMenuItem,
            this.buscarAlunoToolStripMenuItem,
            this.agendarConsultaToolStripMenuItem,
            this.toolStripSeparator6,
            this.agendarAtendimentoToolStripMenuItem,
            this.visualizarAtendimentosToolStripMenuItem});
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.listarClientesToolStripMenuItem.Text = "Listar Clientes";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // buscarAnimalToolStripMenuItem
            // 
            this.buscarAnimalToolStripMenuItem.Name = "buscarAnimalToolStripMenuItem";
            this.buscarAnimalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.buscarAnimalToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.buscarAnimalToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarAnimalToolStripMenuItem.Click += new System.EventHandler(this.buscarAnimalToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // cadastrarAnimalToolStripMenuItem
            // 
            this.cadastrarAnimalToolStripMenuItem.Name = "cadastrarAnimalToolStripMenuItem";
            this.cadastrarAnimalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.cadastrarAnimalToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cadastrarAnimalToolStripMenuItem.Text = "Cadastrar Aluno";
            this.cadastrarAnimalToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAnimalToolStripMenuItem_Click);
            // 
            // buscarAlunoToolStripMenuItem
            // 
            this.buscarAlunoToolStripMenuItem.Name = "buscarAlunoToolStripMenuItem";
            this.buscarAlunoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.buscarAlunoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.buscarAlunoToolStripMenuItem.Text = "Buscar Aluno";
            this.buscarAlunoToolStripMenuItem.Click += new System.EventHandler(this.buscarAlunoToolStripMenuItem_Click);
            // 
            // agendarConsultaToolStripMenuItem
            // 
            this.agendarConsultaToolStripMenuItem.Name = "agendarConsultaToolStripMenuItem";
            this.agendarConsultaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.agendarConsultaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.agendarConsultaToolStripMenuItem.Text = "Listar Alunos";
            this.agendarConsultaToolStripMenuItem.Click += new System.EventHandler(this.agendarConsultaToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(201, 6);
            // 
            // agendarAtendimentoToolStripMenuItem
            // 
            this.agendarAtendimentoToolStripMenuItem.Name = "agendarAtendimentoToolStripMenuItem";
            this.agendarAtendimentoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.agendarAtendimentoToolStripMenuItem.Text = "Agendar Atendimento";
            // 
            // visualizarAtendimentosToolStripMenuItem
            // 
            this.visualizarAtendimentosToolStripMenuItem.Name = "visualizarAtendimentosToolStripMenuItem";
            this.visualizarAtendimentosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.visualizarAtendimentosToolStripMenuItem.Text = "Visualizar Atendimentos";
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizarNaHorizontalToolStripMenuItem,
            this.organizarNaVerticalToolStripMenuItem,
            this.organizarEmCascataToolStripMenuItem,
            this.toolStripSeparator3,
            this.mInimizarToolStripMenuItem,
            this.maximizarToolStripMenuItem,
            this.toolStripSeparator5});
            this.janelaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.janelaToolStripMenuItem.Text = "Janela";
            // 
            // organizarNaHorizontalToolStripMenuItem
            // 
            this.organizarNaHorizontalToolStripMenuItem.Name = "organizarNaHorizontalToolStripMenuItem";
            this.organizarNaHorizontalToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.organizarNaHorizontalToolStripMenuItem.Text = "Organizar na Horizontal";
            this.organizarNaHorizontalToolStripMenuItem.Click += new System.EventHandler(this.organizarNaHorizontalToolStripMenuItem_Click);
            // 
            // organizarNaVerticalToolStripMenuItem
            // 
            this.organizarNaVerticalToolStripMenuItem.Name = "organizarNaVerticalToolStripMenuItem";
            this.organizarNaVerticalToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.organizarNaVerticalToolStripMenuItem.Text = "Organizar na Vertical";
            this.organizarNaVerticalToolStripMenuItem.Click += new System.EventHandler(this.organizarNaVerticalToolStripMenuItem_Click);
            // 
            // organizarEmCascataToolStripMenuItem
            // 
            this.organizarEmCascataToolStripMenuItem.Name = "organizarEmCascataToolStripMenuItem";
            this.organizarEmCascataToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.organizarEmCascataToolStripMenuItem.Text = "Organizar em Cascata";
            this.organizarEmCascataToolStripMenuItem.Click += new System.EventHandler(this.organizarEmCascataToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(196, 6);
            // 
            // mInimizarToolStripMenuItem
            // 
            this.mInimizarToolStripMenuItem.Name = "mInimizarToolStripMenuItem";
            this.mInimizarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.mInimizarToolStripMenuItem.Text = "MInimizar";
            // 
            // maximizarToolStripMenuItem
            // 
            this.maximizarToolStripMenuItem.Name = "maximizarToolStripMenuItem";
            this.maximizarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.maximizarToolStripMenuItem.Text = "Maximizar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(196, 6);
            this.toolStripSeparator5.Click += new System.EventHandler(this.toolStripSeparator5_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem1,
            this.toolStripSeparator4,
            this.sobreOSistemaToolStripMenuItem});
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.ajudaToolStripMenuItem1.Text = "Ajuda";
            this.ajudaToolStripMenuItem1.Click += new System.EventHandler(this.ajudaToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(207, 6);
            // 
            // sobreOSistemaToolStripMenuItem
            // 
            this.sobreOSistemaToolStripMenuItem.Name = "sobreOSistemaToolStripMenuItem";
            this.sobreOSistemaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
            this.sobreOSistemaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.sobreOSistemaToolStripMenuItem.Text = "Sobre o Sistema";
            this.sobreOSistemaToolStripMenuItem.Click += new System.EventHandler(this.sobreOSistemaToolStripMenuItem_Click);
            // 
            // usuarioMenuItem
            // 
            this.usuarioMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.usuarioMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usuarioMenuItem.Name = "usuarioMenuItem";
            this.usuarioMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioMenuItem.Text = "Usuario";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadastroDeClient,
            this.tsbCadastrarAluno,
            this.tsbSobre});
            this.toolStrip1.Location = new System.Drawing.Point(1, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(804, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCadastroDeClient
            // 
            this.tsbCadastroDeClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadastroDeClient.Image = global::JanelasMDI.Properties.Resources.icons8_adicionar_usuário_masculino_96;
            this.tsbCadastroDeClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadastroDeClient.Name = "tsbCadastroDeClient";
            this.tsbCadastroDeClient.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.tsbCadastroDeClient.Size = new System.Drawing.Size(23, 22);
            this.tsbCadastroDeClient.Text = "Cadastrar novo cliente";
            this.tsbCadastroDeClient.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // tsbCadastrarAluno
            // 
            this.tsbCadastrarAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadastrarAluno.Image = global::JanelasMDI.Properties.Resources.icons8_adicionar_usuário_masculino_40;
            this.tsbCadastrarAluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadastrarAluno.Name = "tsbCadastrarAluno";
            this.tsbCadastrarAluno.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.tsbCadastrarAluno.Size = new System.Drawing.Size(23, 22);
            this.tsbCadastrarAluno.Text = "Cadastrar Alunos";
            this.tsbCadastrarAluno.Click += new System.EventHandler(this.tsbCadastrarAluno_Click);
            // 
            // tsbSobre
            // 
            this.tsbSobre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSobre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSobre.Image = global::JanelasMDI.Properties.Resources.icons8_busca_67;
            this.tsbSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSobre.Name = "tsbSobre";
            this.tsbSobre.Size = new System.Drawing.Size(23, 22);
            this.tsbSobre.Text = "Sobre o Sistema";
            this.tsbSobre.Click += new System.EventHandler(this.tsbSobre_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Frm_Principal";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Atendimento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem agendarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CadastrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarEmCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sobreOSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mInimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem agendarAtendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarAtendimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbCadastroDeClient;
        private System.Windows.Forms.ToolStripButton tsbCadastrarAluno;
        private System.Windows.Forms.ToolStripButton tsbSobre;
        private System.Windows.Forms.ToolStripMenuItem usuarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
    }
}

