using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace cafeteria_ReNy.Model
{
    internal class Clientes

    { 
        public int Codcliente { get; set; }
        public string NomeCompleto { get; set; }
        public string   CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Estado { get; set; }
        public int CEP { get; set; }
        public string Bairro { get; set; }
        public string  Rua { get; set; }
        public int Ncasa { get; set; }

       
        

        public Clientes(int Codclientre ,string nomeCompleto, string  cpf, string email, string senha, string estado, int cep, string bairro, string rua, int ncasa) : 
            this(nomeCompleto, cpf, email, senha, estado, cep, bairro, rua, ncasa)
        {
            Codcliente = Codclientre;
        }
        public Clientes(string nomeCompleto, dynamic cpf, string email, string senha, string estado, int cep, string bairro, string rua, int ncasa)
        {
            NomeCompleto = nomeCompleto;
            CPF = cpf;
            Email = email;
            Senha = senha;
            Estado = estado;
            CEP = cep;
            Bairro = bairro;
            Rua = rua;
            Ncasa = ncasa;
        }
    }
   
}
