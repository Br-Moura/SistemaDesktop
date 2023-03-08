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
    public partial class frmPesquisarProjetos : Form
    {
        public frmPesquisarProjetos()
        {
            InitializeComponent();
        }

        string stringConexao = "Data Source=localhost; Initial Catalog = Projeto; User ID =sa ; Password =123456";
        public int _codigoProjeto;

        
        
        private void PesquisarProjetos()
        {

            string sql = "select id_projeto as 'Codigo do Projeto'," +
                "id_freelancer_projeto as 'Codigo do Freelancer'," +
                "nome_projeto as 'Nome Projeto'," +
                "status_projeto as 'Status do Projeto'," +
                "obs_projeto as 'Observações' from Projeto where nome_projeto like '%" + txtPesquisar.Text +"%'"  ;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                adapter.Fill(dt);
                gridPesquisarProjeto.DataSource = dt;
                gridPesquisarProjeto.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gridPesquisarProjeto.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
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

        private void frmPesquisarProjetos_Load(object sender, EventArgs e)
        {
            PesquisarProjetos();
        }

        private void gridPesquisarProjeto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigoProjeto = int.Parse(gridPesquisarProjeto.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.Close();
        }
    }
}
