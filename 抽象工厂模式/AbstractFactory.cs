using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    public abstract class AbstractFactory
    {
        public abstract IColor getColor(String color);
        public abstract IShape getShape(String shape);
    }
}
