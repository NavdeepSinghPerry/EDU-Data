using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {

            logger.Trace("This is a Trace message");
            logger.Debug("This is a Debug message");
            //throw (new Exception());

            logger.Info("This is an Info message");
            logger.Warn("Warn AAA");
            logger.Error("Error AAA");
            logger.Fatal("Fatal AAA");
            Console.ReadKey();
        }
    }
}
