namespace SistemaDesktop
{
    partial class frmPesquisarProjetos
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
            this.gridPesquisarProjeto = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisarProjeto)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPesquisarProjeto
            // 
            this.gridPesquisarProjeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesquisarProjeto.Location = new System.Drawing.Point(12, 45);
            this.gridPesquisarProjeto.Name = "gridPesquisarProjeto";
            this.gridPesquisarProjeto.ReadOnly = true;
            this.gridPesquisarProjeto.RowTemplate.Height = 25;
            this.gridPesquisarProjeto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesquisarProjeto.Size = new System.Drawing.Size(599, 519);
            this.gridPesquisarProjeto.TabIndex = 5;
            this.gridPesquisarProjeto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPesquisarProjeto_CellDoubleClick);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(12, 12);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(599, 26);
            this.txtPesquisar.TabIndex = 4;
            // 
            // frmPesquisarProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 577);
            this.Controls.Add(this.gridPesquisarProjeto);
            this.Controls.Add(this.txtPesquisar);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPesquisarProjetos";
            this.Text = "frmPesquisarProjetos";
            this.Load += new System.EventHandler(this.frmPesquisarProjetos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisarProjeto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridPesquisarProjeto;
        private TextBox txtPesquisar;
    }
}