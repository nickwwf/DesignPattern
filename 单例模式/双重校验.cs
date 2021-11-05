using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    /// <summary>
    /// 这种方式采用双锁机制，安全且在多线程情况下能保持高性能。
    /// </summary>
    public class 双重校验
    {
        private static 双重校验 single;

        private 双重校验()
        {

        }

        private static readonly object lockObj = new object();

        public static 双重校验 GetInstance()
        {
            if (single == null)
            {
                lock (lockObj)
                {
                    if (single == null)
                    {
                        single = new 双重校验();
                    }
                }
            }
            return single;
        }
    }
}
