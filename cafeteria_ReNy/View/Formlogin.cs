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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace cafeteria_ReNy
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string email = txbemail.Text;
            string senha = mtbsenha.Text;

            if (email == "rebeca@email.com" && senha == "rebeca123")
            {
                MessageBox.Show("Login efetuado com sucesso!");
                this.Visible = false;
                Formhome tela4 = new Formhome();
                tela4.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos.");



                this.Visible = false;
                Formlogin tela2 = new Formlogin();
                tela2.ShowDialog();
                this.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtbsenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtbsenha.PasswordChar = '*';
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
    }
}
