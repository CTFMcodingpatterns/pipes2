using System;
using pipeslib;
using pipeslib.Handlers;

namespace pipescli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("hello2");

            var steps = new IHandler<string>[] {};
            Pipeline1<string> pipe1 = new Pipeline1<string>(steps);
            
        }
    }
}
