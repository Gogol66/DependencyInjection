using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Service();
            ConsoleLogger consoleLogger = new ConsoleLogger(logger);
            consoleLogger.LogError("Testing Constructor Dependency Injection");
            Singleton singleton = Singleton.Instance;
            Console.ReadKey();
        }
    }
}
