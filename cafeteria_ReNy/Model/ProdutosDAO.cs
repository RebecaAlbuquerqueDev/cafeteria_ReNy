using cafeteria_ReNy.Model;
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
        public bool Insert(Itens itens )
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText =
            @"INSERT INTO 
            Itens VALUES 
            (@ProdutoName, @ProdutoPreco, @Categoria)";

            Command.Parameters.AddWithValue("@ProdutoName", itens.ProdutoName);
            Command.Parameters.AddWithValue("@ProdutoPreco", itens.ProdutoPreco);
            Command.Parameters.AddWithValue("@Categoria", itens.Categoria);
           
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


        public void Update(Itens itens)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Itens SET 
            ProdutoName = @produtoName,
            ProdutoPreco = @produtoPreco,
            Categoria = @categoria
            ";

            Command.Parameters.AddWithValue("@id", itens.Id);
            Command.Parameters.AddWithValue("@produtoName", itens.ProdutoName);
            Command.Parameters.AddWithValue("@produtoPreco", itens.ProdutoPreco);
            Command.Parameters.AddWithValue("@produtoPreco", itens.Categoria);


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
            Command.CommandText = @"DELETE FROM Itens 
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
        public List<Itens> ListAllProdutos()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Itens";

            List<Itens> produtos1  = new List<Itens>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Itens item = new Itens(
                        (int)rd["Id"],
                        (string)rd["ProdutoName"],
                        (float)rd["ProdutoPreco"],
                        (string)rd["Categoria"]
                        
                        );
                    produtos1.Add(item);
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

            return produtos1;
        }
        public bool ValidateLogin(Itens item )
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Itens WHERE " +
                                  "ProdutosName = @produtosName AND " +
                                  "ProdutosPreco = @produtosPreco" +
                                  "Categoria = @categoria";
            Command.Parameters.AddWithValue("@brokerCode", item.ProdutoName);
            Command.Parameters.AddWithValue("@password", item.ProdutoPreco);
            Command.Parameters.AddWithValue("@password", item.Categoria);

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
