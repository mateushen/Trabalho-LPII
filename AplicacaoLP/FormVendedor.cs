using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AplicacaoLP
{
    public partial class FormVendedor : Form
    {
        Vendedor v = new Vendedor();

        public FormVendedor()
        {
            InitializeComponent();
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            AtualizaDataGrid();
            DesativaTextBox();
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void DesativaTextBox()
        {
            tbxUsuario.Enabled = false;
            tbxSenha.Enabled = false;
        }

        private void AtivaTextBox()
        {
            tbxUsuario.Enabled = true;
            tbxSenha.Enabled = true;
        }

        private void LimpaTextBox()
        {
            tbxUsuario.Clear();
            tbxSenha.Clear();
        }

        private void AtualizaDataGrid()
        {
            Banco banco = new Banco();
            DataTable dados = new DataTable();
            dados = banco.DadosVendedor();
            dgvDados.DataSource = dados;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                v.Usuario = tbxUsuario.Text;
                v.Senha = tbxSenha.Text;

                if (Conexao.VerificaVendedor(v.Usuario))
                {
                    Conexao.SalvarVendedor(v.Usuario, v.Senha);
                }
                else
                {
                    MessageBox.Show("Usuário já existe!", "Falha no cadastro");
                }

                AtualizaDataGrid();
                DesativaTextBox();
                LimpaTextBox();
                dgvDados.Enabled = true;
                btnCadastrar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            dgvDados.Enabled = false;
            LimpaTextBox();
            AtivaTextBox();
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = int.Parse(dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[0].Value.ToString());
            tbxUsuario.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();
            tbxSenha.Text = dgvDados.CurrentRow.Cells[2].Value.ToString();

            if (codigo >= 0)
            {
                btnExcluir.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String nome = tbxUsuario.Text;

            try
            {
                Conexao.ExcluirVendedor(nome);

                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = false;
                dgvDados.Enabled = true;
                AtualizaDataGrid();
                LimpaTextBox();
                DesativaTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
        }
    }
}
