namespace SistemaDesktop
{
    partial class frmProjeto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskData = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarProjeto = new System.Windows.Forms.Button();
            this.cboVersaoProjeto = new System.Windows.Forms.ComboBox();
            this.cboStatusProjeto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeProjeto = new System.Windows.Forms.TextBox();
            this.txtOBS = new System.Windows.Forms.TextBox();
            this.txtIDProjeto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboNomeFreelancer = new System.Windows.Forms.ComboBox();
            this.cboIDFreelancer = new System.Windows.Forms.ComboBox();
            this.btnPesquisarFreelancer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnInativar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Versão Projeto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Projeto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data de Criação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome Freelancer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Observações do Projeto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID Freelancer:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskData);
            this.groupBox3.Controls.Add(this.btnPesquisarProjeto);
            this.groupBox3.Controls.Add(this.cboVersaoProjeto);
            this.groupBox3.Controls.Add(this.cboStatusProjeto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNomeProjeto);
            this.groupBox3.Controls.Add(this.txtOBS);
            this.groupBox3.Controls.Add(this.txtIDProjeto);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 327);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Descrição Projeto";
            // 
            // maskData
            // 
            this.maskData.Location = new System.Drawing.Point(380, 54);
            this.maskData.Mask = "00/00/0000 90:00";
            this.maskData.Name = "maskData";
            this.maskData.ReadOnly = true;
            this.maskData.Size = new System.Drawing.Size(103, 26);
            this.maskData.TabIndex = 7;
            this.maskData.ValidatingType = typeof(System.DateTime);
            // 
            // btnPesquisarProjeto
            // 
            this.btnPesquisarProjeto.Location = new System.Drawing.Point(193, 54);
            this.btnPesquisarProjeto.Name = "btnPesquisarProjeto";
            this.btnPesquisarProjeto.Size = new System.Drawing.Size(60, 28);
            this.btnPesquisarProjeto.TabIndex = 1;
            this.btnPesquisarProjeto.Text = "...";
            this.btnPesquisarProjeto.UseVisualStyleBackColor = true;
            this.btnPesquisarProjeto.Click += new System.EventHandler(this.btnPesquisarProjeto_Click);
            // 
            // cboVersaoProjeto
            // 
            this.cboVersaoProjeto.FormattingEnabled = true;
            this.cboVersaoProjeto.Items.AddRange(new object[] {
            "Em andamento",
            "Finalizado",
            "Cancelado",
            "Quebrado"});
            this.cboVersaoProjeto.Location = new System.Drawing.Point(380, 104);
            this.cboVersaoProjeto.Name = "cboVersaoProjeto";
            this.cboVersaoProjeto.Size = new System.Drawing.Size(189, 28);
            this.cboVersaoProjeto.TabIndex = 3;
            // 
            // cboStatusProjeto
            // 
            this.cboStatusProjeto.FormattingEnabled = true;
            this.cboStatusProjeto.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboStatusProjeto.Location = new System.Drawing.Point(263, 54);
            this.cboStatusProjeto.Name = "cboStatusProjeto";
            this.cboStatusProjeto.Size = new System.Drawing.Size(111, 28);
            this.cboStatusProjeto.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nome Projeto:";
            // 
            // txtNomeProjeto
            // 
            this.txtNomeProjeto.Location = new System.Drawing.Point(6, 106);
            this.txtNomeProjeto.Name = "txtNomeProjeto";
            this.txtNomeProjeto.Size = new System.Drawing.Size(368, 26);
            this.txtNomeProjeto.TabIndex = 2;
            // 
            // txtOBS
            // 
            this.txtOBS.Location = new System.Drawing.Point(6, 158);
            this.txtOBS.Multiline = true;
            this.txtOBS.Name = "txtOBS";
            this.txtOBS.Size = new System.Drawing.Size(563, 154);
            this.txtOBS.TabIndex = 6;
            // 
            // txtIDProjeto
            // 
            this.txtIDProjeto.Location = new System.Drawing.Point(6, 54);
            this.txtIDProjeto.Name = "txtIDProjeto";
            this.txtIDProjeto.Size = new System.Drawing.Size(181, 26);
            this.txtIDProjeto.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboNomeFreelancer);
            this.groupBox2.Controls.Add(this.cboIDFreelancer);
            this.groupBox2.Controls.Add(this.btnPesquisarFreelancer);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Freelancer";
            // 
            // cboNomeFreelancer
            // 
            this.cboNomeFreelancer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboNomeFreelancer.FormattingEnabled = true;
            this.cboNomeFreelancer.Location = new System.Drawing.Point(150, 45);
            this.cboNomeFreelancer.Name = "cboNomeFreelancer";
            this.cboNomeFreelancer.Size = new System.Drawing.Size(224, 28);
            this.cboNomeFreelancer.TabIndex = 2;
            // 
            // cboIDFreelancer
            // 
            this.cboIDFreelancer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboIDFreelancer.FormattingEnabled = true;
            this.cboIDFreelancer.Location = new System.Drawing.Point(8, 45);
            this.cboIDFreelancer.Name = "cboIDFreelancer";
            this.cboIDFreelancer.Size = new System.Drawing.Size(136, 28);
            this.cboIDFreelancer.TabIndex = 1;
            // 
            // btnPesquisarFreelancer
            // 
            this.btnPesquisarFreelancer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPesquisarFreelancer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisarFreelancer.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarFreelancer.Location = new System.Drawing.Point(380, 45);
            this.btnPesquisarFreelancer.Name = "btnPesquisarFreelancer";
            this.btnPesquisarFreelancer.Size = new System.Drawing.Size(150, 30);
            this.btnPesquisarFreelancer.TabIndex = 3;
            this.btnPesquisarFreelancer.Text = "Pesquisar Freelancer";
            this.btnPesquisarFreelancer.UseVisualStyleBackColor = false;
            this.btnPesquisarFreelancer.Click += new System.EventHandler(this.btnPesquisarFreelancer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAdicionar);
            this.groupBox4.Controls.Add(this.btnLimpar);
            this.groupBox4.Controls.Add(this.btnInativar);
            this.groupBox4.Controls.Add(this.btnAlterar);
            this.groupBox4.Location = new System.Drawing.Point(12, 476);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(596, 73);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(52, 25);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(120, 30);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar Projeto";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(430, 25);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 30);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnInativar
            // 
            this.btnInativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInativar.ForeColor = System.Drawing.Color.White;
            this.btnInativar.Location = new System.Drawing.Point(304, 25);
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(120, 30);
            this.btnInativar.TabIndex = 2;
            this.btnInativar.Text = "Inativar/Ativar";
            this.btnInativar.UseVisualStyleBackColor = false;
            this.btnInativar.Click += new System.EventHandler(this.btnInativar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(178, 25);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(120, 30);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar Projeto";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 561);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProjeto";
            this.Text = "frmProjeto";
            this.Load += new System.EventHandler(this.frmProjeto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnPesquisarProjeto;
        private ComboBox cboStatusProjeto;
        private Label label8;
        private TextBox txtNomeProjeto;
        private TextBox txtOBS;
        private TextBox txtIDProjeto;
        private GroupBox groupBox2;
        private ComboBox cboNomeFreelancer;
        private ComboBox cboIDFreelancer;
        private Button btnPesquisarFreelancer;
        private GroupBox groupBox4;
        private Button btnAdicionar;
        private Button btnLimpar;
        private Button btnInativar;
        private Button btnAlterar;
        private ComboBox cboVersaoProjeto;
        private MaskedTextBox maskData;
    }
}