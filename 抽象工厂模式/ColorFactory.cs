using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor getColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            if (color.Equals("RED", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Red();
            }
            else if (color.Equals("GREEN", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Green();
            }
            return null;
        }

        public override IShape getShape(string shape)
        {
            return null;
        }
    }
}
