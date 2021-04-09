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
                Console.SetCursorPosition(0, Console.CursorTop);

                var current = DateTime.Now;
                Console.Write(current.ToLongTimeString());

                Thread.Sleep(1000);
            }
        }
    }
}
