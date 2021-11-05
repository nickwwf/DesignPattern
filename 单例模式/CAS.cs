using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 单例模式
{
    /// <summary>
    /// 线程安全
    /// </summary>
    public class CAS
    {
        private static CAS single;
        private CAS()
        {

        }

        public static CAS GetInstance()
        {
            if (single != null) return single;
            var v = new CAS();
            Interlocked.CompareExchange(ref single, v, null);
            return single;
        }
    }
}
