using System;
using System.Drawing;
using UNIT_rebuild.Engine;
using UNIT_rebuild.Enums;
using UNIT_rebuild.MapObjects.Samples;
using UNIT_rebuild.Maps;

namespace UNIT_rebuild.MapObjects.Obstacles
{
    public class Spike : MapObject
    {
        /// <summary>
        /// Создает конкретный ObstacleType тип шипа, 
        /// принимая значения координат (для сетки 16х16) и множитель размера, 
        /// а также альтернативно смещение по сетке
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cellX"></param>
        /// <param name="cellY"></param>
        /// <param name="size"></param>
        /// <param name="shiftHorizontal"></param>
        /// <param name="shiftVertical"></param>
        public Spike(int cellX, int cellY, float size, ObstacleType type,
            float shiftHorizontal = 0,
            float shiftVertical = 0) : 
            base(cellX, cellY, shiftHorizontal, shiftVertical) 
        {
            isOnlyDeath = true;

            switch (type)
            {
                case ObstacleType.Whole:
                    sprite = Properties.Resources.SPIKE;
                    transform.size = new SizeF(64 * size, 64 * size);
                    break;
                case ObstacleType.Half:
                    sprite = Properties.Resources.SPIKE_Half;
                    transform.size = new SizeF(64 * size, 28 * size);
                    transform.position.Y += 36;
                    break;
                case ObstacleType.Quarter:
                    sprite = Properties.Resources.SPIKE;
                    transform.position.Y += 36;
                    transform.size = new SizeF(28 * size, 28 * size);
                    break;
            }
        }

        public Spike(int cellX, int cellY) : this(cellX, cellY, 1, ObstacleType.Whole)
        { }

        public Spike(int cellX, int cellY, ObstacleType type, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, cellY, 1, type, shiftHorizontal, shiftVertical)
        { }

        public Spike(int cellX, int cellY, float size, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, cellY, size, ObstacleType.Whole, shiftHorizontal, shiftVertical)
        { }

        public Spike(int cellX, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, Map.groundPoint + 1, 1, shiftHorizontal, shiftVertical)
        { }

        public Spike(Sample block) : this(block.cellX, block.cellY, block.size, block.type)
        { }


        protected override bool GetCollide(MapObject obstacle, PointF delta, Physics player)
        {
            if (Math.Abs(delta.Y) <= ((player.transform.size.Height + obstacle.transform.size.Height) / 2) - 9)
            {
                if (Math.Abs(delta.X) <= ((player.transform.size.Width + obstacle.transform.size.Width) / 2) - 20)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
