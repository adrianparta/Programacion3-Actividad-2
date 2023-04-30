using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Environment.MachineName == "DESKTOP - J4H7KBG")
            {
                Console.WriteLine("holas");
            }
            Console.WriteLine(Environment.MachineName);
            Console.ReadKey();
        }
    }
}
