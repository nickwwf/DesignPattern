using System;
using System.Collections.Generic;
using System.Text;

namespace _23空对象模式
{
    public abstract class AbstractCustomer
    {
        protected string Name;
        public abstract bool IsNil();
        public abstract string GetName();
    }
}
