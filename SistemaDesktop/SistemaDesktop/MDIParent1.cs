using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDesktop
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void contratanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild.GetType().Name != "frmClienteContratante")
                {
                    foreach (Form form in this.MdiChildren)
                    {
                        ActiveMdiChild.Close();
                    }
                    frmClienteContratante frmContratante = new frmClienteContratante();
                    frmContratante.Show();
                    frmContratante.MdiParent = this;
                }
                else
                {
                    MessageBox.Show("Formulário já aberto");
                }
            }
            else
            {
                frmClienteContratante frmContratante = new frmClienteContratante();
                frmContratante.Show();
                frmContratante.MdiParent = this;
            }

            

       

            
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild.GetType().Name != "frmProjeto" )
                {
                    foreach (Form form in this.MdiChildren)
                    {
                        ActiveMdiChild.Close();
                    }
                    frmProjeto frmprojeto = new frmProjeto();
                    frmprojeto.Show();
                    frmprojeto.MdiParent = this;
                }
                else
                {
                    MessageBox.Show("Formulário já aberto");
                }
            }
            else
            {
                frmProjeto frmprojeto = new frmProjeto();
                frmprojeto.Show();
                frmprojeto.MdiParent = this;
            }
            
        }

        private void linguagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild.GetType().Name != "frmLinguagens")
                {
                    foreach (Form form in this.MdiChildren)
                    {
                        ActiveMdiChild.Close();
                    }
                    frmLinguagens frmLinguagem = new frmLinguagens();
                    frmLinguagem.Show();
                    frmLinguagem.MdiParent = this;
                }
                else
                {
                    MessageBox.Show("Formulário já aberto");
                }
            }
            else
            {
                frmLinguagens frmLinguagem = new frmLinguagens();
                frmLinguagem.Show();
                frmLinguagem.MdiParent = this;
            }
        }
    }
}
