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
    public partial class Form29 : Form
    {
        public Form29()
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
    }
}
