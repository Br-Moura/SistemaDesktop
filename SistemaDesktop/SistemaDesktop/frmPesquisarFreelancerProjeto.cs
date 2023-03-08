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
    public partial class frmPesquisarFreelancerProjeto : Form
    {
        public frmPesquisarFreelancerProjeto()
        {
            InitializeComponent();
        }

        string stringConexao = "Data Source=localhost; Initial Catalog = Projeto; User ID =sa ; Password =123456";
        public int _codigoFreelancer;


        private void PesquisarFreelancer()
        {
            string sql = "select id_freelancer as 'Codigo'," +
                "nome_freelancer as 'Nome do Freelancer'," +
                "login_freelancer as 'Login do Freelancer'," +
                "status_freelancer as 'Status do Freelancer'," +
                "obs_freelancer as 'Obs do Freelancer' from Freelancer where nome_freelancer like '%" + txtPesquisar.Text + "%'";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                adapter.Fill(dt);
                gridPesquisarFreelancer.DataSource = dt;
                gridPesquisarFreelancer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gridPesquisarFreelancer.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
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

        private void frmPesquisarFreelancerProjeto_Load(object sender, EventArgs e)
        {
            PesquisarFreelancer();
            
        }

        private void gridPesquisarContratante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigoFreelancer = int.Parse(gridPesquisarFreelancer.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.Close();
        }
    }
}
