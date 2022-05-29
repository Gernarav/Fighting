using System;
using System.Drawing;
using System.Windows.Forms;
namespace Fighting
{
    class View : Form
    {
        public static Entity player1;
        public static Entity player2;
        public static Bitmap hero1 = new Bitmap(Resource1.Red_Left_Sprites);
        public static Bitmap hero2 = new Bitmap(Resource1.Red_Right_Sprites);
        public static void PlayOnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            switch (player1.currentAnimation)
            {
                case 0:
                    IdleAnimation(g, player1);
                    break;
                case 1:
                    WalkAnimation(g, player1);
                    break;
                case 2:
                    WalkAnimation(g, player1);
                    break;
                case 3:
                    AttackAnimation(g, player1);
                    break;
            }

            switch (player2.currentAnimation)
            {
                case 0:
                    IdleAnimation(g, player2);
                    break;
                case 1:
                    WalkAnimation(g, player2);
                    break;
                case 2:
                    WalkAnimation(g, player2);
                    break;
                case 3:
                    AttackAnimation(g, player2);
                    break;
            }
        }

        public static void IdleAnimation(Graphics g, Entity player)
        {
            g.DrawImage(player.Sprites,
                new Rectangle(new Point(player.posX, player.posY),
                new Size(500, 390)),
                500 * player.currentFrame,
                390 * player.currentAnimation,
                500, 390,
                GraphicsUnit.Pixel);

            if (player.currentFrame < player.currentLimit - 1)
                player.currentFrame++;
            else player.currentFrame = 0;
        }

        public static void WalkAnimation(Graphics g, Entity player)
        {
            g.DrawImage(player.Sprites,
                new Rectangle(new Point(player.posX, player.posY),
                new Size(550, 390)),
                550 * player.currentFrame,
                390 * player.currentAnimation,
                550, 390,
                GraphicsUnit.Pixel);

            if (player.currentFrame < player.currentLimit - 1)
                player.currentFrame++;
            else
            {
                player.currentFrame = 0;
                player.isMoving = false;
                player.SetAnimation(0);
            }
        }

        public static void AttackAnimation(Graphics g, Entity player)
        {
            g.DrawImage(player.Sprites,
                new Rectangle(new Point(player.posX, player.posY),
                new Size(685, 390)),
                685 * player.currentFrame,
                390 * player.currentAnimation,
                685, 390,
                GraphicsUnit.Pixel);

            if (player.isAttacking == true && player.currentFrame >= player.currentLimit / 2)
                player.isAttacking = false;

            if (player.currentFrame < player.currentLimit - 1)
                player.currentFrame++;
            else
            {
                player.currentFrame = 0;
                player.isMoving = false;
                player.SetAnimation(0);
            }
        }

        public static void SettingsOnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (player1.currentFrame < player1.currentLimit - 1)
                player1.currentFrame++;
            else player1.currentFrame = 0;

            g.DrawImage(player1.Sprites,
                new Rectangle(new Point(player1.posX, player1.posY),
                new Size(500, 390)),
                500 * player1.currentFrame,
                390 * player1.currentAnimation,
                500, 390,
                GraphicsUnit.Pixel);
        }

        public static void StartPlay()
        {
            player1 = new Entity
                (0, 600, 
                Hero.idleFrames, 
                Hero.walkFrames, 
                Hero.attackFrames, 
                Hero.deathFrames, 
                hero1);

            player2 = new Entity
                (1000, 600,
                Hero.idleFrames,
                Hero.walkFrames,
                Hero.attackFrames,
                Hero.deathFrames,
                hero2);
        }
    }
}
