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
            usuarioMenuItem.Text = nome_usu;
            if (tipo == "root")
            {
                
            }
            else if (tipo == "Coordenador")
            {
                ferramentasMenuItem.Visible = false;
            }
            else if (tipo == "Atendimento")
            {
                
                ferramentasMenuItem.Visible = false;
                
            }
            else
            {
                MessageBox.Show("Erro 28999343182","Erro Grave",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
             
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
            Frm_Listar listar = new Frm_Listar("alu");
            listar.MdiParent = this;
            listar.Show();
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
            Frm_Listar listar = new Frm_Listar("cli");
            listar.MdiParent = this;
            listar.Show();
        }

        private void buscarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BuscarAluno _BuscarAluno = new Frm_BuscarAluno();
            _BuscarAluno.MdiParent = this;
            _BuscarAluno.Show();
        }

        private void TsbCadastrarCliente_Click(object sender, EventArgs e)
        {
            Frm_CadastrarCliente FrmCadastrar_Cliente = new Frm_CadastrarCliente();
            FrmCadastrar_Cliente.MdiParent = this;
            FrmCadastrar_Cliente.Show();
        }
        private void tsbAjuda_Click(object sender, EventArgs e)
        {
            Frm_Ajuda _Ajuda = new Frm_Ajuda();
            _Ajuda.MdiParent = this;
            _Ajuda.Show();
        }

        private void TsbCadastrarAluno_Click(object sender, EventArgs e)
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

        private void TsbListar_Click(object sender, EventArgs e)
        {
            Frm_Listar visualizar = new Frm_Listar("usu");
            visualizar.MdiParent = this;
            visualizar.Show();
        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeixarLetrasPreta();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DeixarLetrasPreta();

        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeixarLetrasPreta();
            if (tsbarradeferramentes.Visible == false)
            {
                tsbarradeferramentes.Visible = true;
            }
            else
            {
                tsbarradeferramentes.Visible=false;
            }

        }

        private void TsbBuscarAluno_CLick(object sender, EventArgs e)
        {
            
            Frm_BuscarAluno _BuscarAluno = new Frm_BuscarAluno();
            _BuscarAluno.MdiParent = this;
            _BuscarAluno.Show();
        }

        private void TsbBuscarCliente_Click(object sender, EventArgs e)
        {
            Frm_BuscarClientel frm_BuscarCliente = new Frm_BuscarClientel();
            frm_BuscarCliente.MdiParent = this;
            frm_BuscarCliente.Show();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void DeixarLetrasPreta()
        {
            
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void janelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbListarClientes_Click(object sender, EventArgs e)
        {
            Frm_Listar listar = new Frm_Listar("cli");
            listar.MdiParent = this;
            listar.Show();
        }

        private void tsbListarAlunos_Click(object sender, EventArgs e)
        {
            Frm_Listar listar = new Frm_Listar("alu");
            listar.MdiParent = this;
            listar.Show();
        }

        private void tsbFecharPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
