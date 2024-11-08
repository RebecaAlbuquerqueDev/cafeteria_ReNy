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
    public partial class Formpaodequeijo : Form
    {
        public Formpaodequeijo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formcarrinho tela10 = new Formcarrinho();
            tela10.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formhome tela4 = new Formhome();
            tela4.ShowDialog();
            this.Visible = true;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formsobre telasobre = new Formsobre();
            telasobre.ShowDialog();
            this.Visible = true;
        }
    }
}
