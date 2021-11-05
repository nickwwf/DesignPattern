using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12外观模式
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle::draw()");
        }
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square::draw()");
        }
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle::draw()");
        }
    }
}
