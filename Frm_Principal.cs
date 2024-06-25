using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanelasMDI
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal(string tipo,string nome_usu)
        {
            InitializeComponent();
            lblUsuario.Text = nome_usu;
            usuarioMenuItem.Text = nome_usu;
            if (tipo == "root")
            {
                
            }
            else if (tipo == "Coordenador")
            {
                CadastrarUsuarioToolStripMenuItem.Visible = true;
            }
            else if (tipo == "Atendimento")
            {
                
                ferramentasMenuItem.Visible = false;
                
            }
            else
            {
                MessageBox.Show("Erro 444","Erro Grave",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
             
            }
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Frm_CadastrarCliente FrmCadastrar_Cliente = new Frm_CadastrarCliente();
            FrmCadastrar_Cliente.MdiParent = this;
            FrmCadastrar_Cliente.Show();
        }

        private void cadastrarAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastrarAluno Frm_CadAnimal = new Frm_CadastrarAluno();
            Frm_CadAnimal.MdiParent= this;
            Frm_CadAnimal.Show();
        }

        private void buscarAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BuscarClientel frm_BuscarAnimal = new Frm_BuscarClientel();
            frm_BuscarAnimal.MdiParent = this;
            frm_BuscarAnimal.Show();
        }

        private void agendarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AgendarConsulta frm_Agendar = new Frm_AgendarConsulta();
            frm_Agendar.MdiParent = this;
            frm_Agendar.Show();
        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Ajuda _Ajuda = new Frm_Ajuda();
            _Ajuda.MdiParent = this;
            _Ajuda.Show();
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sobre frmSobre = new Frm_Sobre();
            //frmSobre.MdiParent = this;
            frmSobre.Show();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void organizarNaHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void organizarNaVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void organizarEmCascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void fecharTodosJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator5_Click(object sender, EventArgs e)
        {

        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BuscarAluno _BuscarAluno = new Frm_BuscarAluno();
            _BuscarAluno.MdiParent = this;
            _BuscarAluno.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Frm_CadastrarCliente FrmCadastrar_Cliente = new Frm_CadastrarCliente();
            FrmCadastrar_Cliente.MdiParent = this;
            FrmCadastrar_Cliente.Show();
        }
        private void tsbSobre_Click(object sender, EventArgs e)
        {
            Frm_Sobre frmSobre = new Frm_Sobre();            
            frmSobre.Show();
        }

        private void tsbCadastrarAluno_Click(object sender, EventArgs e)
        {
            Frm_CadastrarAluno Frm_CadAnimal = new Frm_CadastrarAluno();
            Frm_CadAnimal.MdiParent = this;
            Frm_CadAnimal.Show();
        }

        private void CadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastoUsuarioDoSistema frm = new frm_CadastoUsuarioDoSistema();
            frm.MdiParent = this;
            frm.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarUsuarioDoSistema visualizar = new VisualizarUsuarioDoSistema();
            visualizar.MdiParent = this;
            visualizar.Show();
        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
