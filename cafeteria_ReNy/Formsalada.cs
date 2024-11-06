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
    public partial class Formsalada : Form
    {
        public Formsalada()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form10 tela10 = new Form10();
            tela10.ShowDialog();
            this.Visible = true;
        }

        private void label20_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form4 tela4 = new Form4();
            tela4.ShowDialog();
            this.Visible = true;
        }

        private void label18_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Formmenu telamenu = new Formmenu();
            telamenu.ShowDialog();
            this.Visible = true;
        }

        private void label19_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Formsobre telasobre = new Formsobre();
            telasobre.ShowDialog();
            this.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
