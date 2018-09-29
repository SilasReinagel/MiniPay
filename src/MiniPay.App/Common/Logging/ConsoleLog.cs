using System;

namespace MiniPay
{
    public sealed class ConsoleLog : ILog
    {
        public void Print(string message)
        {
            Console.WriteLine( message);
        }
    }
}
