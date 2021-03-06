﻿using SistemaMysql.View;
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
using System.Data.SqlClient;

namespace SistemaMysql
{
    public partial class FormPrincipal : Form
    {
        PessoaModel model = new PessoaModel();
        

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
            Pessoas dado = new Pessoas();
            Cadastrar(dado);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Cadastrar(Pessoas dados)     // capturando dados dos textbox
        {
            

            try
            {
                dados.Nome = txbNome.Text;
                dados.Cpf = txbCpf.Text;
                dados.Endereco = txbLogradouro.Text;
                dados.Logradouro = txbLogradouro.Text;
                dados.Numero = txbNumeroEndereco.Text;
                dados.Bairro = txbBairro.Text;
                dados.Cidade = txbCidade.Text;
                dados.Uf = txbUf.Text;
                dados.Cep = txbCep.Text;

                model.Cadastrar(dados);
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
            txbLogradouro.Text = "";
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

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }



}
