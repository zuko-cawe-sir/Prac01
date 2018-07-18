using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How often do you hear a drip drop?: ");
            string n = Console.ReadLine();


            int a = Convert.ToInt32(n);

            double hour = (3600 / a) * 0.00025;
            double day = (86400 / a) * 0.00025;
            double week = (604800 / a) * 0.00025;

            double GlassesPerHour = (1 / 0.250) * hour;
            double GlassesPerDay = (1 / 0.250) * day;
            double GlassesPerWeek = (1 / 0.250) * week;

            double FullGlassesPerHour = Math.Round(GlassesPerHour, 0);
            double FullGlassesPerDay = Math.Round(GlassesPerDay, 0);
            double FullGlassesPerWeek = Math.Round(GlassesPerWeek, 0);

            Console.WriteLine("This wastes " + FullGlassesPerHour + " full glasses of water per hour");
            Console.WriteLine("This wastes " + FullGlassesPerDay + " full glasses of water per day");
            Console.WriteLine("This wastes " + FullGlassesPerWeek + " full glasses of water per week");

            Console.ReadKey();

        }
    }
}
