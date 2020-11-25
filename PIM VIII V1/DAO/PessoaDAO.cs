using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using SistemaMysql;
using SistemaMysql.Entidades;





namespace SistemaMysql.DAO
{
    public class PessoaDAO
    {
        MySqlCommand sql;
        Conexao con = new Conexao();
        
        
        public DataTable Listar()
        {
            try                                                      // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from pessoa", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Pessoas dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("INSERT INTO pessoa (nome, cpf, endereco) values (@Nome, @Cpf, @Endereco)", con.con);
                sql.Parameters.AddWithValue("@Nome", dados.Nome);
                sql.Parameters.AddWithValue("@Cpf", dados.Cpf);
                sql.Parameters.AddWithValue("@Endereco", dados.Endereco);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar" + ex);
                con.FecharConexao();
            }
        }
       

    } 
}
