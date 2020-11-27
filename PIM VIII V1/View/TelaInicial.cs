using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMysql.View
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnCadastrarInicial_Click(object sender, EventArgs e)
        {
            FormPrincipal form = new FormPrincipal();
            form.Show();
        }

        private void btnPesquisarInicial_Click(object sender, EventArgs e)
        {
            TelaConsultar form = new TelaConsultar();
            form.Show();


        }

        private void btnEditarInicial_Click(object sender, EventArgs e)
        {
            Editar form = new Editar();
            form.Show();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
