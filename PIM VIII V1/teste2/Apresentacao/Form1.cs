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
            conn.ConnectionString = @"Data Source=DESKTOP-9IFV0OT;Initial Catalog=BD_PIM;Integrated Security=True"; // endereço banco de dados
            //comando de inserção dos dados no BD
            string sql = "insert into pessoa (nome,cpf,logradouro)  VALUES (@nome, @cpf, @logradouro)";
            string sql2 = "insert into endereco (logradouro,numero,cep,bairro,cidade,estado)  VALUES (@logradouro,@numero,@cep,@bairro,@cidade,@estado)";

            try
            {
                //Cria uma objeto do tipo comando 
                SqlCommand comando = new SqlCommand(sql, conn);
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@nome", this.txbNome.Text));
                comando.Parameters.Add(new SqlParameter("@cpf", this.txbCpf.Text));
                comando.Parameters.Add(new SqlParameter("logradouro", this.txbLogradouro.Text));

                //Insere dados na tabela Endereço 
                
                SqlCommand inserirTabelaEndereco = new SqlCommand(sql2, conn);
                //Adicionando o valor das textBox nos parametros do inserirTabelaEndereco
                inserirTabelaEndereco.Parameters.Add(new SqlParameter("@logradouro", this.txbLogradouro.Text));
                inserirTabelaEndereco.Parameters.Add(new SqlParameter("@numero", this.txbNumero.Text));
                inserirTabelaEndereco.Parameters.Add(new SqlParameter("@cep", this.txbCep.Text)); // FAZER TXB CEP NO FORM!!!
                inserirTabelaEndereco.Parameters.Add(new SqlParameter("@bairro", this.txbBairro.Text));
                inserirTabelaEndereco.Parameters.Add(new SqlParameter("@cidade", this.txbCidade.Text));
                inserirTabelaEndereco.Parameters.Add(new SqlParameter("@estado", this.txbUf.Text));

                //abre a conexao
                conn.Open();
               
                //executa o comando com os parametros que foram adicionados acima
                comando.ExecuteNonQuery();
                
                //fecha a conexao
                conn.Close();
                
                //Minha função para limpar os textBox
                LimpaCamos();
                
                // Caso esteja tudo certo exibe a mensagem de cadastrado 
                MessageBox.Show (mensagem,"Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                // Caso ocorra algum erro com o BD informa erro
                MessageBox.Show(mensagem, "Erro com Banco de Dados !", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            finally
            {
                // Fecha a conexão com o BD
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

