using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor getColor(string color)
        {
            return null;
        }

        public override IShape getShape(string shape)
        {
            if (shape == null)
            {
                return null;
            }
            if (shape.Equals("CIRCLE", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Circle();
            }
            else if (shape.Equals("RECTANGLE", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Rectangle();
            }
            else if (shape.Equals("SQUARE", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Square();
            }
            return null;
        }
    }
}
