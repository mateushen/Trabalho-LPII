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
    public partial class FormPagamento : Form
    {
        Pagamento p = new Pagamento();

        public FormPagamento()
        {
            InitializeComponent();
            tbxID.Enabled = false;
            tbxTipopgto.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            tbxID.Enabled = false;

            AtualizaDataGrid();

            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void AtualizaDataGrid()
        {
            Banco banco = new Banco();
            DataTable dados = new DataTable();
            dados = banco.DadosPagamentos();
            dgvDados.DataSource = dados;
        }

        private void LimpaTextBox()
        {
            tbxID.Clear();
            tbxTipopgto.Clear();
        }

        private void DesativaTextBox()
        {
            tbxTipopgto.Enabled = false;
        }

        private void AtivaTextBox()
        {
            tbxTipopgto.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;

            dgvDados.Enabled = false;

            AtivaTextBox();
            LimpaTextBox();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                p.Tipo_pagamento = tbxTipopgto.Text;

                Conexao.SalvarPagamento(p.Tipo_pagamento);

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
            LimpaTextBox();
            DesativaTextBox();

            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            dgvDados.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxID.Text);
            try
            {
                Conexao.ExcluirPagamento(id);

                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
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

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = int.Parse(dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[0].Value.ToString());
            tbxID.Text = dgvDados.CurrentRow.Cells[0].Value.ToString();
            tbxTipopgto.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();

            if (codigo > 0)
            {
                btnExcluir.Enabled = true;
            }
        }
    }
}
