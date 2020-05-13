﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Timer
{
    public partial class Timer : Form
    {
        int i = 0;
        public Timer()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = i++ + " msec";
            int maxWidth = ClientSize.Width;
            int maxHeight = ClientSize.Height;
            Point point = lblTimer.Location;

            if (point.X < (maxWidth - point.X / 4) && point.Y == 10)
                lblTimer.Location = new Point(point.X += 10, point.Y);

            else if (point.X > (maxWidth - point.X / 4) && point.Y < (maxHeight - point.Y / 1.4))
                lblTimer.Location = new Point(point.X, point.Y += 10);

            else if (point.Y >= (maxHeight - point.Y / 1.4))
                lblTimer.Location = new Point(point.X -= 10, point.Y);

            if (point.X <= 10)
                lblTimer.Location = new Point(point.X, point.Y -= 10);

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
                timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show($"Пройшло: {lblTimer.Text}", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            i = 0;
            lblTimer.Text = String.Empty;
            lblTimer.Location = new Point(10, 10);
        }
    }
}
