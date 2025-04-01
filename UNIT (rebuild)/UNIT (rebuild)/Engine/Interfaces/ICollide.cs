using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIT_rebuild.Engine
{
    public interface ICollide
    {
        bool IsCollide(Physics player);
    }
}
