using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_BuscarAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
        private void pesquisarAluno()
        {
            try
            {
                //select * from t_cliente c join t_aluno a on c.CodigoCli = a.codigo_cliente;

                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT * FROM t_cliente WHERE CodigoCli = @codigo OR cpf_cli = @cpf ";
                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@codigo", txtBoxPesquisa.Text);
                comando.Parameters.AddWithValue("@cpf", txtBoxPesquisa.Text);

                conexao.Open();
                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    string DDD;
                    string numero;

                    if (dr.Read())
                    {
                        txtboxCodigo.Text = Convert.ToString(dr["CodigoCli"]);
                        msktextData.Text = Convert.ToString(dr["dtnascimento_cli"]);
                        txtboxgenero.Text = Convert.ToString(dr["sexo_cli"]);
                        txtBoxNome.Text = Convert.ToString(dr["nome_cli"]);                    
                        txt.Text = Convert.ToString(dr["email_cli"]);
                        txtBoxCPF.Text = Convert.ToString(dr["cpf_cli"]);
                        DDD = Convert.ToString(dr["dddcel_cli"]);
                        numero = Convert.ToString(dr["numerocel_cli"]);                    
                        txtboxtelefone.Text = DDD + numero;

                    }
                    lblNaoEncontrada.Visible = false;
                    lblEncontrado.Visible = true;
                }
                else
                {
                    lblNaoEncontrada.Visible = true;
                    lblEncontrado.Visible = false;
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
        private void pesquisar()
        {
           
        }
    }
}
