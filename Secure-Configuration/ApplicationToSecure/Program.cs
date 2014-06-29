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
            var connection = ConfigurationManager.ConnectionStrings;
            Console.WriteLine(connection);
        }
    }
}
