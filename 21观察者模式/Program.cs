using System;

namespace _21观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var subject = new Subject();

            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.SetState(15);
            Console.WriteLine("Second state change: 10");
            subject.SetState(10);
        }
    }
}
