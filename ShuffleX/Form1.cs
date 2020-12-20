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

    public partial class Shuffle : Form
    {
        public int m, s;

        public Shuffle()
        {
            InitializeComponent();
        }


        int movesNumber = 0, labelIndex = 0;
        // SHUFFLE THE NUMBERS
        private void shuffleButtons()
        {
            List<int> labelList = new List<int>();

            Random rand = new Random();
            foreach (Button btn in this.btnpanel.Controls)
            {
                while (labelList.Contains(labelIndex))
                    labelIndex = rand.Next(9);

                btn.Text = (labelIndex == 0) ? "" : labelIndex + "";
                labelList.Add(labelIndex);
            }

            movesNumber = 0;
            nbmvs.Text = "Number of moves : " + movesNumber;

        }





        // IF THE USER SOLVE THE GAME
        private void winner()
        {
            int l, m = 0, w = 0;
            for (l = 0; l < 8; l++)
            {
                m++;
                if (btnpanel.Controls[l].Text == Convert.ToString(btnpanel.Controls[l].TabIndex + 1)) 
                {
                    
                    w++;
                    
                }
                
            }

            if (w ==7 )
            {
                DialogResult Wn;
                Wn = MessageBox.Show("Good Job, " +
                    "Do You Want To Play Again", "Congratulation !",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Wn == DialogResult.Yes)
                {
                    shuffleButtons();
                    cnt = 0;
                }
                else
                {
                    Form4 fr4 = new Form4();
                    this.Close();
                    fr4.Close();
                }
            }

        }




        // EXIT BUTTON
        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult ex;
            ex = MessageBox.Show("Do you Realy Wnat to Exite ?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ex == DialogResult.Yes)
            {
                Form4 fr4 = new Form4();
                fr4.Close();
                this.Close();
            }

        }
        // ClOSE THE GAME
        private void ShuffleX_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult Clo;
            Clo = MessageBox.Show("Do you Realy Wnat to Exite ?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (Clo == DialogResult.No)
            {
                e.Cancel = true;

            }
            Form4 fr4 = new Form4();
            fr4.Close();
        }

        int cnt = 0;
        public void KMoveBtn(int x, Button btn,int v,int a)
        {
            Point p = new Point();
            int  b,tb;
            

               
                v += x;
                for (b = 0; b < 9; b++)
                {
                    if (btnpanel.Controls[b].TabIndex == v)
                    {
                        v = btnpanel.Controls[b].TabIndex;

                        break;
                    }
                }
                p = btnpanel.Controls[a].Location;
                btnpanel.Controls[a].Location = btnpanel.Controls[b].Location;
                btnpanel.Controls[b].Location = p;
                
                btnpanel.Controls[b].TabIndex = btnpanel.Controls[a].TabIndex;
                btnpanel.Controls[a].TabIndex = v;
                cnt++;
                nbmvs.Text = "Number of moves : " + cnt;
                winner();

            


        }
     

        Point MouseDownLocation = new Point();
        Point ps = new Point();
        Point pp = new Point();
        Point fbtn = new Point();
        public int x, y;
        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            fbtn = btn.Location;
          
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;

            }

        }

        private void btn1_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text != "")
            {
                if (e.Button == MouseButtons.Left)
                {

                    btn.Left = e.X + btn.Left - MouseDownLocation.X;
                    btn.Top = e.Y + btn.Top - MouseDownLocation.Y;


                }
            }
            
           
           
           
        }

        

        private void Shuffle_KeyDown(object sender, KeyEventArgs e)
        {

           
        }

        private void btn1_KeyUp(object sender, KeyEventArgs e)
        {
            Button btn = (Button)sender;
            int a,v=0;
            for (a = 0; a < 9; a++)
            {
                if (btnpanel.Controls[a].Text == "")
                {

                    v = btnpanel.Controls[a].TabIndex;

                    break;
                }
            }
            //capture up arrow key
            if (e.KeyData == Keys.Up)
            {
                KMoveBtn(3,btn,v,a);
               

            }
            //capture down arrow key
            if (e.KeyData == Keys.Down)
            {
                KMoveBtn(-3, btn,v,a);


            }
            //capture left arrow key
            if (e.KeyData == Keys.Left)
            {

                KMoveBtn(1, btn,v,a);

            }
            //capture right arrow key
            if (e.KeyData == Keys.Right)
            {
                KMoveBtn(-1, btn,v,a);

            }
        }

        private void btn1_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            int j;
            int tb;

            for (j = 0; j < 9; j++)
            {
                if (btnpanel.Controls[j].Text == "")
                {
                    ps = btnpanel.Controls[j].Location;
                    break;
                }
            }
            
            if (btn.Location!= fbtn && fbtn.X == ps.X -125 && fbtn.Y == ps.Y  || btn.Location != fbtn && fbtn.X == ps.X + 125 && fbtn.Y == ps.Y  ||
                btn.Location != fbtn && fbtn.Y == ps.Y - 93 && fbtn.X == ps.X || btn.Location != fbtn && fbtn.Y == ps.Y + 93 && fbtn.X == ps.X)
            {
                pp = btnpanel.Controls[j].Location;
                btnpanel.Controls[j].Location = fbtn;
                btn.Location = pp;
                tb = btn.TabIndex;
                btn.TabIndex = btnpanel.Controls[j].TabIndex;
                btnpanel.Controls[j].TabIndex = tb;
            }
            else
            {
                btn.Location = fbtn;
                

            }
            nbmvs.Text = "Number of moves : " + cnt;
            winner();
            cnt++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(s!=0) s -= 1;
            if (s == 0)
            {

                s = 60;
                m -= 1;
            }


            Timer.Text = String.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }




        // NEW GAME BUTTON
        private void NewGame_MouseClick(object sender, MouseEventArgs e)
        {
            Shuffle sh = new Shuffle();


            shuffleButtons();
            timer1.Start();
            winner();
            cnt = 0;
        }

       

        
    }
}
