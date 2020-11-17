using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste2.Apresentacao
{
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
        }

        private void PESSOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pESSOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_PIMDataSet);

        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_PIMDataSet.PESSOA'. Você pode movê-la ou removê-la conforme necessário.
            this.pESSOATableAdapter.Fill(this.bD_PIMDataSet.PESSOA);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.pESSOATableAdapter.Fill(this.bD_PIMDataSet.PESSOA);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            this.pESSOATableAdapter.FillByCPF(this.bD_PIMDataSet.PESSOA, "%" + textBox1.Text + "%");
        }
    }
}
