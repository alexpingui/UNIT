using System;
using System.Drawing;
using UNIT_rebuild.Engine;
using UNIT_rebuild.Enums;
using UNIT_rebuild.MapObjects.Samples;
using UNIT_rebuild.Maps;

namespace UNIT_rebuild.MapObjects.Obstacles
{
    public class Pad : MapObject, INotDeathCollide
    {
        /// <summary>
        /// Создает конкретный PadType тип пада, 
        /// принимая значения координат (для сетки 16х16) и множитель размера, 
        /// а также альтернативно смещение по сетке
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cellX"></param>
        /// <param name="cellY"></param>
        /// <param name="size"></param>
        /// <param name="shiftHorizontal"></param>
        /// <param name="shiftVertical"></param>
        public Pad(int cellX, int cellY, float size, PadType type,
            float shiftHorizontal = 0, float shiftVertical = -58) : 
            base(cellX, cellY, shiftHorizontal, shiftVertical)
        {
            isOnlyDeath = false;

            transform.size = new SizeF(64 * size, 6 * size);
            switch (type)
            {
                case PadType.Yellow:
                    sprite = Properties.Resources.PAD_Yellow;
                    break;
                case PadType.Blue:
                    sprite = Properties.Resources.PAD_Yellow;
                    break;
                case PadType.Red:
                    sprite = Properties.Resources.PAD_Yellow;
                    break;
                case PadType.Purple:
                    sprite = Properties.Resources.PAD_Yellow;
                    break;
            }
        }

        public Pad(int cellX, int cellY) : this(cellX, cellY, 1, PadType.Yellow)
        { }

        public Pad(int cellX, int cellY, PadType type, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, cellY, 1, type, shiftHorizontal, shiftVertical)
        { }

        public Pad(int cellX, int cellY, float size, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, cellY, size, PadType.Yellow, shiftHorizontal, shiftVertical)
        { }

        public Pad(int cellX, float shiftHorizontal = 0,
            float shiftVertical = 0) : this(cellX, Map.groundPoint + 1, 1, shiftHorizontal, shiftVertical)
        { }

        public Pad(PadSample pad) : this(pad.cellX, pad.cellY, pad.size, pad.type)
        { }

        public Pad(int cellX, PadSample pad) : this(cellX, pad.cellY, pad.size, pad.type)
        { }
        protected override bool GetCollide(MapObject obstacle, PointF delta, Physics player)
        {
            if (Math.Abs(delta.X) <= ((player.transform.size.Width + obstacle.transform.size.Width) / 2))
                
            {
                if (Math.Abs(delta.Y)  <= ((player.transform.size.Height + obstacle.transform.size.Height) / 2))
                {
                         player.transform.position.Y = this.transform.position.Y - player.transform.size.Height;
                    return true;
                }
            }
            return false;
        }

        public bool IsNotDeathCollide(float gravity, Physics player)
        {
            return IsCollide(player);
        }

        public override void WhenCollided(Physics player)
        {
           
            player.BigJump();
        }
    }
}
