using System;
using System.Drawing;
using System.Windows.Forms;
//this.Paint += new System.Windows.Forms.PaintEventHandler(View.OnPaint);
namespace Fighting
{
    class View
    {
        public static Image hero1;
        public static Entity player1;
        public static void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (player1.currentFrame < player1.currentLimit - 1)
                player1.currentFrame++;
            else player1.currentFrame = 0;

            g.DrawImage(player1.spriteSheet, 
                new Rectangle(new Point(player1.posX, player1.posY),
                new Size(player1.size.Item1, player1.size.Item2)), 
                player1.size.Item1*player1.currentFrame, 
                player1.size.Item2*player1.currentAnimation, 
                player1.size.Item1, player1.size.Item2,
                GraphicsUnit.Pixel);
        }

        public static void Start()
        {
            hero1 = new Bitmap(Resource1.Scorpion_sprites);
            player1 = new Entity(30, 750, Hero.idleFrames, Hero.walkFrames, Hero.attackFrames, Hero.deathFrames, hero1);
        }
    }
}
