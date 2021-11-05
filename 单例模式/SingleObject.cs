using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    public class SingleObject
    {
        private SingleObject()
        {

        }

        private static SingleObject instance = new SingleObject();

        public static SingleObject GetInstance()
        {
            return instance;
        }

        public void ShowMessgae()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
