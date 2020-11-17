namespace Teste2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bDPIMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_PIMDataSet = new Teste2.BD_PIMDataSet();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbLogradouro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbUf = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbDDD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbNumTel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.Pessoa = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbCep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.pESSOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pESSOATableAdapter = new Teste2.BD_PIMDataSetTableAdapters.PESSOATableAdapter();
            this.pESSOATELEFONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pESSOA_TELEFONETableAdapter = new Teste2.BD_PIMDataSetTableAdapters.PESSOA_TELEFONETableAdapter();
            this.tELEFONETIPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tELEFONE_TIPOTableAdapter = new Teste2.BD_PIMDataSetTableAdapters.TELEFONE_TIPOTableAdapter();
            this.eNDERECOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNDERECOTableAdapter = new Teste2.BD_PIMDataSetTableAdapters.ENDERECOTableAdapter();
            this.pESSOATELEFONEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pESSOABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDERECODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPIMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PIMDataSet)).BeginInit();
            this.Pessoa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOATELEFONEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONETIPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNDERECOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOATELEFONEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(62, 29);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(194, 20);
            this.txbNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(537, 72);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(537, 43);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(537, 130);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(537, 101);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.eNDERECODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pESSOABindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 162);
            this.dataGridView1.TabIndex = 3;
            // 
            // bDPIMDataSetBindingSource
            // 
            this.bDPIMDataSetBindingSource.DataSource = this.bD_PIMDataSet;
            this.bDPIMDataSetBindingSource.Position = 0;
            // 
            // bD_PIMDataSet
            // 
            this.bD_PIMDataSet.DataSetName = "BD_PIMDataSet";
            this.bD_PIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(316, 29);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(170, 20);
            this.txbCpf.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cpf:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Logradouro:";
            // 
            // txbLogradouro
            // 
            this.txbLogradouro.Location = new System.Drawing.Point(94, 31);
            this.txbLogradouro.Name = "txbLogradouro";
            this.txbLogradouro.Size = new System.Drawing.Size(315, 20);
            this.txbLogradouro.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nº";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(444, 32);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(41, 20);
            this.txbNumero.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Bairro:";
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(60, 57);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(142, 20);
            this.txbBairro.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(218, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cidade:";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(279, 58);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(130, 20);
            this.txbCidade.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(415, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "UF:";
            // 
            // txbUf
            // 
            this.txbUf.Location = new System.Drawing.Point(444, 58);
            this.txbUf.Name = "txbUf";
            this.txbUf.Size = new System.Drawing.Size(41, 20);
            this.txbUf.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Telefone:";
            // 
            // txbDDD
            // 
            this.txbDDD.Location = new System.Drawing.Point(116, 33);
            this.txbDDD.Name = "txbDDD";
            this.txbDDD.Size = new System.Drawing.Size(33, 20);
            this.txbDDD.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(81, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "ddd:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(170, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Número:";
            // 
            // txbNumTel
            // 
            this.txbNumTel.Location = new System.Drawing.Point(235, 34);
            this.txbNumTel.Name = "txbNumTel";
            this.txbNumTel.Size = new System.Drawing.Size(130, 20);
            this.txbNumTel.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(371, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Tipo:";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(537, 314);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Pessoa
            // 
            this.Pessoa.Controls.Add(this.txbCpf);
            this.Pessoa.Controls.Add(this.label3);
            this.Pessoa.Controls.Add(this.txbNome);
            this.Pessoa.Controls.Add(this.label2);
            this.Pessoa.Location = new System.Drawing.Point(12, 43);
            this.Pessoa.Name = "Pessoa";
            this.Pessoa.Size = new System.Drawing.Size(502, 57);
            this.Pessoa.TabIndex = 5;
            this.Pessoa.TabStop = false;
            this.Pessoa.Text = "Pessoa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbLogradouro);
            this.groupBox2.Controls.Add(this.txbNumero);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbUf);
            this.groupBox2.Controls.Add(this.txbCep);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txbBairro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbCidade);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 132);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxTipo);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txbDDD);
            this.groupBox3.Controls.Add(this.txbNumTel);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(12, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 87);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato";
            // 
            // txbCep
            // 
            this.txbCep.Location = new System.Drawing.Point(60, 91);
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(142, 20);
            this.txbCep.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cep:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(537, 287);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Celular",
            "Telefone Fixo"});
            this.comboBoxTipo.Location = new System.Drawing.Point(408, 32);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(78, 21);
            this.comboBoxTipo.TabIndex = 11;
            // 
            // pESSOABindingSource
            // 
            this.pESSOABindingSource.DataMember = "PESSOA";
            this.pESSOABindingSource.DataSource = this.bDPIMDataSetBindingSource;
            // 
            // pESSOATableAdapter
            // 
            this.pESSOATableAdapter.ClearBeforeFill = true;
            // 
            // pESSOATELEFONEBindingSource
            // 
            this.pESSOATELEFONEBindingSource.DataMember = "PESSOA_TELEFONE";
            this.pESSOATELEFONEBindingSource.DataSource = this.bDPIMDataSetBindingSource;
            // 
            // pESSOA_TELEFONETableAdapter
            // 
            this.pESSOA_TELEFONETableAdapter.ClearBeforeFill = true;
            // 
            // tELEFONETIPOBindingSource
            // 
            this.tELEFONETIPOBindingSource.DataMember = "TELEFONE_TIPO";
            this.tELEFONETIPOBindingSource.DataSource = this.bDPIMDataSetBindingSource;
            // 
            // tELEFONE_TIPOTableAdapter
            // 
            this.tELEFONE_TIPOTableAdapter.ClearBeforeFill = true;
            // 
            // eNDERECOBindingSource
            // 
            this.eNDERECOBindingSource.DataMember = "ENDERECO";
            this.eNDERECOBindingSource.DataSource = this.bDPIMDataSetBindingSource;
            // 
            // eNDERECOTableAdapter
            // 
            this.eNDERECOTableAdapter.ClearBeforeFill = true;
            // 
            // pESSOATELEFONEBindingSource1
            // 
            this.pESSOATELEFONEBindingSource1.DataMember = "PESSOA_TELEFONE";
            this.pESSOATELEFONEBindingSource1.DataSource = this.bDPIMDataSetBindingSource;
            // 
            // pESSOABindingSource1
            // 
            this.pESSOABindingSource1.DataMember = "PESSOA";
            this.pESSOABindingSource1.DataSource = this.bDPIMDataSetBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // eNDERECODataGridViewTextBoxColumn
            // 
            this.eNDERECODataGridViewTextBoxColumn.DataPropertyName = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.HeaderText = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.Name = "eNDERECODataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(640, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Pessoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPIMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PIMDataSet)).EndInit();
            this.Pessoa.ResumeLayout(false);
            this.Pessoa.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOATELEFONEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONETIPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNDERECOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOATELEFONEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbLogradouro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbUf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbDDD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbNumTel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox Pessoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource bDPIMDataSetBindingSource;
        private BD_PIMDataSet bD_PIMDataSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCep;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.BindingSource pESSOABindingSource;
        private BD_PIMDataSetTableAdapters.PESSOATableAdapter pESSOATableAdapter;
        private System.Windows.Forms.BindingSource pESSOATELEFONEBindingSource;
        private BD_PIMDataSetTableAdapters.PESSOA_TELEFONETableAdapter pESSOA_TELEFONETableAdapter;
        private System.Windows.Forms.BindingSource tELEFONETIPOBindingSource;
        private BD_PIMDataSetTableAdapters.TELEFONE_TIPOTableAdapter tELEFONE_TIPOTableAdapter;
        private System.Windows.Forms.BindingSource eNDERECOBindingSource;
        private BD_PIMDataSetTableAdapters.ENDERECOTableAdapter eNDERECOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pESSOABindingSource1;
        private System.Windows.Forms.BindingSource pESSOATELEFONEBindingSource1;
    }
}

