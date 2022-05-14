using System;
using System.Drawing;
using System.Windows.Forms;
namespace Fighting
{
    class View : Form
    {       
        public static Entity player1;
        public static Entity player2;
        public static void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (player1.currentFrame < player1.currentLimit - 1)
                player1.currentFrame++;
            else player1.currentFrame = 0;

            if (player2.currentFrame < player2.currentLimit - 1)
                player2.currentFrame++;
            else player2.currentFrame = 0;

            g.DrawImage(player1.spriteSheet, 
                new Rectangle(new Point(player1.posX, player1.posY),
                new Size(player1.size.Item1, player1.size.Item2)), 
                player1.size.Item1*player1.currentFrame, 
                player1.size.Item2*player1.currentAnimation, 
                player1.size.Item1, player1.size.Item2,
                GraphicsUnit.Pixel);
            g.DrawImage(player2.spriteSheet,
                new Rectangle(new Point(player2.posX, player2.posY),
                new Size(player2.size.Item1, player2.size.Item2)),
                player2.size.Item1 * player2.currentFrame,
                player2.size.Item2 * player2.currentAnimation,
                player2.size.Item1, player2.size.Item2,
                GraphicsUnit.Pixel);
        }

        public static void Start()
        {
            player1 = new Entity(30, 750, Hero.idleFrames, 
                Hero.walkFrames, Hero.sitFrames, Hero.jumpFrames, 
                Hero.attackFrames, Hero.deathFrames, new Bitmap(Resource1.Scorpion_sprites));

            player2 = new Entity(30, 350, Hero.idleFrames,
                Hero.walkFrames, Hero.sitFrames, Hero.jumpFrames,
                Hero.attackFrames, Hero.deathFrames, new Bitmap(Resource1.SubZero_sprites));
        }
    }
}
