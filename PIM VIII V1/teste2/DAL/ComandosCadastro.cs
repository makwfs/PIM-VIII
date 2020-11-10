using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.DAL
{
    class ComandosCadastro
    {
        
        SqlCommand cmd = new SqlCommand();
        conexao con = new conexao();
        SqlDataReader dr;


    }


    public bool verificarLogin(String login, String senha)  // comandos sql para verifcar se existe usuário no banco de dados
    {
        // procurar no banco de dados login e senha
        cmd.CommandText = "select* from logins where email = @login and senha = @senha"; ;
        cmd.Parameters.AddWithValue("@login", login);
        cmd.Parameters.AddWithValue("@senha", senha);


    }
}

