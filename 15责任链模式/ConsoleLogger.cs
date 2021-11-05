using System;
using System.Collections.Generic;
using System.Text;

namespace _15责任链模式
{ 
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level) 
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Standard Console::Logger: " + message);
        }
    }
}
