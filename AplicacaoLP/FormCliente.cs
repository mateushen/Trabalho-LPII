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
    public partial class FormCliente : Form
    {
        Cliente c = new Cliente();

        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            AtualizaDataGrid();

            tbxID.Enabled = false;
            tbxNome.Enabled = false;
            tbxCpf.Enabled = false;
            tbxTelefone.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnSalvarEdicao.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void AtualizaDataGrid()
        {
            Banco banco = new Banco();
            DataTable dados = new DataTable();
            dados = banco.DadosClientes();
            dgvDados.DataSource = dados;
        }

        private void LimpaTextBox()
        {
            tbxID.Clear();
            tbxNome.Clear();
            tbxCpf.Clear();
            tbxTelefone.Clear();
        }

        private void DesativaTextBox()
        {
            tbxNome.Enabled = false;
            tbxCpf.Enabled = false;
            tbxTelefone.Enabled = false;
        }

        private void AtivaTextBox()
        {
            tbxNome.Enabled = true;
            tbxCpf.Enabled = true;
            tbxTelefone.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvarEdicao.Enabled = false;

            dgvDados.Enabled = false;

            AtivaTextBox();
            LimpaTextBox();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            { 
                c.Nome = tbxNome.Text;
                c.Cpf = tbxCpf.Text;
                c.Telefone = tbxTelefone.Text;

                Conexao.SalvarCliente(c.Nome, c.Cpf, c.Telefone);

                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
                AtualizaDataGrid();
                LimpaTextBox();
                DesativaTextBox();
                dgvDados.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnSalvarEdicao.Enabled = false;

            dgvDados.Enabled = true;
            LimpaTextBox();
            DesativaTextBox();
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = int.Parse(dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[0].Value.ToString());
            tbxID.Text = dgvDados.CurrentRow.Cells[0].Value.ToString();
            tbxNome.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();
            tbxCpf.Text = dgvDados.CurrentRow.Cells[2].Value.ToString();
            tbxTelefone.Text = dgvDados.CurrentRow.Cells[3].Value.ToString();

            if(codigo >= 0)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvarEdicao.Enabled = true;

            AtivaTextBox();

            dgvDados.Enabled = false;
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            try
            {
                c.IdCliente = Convert.ToInt32(tbxID.Text);
                c.Nome = tbxNome.Text;
                c.Cpf = tbxCpf.Text;
                c.Telefone = tbxTelefone.Text;

                Conexao.EditarCliente(c.IdCliente, c.Nome, c.Cpf, c.Telefone);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
            finally
            {
                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
                btnSalvarEdicao.Enabled = false;
                dgvDados.Enabled = true;
                AtualizaDataGrid();
                LimpaTextBox();
                DesativaTextBox();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxID.Text);

            try
            {
                Conexao.ExcluirCliente(id);

                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = false;
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
