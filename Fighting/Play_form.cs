﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace Fighting
{
    public partial class Play_form : Form
    {
        public Play_form()
        {
            InitializeComponent();

            KeyPreview = true;

            timer1.Interval = 50;
            timer1.Tick += new EventHandler(Update);
            timer1.Start();

            View.StartPlay();

            KeyDown += new KeyEventHandler(OnPress);

            Invalidate();
        }

        public void OnPress(object sender, KeyEventArgs e)
        {
            if(!View.player1.isMoving)
                switch (e.KeyCode)
                {
                    case Keys.D:
                        View.player1.dirX = 50;
                        View.player1.isMoving = true;
                        View.player1.SetAnimation(1);
                        break;
                    case Keys.A:
                        View.player1.dirX = -50;
                        View.player1.isMoving = true;
                        View.player1.SetAnimation(2);
                        break;
                    case Keys.F:
                        View.player1.dirX = 30;
                        View.player1.isMoving = true;
                        View.player1.isAttacking = true;
                        View.player1.SetAnimation(3);
                        break;
                    case Keys.Escape:
                        openForm1();
                        break;
                }

            if (!View.player2.isMoving)
                switch (e.KeyCode)
                {
                    case Keys.L:
                        View.player2.dirX = 50;
                        View.player2.isMoving = true;
                        View.player2.SetAnimation(1);
                        break;
                    case Keys.J:
                        View.player2.dirX = -50;
                        View.player2.isMoving = true;
                        View.player2.SetAnimation(2);
                        break;
                    case Keys.I:
                        View.player2.dirX = -30;
                        View.player2.isMoving = true;
                        View.player2.isAttacking = true;
                        View.player2.SetAnimation(3);
                        break;
                }

            switch(e.KeyCode)
            {
                case Keys.Escape:
                    openForm1();
                    break;
            }
        }

        public void Update(object sender, EventArgs e)
        {
            WinnerStatus();
            if (View.player1.isMoving && player1_hurtBox.Right + View.player1.dirX + 50 < player2_hurtBox.Left)
                View.player1.Move(player1_hurtBox, player1_hitBox, ClientSize.Width);
            
            if (View.player2.isMoving && player2_hurtBox.Left + View.player2.dirX - 50 > player1_hurtBox.Right)
                View.player2.Move(player2_hurtBox, player2_hitBox, ClientSize.Width);

            Invalidate();
        }

        public void WinnerStatus()
        {
            if (View.player1.isAttacking && player1_hitBox.Right >= player2_hurtBox.Left)
            {
                timer1.Stop();
                openForm1();
            }


            if (View.player2.isAttacking &&  player2_hitBox.Left <= player1_hurtBox.Right)
            {
                timer1.Stop();
                openForm1();
            }

        }

        public void openForm1()
        {
            this.Hide();
            Form1 formToSwitch = new Form1();
            formToSwitch.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openForm1();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            View.PlayOnPaint(sender, e);
        }
    }
}
