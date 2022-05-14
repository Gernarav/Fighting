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

            timer1.Interval = 33;
            timer1.Tick += new EventHandler(Update);
            timer1.Start();

            View.Start();

            KeyDown += new KeyEventHandler(OnPress);
            KeyUp += new KeyEventHandler(OnKeyUp);
            Invalidate();
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            View.player1.dirX = 0;
            View.player1.dirY = 0;
            View.player1.isMoving = false;
        }

        public void OnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    View.player1.dirY = -50;
                    break;
                case Keys.A:
                    View.player1.dirX = -50;
                    break;
                case Keys.S:
                    View.player1.dirY = 50;
                    break;
                case Keys.D:
                    View.player1.dirX = 50;
                    break;
                case Keys.Escape:
                    Application.Exit();
                    break;
            }

            View.player1.isMoving = true;
        }

        public void Update(object sender, EventArgs e)
        {
            if (View.player1.isMoving)
                View.player1.Move();
            Invalidate();
        }
    }
}
