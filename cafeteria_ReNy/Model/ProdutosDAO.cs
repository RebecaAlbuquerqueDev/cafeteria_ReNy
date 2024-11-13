﻿using cafeteria_ReNy;
using MarqueSeuImovel.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeteria_ReNy.Model
{
    internal class ProdutosDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        //Sempre o nome da classe
        public ProdutosDAO() //método construtor
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public bool Insert(Produtos produtos )
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText =
            @"INSERT INTO 
            Produtos VALUES 
            (@ProdutoNameName, @ProdutoPreco)";

            Command.Parameters.AddWithValue("@brokerName", produtos.ProdutoName);
            Command.Parameters.AddWithValue("@brokerCode", produtos.ProdutoPreco);
           
            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "produto no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
            return true;
        }


        public void Update(Produtos produtos)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Produtos SET 
            ProdutoName = @produtoName,
            ProdutoPreco = @produtoPreco,
            ";

            Command.Parameters.AddWithValue("@id", produtos.Id);
            Command.Parameters.AddWithValue("@produtoName", produtos.ProdutoName);
            Command.Parameters.AddWithValue("@produtoPreco", produtos.ProdutoPreco);
          

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: " +
                    "Problemas ao realizar atualização dos dados do " +
                    "corretor no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Delete(int id)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Produtos 
            WHERE Id = @id";
            Command.Parameters.AddWithValue("@id", id );
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir " +
                    "cadastro do corretor do banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Produtos> ListAllProdutos()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM produtos";

            List<Produtos> brokers = new List<Produtos>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Produtos produtos = new produtos (
                        (int)rd["Id"],
                        (string)rd["ProdutoName"],
                        (string)rd["ProdutoPreco"]
                        
                        );
                    produtos.Add(produtos);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar " +
                    "leitura de imóveis no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return brokers;
        }
        public bool ValidateLogin(Produtos produtos )
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Broker WHERE " +
                                  "BrokerCode = @brokerCode AND " +
                                  "Password = @password";
            Command.Parameters.AddWithValue("@brokerCode", produtos.ProdutoName);
            Command.Parameters.AddWithValue("@password", produtos.ProdutoPreco);

            try
            {
                SqlDataReader rd = Command.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Close();
                    return true;
                }
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar " +
                    "leitura de dados do corretor no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return false;
        }
    }
}