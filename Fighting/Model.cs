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
        public int dirY;
        public bool isMoving;

        public int idleFrames;
        public int walkFrames;
        public int sitFrames;
        public int jumpFrames;
        public int attackFrames;
        public int deathFrames;

        public int currentAnimation;
        public int currentFrame;
        public int currentLimit;

        public Tuple<int, int> size;

        public Image spriteSheet;

        public Entity(int posX, int posY, int idleFrames, int walkFrames, int sitFrames, int jumpFrames, int attackFrames, int deathFrames, Image spriteSheet)
        {
            this.posX = posX;
            this.posY = posY;
            this.idleFrames = idleFrames;
            this.walkFrames = walkFrames;
            this.sitFrames = sitFrames;
            this.jumpFrames = jumpFrames;
            this.attackFrames = attackFrames;
            this.deathFrames = deathFrames;
            this.spriteSheet = spriteSheet;
            this.size = new Tuple<int, int>(519, 476);
            currentAnimation = 0;
            currentFrame = 0;
            currentLimit = idleFrames;
        }

        public void Move()
        {
            posX += dirX;
            posY += dirY;
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
                    currentLimit = sitFrames;
                    break;
                case 3:
                    currentLimit = jumpFrames;
                    break;
                case 4:
                    currentLimit = attackFrames;
                    
                    break;
                case 5:
                    currentLimit = deathFrames;
                    break;
            }
        }
    }

    public static class Hero
    {
        public static int idleFrames = 24;
        public static int walkFrames = 24;
        public static int sitFrames = 3;
        public static int jumpFrames = 5;
        public static int attackFrames = 14;
        public static int deathFrames = 5;
    }
}
