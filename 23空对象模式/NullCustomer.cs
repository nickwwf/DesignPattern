using System;
using System.Collections.Generic;
using System.Text;

namespace _23空对象模式
{
    public class NullCustomer : AbstractCustomer
    {
        public override string GetName()
        {
            return "Not Available in Customer Database";
        }

        public override bool IsNil()
        {
            return true;
        }
    }
}
