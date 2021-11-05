using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    /// <summary>
    /// 加了Lazy之后，只有当使用到的时候才加载
    /// </summary>
    public class Lazy_singleton
    {
        private Lazy_singleton()
        {

        }

        private static readonly Lazy<Lazy_singleton> single = new Lazy<Lazy_singleton>();

        public static Lazy_singleton GetInstance()
        {
            return single.Value;
        }
    }
}
