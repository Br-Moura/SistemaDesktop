namespace SistemaDesktop
{
    partial class frmClienteContratante
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtIDContratante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoDeletar = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoAdicionar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.maskTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.maskTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.maskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.txtNumeroLocalização = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.maskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtIDContratante);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(458, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(63, 26);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "...";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtIDContratante
            // 
            this.txtIDContratante.Location = new System.Drawing.Point(107, 19);
            this.txtIDContratante.Name = "txtIDContratante";
            this.txtIDContratante.Size = new System.Drawing.Size(345, 26);
            this.txtIDContratante.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Contratante:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btoSair);
            this.groupBox2.Controls.Add(this.btoDeletar);
            this.groupBox2.Controls.Add(this.btoAlterar);
            this.groupBox2.Controls.Add(this.btoLimpar);
            this.groupBox2.Controls.Add(this.btoAdicionar);
            this.groupBox2.Location = new System.Drawing.Point(569, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 312);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(30, 216);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(150, 30);
            this.btoSair.TabIndex = 1;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoDeletar
            // 
            this.btoDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoDeletar.Location = new System.Drawing.Point(30, 94);
            this.btoDeletar.Name = "btoDeletar";
            this.btoDeletar.Size = new System.Drawing.Size(150, 35);
            this.btoDeletar.TabIndex = 0;
            this.btoDeletar.Text = "Inativar";
            this.btoDeletar.UseVisualStyleBackColor = true;
            this.btoDeletar.Click += new System.EventHandler(this.btoDeletar_Click);
            // 
            // btoAlterar
            // 
            this.btoAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoAlterar.Location = new System.Drawing.Point(30, 134);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(150, 35);
            this.btoAlterar.TabIndex = 0;
            this.btoAlterar.Text = "Alterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            this.btoAlterar.Click += new System.EventHandler(this.btoAlterar_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoLimpar.Location = new System.Drawing.Point(30, 175);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(150, 35);
            this.btoLimpar.TabIndex = 0;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoAdicionar
            // 
            this.btoAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoAdicionar.Location = new System.Drawing.Point(30, 53);
            this.btoAdicionar.Name = "btoAdicionar";
            this.btoAdicionar.Size = new System.Drawing.Size(150, 35);
            this.btoAdicionar.TabIndex = 0;
            this.btoAdicionar.Text = "Adicionar";
            this.btoAdicionar.UseVisualStyleBackColor = true;
            this.btoAdicionar.Click += new System.EventHandler(this.btoAdicionar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboStatus);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtSenha);
            this.groupBox3.Controls.Add(this.txtConfirmarSenha);
            this.groupBox3.Controls.Add(this.txtLogin);
            this.groupBox3.Controls.Add(this.maskTelefone2);
            this.groupBox3.Controls.Add(this.maskTelefone1);
            this.groupBox3.Controls.Add(this.maskCNPJ);
            this.groupBox3.Controls.Add(this.txtNome);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 246);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Identificação";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboStatus.Location = new System.Drawing.Point(328, 146);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 28);
            this.cboStatus.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(273, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Status:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(67, 182);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(138, 26);
            this.txtSenha.TabIndex = 1;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(328, 185);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(138, 26);
            this.txtConfirmarSenha.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(62, 149);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(143, 26);
            this.txtLogin.TabIndex = 1;
            // 
            // maskTelefone2
            // 
            this.maskTelefone2.Location = new System.Drawing.Point(273, 112);
            this.maskTelefone2.Mask = "(##)#####-####";
            this.maskTelefone2.Name = "maskTelefone2";
            this.maskTelefone2.Size = new System.Drawing.Size(97, 26);
            this.maskTelefone2.TabIndex = 2;
            // 
            // maskTelefone1
            // 
            this.maskTelefone1.Location = new System.Drawing.Point(88, 112);
            this.maskTelefone1.Mask = "(##)#####-####";
            this.maskTelefone1.Name = "maskTelefone1";
            this.maskTelefone1.Size = new System.Drawing.Size(97, 26);
            this.maskTelefone1.TabIndex = 2;
            // 
            // maskCNPJ
            // 
            this.maskCNPJ.Location = new System.Drawing.Point(59, 77);
            this.maskCNPJ.Mask = "##.###.###/####-##";
            this.maskCNPJ.Name = "maskCNPJ";
            this.maskCNPJ.Size = new System.Drawing.Size(146, 26);
            this.maskCNPJ.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(488, 26);
            this.txtNome.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Confirmar Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Login:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Telefone 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefone 1:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboUF);
            this.groupBox4.Controls.Add(this.txtNumeroLocalização);
            this.groupBox4.Controls.Add(this.txtBairro);
            this.groupBox4.Controls.Add(this.maskCEP);
            this.groupBox4.Controls.Add(this.txtObs);
            this.groupBox4.Controls.Add(this.txtCidade);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtLogradouro);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(760, 219);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Localização";
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cboUF.Location = new System.Drawing.Point(381, 129);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(74, 28);
            this.cboUF.TabIndex = 5;
            // 
            // txtNumeroLocalização
            // 
            this.txtNumeroLocalização.Location = new System.Drawing.Point(248, 129);
            this.txtNumeroLocalização.Name = "txtNumeroLocalização";
            this.txtNumeroLocalização.Size = new System.Drawing.Size(91, 26);
            this.txtNumeroLocalização.TabIndex = 4;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(64, 129);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(112, 26);
            this.txtBairro.TabIndex = 3;
            // 
            // maskCEP
            // 
            this.maskCEP.Location = new System.Drawing.Point(52, 88);
            this.maskCEP.Mask = "####-###";
            this.maskCEP.Name = "maskCEP";
            this.maskCEP.Size = new System.Drawing.Size(62, 26);
            this.maskCEP.TabIndex = 2;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(461, 45);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(285, 148);
            this.txtObs.TabIndex = 1;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(182, 88);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(273, 26);
            this.txtCidade.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cidade:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(345, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "UF:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Bairro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(461, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Observações";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "CEP:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(88, 45);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(367, 26);
            this.txtLogradouro.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Logradouro:";
            // 
            // frmClienteContratante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmClienteContratante";
            this.Text = "CadastroContratante";
            this.Load += new System.EventHandler(this.frmClienteContratante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIDContratante;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox maskCNPJ;
        private TextBox txtNome;
        private Label label8;
        private Button btoSair;
        private Button btoDeletar;
        private Button btoAlterar;
        private Button btoLimpar;
        private Button btoAdicionar;
        private ComboBox cboStatus;
        private Label label16;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private TextBox txtLogin;
        private MaskedTextBox maskTelefone2;
        private MaskedTextBox maskTelefone1;
        private Label label10;
        private Label label9;
        private GroupBox groupBox4;
        private ComboBox cboUF;
        private MaskedTextBox txtNumeroLocalização;
        private TextBox txtBairro;
        private MaskedTextBox maskCEP;
        private TextBox txtObs;
        private TextBox txtCidade;
        private Label label12;
        private Label label15;
        private Label label11;
        private Label label14;
        private Label label13;
        private TextBox txtLogradouro;
        private Label label7;
        private Label label5;
        private Button btnPesquisar;
    }
}