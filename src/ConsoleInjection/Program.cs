using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection();

            Console.WriteLine("Hello World!");
        }
    }
}