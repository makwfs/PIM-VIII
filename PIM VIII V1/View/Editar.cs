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
            txbNome.Text = gridEditar.CurrentRow.Cells[1].Value.ToString();
            txbCpf.Text = gridEditar.CurrentRow.Cells[2].Value.ToString();
            txbEndereco.Text = gridEditar.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
