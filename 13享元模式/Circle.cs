using System;

namespace _13享元模式
{
    public class Circle : IShape
    {
        private string color;
        private int x;
        private int y;
        private int radius;

        public Circle(String color)
        {
            this.color = color;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            
        }
    }
}
