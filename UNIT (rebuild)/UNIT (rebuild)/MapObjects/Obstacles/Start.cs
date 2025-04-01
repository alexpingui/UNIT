using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIT_rebuild.Engine;
using UNIT_rebuild.Enums;
using UNIT_rebuild.MapObjects.Samples;
using UNIT_rebuild.Maps;

namespace UNIT_rebuild.MapObjects.Obstacles
{
    public class Start : MapObject
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
        public Start(int cellX, int cellY, float size, ObstacleType type,
            float shiftHorizontal = 0,
            float shiftVertical = 0) :
            base(cellX, cellY, shiftHorizontal, shiftVertical)
        {
            isOnlyDeath = false;

            type = ObstacleType.Whole;
            sprite = Properties.Resources.Start;
            transform.size = new SizeF(200 * size, 1024 * size);
        }

        public Start(int cellX, int cellY) : this(cellX, cellY, 1, ObstacleType.Whole)
        { }

        public Start(int cellX, int cellY, ObstacleType type, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, cellY, 1, type, shiftHorizontal, shiftVertical)
        { }

        public Start(int cellX, int cellY, float size, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, cellY, size, ObstacleType.Whole, shiftHorizontal, shiftVertical)
        { }

        public Start(int cellX, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, Map.groundPoint + 1, 1, shiftHorizontal, shiftVertical)
        { }

        public Start(Sample block) : this(block.cellX, block.cellY, block.size, block.type)
        { }


        protected override bool GetCollide(MapObject obstacle, PointF delta, Physics player)
        {
            if (Math.Abs(delta.Y) <= ((player.transform.size.Height + obstacle.transform.size.Height) / 2) )
            {
                if (Math.Abs(delta.X) <= ((player.transform.size.Width + obstacle.transform.size.Width) / 2) )
                {
                    return true;
                }
            }
            return false;
        }
    }
}

    
