using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private static readonly int MaxValue = 10;
        private static readonly int MinValue = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        Random rand = new Random();
            int a = rand.Next(MinValue, MaxValue);
            int b = rand.Next(MinValue, MaxValue);
            int c = rand.Next(MinValue, MaxValue);

            label1.Text =a.ToString();
            label2.Text = b.ToString();
            label3.Text = c.ToString();

            int res = a + b + c;
            if (res > 21)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Administrator\\Desktop\\trophy.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                
                MessageBox.Show("Congrats you won the game :)");
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Administrator\\Desktop\\loser.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                MessageBox.Show("OOPS! You lost the game!");
            }
           


        }
    }
}
