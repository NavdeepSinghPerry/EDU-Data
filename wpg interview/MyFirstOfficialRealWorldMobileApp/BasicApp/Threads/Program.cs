using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        /// <summary>
        /// Threads\
        /// Forground 
        /// Background
        /// </summary>
        /// <param name="args"></param>
        static  void Main(string[] args)
        {

            Console.WriteLine("Main Thread terminated");
   
            Thread.Sleep(1000);
        }
        
        public static void longRunningProcess()
        {
            for(int i = 0; i < 1000000; i++)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
