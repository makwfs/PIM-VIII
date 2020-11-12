using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2.DAL
{
    class conexao
    {
        SqlConnection con = new SqlConnection();
        public conexao() //construtor
        {
            con.ConnectionString = @"Data Source=DESKTOP-9IFV0OT;Initial Catalog=BD_PIMVIII;Integrated Security=True"; // endereço banco de dados
        }

        public SqlConnection Conectar()
        {
            // verificar se o banco de dados já esta conectado e caso nao esteja ira conectar
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            // verificar se o banco de dados já esta conectado caso nao esteja ira desconectar
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}