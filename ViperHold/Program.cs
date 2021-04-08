using System;
using System.Threading;

namespace ViperHold
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var current = DateTime.Now;
                Console.Write(current.ToLongTimeString());
                Console.SetCursorPosition(0, Console.CursorTop);

                Thread.Sleep(1000);
            }
        }
    }
}
