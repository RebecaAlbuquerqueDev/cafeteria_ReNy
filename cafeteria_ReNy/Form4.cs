﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form5 tela5 = new Form5();
            tela5.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 tela8 = new Form8();
            tela8.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form22 tela22 = new Form22();
            tela22.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formsalada telasalada = new Formsalada();
            telasalada.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formcombos telacombos = new Formcombos();
            telacombos.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formper telaper = new Formper();
            telaper.ShowDialog();
            this.Visible = true;
        }
    }
}
