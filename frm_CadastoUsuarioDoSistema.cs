using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JanelasMDI
{
    public partial class frm_CadastoUsuarioDoSistema : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQl;
        string senhacript;

        Criptografia cp = new Criptografia(SHA256.Create());

        public frm_CadastoUsuarioDoSistema()
        {
            InitializeComponent();
        }

        public void CripDados()
        {
            
            if(txtSenha.Text == txtSenha2.Text)
            {
                senhacript = cp.CriptografarSenha(txtSenha.Text);
                enviarBD();
            }
            else
            {
                MessageBox.Show("As senhas não coincidem!");
            }
        }
        public void enviarBD()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQl = $"INSERT INTO t_usuarios (NomeUsuario,SenhaUsuario,Cargo) values ('{txtBoxNomeUsuario.Text}','{senhacript}','{cmboxCargo.Text}');";

                comando = new MySqlCommand(strSQl, conexao);
                conexao.Open();

                comando.ExecuteNonQuery();

                txtBoxNomeUsuario.Text = "";
                txtSenha.Text = "";
                txtSenha2.Text = "";
                cmboxCargo.Text = "";

                MessageBox.Show("Login Cadastrado com sucesso!","Confirmação",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                

            }
            finally
            {
                conexao.Close();
            }
           
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            CripDados();
        }

        private void ckbExibir_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbExibir.Checked)
            {
                txtSenha.PasswordChar = default;
                txtSenha2.PasswordChar = default;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                txtSenha2.PasswordChar = '*';
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void frm_CadastoUsuarioDoSistema_Load(object sender, EventArgs e)
        {

        }
    }
}
