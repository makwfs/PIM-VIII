using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste2.Modelo;
using System.Data.SqlClient;

namespace Teste2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string mensagem = "";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-9IFV0OT;Initial Catalog=BD_PIMVIII;Integrated Security=True"; // endereço banco de dados
            //definição do comando sql
            string sql = "insert into pessoa (nome,cpf)  VALUES (@nome, @cpf)";
            
    try
            {
                //Cria uma objeto do tipo comando passando como
                
                SqlCommand comando = new SqlCommand(sql, conn);
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@nome", this.txbNome.Text));
                comando.Parameters.Add(new SqlParameter("@cpf", this.txbCpf.Text));
               
                //abre a conexao
                conn.Open();
                //executa o comando com os parametros que foram adicionados acima
                comando.ExecuteNonQuery();
                //fecha a conexao
                conn.Close();
                //Minha função para limpar os textBox
                LimpaCamos();
                //Abaixo temos a ultlização de javascript para apresentar ao usuário um alert
                // referente ao msgbox
                //RegisterClientScriptBlock("cadastrado", "<script> alert(Operação concluida!)</ script > ");
                MessageBox.Show (mensagem,"Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(mensagem, "Nao funfa!", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            finally
            {
                conn.Close();
            }
        }
        private void LimpaCamos()
        {
            this.txbNome.Text = "";
            this.txbCpf.Text = "";
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}   

