using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class ConsoleLogger
    {
        ILogger logger;
        public ConsoleLogger(ILogger logger)
        {
            this.logger = logger;
        }
        public void LogError(string msg)
        {
            logger.Log(msg);
        }
    }
}
