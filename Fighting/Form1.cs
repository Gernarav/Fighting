using Fighting.Entites;
using Fighting.Models;
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
        public Image IronMan;
        public Entity player;
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 20;
            timer1.Tick += new EventHandler(Update);

            KeyDown += new KeyEventHandler(OnPress);
            KeyUp += new KeyEventHandler(OnKeyUp);


            Init();
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            player.dirX = 0;
            player.dirY = 0;
            player.isMoving = false;
        }

        public void OnPress(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                    player.dirY = -10;
                    break;
                case Keys.A:
                    player.dirX = -10;
                    break;
                case Keys.S:
                    player.dirY = 10;
                    break;
                case Keys.D:
                    player.dirX = 10;
                    break;
            }
            player.isMoving = true;
        }

        public void Init()
        {
            //var dir = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            IronMan = new Bitmap("C:\\Users\\expla\\source\\repos\\Fighting\\Fighting\\Sprites\\IronMan.png");
            player = new Entity(100, 100, Hero.idleFrames, Hero.runFrames, Hero.attackFrames, Hero.deathFrames, IronMan);
            timer1.Start();
        }

        public void Update(object sender, EventArgs e)
        {
            if (player.isMoving)
                player.Move();

            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //отрисовка части спрайта
            g.DrawImage(player.spriteSheet, new Rectangle(new Point(player.posX, player.posY), 
                new Size(player.size.Item1, player.size.Item2)), 0, 0, player.size.Item1, player.size.Item2, 
                GraphicsUnit.Pixel);
        }
    }
}
