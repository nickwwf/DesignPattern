using System;
using System.Linq.Expressions;

namespace _17解释器模式
{
    class Program
    {
        //规则：Robert 和 John 是男性
        static IExpression GetMaleExpression()
        {
            var robert = new TerminalExpression("Robert");
            var john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }

        //规则：Julie 是一个已婚的女性
        static IExpression GetMarriedWomanExpression()
        {
            var julie = new TerminalExpression("Julie");
            var married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var isMale = GetMaleExpression();
            var isMarriedWoman = GetMarriedWomanExpression();

            Console.WriteLine("John is male? " + isMale.Interpret("John"));
            Console.WriteLine("Julie is a married women? " + isMarriedWoman.Interpret("Married Julie"));
        }
    }
}
