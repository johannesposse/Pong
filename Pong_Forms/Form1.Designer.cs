
namespace Pong_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Player1Picture = new System.Windows.Forms.PictureBox();
            this.Player1TimerDown = new System.Windows.Forms.Timer(this.components);
            this.Player1TimerUp = new System.Windows.Forms.Timer(this.components);
            this.Player2Picture = new System.Windows.Forms.PictureBox();
            this.Player2TimerDown = new System.Windows.Forms.Timer(this.components);
            this.Player2TimerUp = new System.Windows.Forms.Timer(this.components);
            this.Devider = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.BallTimer = new System.Windows.Forms.Timer(this.components);
            this.BallTimerLeft = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Devider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1Picture
            // 
            this.Player1Picture.BackColor = System.Drawing.Color.Lime;
            this.Player1Picture.Location = new System.Drawing.Point(10, 349);
            this.Player1Picture.Name = "Player1Picture";
            this.Player1Picture.Size = new System.Drawing.Size(5, 70);
            this.Player1Picture.TabIndex = 0;
            this.Player1Picture.TabStop = false;
            // 
            // Player1TimerDown
            // 
            this.Player1TimerDown.Interval = 10;
            this.Player1TimerDown.Tick += new System.EventHandler(this.Player1TimerDown_Tick);
            // 
            // Player1TimerUp
            // 
            this.Player1TimerUp.Interval = 10;
            this.Player1TimerUp.Tick += new System.EventHandler(this.Player1TimerUp_Tick);
            // 
            // Player2Picture
            // 
            this.Player2Picture.BackColor = System.Drawing.Color.Lime;
            this.Player2Picture.Location = new System.Drawing.Point(1470, 349);
            this.Player2Picture.Name = "Player2Picture";
            this.Player2Picture.Size = new System.Drawing.Size(5, 70);
            this.Player2Picture.TabIndex = 1;
            this.Player2Picture.TabStop = false;
            this.Player2Picture.Click += new System.EventHandler(this.Player2Picture_Click);
            // 
            // Player2TimerDown
            // 
            this.Player2TimerDown.Interval = 10;
            this.Player2TimerDown.Tick += new System.EventHandler(this.Player2TimerDown_Tick);
            // 
            // Player2TimerUp
            // 
            this.Player2TimerUp.Interval = 10;
            this.Player2TimerUp.Tick += new System.EventHandler(this.Player2TimerUp_Tick);
            // 
            // Devider
            // 
            this.Devider.BackColor = System.Drawing.Color.Lime;
            this.Devider.Location = new System.Drawing.Point(750, 0);
            this.Devider.Name = "Devider";
            this.Devider.Size = new System.Drawing.Size(5, 810);
            this.Devider.TabIndex = 2;
            this.Devider.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Red;
            this.Ball.Location = new System.Drawing.Point(0, 696);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(10, 10);
            this.Ball.TabIndex = 3;
            this.Ball.TabStop = false;
            // 
            // BallTimer
            // 
            this.BallTimer.Interval = 10;
            this.BallTimer.Tick += new System.EventHandler(this.BallTimer_Tick);
            // 
            // BallTimerLeft
            // 
            this.BallTimerLeft.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(690, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 46);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1484, 811);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Devider);
            this.Controls.Add(this.Player2Picture);
            this.Controls.Add(this.Player1Picture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Devider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1Picture;
        private System.Windows.Forms.Timer Player1TimerDown;
        private System.Windows.Forms.Timer Player1TimerUp;
        private System.Windows.Forms.PictureBox Player2Picture;
        private System.Windows.Forms.Timer Player2TimerDown;
        private System.Windows.Forms.Timer Player2TimerUp;
        private System.Windows.Forms.PictureBox Devider;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer BallTimer;
        private System.Windows.Forms.Timer BallTimerLeft;
        private System.Windows.Forms.Label label1;
    }
}

