using System;
using System.Collections.Generic;
using System.Text;

namespace _21观察者模式
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Hex String: " + subject.GetState());
        }
    }
}
