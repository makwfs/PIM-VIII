using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMysql.Model;
using System.Data.SqlClient;
using System.Windows.Controls;
using SistemaMysql.Entidades;

namespace SistemaMysql.View
{
    public partial class TelaConsultar : Form
    {
        PessoaModel model = new PessoaModel();
        public TelaConsultar()
        {
            InitializeComponent();
        }

        private void TelaConsultar_Load(object sender, EventArgs e)  // carregar o grid com os dados do BD assim que abrir a tela
        {
            Listar();
        }

        public void Listar()
        {
            try
            {
                grid.DataSource = model.Listar(); // alimentar o grid 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {
            Pessoas dado = new Pessoas();
            Pesquisar(dado);
            if (txbPesquisar.Text == "")                       // Listar caso o campo esteja vazio
            {
                Listar();
                return;
            }

        }

        public void Pesquisar(Pessoas dado)
        {
            try
            {
                dado.Cpf = txbPesquisar.Text;
                grid.DataSource = model.Pesquisar(dado); 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com os dados" + ex.Message);

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Editar form = new Editar();
            form.Show();

        }
    }
}
