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
            if (cbostatus.SelectedIndex == -1)
            {
                txtNome.Enabled = true;
                txtOBS.Enabled = true;
                btnInativar.Text = "Inativar/Ativar";
            }

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
            InativarAtivar();
        }
        private void InativarAtivar()
        {
            if (cbostatus.SelectedIndex == 0)
            {
                txtNome.Enabled = true;
                txtOBS.Enabled = true;
                btnInativar.Text = "Inativar";
            }
            else if (cbostatus.SelectedIndex == 1)
            {
                txtNome.Enabled = false;
                txtOBS.Enabled = false;
                btnInativar.Text = "Ativar";
            }
        }
        private void frmLinguagens_Load(object sender, EventArgs e)
        {
            Testeconexao();
            CarregarGrid();
            InativarAtivar();
            btnInativar.Enabled = false;
            btnAlterar.Enabled = false;
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
            InativarAtivar();
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
            btnAlterar.Enabled = true;
            btnInativar.Enabled = true;
            InativarAtivar();

        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            if (cbostatus.SelectedIndex == 0)
            {
                DialogResult result = MessageBox.Show("Você deseja inativar essa linguagem?", "Inativação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
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

                    btnInativar.Text = "Ativar";
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Linguagem não inativada");
                }
            }
            else if (cbostatus.SelectedIndex == 1)
            {
                DialogResult result = MessageBox.Show("Você deseja ativar essa linguagem?", "Inativação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cbostatus.SelectedIndex = 0;
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
                            MessageBox.Show("Linguagem Ativada");
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

                    btnInativar.Text = "Inativar";
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Linguagem não aitivada");
                }
            }
            InativarAtivar();
            CarregarGrid();

        }

        private void gridPesquisarLinguagem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigoLinguagem = int.Parse(gridPesquisarLinguagem.Rows[e.RowIndex].Cells[0].Value.ToString());
            btnPesquisar.PerformClick();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
    }
}
