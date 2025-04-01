using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIT_rebuild.MapObjects.Obstacles;

namespace UNIT_rebuild.Engine
{
    public interface INotDeathCollide
    {
        bool IsNotDeathCollide(float gravity, Physics player);
    }
}
