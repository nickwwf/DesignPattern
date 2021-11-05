using System;
using System.Collections.Generic;
using System.Text;

namespace _22状态模式
{
    public interface IState
    {
        public void DoAction(Context context);
    }
}
