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
                "\n" + textBox2.Text + 
                "\n"+ textBox3.Text + 
                "\n" + txbsenha1.Text + 
                "\n" + txbsenha2.Text + 
                "\n"+comboBox1.Text +
                "\n" + textBox6.Text+ 
                "\n"+ textBox9.Text+
                "\n"+ textBox7.Text+
                "\n"+ textBox8.Text );
           
        }
    }
}
