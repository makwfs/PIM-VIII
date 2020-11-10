using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection(); //

        public Conexao() // construtor
        {
            con.ConnectionString = @"Data Source=DESKTOP-9IFV0OT;Initial Catalog=BD_PIM;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed) // Se a conexao estiver fechada ira abrir a conexao
            {
                con.Open();
            }
            return con;
        }


        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open) // Se a conexao estiver aberta entao ira fechar
            {
                con.Close();
            }
        }
    }
   
}
