using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeteria_ReNy.Model
{
    internal class Itens
    {
       private int v1;
       private string v2;
       private float v3;
       private string v4;

        public int Id { get; set; }
        public string ProdutoName { get; private set; }
        public float ProdutoPreco { get; private set; }
        public string Categoria { get; private set; }



        public Itens (int id, string ProdutoName, float  ProdutoPreco, string categoria
           ) : this(ProdutoName, ProdutoPreco, categoria )
        {
            Id = id;
        }

        public Itens (string produtoName, float  produtoPreco, string categoria )
        {
            ProdutoName = produtoName;
            ProdutoPreco  = produtoPreco;
            Categoria = categoria;
            
        }

       public Produtos(int v1, string v2, float v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }
    }
}
