using cafeteria_ReNy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cafeteria_ReNy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            string NomeCompleto = txbNome.Text;
            string CPF =  mtbcpf.Text;
            string Email = txbemail.Text;
            string Senha = txbsenha1.Text;
            string Estado = cbestado.Text;
            int CEP = int.Parse (txbcep.Text);
            string Bairro = txbbairro.Text;
            string Rua = txbemail.Text;
            int Ncasa = int.Parse(txbcasa.Text);

            Clientes clientes = new Clientes(NomeCompleto , CPF, Email, Senha, Estado , CEP , Bairro ,Rua , Ncasa );
            ClientesDAO clientesDAO = new ClientesDAO();

            clientesDAO.Insert(clientes);

            string senha1 = txbsenha1.Text;
            string senha2 = txbsenha2.Text;
            if (senha1 == senha2)
            {

                MessageBox.Show(txbNome.Text + " Sua conta foi criada com sucesso!");
                this.Visible = false;
                Form4 tela4 = new Form4();
                tela4.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show( "Erro: As senhas não coincidem!");
            }
             
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txbNome.Text + 
                "\n" + mtbcpf.Text + 
                "\n"+ txbemail.Text + 
                "\n" + txbsenha1.Text + 
                "\n" + txbsenha2.Text + 
                "\n"+cbestado.Text +
                "\n" + txbcep.Text+ 
                "\n"+ txbbairro.Text+
                "\n"+ txbrua.Text+
                "\n"+ txbcasa.Text );
           
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 tela4 = new Form4();
            tela4.ShowDialog();
            this.Visible = true;

        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formsobre telasobre = new Formsobre();
            telasobre.ShowDialog();
            this.Visible = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formmenu telamenu = new Formmenu();
            telamenu.ShowDialog();
            this.Visible = true;
        }
    }
}
