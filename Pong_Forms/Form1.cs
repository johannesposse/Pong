using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Forms
{
    public partial class Form1 : Form
    {
        private bool left = false;
        private bool top = false;
        private int speed = 5;
        public Form1()
        {
            InitializeComponent();
            Ball.Left = 20;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
               Player2TimerDown.Start();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Player2TimerUp.Start();
            }

            if (e.KeyCode == Keys.W)
            {
                Player1TimerUp.Start();
            }
            else if (e.KeyCode == Keys.S)
            {
                Player1TimerDown.Start();
            }

            if(e.KeyCode == Keys.Enter)
            {
                label1.Text = "";
                BallTimer.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Player1TimerDown.Stop();
            Player1TimerUp.Stop();
            Player2TimerDown.Stop();
            Player2TimerUp.Stop();
        }

        private void Player1TimerDown_Tick(object sender, EventArgs e)
        {
            if(Player1Picture.Top < 750)
             Player1Picture.Top += 10;
        }


        private void Player1TimerUp_Tick(object sender, EventArgs e)
        {
            if(Player1Picture.Top > 10)
            Player1Picture.Top += -10;
        }

        private void Player2TimerDown_Tick(object sender, EventArgs e)
        {
            if (Player2Picture.Top < 750)
                Player2Picture.Top += 10;
        }
        private void Player2TimerUp_Tick(object sender, EventArgs e)
        {
            if (Player2Picture.Top > 10)
                Player2Picture.Top += -10;
        }


        private void Player2Picture_Click(object sender, EventArgs e)
        {

        }

        private void BallTimer_Tick(object sender, EventArgs e)
        {

            if (top == false)
            {
                Ball.Top += speed;
                if(Ball.Top > 800)
                {
                    top = true;
                }
            }

            if (top == true)
            {
                Ball.Top -= speed;
                if(Ball.Top < 5)
                {
                    top = false;
                }
            }

            if (left == false)
            {
                Ball.Left += speed;

                if (Ball.Left == Player2Picture.Left & (Ball.Top >= Player2Picture.Top & Ball.Top <= Player2Picture.Top+70))
                {
                    left = true;
                }

            }
            
            if (left == true) 
            {
                Ball.Left -= speed;

                if (Ball.Left == Player1Picture.Left & (Ball.Top >= Player1Picture.Top & Ball.Top <= Player1Picture.Top + 70))
                {
                    left = false;
                }
            }

            if(Ball.Left > Player2Picture.Left ^ Ball.Left < Player1Picture.Left)
            {
                BallTimer.Stop();
                label1.ForeColor = Color.Red; 
                label1.Text = "Game Over";
                Ball.Left = 750;
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
