using System;
using System.Collections.Generic;
using System.Text;

namespace _21观察者模式
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Octal String: " + subject.GetState());
        }
    }
}
