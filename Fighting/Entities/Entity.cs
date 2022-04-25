using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Fighting.Entites
{
    public class Entity
    {
        public int posX;
        public int posY;

        public int dirX;
        public int dirY;
        public bool isMoving;

        public int idleFrames;
        public int runFrames;
        public int attackFrames;
        public int deathFrames;

        public Tuple<int,int> size;

        public Image spriteSheet;

        public Entity(int posX, int posY, int idleFrames, int runFrames, int attackFrames, int deathFrames, Image spriteSheet)
        {
            this.posX = posX;
            this.posY = posY;
            this.idleFrames = idleFrames;
            this.runFrames = runFrames;
            this.attackFrames = attackFrames;
            this.deathFrames = deathFrames;
            this.spriteSheet = spriteSheet;
            var size = new Tuple<int, int>(230, 380);
            this.size = size;
        }

        public void Move()
        {
            posX += dirX;
            posY += dirY;
        }
    }
}
    