﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cel = 0.0;
            double fah = Convert.ToDouble(textBox1.Text);

            cel = (fah - 32) * (5.0 / 9.0);

            textBox2.Text = cel.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
