using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AplicacaoLP
{
    public partial class FormPrincipal : Form
    {
        DataTable vendedor = new DataTable();
        DataTable cliente = new DataTable();
        DataTable moto = new DataTable();
        DataTable pagamento = new DataTable();
        Venda v = new Venda();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            DesativaComboBox();
            btnSalvarVenda.Enabled = false;
        }

        private void DesativaComboBox()
        {
            cbxVendedor.Enabled = false;
            cbxCliente.Enabled = false;
            cbxMoto.Enabled = false;
            cbxPgto.Enabled = false;
        }

        private void AtivaComboBox()
        {
            cbxVendedor.Enabled = true;
            cbxCliente.Enabled = true;
            cbxMoto.Enabled = true;
            cbxPgto.Enabled = true;
        }

        private void LimpaComboBox()
        {
            cbxVendedor.DataSource = null;
            cbxCliente.DataSource = null;
            cbxMoto.DataSource = null;
            cbxPgto.DataSource = null;
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            FormCliente fc = new FormCliente();
            fc.Show();
        }

        private void btnAdicionarMoto_Click(object sender, EventArgs e)
        {
            FormMoto fm = new FormMoto();
            fm.Show();
        }

        private void btnAdicionarPgto_Click(object sender, EventArgs e)
        {
            FormPagamento fp = new FormPagamento();
            fp.Show();
        }

        private void btnAdicionarVendedor_Click(object sender, EventArgs e)
        {
            FormVendedor f = new FormVendedor();
            f.Show();
            this.Hide();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            AtivaComboBox();
            LimpaComboBox();

            cbxVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMoto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPgto.DropDownStyle = ComboBoxStyle.DropDownList;

            btnAdicionarCliente.Enabled = false;
            btnAdicionarMoto.Enabled = false;
            btnAdicionarPgto.Enabled = false;
            btnAdicionarVendedor.Enabled = false;
            btnMostrarVendas.Enabled = false;
            btnNovaVenda.Enabled = false;
            btnSalvarVenda.Enabled = true;

            Banco banco = new Banco();
            vendedor = banco.DetalhesVendedor();
            cliente = banco.DetalhesCliente();
            moto = banco.DetalhesMoto();
            pagamento = banco.DetalhesPagamento();

            cbxVendedor.DisplayMember = "usuario";
            cbxVendedor.DataSource = vendedor;

            cbxCliente.DisplayMember = ("nome");
            cbxCliente.DataSource = cliente;

            cbxMoto.DisplayMember = "modelo";
            cbxMoto.DataSource = moto;

            cbxPgto.DisplayMember = "tipo_pagamento";
            cbxPgto.DataSource = pagamento;

            btnCancelar.Enabled = true;
        }

        private void btnSalvarVenda_Click(object sender, EventArgs e)
        {
            Busca dados = new Busca();
            Banco banco = new Banco();
            DataTable venda = new DataTable();
            venda = banco.DadosVendas();
            String idX;
            int id=0;
            bool verif = true;
            try
            {
                if (venda.Rows.Count > 0)
                {
                    for (int i = 0; i <= moto.Rows.Count-1; i++)
                    {
                        idX = moto.Rows[i]["idMoto"].ToString();
                        id = Convert.ToInt32(idX);

                        if (Conexao.VerificaMotoVendida(id))
                        {
                            String vendedorSel = cbxVendedor.Text;
                            String clienteSel = cbxCliente.Text;
                            String motoSel = cbxMoto.Text;
                            String pgtoSel = cbxPgto.Text;

                            int idVendedor = dados.RetornaVendedorID(vendedorSel);
                            int idCliente = dados.RetornaClienteID(clienteSel);
                            int idMoto = dados.RetornaMotoID(motoSel);
                            int idPagamento = dados.RetornaPagamentoID(pgtoSel);

                            Conexao.SalvarVenda(idVendedor, idCliente, idMoto, idPagamento);
                            verif = true;
                            break;
                        }
                        else
                        {
                            verif = false;
                        }
                    }
                    if(verif == false)
                    {
                        MessageBox.Show("Moto já foi vendida!", "ERRO");
                    }
                }
                else
                {
                    String vendedorSel = cbxVendedor.Text;
                    String clienteSel = cbxCliente.Text;
                    String motoSel = cbxMoto.Text;
                    String pgtoSel = cbxPgto.Text;

                    int idVendedor = dados.RetornaVendedorID(vendedorSel);
                    int idCliente = dados.RetornaClienteID(clienteSel);
                    int idMoto = dados.RetornaMotoID(motoSel);
                    int idPagamento = dados.RetornaPagamentoID(pgtoSel);

                    Conexao.SalvarVenda(idVendedor, idCliente, idMoto, idPagamento);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!");
            }
            finally
            {
                btnAdicionarCliente.Enabled = true;
                btnAdicionarMoto.Enabled = true;
                btnAdicionarPgto.Enabled = true;
                btnAdicionarVendedor.Enabled = true;
                btnMostrarVendas.Enabled = true;
                btnNovaVenda.Enabled = true;
                btnSalvarVenda.Enabled = false;
                btnCancelar.Enabled = false;

                LimpaComboBox();
                DesativaComboBox();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAdicionarCliente.Enabled = true;
            btnAdicionarMoto.Enabled = true;
            btnAdicionarPgto.Enabled = true;
            btnAdicionarVendedor.Enabled = true;
            btnMostrarVendas.Enabled = true;
            btnNovaVenda.Enabled = true;
            btnSalvarVenda.Enabled = false;
            btnCancelar.Enabled = false;

            LimpaComboBox();
            DesativaComboBox();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdicionarVendedor_Click_1(object sender, EventArgs e)
        {
            FormVendedor fv = new FormVendedor();
            fv.Show();
        }

        private void cbxVendedor_DropDown(object sender, EventArgs e)
        {
            cbxVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnMostrarVendas_Click(object sender, EventArgs e)
        {
            FormVenda fv = new FormVenda();
            fv.Show();
        }
    }
}
