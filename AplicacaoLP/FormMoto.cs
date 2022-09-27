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
    public partial class FormMoto : Form
    {
        Moto m = new Moto();

        public FormMoto()
        {
            InitializeComponent();
        }

        private void FormMoto_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            tbxID.Enabled = false;

            AtualizaDataGrid();
            DesativaTextBox();

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
            dados = banco.DadosMotos();
            dgvDados.DataSource = dados;
        }

        private void LimpaTextBox()
        {
            tbxID.Clear();
            tbxPlaca.Clear();
            tbxMarca.Clear();
            tbxModelo.Clear();
            tbxValor.Clear();
        }

        private void DesativaTextBox()
        {
            tbxPlaca.Enabled = false;
            tbxMarca.Enabled = false;
            tbxModelo.Enabled = false;
            tbxValor.Enabled = false;
        }

        private void AtivaTextBox()
        {
            tbxPlaca.Enabled = true;
            tbxMarca.Enabled = true;
            tbxModelo.Enabled = true;
            tbxValor.Enabled = true;
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

            LimpaTextBox();
            AtivaTextBox();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                m.Placa = tbxPlaca.Text;
                m.Marca = tbxMarca.Text;
                m.Modelo = tbxModelo.Text;
                m.Valor = Convert.ToDouble(tbxValor.Text);

                Conexao.SalvarMoto(m.Placa, m.Marca, m.Modelo, m.Valor);

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
            btnSalvarEdicao.Enabled = false;

            dgvDados.Enabled = true;
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            try
            {
                m.IdMoto = Convert.ToInt32(tbxID.Text);
                m.Placa = tbxPlaca.Text;
                m.Marca = tbxMarca.Text;
                m.Modelo = tbxModelo.Text;
                m.Valor = Convert.ToDouble(tbxValor.Text);

                Conexao.EditarMoto(m.IdMoto, m.Placa, m.Marca, m.Modelo, m.Valor);

                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
                btnSalvarEdicao.Enabled = false;

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

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = int.Parse(dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[0].Value.ToString());
            tbxID.Text = dgvDados.CurrentRow.Cells[0].Value.ToString();
            tbxPlaca.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();
            tbxMarca.Text = dgvDados.CurrentRow.Cells[2].Value.ToString();
            tbxModelo.Text = dgvDados.CurrentRow.Cells[3].Value.ToString();
            tbxValor.Text = dgvDados.CurrentRow.Cells[4].Value.ToString();

            if (codigo >= 0)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxID.Text);

            try
            {
                Conexao.ExcluirMoto(id);

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
