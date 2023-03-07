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
    public partial class frmClienteContratante : Form
    {
        public frmClienteContratante()
        {
            InitializeComponent();
        }

        string stringConexao = "Data Source=localhost; Initial Catalog = Projeto; User ID =sa ; Password =123456";

        private bool Validar()
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Insira o nome") ;
                return false;
            }
            if(maskCNPJ.Text.Trim() == "")
            {
                MessageBox.Show("Erro");
                return false;
            }
            if (maskTelefone1.Text.Trim() == "")
            {
                MessageBox.Show("Insira o Telefone");
                return false;
            }
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Coloque seu login");
                return false;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Isira sua senha");
                return false;
            }
            if(txtSenha.Text == txtConfirmarSenha.Text)
            {
                MessageBox.Show("Confirme sua senha");
                return false;
            }
            if(cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Insira o status");
                return false;
            }
            if (txtLogradouro.Text.Trim() == "")
            {
                MessageBox.Show("Insira o logradouro");
                return false;
            }
            if (maskCEP.Text == "")
            {
                MessageBox.Show("Insira o CEP");
                return false;
            }
            if (txtCidade.Text.Trim()=="")
            {
                MessageBox.Show("Insira a cidade");
                return false;
            }
            if (txtBairro.Text.Trim()=="")
            {
                MessageBox.Show("Indisra o bairro");
                return false;
            }
            if (txtNumeroLocalização.Text.Trim()=="")
            {
                MessageBox.Show("Insira o numero do logradouro");
                return false;
            }
            if (cboUF.SelectedIndex == -1)
            {
                MessageBox.Show("selecione a UF");
                return false;
            }
            return true;
        }   



        private void TesteConn()
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

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoAdicionar_Click(object sender, EventArgs e)
        {
            Validar();

            string sql = "insert into Contratante" +
                        "(nome_contratante, " +
                        "cnpj_contratante, " +
                        "telefone1_contratante, " +
                        "telefone2_contratante, " +
                        "logradouro_contratante, " +
                        "numero_contratante," +
                        "bairro_contratante, " +
                        "cidade_contratante, " +
                        "uf_contratante, " +
                        "cep_contratante, " +
                        "login_contratante, " +
                        "senha_contratante, " +
                        "status_contratante,"+
                        "obs_contratante)" +
                        "values" +
                        "('"+txtNome.Text+"'," +
                        "'"+maskCNPJ.Text+"'," +
                        "'"+maskTelefone1.Text+"'," +
                        "'"+maskTelefone2.Text+"'," +
                        "'"+txtLogradouro.Text+"'," +
                        ""+txtNumeroLocalização.Text+"," +
                        "'"+txtBairro.Text+"'," +
                        "'"+txtCidade.Text+"'," +
                        "'"+cboUF.Text+"'," +
                        "'"+maskCEP.Text+"'," +
                        "'"+txtLogin.Text+"'," +
                        "'"+txtSenha.Text+"'," +
                        "'"+cboStatus.Text+"'," +
                        "'"+txtObs.Text+"')"+
                        "select SCOPE_IDENTITY()";

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
                    MessageBox.Show("Cadastro realizado com sucesso. ID gerado:" + leitura[0].ToString());
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
        //oli
        private void frmClienteContratante_Load(object sender, EventArgs e)
        {
            TesteConn();
        }

        private void btoDeletar_Click(object sender, EventArgs e)
        {

                cboStatus.SelectedIndex = 1;

            string sql = "update Contratante set status_contratante = '" + cboStatus.Text + "' where id_contratante = " + txtIDContratante.Text ;

            SqlConnection conn = new SqlConnection (stringConexao);
            SqlCommand cmd = new SqlCommand (sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Contratante Inativado");
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
            if (cboStatus.SelectedIndex == 0)
            {
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
            }
            else if (cboStatus.SelectedIndex == 1)
            {
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtIDContratante.Text == "")
            {
                frmPesquisarContratante frmPesquisar = new frmPesquisarContratante();
                frmPesquisar.ShowDialog();
                txtIDContratante.Text = frmPesquisar._codigoContratante.ToString();
                btnPesquisar.PerformClick();
            }
            else
            {

                string sql = "select * from Contratante where id_contratante ="+txtIDContratante.Text;

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
                        maskCNPJ.Text = leitura[2].ToString();
                        maskTelefone1.Text = leitura[3].ToString();
                        maskTelefone2.Text = leitura[4].ToString();
                        txtLogradouro.Text = leitura[5].ToString();
                        txtNumeroLocalização.Text = leitura[6].ToString();
                        txtBairro.Text = leitura[7].ToString();
                        txtCidade.Text = leitura[8].ToString();
                        cboUF.Text = leitura[9].ToString();
                        maskCEP.Text = leitura[10].ToString();
                        txtLogin.Text = leitura[11].ToString();
                        txtSenha.Text = leitura[12].ToString();
                        txtConfirmarSenha.Text = leitura[12].ToString();
                        cboStatus.Text = leitura[13].ToString();
                        txtObs.Text = leitura[14].ToString();
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
                if (cboStatus.SelectedIndex == 0)
                {
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                }
                else if (cboStatus.SelectedIndex == 1)
                {
                    groupBox3.Enabled = false;
                    groupBox4.Enabled = false;
                }
            }
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            
            Validar();
            string sql = "update Contratante set nome_contratante = '"+txtNome.Text+ "'," +
                "cnpj_contratante = '"+maskCNPJ.Text+ "'," +
                "telefone1_contratante = '"+maskTelefone1.Text+ "'," +
                "telefone2_contratante = '"+maskTelefone2.Text+ "'," +
                "logradouro_contratante = '"+txtLogradouro.Text+ "'," +
                "numero_contratante = "+txtNumeroLocalização.Text+ ",bairro_contratante = '"+txtBairro.Text+ "'," +
                "cidade_contratante = '"+txtCidade.Text+ "'," +
                "uf_contratante = '"+cboUF.Text+ "'," +
                "cep_contratante = '"+maskCEP.Text+ "'," +
                "login_contratante = '"+txtLogin.Text+ "'," +
                "senha_contratante = '"+txtSenha.Text+ "'," +
                "status_contratante = '"+cboStatus.Text+ "'," +
                "obs_contratante = '"+txtObs.Text+ "' where id_contratante = "+ txtIDContratante.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
               int i = cmd.ExecuteNonQuery();
                if (i == 1 )
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
           
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtConfirmarSenha.Text = "";
            txtIDContratante.Text = "";
            txtLogin.Text = "";
            txtLogradouro.Text = "";
            txtNome.Text = "" ;
            txtSenha.Text = "";
            txtNumeroLocalização.Text = "";
            txtObs.Text = "";
            cboStatus.SelectedIndex = -1;
            cboUF.SelectedIndex = -1;
            maskCEP.Text = "";
            maskCNPJ.Text = "";
            maskTelefone1.Text = "";
            maskTelefone2.Text = "";

        }
    }
}
