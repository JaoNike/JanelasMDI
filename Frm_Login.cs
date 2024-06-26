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
    public partial class Frm_Login : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSQl;
        string senhacript;
        public Frm_Login()
        {
            InitializeComponent();
        }
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            ConexaoBD();
        }
        
        public void criptagora()
        {
            Criptografia c = new Criptografia(SHA256.Create());
            senhacript = c.CriptografarSenha(txtSenha.Text);
       
        }
        public void ConexaoBD()
        {
            criptagora();
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQl = $"SELECT * FROM t_usuarios WHERE NomeUsuario = '{txtLogin.Text}' AND SenhaUsuario = '{senhacript}';";
                comando = new MySqlCommand(strSQl, conexao);
                conexao.Open();
                //comando.Parameters.AddWithValue("@login", txtLogin.Text);
                //comando.Parameters.AddWithValue("@senha", txtSenha.Text);

                comando.ExecuteNonQuery();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    string tipo;
                    string nome;

                    if (dr.Read())
                    {
                        
                        this.Hide();
                       
                        tipo = Convert.ToString(dr["Cargo"]);
                        nome = Convert.ToString(dr["NomeUsuario"]);
                        Frm_Principal principal = new Frm_Principal(tipo,nome);
                        principal.Show();   
                        MessageBox.Show("Login Correto!");
                    }
                }
                else
                {
                    MessageBox.Show("Login errado");
                }

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
        private void ckbExibir_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbExibir.Checked)
            {
                txtSenha.PasswordChar = default;
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }
    }
}
