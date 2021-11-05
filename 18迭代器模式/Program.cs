using System;

namespace _18迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var namesRepository = new NameRepository();

            for (var iter = namesRepository.GetIterator(); iter.HasNext();)
            {
                var name = (string)iter.Next();
                Console.WriteLine("Name : " + name);
            }
        }
    }
}
