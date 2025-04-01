using System;
using System.Drawing;
using UNIT_rebuild.Engine;

namespace UNIT_rebuild
{
    /// <summary>
    /// Описывает игровые объекты на карте
    /// </summary>
    public abstract class MapObject : ICollide
    {
        
        protected bool isOnlyDeath;

        /// <summary>
        /// Определяет, однозначно смертелен объект или нет
        /// </summary>
        public bool IsOnlyDeath { get; }

        protected Image sprite;

        public Transform transform;

        protected MapObject(int X, int Y, 
            float shiftHorizontal = 0, float shiftVertical = 0)
        {
            transform = new Transform(X, Y, shiftHorizontal, shiftVertical);
        }

        /// <summary>
        /// Вызывает перерисовку объекта
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            if (transform.position.X <= Transform.windowSize.Width + 128)
                g.DrawImage(sprite, new Rectangle((int)transform.position.X, (int)transform.position.Y, 
                    (int)transform.size.Width, 
                    (int)transform.size.Height));
        }

        /// <summary>
        /// Возвращает расстояние между центрами объектов
        /// </summary>
        /// <param name="obstacle"></param>
        /// <param name="delta"></param>
        /// <param name="player"></param>
        protected void GetDelta(MapObject obstacle, out PointF delta, Physics player)
        {
            delta = new PointF();
            delta.X = (player.transform.position.X + player.transform.size.Width / 2) - (obstacle.transform.position.X + obstacle.transform.size.Width / 2);
            delta.Y = (player.transform.position.Y + player.transform.size.Height / 2) - (obstacle.transform.position.Y + obstacle.transform.size.Height / 2);
        }

        public bool IsCollide(Physics player)
        {
            GetDelta(this, out PointF delta, player);
            return GetCollide(this, delta, player);
        }

        protected virtual bool GetCollide(MapObject obstacle, PointF delta, Physics player)
        {
            if (Math.Abs(delta.Y - 2) <= (player.transform.size.Height + obstacle.transform.size.Height) / 2)
            {
                if (Math.Abs(delta.X - 2) <= (player.transform.size.Width + obstacle.transform.size.Width) / 2)
                {
                    return true;
                }
            }
            return false;
        }

        public virtual void WhenCollided(Physics player)
        { }
    }
}
