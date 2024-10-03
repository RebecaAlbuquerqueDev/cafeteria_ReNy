using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeteria_ReNy
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        public void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            int quantidade = (int)numericUpDown1.Value;
            string produto = "Café"; // Substitua com o nome do produto que você deseja adicionar
            decimal preco = 5.00m; // Substitua com o preço do produto que você deseja adicionar

            if (quantidade > 0)
            {
                // Acessar a tela que contém a ListBox
                Form10 telaCarrinho = new Form10();
                listBoxCarrinho

                // Adicione o produto ao carrinho
                telaCarrinho.listBoxCarrinho.Items.Add($"{produto} x{quantidade} - R${preco * quantidade:F2}");
                // Atualize o total do carrinho
                telaCarrinho.labelTotal.Text = $"Total: R${GetTotalCarrinho(telaCarrinho.listBoxCarrinho):F2}";
            }
        }
    }
}
