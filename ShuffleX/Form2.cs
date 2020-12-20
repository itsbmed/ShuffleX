using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form2 : Form
    {
        public string NamePlayer;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form4 tr2 = new Form4();  
            WelcomeBox.Text = NamePlayer + " Welcome To ShuflleX ";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shuffle fr1 = new Shuffle();
            fr1.m = 20;
            fr1.s = 0;
            fr1.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shuffle fr1 = new Shuffle();
            fr1.m = 8;
            fr1.s = 0;
            fr1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shuffle fr1 = new Shuffle();
            fr1.m = 2;
            fr1.s = 0;
            fr1.Show();
            this.Close();
        }
    }
}
