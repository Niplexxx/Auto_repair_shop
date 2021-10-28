using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.91; // прозрачность формы
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.form2.Show();
            this.Hide();
        }
    }
}
