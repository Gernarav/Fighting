using System;
using System.Drawing;
using System.Windows.Forms;
namespace Fighting
{
    class View : Form
    {
        public static void PlayOnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            switch (Play_form.player1.currentAnimation)
            {
                case 0:
                    PlayAnimation(g, Play_form.player1, 390, 500);
                    break;
                case 1:
                    PlayAnimation(g, Play_form.player1, 390, 550);
                    break;
                case 2:
                    PlayAnimation(g, Play_form.player1, 390, 550);
                    break;
                case 3:
                    PlayAnimation(g, Play_form.player1, 390, 685);
                    break;
            }

            switch (Play_form.player2.currentAnimation)
            {
                case 0:
                    PlayAnimation(g, Play_form.player2, 390, 500);
                    break;
                case 1:
                    PlayAnimation(g, Play_form.player2, 390, 550);
                    break;
                case 2:
                    PlayAnimation(g, Play_form.player2, 390, 550);
                    break;
                case 3:
                    PlayAnimation(g, Play_form.player2, 390, 685);
                    break;
            }
        }

        public static void PlayAnimation(Graphics g, Entity player, int height, int width)
        {
            g.DrawImage(player.sprites,
                new Rectangle(new Point(player.posX, player.posY),
                new Size(width, height)),
                width * player.currentFrame,
                height * player.currentAnimation,
                width, height,
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

        public static void SettingsOnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }
    }
}
