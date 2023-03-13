namespace SistemaDesktop
{
    partial class frmPesquisarFreelancerProjeto
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
            this.gridPesquisarFreelancer = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisarFreelancer)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPesquisarFreelancer
            // 
            this.gridPesquisarFreelancer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesquisarFreelancer.Location = new System.Drawing.Point(12, 45);
            this.gridPesquisarFreelancer.Name = "gridPesquisarFreelancer";
            this.gridPesquisarFreelancer.ReadOnly = true;
            this.gridPesquisarFreelancer.RowTemplate.Height = 25;
            this.gridPesquisarFreelancer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesquisarFreelancer.Size = new System.Drawing.Size(599, 519);
            this.gridPesquisarFreelancer.TabIndex = 3;
            this.gridPesquisarFreelancer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPesquisarContratante_CellDoubleClick);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(12, 12);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(599, 26);
            this.txtPesquisar.TabIndex = 2;
            // 
            // frmPesquisarFreelancerProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 577);
            this.Controls.Add(this.gridPesquisarFreelancer);
            this.Controls.Add(this.txtPesquisar);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPesquisarFreelancerProjeto";
            this.Text = "frmPesquisarFreelancerProjeto";
            this.Load += new System.EventHandler(this.frmPesquisarFreelancerProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisarFreelancer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridPesquisarFreelancer;
        private TextBox txtPesquisar;
    }
}