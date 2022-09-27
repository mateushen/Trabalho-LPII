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
    public partial class FormVenda : Form
    {
        int id;
        public FormVenda()
        {
            InitializeComponent();
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            btnExcluir.Enabled = false;

            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            Banco banco = new Banco();
            DataTable dados = new DataTable();
            dados = banco.DadosVendas();
            dgvDados.DataSource = dados;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.ExcluirVenda(id);
                btnExcluir.Enabled = false;
                dgvDados.Enabled = true;
                AtualizaDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = int.Parse(dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[0].Value.ToString());

            id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value.ToString());

            if (codigo >= 0)
            {
                btnExcluir.Enabled = true;
            }
        }
    }
}
