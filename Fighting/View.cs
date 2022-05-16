using System;
using System.Drawing;
using System.Windows.Forms;
namespace Fighting
{
    class View : Form
    {
        public static Entity red1;
        public static Entity blue1;
        public static Entity red2;
        public static Entity blue2;
        public static Entity player1;
        public static Bitmap hero1 = new Bitmap(Resource1.RED);
        public static Entity player2;
        public static Bitmap hero2 = new Bitmap(Resource1.RED);
        public static void PlayOnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (player1.currentFrame < player1.currentLimit - 1)
                player1.currentFrame++;
            else player1.currentFrame = 0;

            g.DrawImage(player1.spriteSheet,
                new Rectangle(new Point(player1.posX, player1.posY),
                new Size(player1.size.Item1, player1.size.Item2)),
                player1.size.Item1 * player1.currentFrame,
                player1.size.Item2 * player1.currentAnimation,
                player1.size.Item1, player1.size.Item2,
                GraphicsUnit.Pixel);

            //if (player2.currentFrame < player2.currentLimit - 1)
            //    player2.currentFrame++;
            //else player2.currentFrame = 0;


            //g.DrawImage(player2.spriteSheet,
            //    new Rectangle(new Point(player2.posX, player2.posY),
            //    new Size(player2.size.Item1, player2.size.Item2)),
            //    player2.size.Item1 * player2.currentFrame,
            //    player2.size.Item2 * player2.currentAnimation,
            //    player2.size.Item1, player2.size.Item2,
            //    GraphicsUnit.Pixel);
        }

        public static void SettingsOnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (red1.currentFrame < red1.currentLimit - 1)
                red1.currentFrame++;
            else red1.currentFrame = 0;

            g.DrawImage(red1.spriteSheet,
                new Rectangle(new Point(red1.posX, red1.posY),
                new Size(red1.size.Item1, red1.size.Item2)),
                red1.size.Item1 * red1.currentFrame,
                red1.size.Item2 * red1.currentAnimation,
                red1.size.Item1, red1.size.Item2,
                GraphicsUnit.Pixel);

            if (blue1.currentFrame < blue1.currentLimit - 1)
                blue1.currentFrame++;
            else blue1.currentFrame = 0;

            g.DrawImage(blue1.spriteSheet,
                new Rectangle(new Point(blue1.posX, blue1.posY),
                new Size(blue1.size.Item1, blue1.size.Item2)),
                blue1.size.Item1 * blue1.currentFrame,
                blue1.size.Item2 * blue1.currentAnimation,
                blue1.size.Item1, blue1.size.Item2,
                GraphicsUnit.Pixel);

            if (red2.currentFrame < red2.currentLimit - 1)
                red2.currentFrame++;
            else red2.currentFrame = 0;

            g.DrawImage(red2.spriteSheet,
                new Rectangle(new Point(red2.posX, red2.posY),
                new Size(red2.size.Item1, red2.size.Item2)),
                red2.size.Item1 * red2.currentFrame,
                red2.size.Item2 * red2.currentAnimation,
                red2.size.Item1, red2.size.Item2,
                GraphicsUnit.Pixel);

            if (blue2.currentFrame < blue2.currentLimit - 1)
                blue2.currentFrame++;
            else blue2.currentFrame = 0;

            g.DrawImage(blue2.spriteSheet,
                new Rectangle(new Point(blue2.posX, blue2.posY),
                new Size(blue2.size.Item1, blue2.size.Item2)),
                blue2.size.Item1 * blue2.currentFrame,
                blue2.size.Item2 * blue2.currentAnimation,
                blue2.size.Item1, blue2.size.Item2,
                GraphicsUnit.Pixel);
        }

        public static void StartPlay()
        {
            player1 = new Entity(0, 600, Hero.idleFrames, 
                Hero.walkFrames, Hero.sitFrames, Hero.jumpFrames, 
                Hero.attackFrames, Hero.deathFrames, hero1);

            //player2 = new Entity(30, 350, Hero.idleFrames,
            //    Hero.walkFrames, Hero.sitFrames, Hero.jumpFrames,
            //    Hero.attackFrames, Hero.deathFrames, new Bitmap(Resource1.SubZero_sprites));
        }

        public static void StartSettings()
        {
            red1 = new Entity(0, 500, Hero.idleFrames,
                Hero.walkFrames, Hero.sitFrames, Hero.jumpFrames,
                Hero.attackFrames, Hero.deathFrames, new Bitmap(Resource1.RED));
            blue1 = new Entity(500, 500, Hero.idleFrames,
                Hero.walkFrames, Hero.sitFrames, Hero.jumpFrames,
                Hero.attackFrames, Hero.deathFrames, new Bitmap(Resource1.BLUE));
            red2 = new Entity(1000, 500, Hero.idleFrames,
                Hero.walkFrames, Hero.sitFrames, Hero.jumpFrames,
                Hero.attackFrames, Hero.deathFrames, new Bitmap(Resource1.RED));
            blue2 = new Entity(1500, 500, Hero.idleFrames,
                Hero.walkFrames, Hero.sitFrames, Hero.jumpFrames,
                Hero.attackFrames, Hero.deathFrames, new Bitmap(Resource1.BLUE));
            red1.SetAnimation(0);
            blue1.SetAnimation(0);
            red2.SetAnimation(0);
            blue2.SetAnimation(0);
        }
    }
}
