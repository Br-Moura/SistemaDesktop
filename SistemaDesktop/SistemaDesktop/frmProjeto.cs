using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaDesktop
{
    public partial class frmProjeto : Form
    {
        public frmProjeto()
        {
            InitializeComponent();
        }
        string stringConexao = "Data Source=localhost; Initial Catalog = Projeto; User ID =sa ; Password =123456";
        public string IDFree;
        private void CarregarCombo()
        {
            string sql = "select id_freelancer, nome_freelancer from Freelancer";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    dt.Load(leitura);
                    cboIDFreelancer.DisplayMember = "id_freelancer";
                    cboIDFreelancer.DataSource = dt;

                    cboNomeFreelancer.DisplayMember = "nome_freelancer";
                    cboNomeFreelancer.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void InativarAtivar()
        {
            if (cboStatusProjeto.SelectedIndex == 0)
            {
                txtNomeProjeto.Enabled = true;
                cboVersaoProjeto.Enabled = true;
                txtOBS.Enabled = true;
                cboStatusProjeto.Enabled = true;
                btnAdicionar.Enabled = true;
                btnAlterar.Enabled = true;
                btnInativar.Enabled=true;
                btnInativar.Text = "Inativar";
            }
            else if (cboStatusProjeto.SelectedIndex == 1)
            {
                txtNomeProjeto.Enabled = false;
                cboVersaoProjeto.Enabled = false;
                txtOBS.Enabled = false;
                cboStatusProjeto.Enabled = false;
                btnAdicionar.Enabled = false;
                btnAlterar.Enabled = false;
                btnInativar.Enabled = true;
                btnInativar.Text = "Ativar";
            }
        }

        private void frmProjeto_Load(object sender, EventArgs e)
        {
            CarregarCombo();
            InativarAtivar();
            
        }

        private void btnPesquisarFreelancer_Click(object sender, EventArgs e)
        {
            frmPesquisarFreelancerProjeto frmPesquisarFree = new frmPesquisarFreelancerProjeto();
            frmPesquisarFree.ShowDialog();
            cboIDFreelancer.Text = frmPesquisarFree._codigoFreelancer.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string sql = "insert into Projeto"+
                        "(id_freelancer_projeto, nome_projeto, versao_projeto, status_projeto, obs_projeto)"+
                        "values"+
                        "("+cboIDFreelancer.Text+"," +
                        "'"+txtNomeProjeto.Text+"'," +
                        "'"+cboVersaoProjeto.Text+"'," +
                        "'"+cboStatusProjeto.Text+"'," +
                        "'"+txtOBS.Text+"') select SCOPE_IDENTITY()";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    MessageBox.Show("Projeto criado com sucesso");
                    txtIDProjeto.Text = leitura[0].ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            btnPesquisarProjeto.PerformClick();
        }

        private void btnPesquisarProjeto_Click(object sender, EventArgs e)
        {
            if (txtIDProjeto.Text == "")
            {
                frmPesquisarProjetos frmProjetos = new frmPesquisarProjetos();
                frmProjetos.ShowDialog();
                txtIDProjeto.Text = frmProjetos._codigoProjeto.ToString();
                btnPesquisarProjeto.PerformClick();
            }
            else
            {
                string sql = "select * from Projeto where id_projeto = "+ txtIDProjeto.Text;

                SqlConnection conn = new SqlConnection(stringConexao);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader leitura;
                conn.Open();

                try
                {
                    leitura = cmd.ExecuteReader();
                    if (leitura.Read())
                    {
                        cboIDFreelancer.Text = leitura[1].ToString();
                        txtNomeProjeto.Text = leitura[2].ToString();
                        maskData.Text = leitura[3].ToString();
                        cboVersaoProjeto.Text = leitura[4].ToString();
                        cboStatusProjeto.Text = leitura[5].ToString();
                        txtOBS.Text = leitura[6].ToString();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                btnAlterar.Enabled = true;
                btnInativar.Enabled = true;
                InativarAtivar();

            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            cboIDFreelancer.Enabled = false;
            cboNomeFreelancer.Enabled = false;
            btnInativar.Enabled = false;
            btnAlterar.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(IDFree);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update Projeto set id_freelancer_projeto = "+cboIDFreelancer.Text+"," +
                "nome_projeto = '"+txtNomeProjeto.Text+ "'," +
                "versao_projeto = '"+cboVersaoProjeto.Text+ "'," +
                "status_projeto = '"+cboStatusProjeto.Text+ "'," +
                "obs_projeto = '"+txtOBS.Text+"' where id_projeto = " + txtIDProjeto.Text;
            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados altearados com sucesso.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            btnPesquisarProjeto.PerformClick();
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            if (cboStatusProjeto.SelectedIndex == 0)
            {
                DialogResult result = MessageBox.Show("Você deseja inativar esse Projeto?", "Inativação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cboStatusProjeto.SelectedIndex = 1;

                    string sql = "update Projeto set status_projeto = '" + cboStatusProjeto.Text + "' where id_projeto = " + txtIDProjeto.Text;

                    SqlConnection conn = new SqlConnection(stringConexao);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();

                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("Projeto Inativado");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Projeto não foi inativado");
                }
                btnInativar.Text = "Ativar";
            }
            else if(cboStatusProjeto.SelectedIndex == 1)
            {
                DialogResult result = MessageBox.Show("Você deseja ativar esse Projeto?", "Inativação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cboStatusProjeto.SelectedIndex = 0;

                    string sql = "update Projeto set status_projeto = '" + cboStatusProjeto.Text + "' where id_projeto = " + txtIDProjeto.Text;

                    SqlConnection conn = new SqlConnection(stringConexao);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();

                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("Projeto Ativado");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Projeto não foi ativado");
                }
                
                btnInativar.Text = "Inativar";
            }
            InativarAtivar();
            btnPesquisarProjeto.PerformClick();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cboIDFreelancer.SelectedIndex = -1;
            cboNomeFreelancer.SelectedIndex = -1;
            txtIDProjeto.Text = "";
            maskData.Text = "";
            txtNomeProjeto.Text = "";
            cboVersaoProjeto.SelectedIndex = -1;
            cboStatusProjeto.SelectedIndex = -1;
            txtOBS.Text = "";
            if (cboStatusProjeto.SelectedIndex == -1)
            {
                txtNomeProjeto.Enabled = true;
                cboVersaoProjeto.Enabled = true;
                txtOBS.Enabled = true;
                cboStatusProjeto.Enabled = true;
                btnAdicionar.Enabled = true;
                btnInativar.Enabled = false;
                btnAlterar.Enabled = false;
            }
        }

    }
}
