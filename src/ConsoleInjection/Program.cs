using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Logging;

namespace ConsoleInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = BuildServiceProvider();
            var concrete = GetService<IInjectable>(provider);
            concrete.Execute();
        }

        static IServiceProvider BuildServiceProvider()
        {
            var provider = new ServiceCollection()
                .AddSingleton<IInjectable, Concrete>()
                .AddLogging()
                .BuildServiceProvider();
            
            provider
                .GetService<ILoggerFactory>()
                .AddConsole(LogLevel.Debug);

            return provider;
        }

        static T GetService<T>(IServiceProvider provider)
        {
            return provider.GetService<T>();
        }
    }
}