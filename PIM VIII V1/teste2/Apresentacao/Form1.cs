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
using Teste2.Apresentacao;

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
            string sql3 = "insert into telefone (numero,ddd,tipo)  VALUES (@numero,@ddd,@tipo)";
            //string sql4 = "insert into pessoa_telefone (pessoa,telefone)  VALUES (@pessoa,@telefone)";
            //string sql5 = "insert into pessoa_telefone (tipo)  VALUES (@tipo)";
            try
            {
                //Cria uma objeto do tipo comando 
                SqlCommand comando = new SqlCommand(sql, conn);
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@nome", this.txbNome.Text));
                comando.Parameters.Add(new SqlParameter("@cpf", this.txbCpf.Text));
                comando.Parameters.Add(new SqlParameter("logradouro", this.txbLogradouro.Text));

                //Inserção de Dados na Tabela Endereço
                SqlCommand inserirTabelaEndereco = new SqlCommand(sql2,conn);
                //Adicionando o valor das textBox nos parametros do inserirTabelaEndereco
                inserirTabelaEndereco.Parameters.Add(new SqlParameter("@logradouro", this.txbLogradouro.Text));
                inserirTabelaEndereco.Parameters.Add(new SqlParameter("@numero", this.txbNumero.Text));
                inserirTabelaEndereco.Parameters.Add(new SqlParameter("@cep", this.txbCep.Text)); 
                inserirTabelaEndereco.Parameters.Add(new SqlParameter("@bairro", this.txbBairro.Text));
                inserirTabelaEndereco.Parameters.Add(new SqlParameter("@cidade", this.txbCidade.Text));
                inserirTabelaEndereco.Parameters.Add(new SqlParameter("@estado", this.txbUf.Text));

               
                //Inserção de Dados na Tabela telefone
                SqlCommand inserirTabelaTelefone = new SqlCommand(sql3, conn);
                //Adicionando o valor das textBox nos parametros do inserirTabelaTelefone
                inserirTabelaTelefone.Parameters.Add(new SqlParameter("@numero",this.txbNumTel.Text));
                inserirTabelaTelefone.Parameters.Add(new SqlParameter("@ddd",this.txbDDD.Text));
                inserirTabelaTelefone.Parameters.Add(new SqlParameter("@tipo",this.comboBoxTipo.Text));
                
                /*
                //Inserção de Dados na Tabela Pessoa_telefone
                SqlCommand inserirTabelaPessoaTelefone = new SqlCommand(sql4, conn);
                //Adicionando o valor das textBox nos parametros do inserirTabelaTelefone
                inserirTabelaPessoaTelefone.Parameters.Add(new SqlParameter("@numero", int.Parse(this.txbNumTel.Text)));
                inserirTabelaPessoaTelefone.Parameters.Add(new SqlParameter("@ddd",int.Parse(this.txbDDD.Text)));
                inserirTabelaPessoaTelefone.Parameters.Add(new SqlParameter("@tipo",int.Parse(this.comboBoxTipo.Text)));
                */
                /*
                //Inserção de Dados na Tabela Pessoa_telefone
                SqlCommand inserirTabelaTelefoneTipo = new SqlCommand(sql5, conn);
                //Adicionando o valor das textBox nos parametros do inserirTabelaTelefone
                inserirTabelaTelefoneTipo.Parameters.Add(new SqlParameter("@tipo", this.comboBoxTipo.Text));
               */
                
                //abre a conexao
                conn.Open();
               
                //executa o comando com os parametros que foram adicionados acima
                comando.ExecuteNonQuery();
                inserirTabelaEndereco.ExecuteNonQuery();
                inserirTabelaTelefone.ExecuteNonQuery();
                //inserirTabelaPessoaTelefone.ExecuteNonQuery();
                //inserirTabelaPessoaTelefone.ExecuteNonQuery();
                //inserirTabelaTelefoneTipo.ExecuteNonQuery();

                //fecha a conexao
                conn.Close();
                
                                
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
       
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PIMDataSet.ENDERECO'. Você pode movê-la ou removê-la conforme necessário.
            this.eNDERECOTableAdapter.Fill(this.bD_PIMDataSet.ENDERECO);
            // TODO: esta linha de código carrega dados na tabela 'bD_PIMDataSet.TELEFONE_TIPO'. Você pode movê-la ou removê-la conforme necessário.
            this.tELEFONE_TIPOTableAdapter.Fill(this.bD_PIMDataSet.TELEFONE_TIPO);
            // TODO: esta linha de código carrega dados na tabela 'bD_PIMDataSet.PESSOA_TELEFONE'. Você pode movê-la ou removê-la conforme necessário.
            this.pESSOA_TELEFONETableAdapter.Fill(this.bD_PIMDataSet.PESSOA_TELEFONE);
            // TODO: esta linha de código carrega dados na tabela 'bD_PIMDataSet.PESSOA'. Você pode movê-la ou removê-la conforme necessário.
            this.pESSOATableAdapter.Fill(this.bD_PIMDataSet.PESSOA);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.txbNome.Text = "";
            this.txbCpf.Text = "";
            this.txbLogradouro.Text = "";
            this.txbNumero.Text = "";
            this.txbBairro.Text = "";
            this.txbCidade.Text = "";
            this.txbUf.Text = "";
            this.txbCep.Text = "";
            this.txbDDD.Text = "";
            this.txbNumTel.Text = "";
            this.comboBoxTipo.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Pesquisar pes = new Pesquisar();
            pes.Show();

        }
    }
}   

