using SistemaMysql.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaMysql.Entidades;
using SistemaMysql;
using System.Windows.Forms;

namespace SistemaMysql.Model
{
    public class PessoaModel
    {
		public bool tem;
        PessoaDAO dao = new PessoaDAO();      // acessar os metodos de DAO
		public String mensagem = "";
		public DataTable Listar()
        {

			try                                       // Utilizar o try pra caso ocorra o erro ele retorne
			{
				DataTable dt = new DataTable();
				dt = dao.Listar();
				return dt;
			}
			catch (Exception )
			{

				throw;
			}
		}
        public void Cadastrar(Pessoas dados)
        {

            try
            {
                dao.Cadastrar(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar" + ex);
            }
        }


        public void EditarDados(Pessoas dados)
        {
            try
            {
                dao.EditarDados(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar" + ex);
            }
        }

        public void Excluir(Pessoas dados)
        {
            try
            {
                dao.Excluir(dados);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir!" + ex);
            }
        }

        public object Pesquisar(Pessoas dados)
        {
            try                                       
            {
                DataTable dt = new DataTable();
                dt = dao.Pesquisar(dados);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
