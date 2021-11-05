using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17解释器模式
{
    public class TerminalExpression : IExpression
    {
        private string data;

        public TerminalExpression(string data)
        {
            this.data = data;
        }

        public bool Interpret(string context)
        {
            if (context.Contains(data))
            {
                return true;
            }
            return false;
        }
    }
}
