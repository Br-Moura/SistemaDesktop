namespace SistemaDesktop
{
    partial class frmPesquisarContratante
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
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.gridPesquisarContratante = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisarContratante)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(12, 13);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(599, 26);
            this.txtPesquisar.TabIndex = 0;
            // 
            // gridPesquisarContratante
            // 
            this.gridPesquisarContratante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesquisarContratante.Location = new System.Drawing.Point(12, 46);
            this.gridPesquisarContratante.Name = "gridPesquisarContratante";
            this.gridPesquisarContratante.ReadOnly = true;
            this.gridPesquisarContratante.RowTemplate.Height = 25;
            this.gridPesquisarContratante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesquisarContratante.Size = new System.Drawing.Size(599, 519);
            this.gridPesquisarContratante.TabIndex = 1;
            this.gridPesquisarContratante.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPesquisarContratante_CellDoubleClick);
            // 
            // frmPesquisarContratante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 577);
            this.Controls.Add(this.gridPesquisarContratante);
            this.Controls.Add(this.txtPesquisar);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPesquisarContratante";
            this.Text = "frmPesquisarContratante";
            this.Load += new System.EventHandler(this.frmPesquisarContratante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisarContratante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPesquisar;
        private DataGridView gridPesquisarContratante;
    }
}