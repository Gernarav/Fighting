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
        public int attackFrames;
        public int deathFrames;

        public int currentAnimation;
        public int currentFrame;
        public int currentLimit;

        public Tuple<int, int> size;

        public Image spriteSheet;

        public Entity(int posX, int posY, int idleFrames, int walkFrames, int attackFrames, int deathFrames, Image spriteSheet)
        {
            this.posX = posX;
            this.posY = posY;
            this.idleFrames = idleFrames;
            this.walkFrames = walkFrames;
            this.attackFrames = attackFrames;
            this.deathFrames = deathFrames;
            this.spriteSheet = spriteSheet;
            var size = new Tuple<int, int>(120, 291);
            this.size = size;
            currentAnimation = 0;
            currentFrame = 0;
            currentLimit = idleFrames;
        }

        public void Move()
        {
            posX += dirX;
            posY += dirY;
        }
    }

    public static class Hero
    {
        public static int idleFrames = 8;
        public static int walkFrames = 8;
        public static int attackFrames = 7;
        public static int deathFrames = 5;
    }
}
