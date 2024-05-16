using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProjectC_
{
    public partial class Form1 : Form
    {
        private Point pos;
        private bool dragging, lose = false;
        private int countCoins = 0;
        int bgspeed = 5;
        int carspeed = 7;
        public Form1()
        {
            
            InitializeComponent();

            bg1.MouseDown += MouseClickDown;
            bg1.MouseUp += MouseClickUp;
            bg1.MouseMove += MouseClickMove;
            bg2.MouseDown += MouseClickDown;
            bg2.MouseUp += MouseClickUp;
            bg2.MouseMove += MouseClickMove;
            LabelLose.Visible = false;
            Restart.Visible = false;
            KeyPreview = true;
        }
        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;

        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + bg1.Top); 
            }
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           // int speed = 5;
            bg1.Top += bgspeed;
            bg2.Top += bgspeed;

           // int carspeed = 7;
            enemy1.Top += carspeed;
            enemy2.Top += carspeed;

            coin.Top += bgspeed;

            if (coin.Top >= 650)
            {
                coin.Top = -50;
                Random rnd = new Random();
                coin.Left = rnd.Next(150, 560);
            }

            if (bg1.Top >= 650)
            {
                bg1.Top = 0;
               
                bg2.Top  = - 650;
            }

            if (enemy1.Top >= 650)  
            {
               enemy1.Top -= 670;
                Random rnd = new Random();
                enemy1.Left = rnd.Next(134, 306);
            }
            if (enemy2.Top >= 650) 
            {
                enemy2.Top -=800;
                Random rnd = new Random();
                enemy2.Left = rnd.Next(306, 582);
            }

            if (car.Bounds.IntersectsWith(enemy1.Bounds) 
                || car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer.Enabled = false;
                LabelLose.Visible = true;
                Restart.Visible = true;
                lose = true;
            }
             

            if (enemy1.Top >= 650) enemy1.Top = -130;
            if (enemy2.Top >= 650) enemy2.Top = -400;

            if (car.Bounds.IntersectsWith(coin.Bounds))
            {
                countCoins++;
                labelCoins.Text ="Coins :" + countCoins.ToString();
                coin.Top = -50;
                Random rnd = new Random();
                coin.Left = rnd.Next(150, 560);
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;
            int speed = 10;
            if ((e.KeyCode == Keys.Left  || e.KeyCode== Keys.A) && car.Left>125)
             car.Left -= speed;

            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && car.Right < 750)
                car.Left +=speed;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            enemy1.Top = -130;
            enemy2.Top = -400;
            LabelLose.Visible = false;
            Restart.Visible=false;
            timer.Enabled = true;
            lose = false;
            countCoins= 0;
            labelCoins.Text = "Coins :" + countCoins.ToString();
            coin.Top = -500;
        }
    }
}
