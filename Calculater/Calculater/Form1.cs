using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Calculater : Form
    {
        public Calculater()
        {
            InitializeComponent();
        }
        int tot1 = 0;
        int tot2 = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button0.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Add_Click(object sender, EventArgs e)
        {
            tot1 += int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            tot2 = tot1 + int.Parse(textBox1.Text);
            textBox1.Text = tot2.ToString();
            tot1 = 0;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
