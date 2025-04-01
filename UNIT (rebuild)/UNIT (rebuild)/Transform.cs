using System;
using System.Drawing;

namespace UNIT_rebuild
{
    /// <summary>
    /// Описывает положение и размер объекта в двумерном пространстве с помощью сетки 16х16.
    /// Также содержит базовую информацию о свойствах игрового пространства.
    /// </summary>
    public class Transform
    {
        static private Size WindowSize;

        /// <summary>
        /// Размер окна для приложения в пикселях
        /// </summary>
        static public Size windowSize { get { return WindowSize; } }

        /// <summary>
        /// Размер квадратной ячейки в пикселях
        /// </summary>
        public const int cellSize = 64;

        /// <summary>
        /// Количество видимых в окне ячеек по горизонтали в соответствии с размером ячейки
        /// </summary>
        static public int NumberOfCellsX;

        static public int numberOfCellsX { get { return NumberOfCellsX; } }

        /// <summary>
        /// Количество видимых в окне ячеек по вертикали в соответствии с размером ячейки
        /// </summary>
        static public int NumberOfCellsY;

        static public int numberOfCellsY { get { return NumberOfCellsY; } }

        public static void GetSizeOfForm(int width, int height)
        {
            WindowSize = new Size()
            {
                Width = width,
                Height = height
            };

            NumberOfCellsX = (int)Math.Ceiling((double)(windowSize.Width / cellSize));
            NumberOfCellsY = (int)Math.Ceiling((double)(windowSize.Height / cellSize));
        }

        /// <summary>
        /// Позиция в двумерном пространстве
        /// </summary>
        public PointF position;

        /// <summary>
        /// Размер двумерного объекта
        /// </summary>
        public SizeF size;

        public Transform(float X, int Y, float shiftHorizontal = 0, float shiftVertical = 0) 
        {
            position.X = (cellSize * X + shiftHorizontal);
            position.Y = (cellSize * (15 - Y) - shiftVertical);
        }

    }
}
