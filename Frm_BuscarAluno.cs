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
        public Frm_BuscarAluno()
        {
            InitializeComponent();
        }
        private void Frm_BuscarAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigoCli.Checked)
            {
                pesquisarAluno();
            }
            
        }
        private void pesquisarAluno()
        {
            Boolean flag = true;
            conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");

            if (rdbCodigoCli.Checked)
            {
                strSQL = "select * from t_cliente c join t_aluno a on c.CodigoCli = @valor and a.codigo_cliente = @valor;";
            }
            else if (rdbCpfAluno.Checked)
            {
                strSQL = "select * from t_cliente c join t_aluno a on a.cpf_aluno = @valor and a.cpf_cli = c.cpf_cli;";
            }
            else if (rdbCpfCliente.Checked)
            {
                strSQL = "select * from t_cliente c join t_aluno a on c.cpf_cli = @valor and a.cpf_cli = @valor;";
            }
            else if (rdbMatricula.Checked)
            {
                strSQL = "select * from t_cliente c join t_aluno a on a.matricula_aluno = @valor and c.cpf_cli = a.cpf_cli;";
            }
            else
            {
                MessageBox.Show("Escolha uma das opções de busca!!!");
                txtboxPesquisa.Clear();
                flag = false;
            }

            try
            {
                if (flag)
                {
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
                            msktextData.Text = Convert.ToString(dr["dtnascimento_aluno"]);
                            txtboxgenero.Text = Convert.ToString(dr["sexo_cli"]);
                            txtBoxNome.Text = Convert.ToString(dr["nome_cli"]);
                            txtboxEmail.Text = Convert.ToString(dr["email_cli"]);
                            msktextData.Text = Convert.ToString(dr["dtnascimento_cli"]);
                            txtboxgenero.Text = Convert.ToString(dr["sexo_cli"]);
                            txtBoxCPF.Text = Convert.ToString(dr["cpf_cli"]);
                            DDD = Convert.ToString(dr["dddcel_cli"]);
                            numero = Convert.ToString(dr["numerocel_cli"]);
                            txtboxtelefone.Text = DDD + numero;
                        }
                        MessageBox.Show("Encontrado");
                    }
                    else
                    {
                        MessageBox.Show("Não encontrado");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
