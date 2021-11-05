using System;
using System.Collections.Generic;
using System.Text;

namespace _26访问者模式
{
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
