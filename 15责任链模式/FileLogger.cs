using System;
using System.Collections.Generic;
using System.Text;

namespace _15责任链模式
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }
}
