namespace MovimentacaoBancaria
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.cbxConta = new System.Windows.Forms.ComboBox();
            this.cbxOperacao = new System.Windows.Forms.ComboBox();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.btnIncluirCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGravarExtrato = new System.Windows.Forms.Button();
            this.btnExibirExtrato = new System.Windows.Forms.Button();
            this.btnExecOpe = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbContaEspecial = new System.Windows.Forms.RadioButton();
            this.rdbContaComum = new System.Windows.Forms.RadioButton();
            this.btnListarContas = new System.Windows.Forms.Button();
            this.btnIncluirConta = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Conta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Operação:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 338);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 146);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Banco:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 431);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Agência:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 489);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Num. Conta:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(284, 489);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Limite:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(124, 75);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(212, 26);
            this.txtCpf.TabIndex = 14;
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(124, 122);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(390, 26);
            this.txtNome.TabIndex = 15;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 166);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 26);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(108, 134);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(178, 26);
            this.txtValor.TabIndex = 17;
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(124, 426);
            this.txtBanco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(148, 26);
            this.txtBanco.TabIndex = 18;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(366, 426);
            this.txtAgencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(148, 26);
            this.txtAgencia.TabIndex = 19;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(124, 485);
            this.txtConta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(148, 26);
            this.txtConta.TabIndex = 20;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(366, 485);
            this.txtLimite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(148, 26);
            this.txtLimite.TabIndex = 21;
            // 
            // cbxConta
            // 
            this.cbxConta.FormattingEnabled = true;
            this.cbxConta.Location = new System.Drawing.Point(108, 42);
            this.cbxConta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxConta.Name = "cbxConta";
            this.cbxConta.Size = new System.Drawing.Size(289, 28);
            this.cbxConta.TabIndex = 22;
            // 
            // cbxOperacao
            // 
            this.cbxOperacao.FormattingEnabled = true;
            this.cbxOperacao.Location = new System.Drawing.Point(108, 88);
            this.cbxOperacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxOperacao.Name = "cbxOperacao";
            this.cbxOperacao.Size = new System.Drawing.Size(289, 28);
            this.cbxOperacao.TabIndex = 23;
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(106, 49);
            this.cbxCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(390, 28);
            this.cbxCliente.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListarClientes);
            this.groupBox1.Controls.Add(this.btnIncluirCliente);
            this.groupBox1.Location = new System.Drawing.Point(18, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(528, 243);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente:";
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.Location = new System.Drawing.Point(300, 186);
            this.btnListarClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(147, 35);
            this.btnListarClientes.TabIndex = 29;
            this.btnListarClientes.Text = "Listar Clientes";
            this.btnListarClientes.UseVisualStyleBackColor = true;
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // btnIncluirCliente
            // 
            this.btnIncluirCliente.Location = new System.Drawing.Point(117, 186);
            this.btnIncluirCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIncluirCliente.Name = "btnIncluirCliente";
            this.btnIncluirCliente.Size = new System.Drawing.Size(153, 35);
            this.btnIncluirCliente.TabIndex = 28;
            this.btnIncluirCliente.Text = "Incluir Cliente";
            this.btnIncluirCliente.UseVisualStyleBackColor = true;
            this.btnIncluirCliente.Click += new System.EventHandler(this.btnIncluirCliente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGravarExtrato);
            this.groupBox2.Controls.Add(this.cbxOperacao);
            this.groupBox2.Controls.Add(this.btnExibirExtrato);
            this.groupBox2.Controls.Add(this.cbxConta);
            this.groupBox2.Controls.Add(this.btnExecOpe);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(570, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(626, 243);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimentação:";
            // 
            // btnGravarExtrato
            // 
            this.btnGravarExtrato.Location = new System.Drawing.Point(456, 186);
            this.btnGravarExtrato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGravarExtrato.Name = "btnGravarExtrato";
            this.btnGravarExtrato.Size = new System.Drawing.Size(152, 35);
            this.btnGravarExtrato.TabIndex = 30;
            this.btnGravarExtrato.Text = "Gravar Extrato";
            this.btnGravarExtrato.UseVisualStyleBackColor = true;
            // 
            // btnExibirExtrato
            // 
            this.btnExibirExtrato.Location = new System.Drawing.Point(297, 186);
            this.btnExibirExtrato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExibirExtrato.Name = "btnExibirExtrato";
            this.btnExibirExtrato.Size = new System.Drawing.Size(144, 35);
            this.btnExibirExtrato.TabIndex = 29;
            this.btnExibirExtrato.Text = "Exibir Extrato";
            this.btnExibirExtrato.UseVisualStyleBackColor = true;
            // 
            // btnExecOpe
            // 
            this.btnExecOpe.Location = new System.Drawing.Point(108, 186);
            this.btnExecOpe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExecOpe.Name = "btnExecOpe";
            this.btnExecOpe.Size = new System.Drawing.Size(174, 35);
            this.btnExecOpe.TabIndex = 28;
            this.btnExecOpe.Text = "Executar Operação";
            this.btnExecOpe.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbContaEspecial);
            this.groupBox3.Controls.Add(this.rdbContaComum);
            this.groupBox3.Controls.Add(this.btnListarContas);
            this.groupBox3.Controls.Add(this.btnIncluirConta);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbxCliente);
            this.groupBox3.Location = new System.Drawing.Point(18, 285);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(528, 312);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conta Corrente:";
            // 
            // rdbContaEspecial
            // 
            this.rdbContaEspecial.AutoSize = true;
            this.rdbContaEspecial.ForeColor = System.Drawing.Color.Blue;
            this.rdbContaEspecial.Location = new System.Drawing.Point(303, 91);
            this.rdbContaEspecial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbContaEspecial.Name = "rdbContaEspecial";
            this.rdbContaEspecial.Size = new System.Drawing.Size(141, 24);
            this.rdbContaEspecial.TabIndex = 30;
            this.rdbContaEspecial.TabStop = true;
            this.rdbContaEspecial.Text = "Conta Especial";
            this.rdbContaEspecial.UseVisualStyleBackColor = true;
            // 
            // rdbContaComum
            // 
            this.rdbContaComum.AutoSize = true;
            this.rdbContaComum.ForeColor = System.Drawing.Color.Blue;
            this.rdbContaComum.Location = new System.Drawing.Point(134, 91);
            this.rdbContaComum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbContaComum.Name = "rdbContaComum";
            this.rdbContaComum.Size = new System.Drawing.Size(136, 24);
            this.rdbContaComum.TabIndex = 28;
            this.rdbContaComum.TabStop = true;
            this.rdbContaComum.Text = "Conta Comum";
            this.rdbContaComum.UseVisualStyleBackColor = true;
            // 
            // btnListarContas
            // 
            this.btnListarContas.Location = new System.Drawing.Point(300, 257);
            this.btnListarContas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarContas.Name = "btnListarContas";
            this.btnListarContas.Size = new System.Drawing.Size(147, 35);
            this.btnListarContas.TabIndex = 29;
            this.btnListarContas.Text = "Listar Contas";
            this.btnListarContas.UseVisualStyleBackColor = true;
            // 
            // btnIncluirConta
            // 
            this.btnIncluirConta.Location = new System.Drawing.Point(117, 257);
            this.btnIncluirConta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIncluirConta.Name = "btnIncluirConta";
            this.btnIncluirConta.Size = new System.Drawing.Size(153, 35);
            this.btnIncluirConta.TabIndex = 28;
            this.btnIncluirConta.Text = "Incluir Conta";
            this.btnIncluirConta.UseVisualStyleBackColor = true;
            this.btnIncluirConta.Click += new System.EventHandler(this.btnIncluirConta_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 20;
            this.listBoxResultado.Location = new System.Drawing.Point(570, 305);
            this.listBoxResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(624, 284);
            this.listBoxResultado.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 623);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação Bancária";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.ComboBox cbxConta;
        private System.Windows.Forms.ComboBox cbxOperacao;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnListarClientes;
        private System.Windows.Forms.Button btnIncluirCliente;
        private System.Windows.Forms.Button btnGravarExtrato;
        private System.Windows.Forms.Button btnExibirExtrato;
        private System.Windows.Forms.Button btnExecOpe;
        private System.Windows.Forms.Button btnListarContas;
        private System.Windows.Forms.Button btnIncluirConta;
        private System.Windows.Forms.RadioButton rdbContaEspecial;
        private System.Windows.Forms.RadioButton rdbContaComum;
        private System.Windows.Forms.ListBox listBoxResultado;
    }
}

