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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form9 tela9 = new Form9();
            tela9.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form15 tela15 = new Form15();
            tela15.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form16 tela16 = new Form16();
            tela16.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form17 tela17 = new Form17  ();
            tela17.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form18 tela18 = new Form18();
            tela18.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form19 tela19 = new Form19();
            tela19.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form20 tela20 = new Form20();
            tela20.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form21 tela21 = new Form21();
            tela21.ShowDialog();
            this.Visible = true;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 tela4 = new Form4();
            tela4.ShowDialog();
            this.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formsobre telasobre = new Formsobre();
            telasobre.ShowDialog();
            this.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formmenu telamenu = new Formmenu();
            telamenu.ShowDialog();
            this.Visible = true;
        }
    }
}
