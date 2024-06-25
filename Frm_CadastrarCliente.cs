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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JanelasMDI
{
    public partial class Frm_CadastrarCliente : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQl;
        DateTime data;
        int nm;
        int nmddd;
        string cpf;

        public Frm_CadastrarCliente()
        {
            InitializeComponent();
        }

        private void Frm_CadastrarCliente_Load(object sender, EventArgs e)
        {

        }
        private string RemoveMask(string mask)
        {
            return Regex.Replace(mask, @"\D", "");
        }
        private void Arruma()
        {
            cpf = RemoveMask(mskCpf.Text);
            nm = int.Parse(RemoveMask(mskBoxTelefone.Text));
            nmddd = int.Parse(RemoveMask(mskTxtDDD.Text));
            data = Convert.ToDateTime(dtnascimento.Text);
        }
        private void cadastrar_()
        {

            conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
            strSQl = $"INSERT INTO t_cliente (nome_cli, sexo_cli, cep_cli, rua_cli, bairro_cli, numero_cli, " +
                $"cidade_cli,estado_cli, pais_cli, dddcel_cli, numerocel_cli, email_cli, dtnascimento_cli, " +
                $"cpf_cli, profissao_cli) VALUES (@nome,@sexo,@cep,@rua,@bairro,@numero,@cidade,@estado,@pais" +
                $",@dddcel,@numerocel,@email,@data,@cpf,@profissao)";

            comando = new MySqlCommand(strSQl, conexao);

            //fazer o if verificando se os campos estão vazios

            try
            {
                Arruma();
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@sexo", cbxGenero.Text);
                comando.Parameters.AddWithValue("@cep", txtBoxCep.Text);
                comando.Parameters.AddWithValue("@rua", txtboxRua.Text);
                comando.Parameters.AddWithValue("@bairro", txtBoxBairro.Text);
                comando.Parameters.AddWithValue("@numero", txtBoxNumero.Text);
                comando.Parameters.AddWithValue("@cidade", txtBoxCidade.Text);
                comando.Parameters.AddWithValue("@estado", CmboxEstado.Text);
                comando.Parameters.AddWithValue("@pais", txtpais.Text);
                comando.Parameters.AddWithValue("@dddcel", nmddd);
                comando.Parameters.AddWithValue("@numerocel", nm);
                comando.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                comando.Parameters.AddWithValue("@data", data);
                comando.Parameters.AddWithValue("@cpf",cpf);
                comando.Parameters.AddWithValue("@profissao", txtProfissao.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro salva!", "Confirmação de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpar();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Joao";
            cbxGenero.Text = "Masculino";
            ////txtBoxCep.Text = "29310374";
            ////txtboxRua.Text = "Seial";
            ////txtBoxBairro.Text = "Algum lugar";
            ////txtBoxNumero.Text = "102";
            ////txtBoxCidade.Text = "cachoeiro de itapemirim";
            ////CmboxEstado.Text = "ES";
            ////txtpais.Text = "Brasil";
            nmddd = 28;
            nm = 999343182;
            txtBoxEmail.Text = "joao@gmail.com";
            mskCpf.Text = "111.111.111-11";
            txtProfissao.Text = "porteiro";
        }
        private void executarBusca()
        {
            string entrada = txtBoxCep.Text;
            int c;

            if (int.TryParse(txtBoxCep.Text, out c) && entrada.Length == 8)
            {
                try
                {
                    BuscaCEP buscaCEP = new BuscaCEP(c);

                    if (string.IsNullOrEmpty(buscaCEP.Cep))
                    {
                        MessageBox.Show("CEP não encontrada. " +
                            "Verifique o número digitado e tente nnovamente.",
                            "CEP Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtboxRua.Text = buscaCEP.Rua;
                        txtBoxCidade.Text = buscaCEP.Cidade;
                        txtBoxBairro.Text = buscaCEP.Bairro;
                        CmboxEstado.Text = buscaCEP.Estado;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o CEP:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Por Favor, insira um CEP válido que contenha apenas 8 números.",
                    "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxCep.Clear();
                txtBoxCep.Focus();
            }
        }

        private void Limpar()
        {
            txtNome.Clear();
            cbxGenero.Text = "";
            txtBoxCep.Clear();
            txtboxRua.Clear();
            txtBoxBairro.Clear();
            txtBoxNumero.Clear();
            txtBoxCidade.Clear();
            CmboxEstado.Text = "";
            txtpais.Clear();
            mskTxtDDD.Clear();
            mskBoxTelefone.Clear();
            txtBoxEmail.Clear();
            mskCpf.Clear();
            txtProfissao.Clear();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrar_();
        }

        private void txtBoxCep_Leave(object sender, EventArgs e)
        {
            executarBusca();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
