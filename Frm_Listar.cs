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
    public partial class Frm_Listar : Form
    {
        MySqlConnection conexao;
        MySqlDataAdapter da;
        string strSQl;      
        public Frm_Listar(string tp)
        {
            InitializeComponent();       
            if (tp == "cli")
            {
                strSQl = "SELECT * FROM t_cliente";
                lblCadastrados.Text = "Clientes Cadastrados";
            }
            else if (tp == "usu")
            {
                lblCadastrados.Text = "Usuarios Cadastrados";
                strSQl = "SELECT * FROM t_usuarios";
                this.BackColor = Color.White;
                lblCadastrados.ForeColor = Color.Black;
            }
            else if (tp == "alu")
            {
                lblCadastrados.Text = "Alunos Cadastrados";
                strSQl = "SELECT * FROM t_aluno";
            }
        }

        private void Frm_ListarClientes_Load(object sender, EventArgs e)
        {
            listar_clientes();
        }
        private void listar_clientes()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
              
                da = new MySqlDataAdapter(strSQl, conexao);

                conexao.Open();

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgv.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            listar_clientes();
        }
    }
}
