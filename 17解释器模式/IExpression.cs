using System;
using System.Collections.Generic;
using System.Text;

namespace _17解释器模式
{
    public interface IExpression
    {
        public bool Interpret(string context);
    }
}
