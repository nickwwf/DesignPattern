using System;

namespace _12外观模式
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }
}
