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
    public partial class cafeteria : Form
    {
        public cafeteria()
        {
            InitializeComponent();
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Você escreveu");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 tela2 = new Form2();
            tela2.ShowDialog();
            this.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 tela3 = new Form3();
            tela3.ShowDialog();
            this.Visible = true;
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
