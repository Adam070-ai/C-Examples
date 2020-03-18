using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 25;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 75;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Bar Kullanimi";
        }
    }
}
