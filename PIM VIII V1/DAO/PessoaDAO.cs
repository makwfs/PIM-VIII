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
            try                                                                                                               // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from pessoa", con.con);                                                    // comando para buscar dados no BD
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
                sql = new MySqlCommand("INSERT INTO pessoa (nome, cpf, endereco) values (@Nome, @Cpf, @Endereco)", con.con);  // comando para inserir dados no BD
                sql.Parameters.AddWithValue("@Nome", dados.Nome);
                sql.Parameters.AddWithValue("@Cpf", dados.Cpf);
                sql.Parameters.AddWithValue("@Endereco", dados.Endereco);

                sql = new MySqlCommand("INSERT INTO endereco (logradouro, numero, bairro, cidade, uf, cep) values (@Logradouro, @Numero, @Bairro, @Cidade, @Uf, @Cep)", con.con);
                sql.Parameters.AddWithValue("@Logradouro", dados.Logradouro);
                sql.Parameters.AddWithValue("@Numero", dados.Numero);
                sql.Parameters.AddWithValue("@Bairro", dados.Bairro);
                sql.Parameters.AddWithValue("@Cidade", dados.Cidade);
                sql.Parameters.AddWithValue("@Uf", dados.Uf);
                sql.Parameters.AddWithValue("@Cep", dados.Cep);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar" + ex);
                con.FecharConexao();
            }
        }

        public void EditarDados(Pessoas dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("UPDATE pessoa SET nome = @Nome, Cpf = @Cpf, endereco = @Endereco WHERE id =@Id", con.con); // comando para editar dados no BD
                sql.Parameters.AddWithValue("@Nome", dados.Nome);
                sql.Parameters.AddWithValue("@Cpf", dados.Cpf);
                sql.Parameters.AddWithValue("@Endereco", dados.Endereco);
                sql.Parameters.AddWithValue("@Id", dados.Id);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar" + ex);
                con.FecharConexao();
            }
        }
       

    } 
}
