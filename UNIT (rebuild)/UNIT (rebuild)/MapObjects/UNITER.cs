using System.Drawing;
using UNIT_rebuild.Engine;
using UNIT_rebuild.Maps;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UNIT_rebuild.MapObjects
{
    /// <summary>
    /// Описывает персонажа игры, его размер, спрайт(изображение). Принимает прописанную для него физику из класса
    /// Physics и выполняет отрисовку с учётом заданных параметров
    /// </summary>
    public class UNITER
    {
        public static Image sprite;
        public Physics physics;

        public UNITER(Map map)
        {
            sprite = Properties.Resources.ИГРОК_1;
            physics = new Physics(map.GetStartPosition());

            physics.transform.size.Width = Transform.cellSize ;
            physics.transform.size.Height = Transform.cellSize ;

            
        }



        public void DrawUNIT(Graphics g)
        {
            g.DrawImage(sprite, new Rectangle((int)physics.transform.position.X, (int)physics.transform.position.Y, (int)physics.transform.size.Width, (int)physics.transform.size.Height));  
            
            if(!physics.isJumping)
            { 
                g.RotateTransform(45);
            }
        }

       
      

    }
}
