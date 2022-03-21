using System;

namespace 重写Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            //var t1 = new Test() { MyProperty = "1" };
            //var t2 = new Test() { MyProperty = "1" };
            //string str1 = "aa";
            //string str2 = "aa";
            //Console.WriteLine(str1.Equals(str2));
            //Console.ReadKey();

            Console.WriteLine(GetNumber(10));
            Console.ReadKey();
        }

        //输出斐波那契额数列
        private static void FibTest()
        {
            Func<int, int> Fib = num =>
            {
                var a = 1;
                var b = 1;
                for (var i = 0; i < num - 1; i++)
                {
                    var t = a;
                    a = b;
                    b = a + t;
                }
                return a;
            };

            Console.WriteLine(Fib(10).ToString());
        }

        private static int GetNumber(int num)
        {
            if (num == 1 || num == 2) return 1;
            return GetNumber(num - 1) + GetNumber(num - 2);
        }
    }

    public class Test
    {
        public string MyProperty { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Test test)
                return MyProperty == test.MyProperty;
            return false;
        }

        public override int GetHashCode()
        {
            return MyProperty.GetHashCode();
        }
    }
}