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
    }
}
