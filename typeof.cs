using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose - int, double, string:");
            string userChoice = Console.ReadLine().ToLower();
            switch(userChoice)
            {
                case "int":
                    Console.Write("Enter your value: ");
                    int value = int.Parse(Console.ReadLine());
                    Console.WriteLine(value+1);
                    break;
                case "double":
                    Console.Write("Enter your value: ");
                    double value1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(value1+1);
                    break;
                case "string":
                    Console.Write("Enter your value: ");
                    string value2 = Console.ReadLine();
                    Console.WriteLine(value2+"*");
                    break;
            }
            Console.ReadLine();
        }
    }
}
