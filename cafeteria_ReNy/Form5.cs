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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 tela6 = new Form6();
            tela6.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CafeteriaReny7 tela7 = new CafeteriaReny7();
            tela7.ShowDialog();
            this.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form11 tela11 = new Form11();
            tela11.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form12 tela12 = new Form12();
            tela12.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form13 tela13 = new Form13();
            tela13.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form14 tela14 = new Form14();
            tela14.ShowDialog();
            this.Visible = true;
        }
    }
}
