using System;
using System.Collections.Generic;
using System.Text;

namespace _24策略模式
{
    public interface IStrategy
    {
        public int DoOperation(int num1, int num2);
    }
}
