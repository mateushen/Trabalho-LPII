using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AplicacaoLP
{
    public class Busca
    {
        //Retorna ID do Vendedor
        public int RetornaVendedorID(String usuario)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT idVendedor AS ID FROM Vendedor WHERE usuario = '"+ usuario + "'";

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                String idX = dt.Rows[0]["ID"].ToString();
                int id = Convert.ToInt32(idX);

                con.Close();
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna ID do Cliente
        public int RetornaClienteID(String nome)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT idCliente AS ID FROM Cliente WHERE nome = '" + nome + "'";

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                String idX = dt.Rows[0]["ID"].ToString();
                int id = Convert.ToInt32(idX);

                con.Close();
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna ID da Moto
        public int RetornaMotoID(String modelo)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT idMoto AS ID FROM Moto WHERE modelo = '" + modelo + "'";

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                String idX = dt.Rows[0]["ID"].ToString();
                int id = Convert.ToInt32(idX);

                con.Close();
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna ID do Pagamento
        public int RetornaPagamentoID(String tipo)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT idPagamento AS ID FROM Pagamento WHERE tipo_pagamento = '" + tipo + "'";

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                String idX = dt.Rows[0]["ID"].ToString();
                int id = Convert.ToInt32(idX);

                con.Close();
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna NOME do Vendedor
        public DataTable RetornaVendedorNome(int id)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT usuario FROM Vendedor WHERE idVendedor = '" + id + "'";

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

        //Retorna NOME do Cliente
        public DataTable RetornaClienteNome(int id)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT nome FROM Cliente WHERE idCliente = '" + id + "'";

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

        //Retorna MODELO da Moto
        public DataTable RetornaMotoModelo(int id)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT modelo FROM Moto WHERE idMoto = '" + id + "'";

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

        //Retorna TIPO do Pagamento
        public DataTable RetornaPagamentoTipo(int id)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT tipo_pagamento AS tipo FROM Pagamento WHERE idPagamento = '" + id + "'";

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
