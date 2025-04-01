using System.Drawing;

namespace UNIT_rebuild.MapObjects
{
    public class BackGround : MapObject
    {
        /// <summary>
        /// Создает объект фона
        /// </summary>
        public BackGround(int CellX, float shiftHorizontal = 0) : base(CellX, 15, shiftHorizontal)
        {
            transform.size = new SizeF(Transform.windowSize.Width + 4, Transform.windowSize.Height);
            sprite = Properties.Resources.BG;
        }
    }
}
