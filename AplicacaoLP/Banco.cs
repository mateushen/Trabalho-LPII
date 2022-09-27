using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AplicacaoLP
{
    public class Banco
    {
        //Busca dados de clientes
        public DataTable DadosClientes()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT idCliente AS ID, nome AS Nome, cpf AS CPF, telefone AS Telefone FROM Cliente";

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Busca dados de motos
        public DataTable DadosMotos()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT idMoto AS ID, placa AS Placa, marca AS Marca, modelo AS Modelo, valor AS Valor FROM Moto";

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
                
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Busca dados de pagamentos
        public DataTable DadosPagamentos()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT idPagamento AS ID, tipo_pagamento AS Tipo FROM Pagamento";

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Busca dados de vendas
        public DataTable DadosVendas()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Venda";

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable DadosVendedor()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Vendedor";

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable DetalhesCliente()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT idCliente, nome FROM Cliente";

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable DetalhesPagamento()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Pagamento";

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable DetalhesMoto()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT idMoto, placa, modelo FROM Moto";

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable DetalhesVendedor()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT idVendedor, usuario FROM Vendedor";

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
