using System;

namespace _25模板模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Game game = new Cricket();
            game.Play();
            Console.WriteLine();
            game = new Football();
            game.Play();
        }
    }
}
