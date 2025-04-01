using System;
using System.Drawing;
using UNIT_rebuild.Engine;
using UNIT_rebuild.Enums;
using UNIT_rebuild.MapObjects.Samples;
using UNIT_rebuild.Maps;

namespace UNIT_rebuild.MapObjects.Obstacles
{
    public class Block : MapObject, INotDeathCollide
    {
        /// <summary>
        /// Создает конкретный ObstacleType тип блока, 
        /// принимая значения координат и размера (для сетки 16х16), 
        /// а также альтернативно смещение по сетке
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cellX"></param>
        /// <param name="cellY"></param>
        /// <param name="_size"></param>
        /// <param name="shiftHorizontal"></param>
        /// <param name="shiftVertical"></param>
        public Block(int cellX, int cellY, float size, ObstacleType type,
            float shiftHorizontal = 0,
            float shiftVertical = 0) :
            base(cellX, cellY, shiftHorizontal, shiftVertical)
        {
            isOnlyDeath = false;

            switch (type)
            {
                case ObstacleType.Whole: 
                    sprite = Properties.Resources.BLOCK;
                    transform.size = new SizeF(64 * size, 64 * size);
                    break;
                case ObstacleType.Half:
                    sprite = Properties.Resources.BLOCK_Half;
                    transform.size = new SizeF(64 * size, 28 * size);
                    break;
                case ObstacleType.Quarter:
                    sprite = Properties.Resources.BLOCK;
                    transform.size = new SizeF(28 * size, 28 * size);
                    break;
            }
        }

        public Block (int cellX, int cellY) : this(cellX, cellY, 1, ObstacleType.Whole)
        { }

        public Block (int cellX, int cellY, ObstacleType type, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, cellY, 1, type, shiftHorizontal, shiftVertical)
        { }

        public Block (int cellX, int cellY, float size, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, cellY, size, ObstacleType.Whole, shiftHorizontal, shiftVertical)
        { }

        public Block(int cellX, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, Map.groundPoint + 1, 1, shiftHorizontal, shiftVertical)
        { }

        public Block(Sample block) : this(block.cellX, block.cellY, block.size, block.type)
        { }

        public Block(int cellX, Sample block) : this(cellX, block.cellY, block.size, block.type)
        { }

        public bool IsNotDeathCollide(float gravity, Physics player)
        {
            GetDelta(this, out PointF delta, player);

            if (Math.Abs(delta.X) < ((player.transform.size.Width + this.transform.size.Width) / 2))
            {
                if ((Math.Abs(delta.Y) - (gravity)) <= ((player.transform.size.Height + this.transform.size.Height) / 2) )
                {
                    player.isJumping = false;
                    player.gravity = 0;
                    player.transform.position.Y = this.transform.position.Y - player.transform.size.Height;
                    
                    return true;
                }
            }

            return false;
        }

        protected override bool GetCollide(MapObject obstacle, PointF delta, Physics player)
        {
            if ((Math.Abs(delta.Y)) < ((player.transform.size.Height + obstacle.transform.size.Height) / 2))
            {
               if ((Math.Abs(delta.X)+1) <= ((player.transform.size.Width + obstacle.transform.size.Width) / 2))
               {
                    return true;
               }
            }
            return false;
        }
    }
}
