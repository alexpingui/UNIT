using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using UNIT_rebuild.Enums;
using UNIT_rebuild.MapObjects;
using UNIT_rebuild.MapObjects.Obstacles;

namespace UNIT_rebuild.Engine
{
    /// <summary>
    /// Описывает физику персонажа и его реакцию на коллизию с другими объектами
    /// </summary>
    public class Physics : MapObject 
    {
        Image sprite = Properties.Resources.ИГРОК_1;
        public float gravity;
        
        float a;
        float jumpValue;
        float coefBigJump;
        public bool CollideFinish;
        public bool isJumping;

        public Physics(Point position) : base(position.X, position.Y)
        {
            gravity = 0;

            jumpValue = -1 * Level.speedOfMap * 1.7f;
            coefBigJump = 1.31f;
            a = -1 * jumpValue * 0.1f;

            isJumping = true;
        }
        public void CalculatePhysics()
        {
           if (CollideNotDeath(out MapObject obstacle))
            {
                switch (obstacle)
                {
                    case Finish finish:
                        CollideFinish = true; break;
                    

                    case Pad pad :
                        
                        break;
                    case Block block:
                    case Portal portal:
                        isJumping = false;
                        gravity = 0;
                        break;
                    
                }
            }

            else if (CollideGround())
            {
                isJumping = false;
            }
            

            else
            {
                isJumping = true;
            }

            if (isJumping)
            {
                transform.position.Y += gravity;
                gravity += a;
            }
        }

        public void Jump()
        {
            if (!isJumping || CollideOrb())
            {
                
                isJumping = true;
                gravity = jumpValue;

                /*Bitmap bit_map = new Bitmap(sprite.Width, sprite.Height);
                Graphics gfx = Graphics.FromImage(bit_map);

                gfx.TranslateTransform(bit_map.Width / 2, -bit_map.Height / 2);
                gfx.RotateTransform(45);

                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;*/
            }
        }

        public void BigJump()
        {
            isJumping = true;
            gravity = jumpValue * coefBigJump;
        }

        public bool CollideOrb()
        {
            for (int i = 0; i < Level.obstacles.Count; i++)
            {
                if (Level.obstacles[i] is Orb orb && Level.obstacles[i].transform.position.X <= Transform.windowSize.Width)
                {
                    if (orb != null && orb.IsCollide(this)) return true;
                }
            }
            return false;
        }

        
        

        public bool CollideGround()
        {
            var ground = Level.ground;
            PointF delta = new PointF();
            delta.Y = (transform.position.Y + transform.size.Height / 2) - (ground.transform.position.Y + ground.transform.size.Height / 2);

            if (Math.Abs(delta.Y) - gravity <= (transform.size.Height + ground.transform.size.Height) / 2)
            {
                transform.position.Y = ground.transform.position.Y - transform.size.Height;
                return true;
            }
            return false;
        }
       


        public bool CollideNotDeath(out MapObject currentObstacle)
        {
            for (int i = 0; i < Level.obstacles.Count; i++)
            {
                if ((Level.obstacles[i] is Pad)|| (Level.obstacles[i] is Finish))
                {
                    INotDeathCollide obstacle = (INotDeathCollide)Level.obstacles[i];
                    bool isCollide = obstacle.IsNotDeathCollide(gravity, this);
                    if (isCollide)
                    {
                        currentObstacle = Level.obstacles[i];
                        currentObstacle.WhenCollided(this);
                        return true;
                    }
                }
            }

        

            for (int i = 0; i < Level.obstacles.Count; i++)
            {
                if (!(Level.obstacles[i] is Spike) && !(Level.obstacles[i] is Orb) && !(Level.obstacles[i] is Pad) && !(Level.obstacles[i] is Start) && !(Level.obstacles[i] is Finish))
                {
                    INotDeathCollide obstacle = (INotDeathCollide)Level.obstacles[i];
                    bool isCollide = obstacle.IsNotDeathCollide(gravity, this);
                    if (isCollide) 
                    { 
                        currentObstacle = Level.obstacles[i]; 
                        currentObstacle.WhenCollided(this);
                        return true; 
                    }
                }
            }
            currentObstacle = null;
            return false;
        }

        public bool CollideDeath()
        {
            for (int i = 0; i < Level.obstacles.Count; i++)
            {
                if (Level.obstacles[i] is Block block && Level.obstacles[i].transform.position.X <= Transform.windowSize.Width)
                {
                    if (block != null && block.IsCollide(this)) return true;
                }

                if (Level.obstacles[i] is Spike spike && Level.obstacles[i].transform.position.X <= Transform.windowSize.Width)
                {
                    if (spike != null && spike.IsCollide(this)) return true;
                }
            }

            return false;
        }
    }
}
