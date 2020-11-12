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
        SqlDataReader dr;

        public String Cadastrar (String nome, String cpf)  // cadastro no BD
        {
            
            cmd.CommandText = "insert into pessoa values (@nome, @cpf);";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@nome",cpf);
            


            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();

            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco de Dados !";
            }

           return mensagem;
        }
    }
}
