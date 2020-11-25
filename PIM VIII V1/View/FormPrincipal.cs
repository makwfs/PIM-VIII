using SistemaMysql.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMysql;
using SistemaMysql.Model;
using SistemaMysql.Entidades;

namespace SistemaMysql
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnPesquisarPrincipal_Click(object sender, EventArgs e)
        {
            TelaConsultar form = new TelaConsultar();
            form.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoas dados = new Pessoas();
            Cadastrar(dados);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Cadastrar(Pessoas dados)     // capturando dados dos textbox
        {
            PessoaModel pessoaModel = new PessoaModel();

            try
            {
                dados.Nome = txbNome.Text;
                dados.Cpf = txbCpf.Text;
                dados.Endereco = txbEndereco.Text;

                pessoaModel.Cadastrar(dados);
                MessageBox.Show("Cliente Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }


    }



}
