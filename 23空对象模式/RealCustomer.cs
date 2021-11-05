using System;
using System.Collections.Generic;
using System.Text;

namespace _23空对象模式
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            Name = name;
        }

        public override string GetName()
        {
            return Name;
        }

        public override bool IsNil()
        {
            return false;
        }
    }
}
