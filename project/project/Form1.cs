﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string test = "test3";

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Its working very good!");
        }

        string newTest = "newtestlocal";

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "title ready";
            this.BackColor = Color.GreenYellow;
        }

        void upd2()
        {
            int a = 0;
            return;
        }
    }
}
