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
    public partial class Formdoce : Form
    {
        public Formdoce()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formtortadoce tela23 = new Formtortadoce();
            tela23.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formpanetone tela24 = new Formpanetone();
            tela24.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formcoockies tela25 = new Formcoockies();
            tela25.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formbolo tela26 = new Formbolo();
            tela26.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formmuffins tela27 = new Formmuffins();
            tela27.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formbrownies tela28 = new Formbrownies();
            tela28.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formcc telacc = new Formcc();
            telacc.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formbri telabri = new Formbri();
            telabri.ShowDialog();
            this.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formhome tela4 = new Formhome();
            tela4.ShowDialog();
            this.Visible = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formsobre telasobre = new Formsobre();
            telasobre.ShowDialog();
            this.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formmenu telamenu = new Formmenu();
            telamenu.ShowDialog();
            this.Visible = true;
        }
    }
}
