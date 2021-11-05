using System;
using System.Collections.Generic;
using System.Text;

namespace _21观察者模式
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Binary String: " + Convert.ToString(subject.GetState(), 2).PadLeft(4, '0'));
        }
    }
}
