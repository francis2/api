using System;
using System.Diagnostics;

namespace Tradovate
{
    public static class Log
    {
        static private Stopwatch stopwatch = new Stopwatch();
        static public void Write(object message)
        {            
            Console.WriteLine($"[+{stopwatch.ElapsedMilliseconds}] {message}");
            stopwatch.Restart();
        }
    }
}
