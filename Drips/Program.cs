using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drips
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How often do you hear a drip drop (in seconds)?: ");
            string n = Console.ReadLine();
            int a = Convert.ToInt32(n);

            double hour = (3600 / a) * 0.00025;
            double day = (86400 / a) * 0.00025;
            double week = (604800 / a) * 0.00025;

            Console.WriteLine("This wastes " + hour + " liters of water every hour");
            Console.WriteLine("This wastes " + day + " litres of water every day");
            Console.WriteLine("This wastes " + week + " litres of water every week");

            Console.ReadKey();
        }
    }
}
