﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _02_课后
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "寜樱";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Insert(0,textBox1.Text.ToString());
        }


    }
}
