using System;

namespace _14代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var img = new ProxyImage("test_10mb.jpg");

            img.Display();


        }
    }
}
