using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    public class Entity
    {
        public int posX;
        public int posY;

        public int dirX;
        public bool isMoving;
        public bool isAttacking;

        public int idleFrames;
        public int walkFrames;
        public int attackFrames;
        public int deathFrames;

        public int currentAnimation;
        public int currentFrame;
        public int currentLimit;

        public Image Sprites;

        public Entity(int posX, int posY, int idleFrames, int walkFrames, int attackFrames, int deathFrames, Image spriteSheet)
        {
            this.posX = posX;
            this.posY = posY;
            this.idleFrames = idleFrames;
            this.walkFrames = walkFrames;
            this.attackFrames = attackFrames;
            this.deathFrames = deathFrames;
            Sprites = spriteSheet;
            currentAnimation = 0;
            currentFrame = 0;
            currentLimit = idleFrames;
        }

        public void Move()
        {
            posX += dirX;
        }

        public void SetAnimation(int currentAnimation)
        {
            this.currentAnimation = currentAnimation;

            switch(currentAnimation)
            {
                case 0:
                    currentLimit = idleFrames;
                    break;
                case 1:
                    currentLimit = walkFrames;
                    break;
                case 2:
                    currentLimit = walkFrames;
                    break;
                case 3:
                    currentLimit = attackFrames;
                    break;
                case 4:
                    currentLimit = deathFrames;
                    break;
            }
        }
    }

    public static class Hero
    {
        public static int idleFrames = 41;
        public static int walkFrames = 13;
        public static int attackFrames = 30;
        public static int deathFrames = 5;
    }
}
