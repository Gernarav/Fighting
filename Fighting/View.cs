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
    class View
    {
        public static Image IronMan;
        public static Entity player;
        public static void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //отрисовка части спрайта
            g.DrawImage(player.spriteSheet, new Rectangle(new Point(player.posX, player.posY),
                new Size(player.size.Item1, player.size.Item2)), 0, 0, player.size.Item1, player.size.Item2,
                GraphicsUnit.Pixel);
        }

        public static void Start()
        {
            IronMan = new Bitmap(Resource1.IronMan);
            player = new Entity(100, 100, Hero.idleFrames, Hero.runFrames, Hero.attackFrames, Hero.deathFrames, IronMan);
        }
    }
}
