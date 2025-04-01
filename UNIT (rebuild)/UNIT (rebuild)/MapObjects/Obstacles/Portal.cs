using System.Drawing;
using UNIT__rebuild_.Enums;
using UNIT_rebuild.Engine;

namespace UNIT_rebuild.MapObjects.Obstacles
{
    public class Portal : MapObject, INotDeathCollide
    {
        public Portal(PortalType type, int cellX, int cellY, float size,
            float shiftHorizontal = 0, float shiftVertical = 0) : 
            base(cellX, cellY, shiftHorizontal, shiftVertical)
        {
            isOnlyDeath = false;

            transform.size = new SizeF(64 * 1.2f * size, 64 * 3 * size);
            switch (type)
            {
                case PortalType.Cub:
                    sprite = Properties.Resources.BLOCK;
                    break;
                case PortalType.Ship:
                    sprite = Properties.Resources.BLOCK;
                    break;
                case PortalType.Ball:
                    sprite = Properties.Resources.BLOCK;
                    break;
            }
        }

        public bool IsNotDeathCollide(float gravity, Physics player)
        {
            throw new System.NotImplementedException();
        }
    }
}
