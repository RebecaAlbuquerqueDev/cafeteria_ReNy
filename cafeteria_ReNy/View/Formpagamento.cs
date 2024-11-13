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
    public partial class Formpagamento : Form
    {
        public Formpagamento()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            btnok.Visible = false;  
            cbforma.Visible = false;
            lblforma.Visible = false;
            lblmensagem.Visible = true;
            
        }

        private void Form29_Load(object sender, EventArgs e)
        {
            lblmensagem.Visible = false;
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
