using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIT_rebuild.Enums;
using UNIT_rebuild.Maps;

namespace UNIT_rebuild.MapObjects.Samples
{
    public class PadSample
    {
        public PadType type;
        public float size;
        public int cellX;
        public int cellY;
        public float shiftVertical;
        public float shiftHorizontal;

        public PadSample(int cellX, int cellY, float size, PadType type)
        {
            this.type = type;
            this.cellX = cellX;
            this.cellY = cellY;
            this.size = size;
        }

        public PadSample(PadType type) : this (0, Map.groundPoint + 1, 1, type)
        {
        }
    }
}
