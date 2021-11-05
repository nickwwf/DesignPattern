using System;

namespace _15责任链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var loggerChain = GetChainOfLoggers();

            loggerChain.LogMessage(AbstractLogger.INFO, "This is an information.");

            loggerChain.LogMessage(AbstractLogger.DEBUG,
               "This is a debug level information.");

            loggerChain.LogMessage(AbstractLogger.ERROR,
               "This is an error information.");
        }

        private static AbstractLogger GetChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }
    }
}
