using System;
using System.Drawing;
using UNIT_rebuild.Engine;

namespace UNIT_rebuild.MapObjects
{
    public class Ground : MapObject, INotDeathCollide
    {
        /// <summary>
        /// Создает объект граунда на указанной высоте
        /// </summary>
        /// <param name="Y"></param>
        /// <param name="shiftVertical"></param>
        public Ground(int cellY, float shiftVertical = 0) : 
            base(0, cellY, shiftVertical)
        {
            transform.size = new SizeF(Transform.windowSize.Width,
                Transform.windowSize.Height / 3.5f);

            sprite = Properties.Resources.GROUND;
        }

        public bool IsNotDeathCollide(float gravity, Physics player)
        {
            GetDelta(this, out PointF delta, player);

            if (Math.Abs(delta.Y) - gravity <= (player.transform.size.Height + this.transform.size.Height) / 2)
            {
                player.transform.position.Y = this.transform.position.Y - player.transform.size.Height;
                return true;
            }

            return false;
        }
    }
}
