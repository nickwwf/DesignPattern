using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    /// <summary>
    /// 线程不安全
    /// </summary>
    public class 懒汉式
    {
        private static 懒汉式 instance;

        private 懒汉式()
        {

        }

        public static 懒汉式 GetInstance()
        {
            if (instance == null)
                instance = new 懒汉式();
            return instance;
        }
    }
    /// <summary>
    /// 线程安全
    /// </summary>
    public class 懒汉式_Safe
    {
        private static 懒汉式_Safe instance;
        private 懒汉式_Safe()
        {

        }

        public static 懒汉式_Safe GetInstance()
        {
            lock(instance)
            {
                if (instance == null)
                    instance = new 懒汉式_Safe();
                return instance;
            }
        }
    }
}
