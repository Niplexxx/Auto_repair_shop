﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_repair_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.91; // прозрачность формы
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form2.Show();
            this.Hide();
        }
    }
}
