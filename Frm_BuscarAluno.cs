using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace JanelasMDI
{
    public partial class Frm_BuscarAluno : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        MySqlDataReader dr;
        Boolean flag = true;
        public Frm_BuscarAluno()
        {
            InitializeComponent();
        }
        private void Frm_BuscarAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           verificar();
        }
        private void verificar()
        {
            if (rdbCodigoCli.Checked)
            {
                strSQL = "select * from t_cliente c join t_aluno a on c.CodigoCli = @valor and a.cpf_cli = c.cpf_cli;";
                pesquisarAluno();
            }
            else if (rdbCpfAluno.Checked)
            {
                strSQL = "select * from t_cliente c join t_aluno a on a.cpf_aluno = @valor and a.cpf_cli = c.cpf_cli;";
                pesquisarAluno();
            }
            else if (rdbCpfCliente.Checked)
            {
                strSQL = "select * from t_cliente c join t_aluno a on c.cpf_cli = @valor and a.cpf_cli = @valor;";
                pesquisarAluno();
            }
            else if (rdbMatricula.Checked)
            {
                strSQL = "select * from t_cliente c join t_aluno a on a.matricula_aluno = @valor and c.cpf_cli = a.cpf_cli;";
                pesquisarAluno();
            }
            else
            {
                MessageBox.Show("Escolha uma das opções de busca!!!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtboxPesquisa.Clear();
            }

        }
        private void pesquisarAluno()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                
                comando = new MySqlCommand(strSQL, conexao);
                
                comando.Parameters.AddWithValue("@valor", txtboxPesquisa.Text); 

                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    string DDD;
                    string numero;

                    if (dr.Read())
                    {
                        txtBoxNome.Text = Convert.ToString(dr["nome_aluno"]);
                        txtBoxMatricula.Text = Convert.ToString(dr["matricula_aluno"]);
                        txtBoxCPF.Text = Convert.ToString(dr["cpf_aluno"]);
                        msktextData.Text = Convert.ToString(dr["dtnascimento_aluno"]);
                        txtboxgenero.Text = Convert.ToString(dr["sexo_aluno"]);
                        txtboxEmail.Text = Convert.ToString(dr["email_aluno"]);
                        msktextData.Text = Convert.ToString(dr["dtnascimento_aluno"]);                      
                        txtBoxNomeDoCli.Text = Convert.ToString(dr["nome_cli"]);
                        txtBoxCPFcliente.Text = Convert.ToString(dr["cpf_cli"]);
                        DDD = Convert.ToString(dr["dddcel_cli"]);
                        numero = Convert.ToString(dr["numerocel_cli"]);
                        txtboxTelefoneCli.Text = DDD + numero;
                    }

                    MessageBox.Show("Encontrado","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não encontrado","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    limpar();
                }             

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        private void limpar()
        {
            txtBoxCPF.Clear();
            txtboxgenero.Clear();
            txtboxEmail.Clear();
            txtboxTelefoneCli.Clear();
            txtBoxMatricula.Clear();
            txtBoxNomeDoCli.Clear();
            txtboxPesquisa.Clear();
            txtBoxCPFcliente.Clear(); 
        }
    }
}
