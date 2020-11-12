using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste2.Modelo;

namespace Teste2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            controle controle = new controle();
            String mensagem = controle.Cadastrar(txbNome.Text, txbCpf.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro Realizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}   

