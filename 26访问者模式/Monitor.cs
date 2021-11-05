using System;
using System.Collections.Generic;
using System.Text;

namespace _26访问者模式
{
    public class Monitor : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
