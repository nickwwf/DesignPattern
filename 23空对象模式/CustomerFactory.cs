using System;
using System.Collections.Generic;
using System.Text;

namespace _23空对象模式
{
    public class CustomerFactory
    {
        public static readonly string[] names = { "Rob", "Joe", "Julie" };

        public static AbstractCustomer GetCustomer(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].ToLower().Equals(name.ToLower()))
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }
}
