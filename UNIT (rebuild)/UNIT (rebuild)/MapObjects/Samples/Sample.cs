using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIT_rebuild.Enums;

namespace UNIT_rebuild.MapObjects.Samples
{
    /// <summary>
    /// Базовый шаблон для блоков и шипов
    /// </summary>
    public class Sample
    {
        public ObstacleType type;
        public float size;
        public int cellX;
        public int cellY;
        public float shiftVertical;
        public float shiftHorizontal;

        public Sample(int cellX, int cellY, float size, ObstacleType type) 
        {
            this.type = type;
            this.cellX = cellX;
            this.cellY = cellY;
            this.size = size;
        }
    }
}
