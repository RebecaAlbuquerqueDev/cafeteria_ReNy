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
    public partial class Form22 : Form
    {
        public Form22()
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
            Form23 tela23 = new Form23();
            tela23.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form24 tela24 = new Form24();
            tela24.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form25 tela25 = new Form25();
            tela25.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form26 tela26 = new Form26();
            tela26.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form27 tela27 = new Form27();
            tela27.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form28 tela28 = new Form28();
            tela28.ShowDialog();
            this.Visible = true;
        }
    }
}
