using MySql.Data.MySqlClient;
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
    public partial class Frm_BuscarClientel : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        MySqlDataReader dr;

        public Frm_BuscarClientel()
        {
            InitializeComponent();
        }

        private void Frm_BuscarClientel_Load(object sender, EventArgs e)
        {
            lblNaoEncontrada.Visible = false;
            lblEncontrado.Visible = false;
        }
        private void label10_Click_1(object sender, EventArgs e)
        {

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }
        private void pesquisar()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT * FROM t_cliente WHERE CodigoCli = @codigo OR cpf_cli = @cpf ";
                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@codigo", txtBoxPesquisa.Text);
                comando.Parameters.AddWithValue("@cpf",txtBoxPesquisa.Text);

                conexao.Open();
                dr = comando.ExecuteReader();
            
                if (dr.HasRows)
                {
                    string DDD;
                    string numero;

                    if (dr.Read())
                    {
                        txtboxCodigo.Text = Convert.ToString(dr["CodigoCli"]);
                        mskData.Text = Convert.ToString(dr["dtnascimento_cli"]);
                        txtboxGenero.Text = Convert.ToString(dr["sexo_cli"]);
                        txtboxNome.Text = Convert.ToString(dr["nome_cli"]);
                        txtboxProfissao.Text = Convert.ToString(dr["profissao_cli"]);
                        txtBoxEmail.Text = Convert.ToString(dr["email_cli"]);
                        mskCpf.Text = Convert.ToString(dr["cpf_cli"]);
                        DDD = Convert.ToString(dr["dddcel_cli"]);
                        numero = Convert.ToString(dr["numerocel_cli"]);
                        txtBoxCep.Text = Convert.ToString(dr["cep_cli"]);
                        mskEstado.Text = Convert.ToString(dr["estado_cli"]);
                        txtboxPais.Text = Convert.ToString(dr["pais_cli"]);
                        txtboxCidade.Text = Convert.ToString(dr["cidade_cli"]);
                        txtboxRua.Text = Convert.ToString(dr["rua_cli"]);
                        txtBoxBairro.Text = Convert.ToString(dr["bairro_cli"]);
                        txtBoxNumero.Text = Convert.ToString(dr["numero_cli"]);
                        mskBoxTelefone.Text = DDD + numero;

                    }
                    lblNaoEncontrada.Visible = false;
                    lblEncontrado.Visible = true;
                }
                else
                {
                    lblNaoEncontrada.Visible = true;
                    lblEncontrado.Visible = false;
                    limpar();
                    
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
        private void limpar()
        {
            txtboxCodigo.Clear();
            mskData.Clear();
            txtboxNome.Clear();
            txtboxGenero.Text = "";
            txtBoxCep.Clear();
            txtboxRua.Clear();
            txtBoxBairro.Clear();
            txtBoxNumero.Clear();
            txtboxCidade.Clear();
            mskEstado.Text = "";
            txtboxPais.Clear();
            mskBoxTelefone.Clear();
            txtBoxEmail.Clear();
            mskCpf.Clear();
            txtboxProfissao.Clear();
        }
        private void bloco_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar2_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
