using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace Fighting
{
    //Controller
    public partial class Play_form : Form
    {

        public Play_form()
        {
            InitializeComponent();

            KeyPreview = true;

            timer1.Interval = 100;
            timer1.Tick += new EventHandler(Update);
            timer1.Start();

            View.StartPlay();

            KeyDown += new KeyEventHandler(OnPress);
            KeyUp += new KeyEventHandler(OnKeyUp);
            Invalidate();
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            //if(player1Keys.Contains(e.KeyCode))
            //{

            //}
            View.player1.dirX = 0;
            View.player1.dirY = 0;
            View.player1.isMoving = false;
            View.player1.SetAnimation(0);


            //View.player2.dirX = 0;
            //View.player2.dirY = 0;
            //View.player2.isMoving = false;
            //View.player2.SetAnimation(0);
        }

        public void OnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //case Keys.W:
                //    View.player1.dirY = -25;
                //    View.player1.isMoving = true;
                //    View.player1.SetAnimation(3);
                //    break;
                case Keys.A:
                    View.player1.dirX = -25;
                    View.player1.isMoving = true;
                    View.player1.SetAnimation(3);
                    break;
                //case Keys.S:
                //    View.player1.dirY = 25;
                //    View.player1.isMoving = true;
                //    View.player1.SetAnimation(2);
                //    break;
                case Keys.D:
                    View.player1.dirX = 25;
                    View.player1.isMoving = true;
                    View.player1.SetAnimation(2);
                    break;
                //case Keys.Space:
                //    View.player1.dirX = 0;
                //    View.player1.dirY = 0;
                //    View.player1.isMoving = false;
                //    View.player1.SetAnimation(4);
                //    break;

                //case Keys.I:
                //    View.player2.dirY = -25;
                //    View.player2.isMoving = true;
                //    View.player2.SetAnimation(3);
                //    break;
                //case Keys.J:
                //    View.player2.dirX = -25;
                //    View.player2.isMoving = true;
                //    View.player2.SetAnimation(1);
                //    break;
                //case Keys.K:
                //    View.player2.dirY = 25;
                //    View.player2.isMoving = true;
                //    View.player2.SetAnimation(2);
                //    break;
                //case Keys.L:
                //    View.player2.dirX = 25;
                //    View.player2.isMoving = true;
                //    View.player2.SetAnimation(1);
                //    break;
                //case Keys.Enter:
                //    View.player2.dirX = 0;
                //    View.player2.dirY = 0;
                //    View.player2.isMoving = false;
                //    View.player2.SetAnimation(4);
                //    break;
                case Keys.Escape:
                    openForm1();
                    break;
            }
        }

        public void Update(object sender, EventArgs e)
        {
            if (View.player1.isMoving)
                View.player1.Move();
            Invalidate();

            //if (View.player2.isMoving)
            //    View.player2.Move();
            //Invalidate();
        }

        public void openForm1()
        {
            this.Hide();
            Form1 formToSwitch = new Form1();
            formToSwitch.ShowDialog();
            this.Close();
        }

        List<Keys> player1Keys = new List<Keys>
        {
            Keys.W,
            Keys.A,
            Keys.S,
            Keys.D,
            Keys.Space,
        };

        List<Keys> player2Keys = new List<Keys>
        {
            Keys.I,
            Keys.J,
            Keys.K,
            Keys.L,
            Keys.Enter,
        };

        private void btnHome_Click(object sender, EventArgs e)
        {
            openForm1();
        }
    }
}
