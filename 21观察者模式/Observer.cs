using System;
using System.Collections.Generic;
using System.Text;

namespace _21观察者模式
{
    public abstract class Observer
    {
        protected Subject subject;

        public abstract void Update();
    }
}
