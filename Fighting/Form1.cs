using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fighting
{
    public partial class Form1 : Form
    {
        public static Timer timer1;
        public Form1()
        {
            InitializeComponent();
            View.Start();

            timer1.Interval = 20;
            timer1.Tick += new EventHandler(Update);
            timer1.Start();

            KeyDown += new KeyEventHandler(OnPress);
            KeyUp += new KeyEventHandler(OnKeyUp);
            Invalidate();
        }
        void Update(object sender, EventArgs e)
        {
            if (View.player.isMoving)
                View.player.Move();
            Invalidate();
        }

        public static void OnKeyUp(object sender, KeyEventArgs e)
        {
            View.player.dirX = 0;
            View.player.dirY = 0;
            View.player.isMoving = false;
        }

        public static void OnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    View.player.dirY = -10;
                    break;
                case Keys.A:
                    View.player.dirX = -10;
                    break;
                case Keys.S:
                    View.player.dirY = 10;
                    break;
                case Keys.D:
                    View.player.dirX = 10;
                    break;
                case Keys.Escape:
                    Application.Exit();
                    break;
            }

            View.player.isMoving = true;
        }
    }
}
