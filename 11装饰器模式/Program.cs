using System;

namespace _11装饰器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            ShapeDecorator redCircle = new RedShapeDecorator(new Circle());
            ShapeDecorator redRectangle = new RedShapeDecorator(new Rectangle());
            Console.WriteLine("Circle with normal border");
            circle.Draw();

            Console.WriteLine("\nCircle of red border");
            redCircle.Draw();

            Console.WriteLine("\nRectangle of red border");
            redRectangle.Draw();
        }
    }
}
