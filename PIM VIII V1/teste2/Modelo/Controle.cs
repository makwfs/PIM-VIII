using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste2.DAL;
using System.Windows.Forms;


namespace Teste2.Modelo
{
    public class controle
    {
        public bool tem;
        public string mensagem = "";
        
        public String Cadastrar(String nome, String cpf)
        {
            CadastroDaoComandos cadastro = new CadastroDaoComandos();
            this.mensagem = cadastro.Cadastrar(nome,cpf);
            if(cadastro.tem)
            {
                MessageBox.Show(mensagem, "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            return mensagem;
        }
    }
}
