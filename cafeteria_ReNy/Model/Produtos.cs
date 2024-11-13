using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarqueSeuImovel.Model
{
    internal class Produtos
    {
        public int Id { get; set; }
        public string ProdutoName { get; private set; }
        public string ProdutoPreco { get; private set; }
        public string Categoria { get; private set; }



        public Produtos (int id, string ProdutoName, string ProdutoPreco, string categoria
           ) : this(ProdutoName, ProdutoPreco, categoria )
        {
            Id = id;
        }

        public Produtos (string produtoName, string produtoPreco, string categoria )
        {
            ProdutoName = produtoName;
            ProdutoPreco  = produtoPreco;
            Categoria = categoria;
            
        }
    }
}
