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
    public partial class Formsobre : Form
    {
        public Formsobre()
        {
            InitializeComponent();
        }

        private void Formsobre_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Formhome tela4 = new Formhome();
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
