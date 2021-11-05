using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _26访问者模式
{
    public interface IComputerPartVisitor
    {
        public void Visit(Computer computer);
        public void Visit(Mouse mouse);
        public void Visit(Keyboard keyboard);
        public void Visit(Monitor monitor);
    }
}
