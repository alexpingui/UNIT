using System.Collections.Generic;
using System.Drawing;
using UNIT_rebuild.Enums;
using UNIT_rebuild.MapObjects;
using UNIT_rebuild.MapObjects.Obstacles;
using UNIT_rebuild.MapObjects.Samples;

namespace UNIT_rebuild.Maps
{
    /// <summary>
    /// Класс-шаблон проигрываемой в игре карты
    /// </summary>
    public class MAP_1 : Map
    {
        // шаблоны для упрощения написания карты
        Sample sample = new WholeBlock();
        PadSample padYellow = new PadSample(PadType.Yellow);

        public override void GetMap(out List<MapObject> obstacles, out List<BackGround> backGrounds, out Ground ground)
        {
            obstacles = new List<MapObject>
            {
                new Start(5,15),
                //
                new Block(14,7),
                new Block(20,8),
                new Block(21,8),
                new Block(22,8),
                new Block(23,8),
                new Block(24,8),
                new Block(23,7),
                new Block(24,9),
                new Block(31,7),
                new Block(32,7),
                new Block(33,7),
                new Block(34,7),
                new Block(35,7),
                new Block(36,7),
                new Block(37,7),
                new Block(49,7),
                new Block(49,8),
                new Block(59,7),
                new Block(59,8),
                new Block(59,9),
                new Block(61,8),
                //new Block(64,11),
                new Block(65,11),
                new Block(66,11),
                new Block(70,9),
                new Block(71,9),
                new Block(72,9),
                new Block(73,9),
                new Block(71,8),
                new Block(71,7),
                new Block(73,10),
                new Block(73,11),
                new Block(74,10),
                new Block(75,10),
                new Block(76,10,ObstacleType.Half),
                new Block(70,14),
                new Block(71,14),
                new Block(72,14),
                new Block(79,7),
                new Block(79,8),
                new Block(80,8),
                new Block(81,8),
                new Block(82,8),
                new Block(83,11),
                new Block(83,12),
                new Block(83,13),
                new Block(84,13),
                new Block(85,13),
                new Block(85,7),
                new Block(86,7),
                new Block(90,7),
                new Block(90,8),
                new Block(90,9),
                //new Block(90,11),
                new Block(90,12),
                new Block(90,13),
                new Block(90,14),
                new Block(90,15),
                new Block(89,15),
                new Block(88,15),
                new Block(87,15),
                new Block(91,7),
                new Block(93,7),
                new Block(94,7),
                new Block(99,9),

                new Block(62,8),
                //
                new Spike(13,7),
                new Spike(16,7),
                new Spike(18,7),
                new Spike(23,9),
                new Spike(30,7),
                new Spike(35,8),
                new Spike(36,8),
                new Spike(37,8),
                new Spike(43,7),
                new Spike(44,7),
                new Spike(47,7),
                new Spike(48,7),
                new Spike(49,9),
                new Spike(55,7),
                new Spike(59,10),
                new Spike(64,7),
                new Spike(72,15f),
                new Spike(73,15f),
                new Spike(74,15f),
                new Spike(80,9),
                new Spike(87,7),
                new Spike(91,8),

                new Block(14,8, ObstacleType.Half),
                new Block(18,9, ObstacleType.Half),
                new Block(21,11,ObstacleType.Half),
                new Block(50,8, ObstacleType.Half),
                new Block(53,7, ObstacleType.Half),
                new Block(52,7, ObstacleType.Half),
                new Block(84,8, ObstacleType.Half),
                new Block(83,8, ObstacleType.Half),
                new Block(82,8, ObstacleType.Half),
                new Block(89,7, ObstacleType.Half),
                new Block(104,11, ObstacleType.Half),


                //
                new Pad (42, 7),
                new Pad (61, 9),
                new Pad (62, 9),
                new Pad (93, 8),
                new Pad (94, 8),
                new Pad (99, 10),
                new Pad (104,12),

                //
                 new Spike(17,7, ObstacleType.Half),
                new Spike(24,10, ObstacleType.Half),
                new Spike(21,12, ObstacleType.Half),
                new Spike(45,7, ObstacleType.Half),
                new Spike(46,7, ObstacleType.Half),
                new Spike(63,7, ObstacleType.Half),
                new Spike(74,11, ObstacleType.Half),
                new Spike(79,9, ObstacleType.Half),
                new Spike(89,8, ObstacleType.Half),

                //
                new Orb(46,10),
                new Orb(57,9) ,


                //
                new Finish(120,15)
                // у каждого конструктора есть шесть вариаций
            };

            // инициализация остальных компонентов карты по умолчанию
            backGrounds = base.backGrounds;
            ground = base.ground;
        }
    }
}
