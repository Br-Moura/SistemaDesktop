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
    public partial class frmPesquisarContratante : Form
    {
        public frmPesquisarContratante()
        {
            InitializeComponent();
        }

        string stringConexao = "Data Source=localhost; Initial Catalog = Projeto; User ID =sa ; Password =123456";
        public int _codigoContratante;
        private void PesquisarContratante()
        {
            string sql = "select id_contratante as 'Codigo'," +
                "nome_contratante as 'Nome Empresa'," +
                "cnpj_contratante as 'CNPJ'," +
                "telefone1_contratante as 'Telefone1'," +
                "telefone2_contratante as 'Telefone 2',"+
                "login_contratante as 'Login'," +
                "status_contratante as 'Status'," +
                "obs_contratante as 'OBS' " +
                "from Contratante where nome_contratante like '%" + txtPesquisar.Text+ "%'";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt =new DataTable();
            conn.Open();
            try
            {
                adapter.Fill(dt);
                gridPesquisarContratante.DataSource = dt;
                gridPesquisarContratante.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gridPesquisarContratante.AutoResizeRow(0,DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
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

        private void frmPesquisarContratante_Load(object sender, EventArgs e)
        {
            PesquisarContratante();
        }

        private void gridPesquisarContratante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigoContratante = int.Parse(gridPesquisarContratante.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.Close();
        }
    }
}