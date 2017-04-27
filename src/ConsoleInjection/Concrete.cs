using System;
using Microsoft.Extensions.Logging;

namespace ConsoleInjection
{
    public class Concrete : IInjectable
    {
        ILogger<Concrete> logger;

        public Concrete(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<Concrete>();
        }

        public void Execute()
        {
            logger.LogDebug("Hello World!");
        }
    }
}