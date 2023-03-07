using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SistemaDesktop
{
    public partial class frmLinguagens : Form
    {
        public frmLinguagens()
        {
            InitializeComponent();
        }
        string stringConexao = "Data Source=localhost; Initial Catalog = Projeto; User ID =sa ; Password =123456";
        int _codigoLinguagem;
        private void Testeconexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Application.Exit();
            }

        }

        private void CarregarGrid()
        {
            string sql = "select id_linguagem as 'Codigo'," +
                "nome_linguagem as 'Linguagem'," +
                "status_linguagem as 'Status'," +
                "obs_linguagem as 'Observações' from Linguagem";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                adapter.Fill(dt);
                gridPesquisarLinguagem.DataSource = dt;
                gridPesquisarLinguagem.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gridPesquisarLinguagem.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtOBS.Text = "";
            cbostatus.SelectedIndex = -1;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string sql = "insert into Linguagem"+
	                    "(nome_linguagem, status_linguagem, obs_linguagem)"+
                        "values"+
                        "('"+txtNome.Text+"','"+cbostatus.Text+"','"+txtOBS.Text+"')select SCOPE_IDENTITY()";

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
                    MessageBox.Show("Linguagem cadastrada com Sucesso. ID gerado = " + leitura[0].ToString());
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

        private void frmLinguagens_Load(object sender, EventArgs e)
        {
            Testeconexao();
            CarregarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update Linguagem set nome_linguagem = '"+txtNome.Text+ "'," +
                "status_linguagem = '"+cbostatus.Text+ "'," +
                "obs_linguagem = '"+txtOBS.Text+ "'" +
                " where id_linguagem = "+txtID.Text;
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
            CarregarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            txtID.Text = _codigoLinguagem.ToString();
            string sql = "select * from Linguagem where id_linguagem =" + txtID.Text;

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
                    txtNome.Text = leitura[1].ToString();
                    cbostatus.Text = leitura[2].ToString();
                    txtOBS.Text = leitura[3].ToString();
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

        private void btnInativar_Click(object sender, EventArgs e)
        {
            cbostatus.SelectedIndex = 1;
            string sql = "update Linguagem set status_linguagem = '" + cbostatus.Text + "' where id_linguagem = " + txtID.Text;
            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Linguagem Inativada");
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
            CarregarGrid();
        }

        private void gridPesquisarLinguagem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigoLinguagem = int.Parse(gridPesquisarLinguagem.Rows[e.RowIndex].Cells[0].Value.ToString());
            btnPesquisar.PerformClick();
        }
    }
}
