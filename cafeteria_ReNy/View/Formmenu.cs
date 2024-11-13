using cafeteria_ReNy.Model;
using MarqueSeuImovel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeteria_ReNy
{
    public partial class Formmenu : Form
    {
        private int Id = -1;
        public Formmenu()
        {
            InitializeComponent();
        }


        private void ClearFields()
        {
            txbid.Clear();
            txbnome.Clear();
            txbcategoria.Clear();
            txbpreco.Clear();
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        private bool ValidateFields()
        {
            if (txbid.Text.Length == 0 || txbpreco.Text.Length == 0)
            {
                MessageBox.Show("Os campos id e preço são obrigatórios", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void UpdateListView()
        {
            lsvprodutos.Items.Clear();

            ProdutosDAO produtosDAO = new ProdutosDAO();
            List<Produtos> produtos1 = produtosDAO.ListAllProdutos();

            //This code part access all brokers received from database and iterate by them.
            foreach (Produtos produtos  in produtos1)
            {
                //Creating a fully line of listview with items from database.
                ListViewItem item = new ListViewItem(produtos.Id.ToString());
                item.SubItems.Add(produtos.ProdutoName);
                item.SubItems.Add(produtos.ProdutoPreco);
                item.SubItems.Add(produtos.Categoria);
                
                //Adding the fully line to the listview.
                lsvprodutos.Items.Add(item);
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (ValidateFields())
            {
                try
                {
                    //Capture inputed text from fields.
                    if (new ProdutosDAO().Insert(new Produtos (
                        int.Parse(txbid.Text), txbnome.Text, txbcategoria.Text,
                        txbpreco.Text)))
                        MessageBox.Show("Produto cadastrado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }


        private void FrmBroker_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void ltvBroker_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = lsvprodutos.FocusedItem.Index;
                Id = int.Parse(lsvprodutos.Items[index].SubItems[0].Text);
                txbid.Text = lsvprodutos.Items[index].SubItems[1].Text;
                txbnome.Text = lsvprodutos.Items[index].SubItems[2].Text;
                txbcategoria.Text = lsvprodutos.Items[index].SubItems[3].Text;
                txbpreco.Text = lsvprodutos.Items[index].SubItems[4].Text;
               

                btnDelete.Visible = true;
                btnUpdate.Visible = true;

            }

            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProdutosDAO produtosDao = new ProdutosDAO();

            DialogResult resultado = MessageBox.Show("Tem certeza" +
            " que deseja excluir?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    produtosDao.Delete(Id);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (ValidateFields())
            {
                try
                {
                    //Capture inputed text from fields.
                    new ProdutosDAO().Update(new Produtos(Id ,
                        int.Parse ( txbid.Text), txbnome.Text,
                        txbcategoria.Text, txbpreco.Text));
                    MessageBox.Show("Produto atualizado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

        
       
        private void Formmenu_Load(object sender, EventArgs e)
        {

        }
        
            
        

        private void label7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formhome tela4 = new Formhome();
            tela4.ShowDialog();
            this.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formsobre telasobre = new Formsobre();
            telasobre.ShowDialog();
            this.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formmenu telamenu = new Formmenu();
            telamenu.ShowDialog();
            this.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
