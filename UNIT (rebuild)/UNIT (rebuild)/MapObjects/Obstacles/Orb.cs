using System;
using System.Drawing;
using UNIT_rebuild.Engine;
using UNIT_rebuild.Enums;
using UNIT_rebuild.MapObjects.Samples;
using UNIT_rebuild.Maps;

namespace UNIT_rebuild.MapObjects.Obstacles
{
    public class Orb : MapObject
    {
        /// <summary>
        /// Создает конкретный OrbType тип орба, 
        /// принимая значения координат(для сетки 16х16) и множитель размера, 
        /// а также альтернативно смещение по сетке
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cellX"></param>
        /// <param name="cellY"></param>
        /// <param name="_size"></param>
        /// <param name="shiftHorizontal"></param>
        /// <param name="shiftVertical"></param>
        public Orb(int cellX, int cellY, float size, OrbType type,
            float shiftHorizontal = 0,
            float shiftVertical = 0) : 
            base(cellX, cellY, shiftHorizontal, shiftVertical)
        {
            transform.size = new SizeF(64 * size, 64 * size);
            switch (type)
            {
                case OrbType.Yellow:
                    sprite = Properties.Resources.ORB_Yellow;
                    break;
                case OrbType.Green:
                    sprite = Properties.Resources.ORB_Yellow;
                    break;
                case OrbType.Blue:
                    sprite = Properties.Resources.ORB_Yellow;
                    break;
                case OrbType.Red:
                    sprite = Properties.Resources.ORB_Yellow;
                    break;
                case OrbType.Purple:
                    sprite = Properties.Resources.ORB_Yellow;
                    break;
                case OrbType.Black:
                    sprite = Properties.Resources.ORB_Yellow;
                    break;
            }
        }

        public Orb(int cellX, int cellY) : this(cellX, cellY, 1, OrbType.Yellow)
        { }

        public Orb(int cellX, int cellY, OrbType type, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, cellY, 1, type, shiftHorizontal, shiftVertical)
        { }

        public Orb(int cellX, int cellY, float size, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, cellY, size, OrbType.Yellow, shiftHorizontal, shiftVertical)
        { }

        public Orb(int cellX, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, Map.groundPoint + 1, shiftHorizontal, shiftVertical)
        { }

        public Orb(OrbSample pad) : this(pad.cellX, pad.cellY, pad.size, pad.type)
        { }

        public Orb(int cellX, OrbSample pad) : this(pad)
        { }

        protected override bool GetCollide(MapObject obstacle, PointF delta, Physics player)
        {
            if (Math.Abs(delta.X) < (player.transform.size.Width + obstacle.transform.size.Width) / 2)
            {
                if (Math.Abs(delta.Y) <= (player.transform.size.Height + (obstacle.transform.size.Height) / 2))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
