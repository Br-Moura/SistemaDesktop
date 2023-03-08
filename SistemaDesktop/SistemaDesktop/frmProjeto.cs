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

        private void frmProjeto_Load(object sender, EventArgs e)
        {
            CarregarCombo();
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
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            cboIDFreelancer.Enabled = false;
            cboNomeFreelancer.Enabled = false;
            txtIDProjeto.Enabled = false;
        }
    }
}
