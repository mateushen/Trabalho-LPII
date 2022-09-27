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
    public class Conexao
    {
    //CRUD Cliente
    public static void SalvarCliente(String nome, String cpf, String telefone)
    {
        try
        {
            MySqlConnection con = new MySqlConnection(SQLConn.strConn);
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Cliente(nome, cpf, telefone) " +
                "VALUES(@nome, @cpf, @telefone)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.ExecuteNonQuery();
            con.Close();
                MessageBox.Show("SALVO!!!");
            }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public static void EditarCliente(int id, String nome, String cpf, String telefone)
    {
        try
        {
            MySqlConnection con = new MySqlConnection(SQLConn.strConn);
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE Cliente SET " +
                "nome = @nome, cpf = @cpf, telefone = @telefone " +
                "WHERE idCliente = @id";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ATUALIZADO!");
            }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public static void ExcluirCliente(int id)
    {
        try
        {
            MySqlConnection con = new MySqlConnection(SQLConn.strConn);
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM Cliente WHERE idCliente = @id";

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("DELETADO!");
            }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

        //CRUD Moto
        public static void SalvarMoto(String placa, String marca, String modelo, double valor)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Moto(placa, marca, modelo, valor) " +
                    "VALUES(@placa, @marca, @modelo, @valor)";

                cmd.Parameters.AddWithValue("@placa", placa);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SALVO!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void EditarMoto(int id, String placa, String marca, String modelo, double valor)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Moto SET " +
                    "placa = @placa, marca = @marca, modelo = @modelo, valor = @valor " +
                    "WHERE idMoto = @id";

                cmd.Parameters.AddWithValue("@placa", placa);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ATUALIZADO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ExcluirMoto(int id)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Moto WHERE idMoto = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DELETADO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool VerificaMotoVendida(int id)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();

                String strSQL = "SELECT idVenda FROM Venda " +
                    "WHERE idMoto = '" + id + "'";

                DataTable dt = new DataTable();
                MySqlDataAdapter da;

                var cmd = con.CreateCommand();
                cmd.CommandText = (strSQL);

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //CRUD Pagamento
        public static void SalvarPagamento(String tipo)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Pagamento(tipo_pagamento) " +
                    "VALUES(@tipo_pagamento)";

                cmd.Parameters.AddWithValue("@tipo_pagamento", tipo);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SALVO!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ExcluirPagamento(int id)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Pagamento WHERE idPagamento = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DELETADO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //CRUD Vendedor
        public static void SalvarVendedor(String usuario, String senha)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Vendedor(usuario, senha) " +
                    "VALUES(@usuario, @senha)";

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SALVO!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ExcluirVendedor(String nome)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Vendedor WHERE usuario = @usuario";
                cmd.Parameters.AddWithValue("@usuario", nome);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DELETADO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool VerificaVendedor(String usuario)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();

                String strSQL = "SELECT * FROM Vendedor " +
                    "WHERE usuario= '" + usuario + "'";

                DataTable dt = new DataTable();
                MySqlDataAdapter da;

                var cmd = con.CreateCommand();
                cmd.CommandText = (strSQL);

                da = new MySqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                { 
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        //CRUD Venda
        public static void SalvarVenda(int idVendedor, int idCliente, int idMoto, int idPagamento)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Venda (idVendedor, idCliente, idMoto, idPagamento) " +
                    "VALUES(@idVendedor, @idCliente, @idMoto, @idPagamento)";

                cmd.Parameters.AddWithValue("@idVendedor", idVendedor);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                cmd.Parameters.AddWithValue("@idMoto", idMoto);
                cmd.Parameters.AddWithValue("@idPagamento", idPagamento);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SALVO!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ExcluirVenda(int id)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(SQLConn.strConn);
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Venda WHERE idVenda = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DELETADO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

