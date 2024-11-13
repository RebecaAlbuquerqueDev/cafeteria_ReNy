using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace cafeteria_ReNy.Model
{
    internal class ClientesDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        public ClientesDAO()
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }

        public void Insert(Clientes clientes)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO Clientes VALUES
          (@NomeCompleto, @CPF, @Email, @Senha, @Estado, @CEP, @Bairro, @Rua, @Ncasa )";

            Command.Parameters.AddWithValue("@NomeCompleto", clientes.NomeCompleto);
            Command.Parameters.AddWithValue("@CPF", clientes.CPF);
            Command.Parameters.AddWithValue("@Email", clientes.Email);
            Command.Parameters.AddWithValue("@Senha", clientes.Senha);
            Command.Parameters.AddWithValue("@Estado", clientes.Estado);
            Command.Parameters.AddWithValue("@CEP", clientes.CEP);
            Command.Parameters.AddWithValue("@Bairro", clientes.Bairro);
            Command.Parameters.AddWithValue("@Rua", clientes.Rua);
            Command.Parameters.AddWithValue("@Ncasa", clientes.Ncasa);

            try
            {
                //Executa query definida acima
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuário " + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }


        }
        public void Update(Clientes clientes)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Clientes SET
          NomeCompleto = @NomeCompleto,
          CPF = @CPF, 
          Email = @Email, 
          Senha = @Senha,
          Estado = @Estado, 
          CEP = @CEP,
          Bairro = @Bairro,
          Rua = @Rua, 
          Ncasa = @Ncasa
          WHERE Codcliente = @Codcliente";

            Command.Parameters.AddWithValue("@NomeCompleto", clientes.NomeCompleto);
            Command.Parameters.AddWithValue("@CPF", clientes.CPF);
            Command.Parameters.AddWithValue("@Email", clientes.Email);
            Command.Parameters.AddWithValue("@Senha", clientes.Senha);
            Command.Parameters.AddWithValue("@Estado", clientes.Estado);
            Command.Parameters.AddWithValue("@CEP", clientes.CEP);
            Command.Parameters.AddWithValue("@Bairro", clientes.Bairro);
            Command.Parameters.AddWithValue("@Rua", clientes.Rua);
            Command.Parameters.AddWithValue("@Ncasa", clientes.Ncasa);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Excluir(int Codcliente)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Clientes WHERE Codcliente = @Codcliente";
            Command.Parameters.AddWithValue("@Codcliente", Codcliente);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Clientes> ListAllClientes()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Clientes";

            List<Clientes> lClientes = new List<Clientes>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Clientes clientes = new Clientes(
                        (int)rd["Codcliente"],
                        (string)rd["NomeCompleto"],
                        (string)rd["CPF"],
                        (string)rd["Email"],
                        (string)rd["Senha"],
                        (string)rd["Estado"],
                        (int)rd["CEP"],
                        (string)rd["Bairro"],
                        (string)rd["Rua"],
                        (int)rd["Ncasa"]
                        );
                    lClientes.Add(clientes);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
            return lClientes;
        }
    }
}
