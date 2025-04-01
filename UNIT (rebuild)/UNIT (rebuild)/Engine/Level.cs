using System.Collections.Generic;
using System.Drawing;
using UNIT_rebuild.MapObjects;
using UNIT_rebuild.Maps;

namespace UNIT_rebuild.Engine
{
    /// <summary>
    /// 
    /// </summary>
    public static class Level
    {
        public static int speedOfMap = 15;
        public static List<MapObject> obstacles;
        public static List<BackGround> backGrounds;
        public static Ground ground;
        public static Physics physics;

        public static void Start(Map map, out UNITER unit)
        {
            map.GetMap(out obstacles, out backGrounds, out ground);
            unit = new UNITER(map);
        }

        public static void MoveMap()
        {
            for (int i = 0; i < backGrounds.Count; i++)
            {
                
                backGrounds[i].transform.position.X -= (speedOfMap - 3);
                if (backGrounds[i].transform.position.X + backGrounds[i].transform.size.Width < 0)
                {

                    backGrounds.RemoveAt(i);
                    GetNewBG();
                    
                }
            }

            for (int i = 0; i < obstacles.Count; i++)
            {
                obstacles[i].transform.position.X -= speedOfMap;
                if (obstacles[i].transform.position.X + obstacles[i].transform.size.Width < 0)
                {
                   
                    obstacles.RemoveAt(i);
                   
                }
            }
        }
        public static void GetNewBG()
        {
            BackGround backGround = new BackGround(Transform.numberOfCellsX);
            backGrounds.Add(backGround);
        }

        public static void DrawMap(Graphics g)
        {
            for (int i = 0; i < backGrounds.Count; i++)
            {
               backGrounds[i].Draw(g);
            }
            for (int i = 0; i < obstacles.Count; i++)
            {
                obstacles[i].Draw(g);
            }
            ground.Draw(g);
        }
    }
}
