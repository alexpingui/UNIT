using System.Collections.Generic;
using System.Drawing;
using UNIT_rebuild.MapObjects;

namespace UNIT_rebuild.Maps
{
    /// <summary>
    /// Базовый класс для всех проигрываемых карт (уровней).
    /// </summary>
    public abstract class Map
    {
        public const int groundPoint = 6;

        public readonly Point startPosition;

        protected Map()
        {
            startPosition = new Point(3, groundPoint + 1);
        }

        protected Ground ground = new Ground(groundPoint);
        protected List<BackGround> backGrounds = new List<BackGround>
        {
            new BackGround(0),
            new BackGround(Transform.numberOfCellsX)
        };

        public virtual Point GetStartPosition()
        {
            return startPosition;
        }

        public abstract void GetMap(out List<MapObject> obstacles, out List<BackGround> backGrounds, out Ground ground);
    }
}
