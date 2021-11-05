using System;
using System.Collections.Generic;
using System.Text;

namespace _18迭代器模式
{
    public interface IContainer
    {
        public IIterator GetIterator();
    }
}
