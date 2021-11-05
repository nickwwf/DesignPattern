using System;

namespace _22状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var context = new Context();

            var startState = new StartState();
            var stopState = new StopState();

            startState.DoAction(context);
            Console.WriteLine(context.GetState().ToString());

            stopState.DoAction(context);
            Console.WriteLine(context.GetState().ToString());
        }
    }
}
