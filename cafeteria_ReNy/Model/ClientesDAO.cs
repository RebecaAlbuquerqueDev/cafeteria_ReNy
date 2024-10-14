using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
                Command.CommandText = @"INSERT INTO clientes VALUES
          (NomeCompleto, @CPF, @Email, @Senha, @Estado, @CEP, @Bairro, @Rua, @Ncasa )";

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
                    throw new Exception("Erro: Problemas ao inserir usuário");
                }
                finally
                {
                    Connect.CloseConnection();
                }


            }
        
    }
}
