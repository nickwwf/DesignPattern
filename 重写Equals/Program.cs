using System;

namespace 重写Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Test() { MyProperty = "1" };
            var t2 = new Test() { MyProperty = "1" };
            string str1 = "aa";
            string str2 = "aa";
            Console.WriteLine(str1.Equals(str2));
            Console.ReadKey();
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
