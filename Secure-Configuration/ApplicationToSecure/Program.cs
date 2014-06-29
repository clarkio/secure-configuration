using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ApplicationToSecure
{
    class Program
    {
        static void Main(string[] args)
        {
            var connections = ConfigurationManager.ConnectionStrings;
            var count = 1;
            
            foreach(var connection in connections)
            {
                Console.WriteLine(count + ": \t" + connection);
                Console.WriteLine();
                count++;
            }

            Console.ReadLine();
        }
    }
}
