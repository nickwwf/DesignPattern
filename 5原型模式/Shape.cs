using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5原型模式
{
    //***************************//
    // 对于原型模式,有两种处理方法：对象的浅拷贝和深拷贝
    //***************************//

    public abstract class Shape : ICloneable
    {
        private string Id;
        protected string Type;

        public abstract void Draw();

        public new string GetType()
        {
            return Type;
        }

        public string GetId()
        {
            return Id;
        }

        public void SetId(string id)
        {
            this.Id = id;

        }

        public object Clone()
        {
            return this.MemberwiseClone(); //浅复制
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle()
        {
            Type = "Rectangle";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }

    public class Circle : Shape
    {
        public Circle()
        {
            Type = "Circle";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }

    public class ShapeCache
    {
        static Dictionary<string, Shape> shape = new Dictionary<string, Shape>();

        public static Shape GetShape(string shapeId)
        {
            Shape cachedShape = shape[shapeId];
            return (Shape)cachedShape.Clone();
        }

        public static void LoadCache()
        {
            var circle = new Circle();
            circle.SetId("1");
            shape.Add(circle.GetId(), circle);
        }
    }
}
