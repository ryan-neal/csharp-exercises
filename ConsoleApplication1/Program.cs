using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a radius");
            String radius = Console.ReadLine();
            double radius2 = Double.Parse(radius);
            double answer = Math.PI * Math.Pow(radius2, 2.0);
            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}
