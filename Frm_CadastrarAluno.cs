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
            //if (txtNomeCompleto.Text.Equals("") || !mTDdd.MaskCompleted || !mTTel.Text.Equals("") || !mskCpfAluno.MaskCompleted ||
            // !mskCpfClie.MaskCompleted || txtEmail.Text == (""))
            //{
            //    MessageBox.Show("Erro! Algum dos espaços não foram preenchidos");
            //}
            //else
            //{
            //    MessageBox.Show("Aluno cadastrado com sucesso");
            //}
            try
            {

                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "INSERT INTO t_aluno (nome_aluno,dddcel_aluno,numerocel_aluno,email_aluno,dtnascimento_aluno,cpf_aluno,cpf_cli,codigo_cliente) VALUES (@nome,@ddd, @numeroCel, @email, @dtnascimento, @cpfAluno, @fk_cpfCliente,@fk_codigo_cliente)";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@nome", txtBoxNome.Text);
                comando.Parameters.AddWithValue("@ddd", RemoveMask(mskBoxDDD.Text));
                comando.Parameters.AddWithValue("@numeroCel", RemoveMask(mskBoxTelefone.Text));
                comando.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                comando.Parameters.AddWithValue("@dtnascimento", Convert.ToDateTime(dtpDataNas.Text));
                comando.Parameters.AddWithValue("@cpfAluno", RemoveMask(mskBoxCpfAluno.Text));
                comando.Parameters.AddWithValue("@fk_cpfCliente", RemoveMask(mskBoxCpfCliente.Text));
                comando.Parameters.AddWithValue("@fk_codigo_cliente", txtboxCodigo.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

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
