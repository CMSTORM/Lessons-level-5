using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
           

            if (discriminant>0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
                Console.WriteLine("x1 = {0}    x2 = {1}" , x1 ,x2);
            }
            else if(discriminant==0)
            {
                double x1and2 = -b / 2 * a;
                Console.WriteLine("There is only one solution - {0}" ,x1and2);
            }
            else
            {
                Console.WriteLine("Negative Discriminant! No solution.");
            }
            Console.ReadLine();
        }

    }
}
