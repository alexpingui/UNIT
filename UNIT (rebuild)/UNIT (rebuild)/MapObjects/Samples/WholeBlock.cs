using UNIT_rebuild.Enums;
using UNIT_rebuild.Maps;

namespace UNIT_rebuild.MapObjects.Samples
{
    /// <summary>
    /// Шаблон игрового блока.
    /// </summary>
    public class WholeBlock : Sample
    {
        /// <summary>
        /// Создает шаблон блока ObstacleType.Whole (целого) типа.
        /// </summary>
        /// <param name="cellX"></param>
        /// <param name="cellY"></param>
        public WholeBlock(int cellX, int cellY = Map.groundPoint + 1) : base (cellX, cellY, 1, ObstacleType.Whole)
        {
            this.cellX = cellX;
            this.cellY = cellY;
        }

        public WholeBlock() : base(0, Map.groundPoint + 1, 1, ObstacleType.Whole)
        {
        }
    }
}
