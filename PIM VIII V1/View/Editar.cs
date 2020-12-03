using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMysql.Entidades;
using SistemaMysql.Model;
using SistemaMysql.View;


namespace SistemaMysql.View
{
    public partial class Editar : Form
    {
        PessoaModel model = new PessoaModel();

        public Editar()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            try
            {
                gridEditar.DataSource = model.Listar(); // alimentar o grid 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        private void gridEditar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Pegando os dados do grid e jogando nas texbox 
            // O valor contido em Cells[] corresponde as colunas das tabelas
            txbId.Text = gridEditar.CurrentRow.Cells[0].Value.ToString();
            txbNome.Text = gridEditar.CurrentRow.Cells[1].Value.ToString();
            txbCpf.Text = gridEditar.CurrentRow.Cells[2].Value.ToString();
            txbEndereco.Text = gridEditar.CurrentRow.Cells[3].Value.ToString();
            
            
            
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txbId.Text == "")
            {
                MessageBox.Show("Selecione um registro na tabela para prosseguir com a edição!");
                return;
            }
            Pessoas dado = new Pessoas();
            EditarDados(dado);
            Listar();
        }

        public void EditarDados(Pessoas dados)
        {
            try
            {
                dados.Id = Convert.ToInt32(txbId.Text);
                dados.Nome = txbNome.Text;
                dados.Cpf = txbCpf.Text;
                dados.Endereco = txbEndereco.Text;
                dados.Logradouro = txbEndereco.Text;
                dados.Numero = Convert.ToInt32(txbNumeroEndereco);
                dados.Cep = Convert.ToInt32(txbCep);
                dados.Bairro = txbBairro.Text;
                dados.Cidade = txbCidade.Text;
                dados.Uf = txbUf.Text;



                model.EditarDados(dados);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            txbCpf.Text = "";
            txbEndereco.Text = "";
            txbNumeroEndereco.Text = "";
            txbBairro.Text = "";
            txbCidade.Text = "";
            txbUf.Text = "";
            txbCep.Text = "";
            txbNome.Text = "";
            txbDDD.Text = "";
            txbNumeroTel.Text = "";
            cbTipo.Text = "";
        }

        private void btnEcluir_Click(object sender, EventArgs e)
        {
            if (txbId.Text == "")
            {
                MessageBox.Show("Selecione um registro na tabela para Ecluir!");
                return;
            }
            Pessoas dado = new Pessoas();
            Excluir(dado);
            Listar();
        }

        public void Excluir(Pessoas dados) 
        {
            try
            {
                dados.Id = Convert.ToInt32(txbId.Text);
                

                model.Excluir(dados);
                MessageBox.Show("Excluido com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }
    }
}
