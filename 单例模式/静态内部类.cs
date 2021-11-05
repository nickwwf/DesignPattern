using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    public class 静态内部类
    {
        private 静态内部类()
        {

        }

        private static class Inner
        {
            internal static 静态内部类 single = new 静态内部类();
        }

        public static 静态内部类 GetInstance()
        {
            return Inner.single;
        }
    }
}
