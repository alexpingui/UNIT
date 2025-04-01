using UNIT_rebuild.Enums;

namespace UNIT_rebuild.MapObjects.Samples
{
    /// <summary>
    /// Шаблон игровой платформы-полублока.
    /// </summary>
    public class HalfBlock : Sample
    {
        /// <summary>
        /// Создает шаблон блока ObstacleType.Whole (целого) типа.
        /// isLowered true опустит объект на половину ячейки.
        /// </summary>
        /// <param name="cellX"></param>
        /// <param name="cellY"></param>
        public HalfBlock(int cellX, int cellY = 7, bool isLowered = false) : base (cellX, cellY, 1, ObstacleType.Half)
        {
            base.cellX = cellX;
            base.cellY = cellY;
            if (isLowered) shiftVertical = -36;
            else shiftVertical = 0;
        }

        public HalfBlock(int cellX, bool isLowered = false) : this (cellX, 7, isLowered)
        {
            this.cellX = cellX;
            cellY = 7;
            if (isLowered) shiftVertical = -36;
            else shiftVertical = 0;
        }
    }
}
