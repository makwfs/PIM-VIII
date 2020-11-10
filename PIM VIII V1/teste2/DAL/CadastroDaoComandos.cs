using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2.DAL
{
    class CadastroDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        conexao con = new conexao();

        public String Cadastrar(String nome, String cpf, String logradouro, String num,
            String bairro, String cidade, String estado, String ddd, String tel,String tipo)  // cadastro no BD
        {
            
            cmd.CommandText = "insert into PESSOA values (@nome, @cpf);";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);

            cmd.CommandText = "insert into ENDERECO values (@logradouro, @num, @bairro, @cidade, @estado);";
            cmd.Parameters.AddWithValue("@logradouro", logradouro);
            cmd.Parameters.AddWithValue("@num", num);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@estado", estado);

            cmd.CommandText = "insert into TELEFONE values (@ddd, @tel,@tipo);";
            cmd.Parameters.AddWithValue("@ddd", ddd);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@tipo", tipo);

            cmd.CommandText = "insert into TELEFONE_TIPO values(@tipo);";
            cmd.Parameters.AddWithValue("@tipo", tipo);


            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Cadastrado com sucesso!";
                
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados";

            }

            return mensagem;
        }
    }
}
