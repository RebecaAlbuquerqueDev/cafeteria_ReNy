using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeteria_ReNy.Model
{
    internal class clientes

    { 
        public int Codcliente { get; set; }
        public string NomeCompleto { get; set; }
        public float CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Estado { get; set; }
        public int CEP { get; set; }
        public string Bairro { get; set; }
        public string  Rua { get; set; }
        public int Ncasa { get; set; }

        public clientes (int codcliente, string nomecompleto, float cpf, string email, string senha, string estado,
            int cep, string bairro, string rua, int ncasa)
        {
            Codcliente = codcliente;
            NomeCompleto = nomecompleto;
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
