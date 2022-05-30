using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fighting
{
    public class Entity
    {
        public int posX;
        public int posY;
        public int side;

        public int dirX;
        public bool isMoving;
        public bool isAttacking;

        public int currentAnimation;
        public int currentFrame;
        public int currentLimit;

        public Image sprites;
        public PictureBox hurtBox;
        public PictureBox hitBox;

        public Entity(int posX, int posY, int side, Image sprites, PictureBox hurtBox, PictureBox hitBox)
        {
            this.posX = posX;
            this.posY = posY;
            this.side = side;
            this.sprites = sprites;
            this.hurtBox = hurtBox;
            this.hitBox = hitBox;
            currentLimit = 41;
        }

        public void SetAnimation(int currentAnimation)
        {
            this.currentAnimation = currentAnimation;

            switch (currentAnimation)
            {
                case 0:
                    currentLimit = 41;
                    break;
                case 1:
                    currentLimit = 13;
                    break;
                case 2:
                    currentLimit = 13;
                    break;
                case 3:
                    currentLimit = 30;
                    break;
            }
        }
    }
}
