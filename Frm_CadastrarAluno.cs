using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanelasMDI
{
    public partial class Frm_CadastrarAluno : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSQL;
        public Frm_CadastrarAluno()
        {
            InitializeComponent();
        }

        private void Frm_CadastrarAluno_Load(object sender, EventArgs e)
        {
            lblCPFinvalido.Visible = false;
        }   
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            salvar();
        }
        private string RemoveMask(string mask)
        {
            return Regex.Replace(mask, @"\D", "");
        }
        public void salvar()
        {
            bool erro = false;
            
            string[] verificarlos = { txtBoxNome.Text,mskBoxDDD.Text,mskBoxTelefone.Text,txtBoxEmail.Text,dtpDataNas.Text,mskBoxCpfAluno.Text,mskBoxCpfCliente.Text,txtboxCodigo.Text,cmboxgenero.Text,};
            if (!erro)
            {
                foreach (string s in verificarlos)
                {
                    if (s.Equals(""))
                    {
                        MessageBox.Show("Nenhum campo pode está vazio");
                        erro = true;
                        break;
                    }

                }
            }

            if(!erro)
            {
                if (!ContemApenasLetrasEEspacos(txtBoxNome.Text) && !ContemApenasLetrasEEspacos(cmboxgenero.Text))
                {
                    MessageBox.Show("Apenas letras são aceitas no campo Nome e Genero ");
                    erro = true;

                }
            }
//1 - avisar que ta salvo V
//2 - limpar pesquisar V
//3 - listar cliente V
//4 - listar alunos V
//5 - Tradamento de dados V
//6 - Ajuda V
//7 - Adicionar Icons na barra de ferramentas V
//8 - Melhora o desiner se possivel tt
//9 - Em cada listar colocar o cadastra (idea boa) - X
            else
            {
                try
                {

                    conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                    strSQL = "INSERT INTO t_aluno (nome_aluno,dddcel_aluno,numerocel_aluno,email_aluno,dtnascimento_aluno,cpf_aluno,cpf_cli,codigo_cliente,sexo_aluno) VALUES (@nome,@ddd, @numeroCel, @email, @dtnascimento, @cpfAluno, @fk_cpfCliente,@fk_codigo_cliente,@genero)";

                    comando = new MySqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@nome", txtBoxNome.Text);
                    comando.Parameters.AddWithValue("@ddd", RemoveMask(mskBoxDDD.Text));
                    comando.Parameters.AddWithValue("@numeroCel", RemoveMask(mskBoxTelefone.Text));
                    comando.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                    comando.Parameters.AddWithValue("@dtnascimento", Convert.ToDateTime(dtpDataNas.Text));
                    comando.Parameters.AddWithValue("@cpfAluno", RemoveMask(mskBoxCpfAluno.Text));
                    comando.Parameters.AddWithValue("@fk_cpfCliente", RemoveMask(mskBoxCpfCliente.Text));
                    comando.Parameters.AddWithValue("@fk_codigo_cliente", txtboxCodigo.Text);
                    comando.Parameters.AddWithValue("@genero", cmboxgenero.Text);

                    conexao.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cadastro salva!", "Confirmação de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
           
        }
        public bool ContemApenasLetrasEEspacos(string text)
        {
            return text.All(ch => char.IsLetter(ch) || char.IsWhiteSpace(ch));
        }
        private void Pegar_codigo_cliente(string cpf)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = $"SELECT CodigoCli FROM t_cliente WHERE cpf_cli = {cpf}";

                comando = new MySqlCommand(strSQL, conexao);

                conexao.Open();

                comando.ExecuteNonQuery();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        txtboxCodigo.Text = Convert.ToString(dr["CodigoCli"]);
                        lblCPFinvalido.Visible = false;
                    }
                }
                else
                {
                    lblCPFinvalido.Visible = true;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void limpar()
        {
            txtboxCodigo.Clear();
            txtBoxEmail.Clear();
            txtBoxNome.Clear();
            mskBoxCpfAluno.Clear();
            mskBoxCpfCliente.Clear();
            dtpDataNas.Value = DateTime.Now;
            mskBoxDDD.Clear();
            mskBoxTelefone.Clear();
            cmboxgenero.Text = "";

        }

        private void mskBoxCpfCliente_Leave(object sender, EventArgs e)
        {
            Pegar_codigo_cliente(RemoveMask(mskBoxCpfCliente.Text));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
