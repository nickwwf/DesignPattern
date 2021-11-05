using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7桥接模式
{
    public interface IDrawAPI 
    {
        void DrawCircle(int radius, int x, int y);
    }
}
