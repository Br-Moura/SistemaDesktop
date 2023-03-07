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

        private void Validar()
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Insira o nome") ;
            }
            if(maskCNPJ.Text.Trim() == "")
            {
                MessageBox.Show("Erro");
            }
            if (maskTelefone1.Text.Trim() == "")
            {
                MessageBox.Show("Insira o Telefone");
            }
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
    }
}
