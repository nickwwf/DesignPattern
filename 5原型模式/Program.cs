using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCache.LoadCache();

            Shape clonedShape = (Shape)ShapeCache.GetShape("1");
            clonedShape = new Circle();
            clonedShape.SetId("2");
            Shape clonedShape2 = (Shape)ShapeCache.GetShape("1");
            Console.WriteLine("Shape : " + clonedShape.GetType());
        }
    }
}