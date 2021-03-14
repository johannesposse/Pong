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
        private int playerOneScore;
        private int playerTwoScore;
        private bool left = false;
        private bool top = false;
        private int speed = 5;
        public Form1()
        {
            InitializeComponent();
            PlayerOneScoreLabel.Text = "Player 1: 0";
            PlayerTwoScoreLabel.Text = "Player 2: 0";
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

        private void BallTimer_Tick(object sender, EventArgs e)
        {

            if (top == false)
            {
                Ball.Top += speed;
                if (Ball.Top > 800)
                {
                    top = true;
                }
            }

            if (top == true)
            {
                Ball.Top -= speed;
                if (Ball.Top < 5)
                {
                    top = false;
                }
            }

            if (left == false)
            {
                Ball.Left += speed;

                if (Ball.Left == (Player2Picture.Left - Player2Picture.Width) & (Ball.Top >= Player2Picture.Top & Ball.Top <= Player2Picture.Top + Player2Picture.Height))
                {
                    left = true;
                }

            }
            
            if (left == true) 
            {
                Ball.Left -= speed;

                if (Ball.Left == (Player1Picture.Left + Player1Picture.Width) + Player1Picture.Width & (Ball.Top >= Player1Picture.Top & Ball.Top <= Player1Picture.Top + Player1Picture.Height))
                {
                    left = false;
                }
            }

            if (Ball.Left > Player2Picture.Left) //om spelare två förlorar
            {
                BallTimer.Stop();
                label1.ForeColor = Color.Red; 
                label1.Text = "Player 2, you suck...";
                Ball.Left = 750;
                playerOneScore++;
                PlayerOneScoreLabel.Text = "Player 1: " + playerOneScore.ToString();
            }

            if (Ball.Left < Player1Picture.Left) //om spelare ett förlorar
            {
                BallTimer.Stop();
                label1.ForeColor = Color.Red;
                label1.Text = "Player 1, try to hit the ball...";
                Ball.Left = 750;
                playerTwoScore++;
                PlayerTwoScoreLabel.Text = "Player 2: " + playerTwoScore.ToString();
            }

        }

    }
}
