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
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {
            Form2 tr1 = new Form2();
            tr1.NamePlayer = PlayerName.Text; 
            tr1.Show();
            this.Hide();
        }
    }
}
