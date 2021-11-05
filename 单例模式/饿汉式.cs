using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    public class 饿汉式
    {
        private 饿汉式()
        {

        }

        private static 饿汉式 instance = new 饿汉式();

        public static 饿汉式 GetInstance()
        {
            return instance;
        }
    }
}
