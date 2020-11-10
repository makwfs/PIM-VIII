using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste2.DAL;

namespace Teste2.Modelo
{
    public class controle
    {
        public bool tem;
        public string mensagem = "";
        
        public String Cadastrar(String nome, String cpf, String logradouro, String num, String bairro,
            String cidade,String estado,String ddd,String tel, String tipo)
        {
            CadastroDaoComandos cadastro = new CadastroDaoComandos();
            this.mensagem = cadastro.Cadastrar(nome,cpf,logradouro,num,bairro,cidade,estado,ddd,tel,tipo);
            if(cadastro.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
