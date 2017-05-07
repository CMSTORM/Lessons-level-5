using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class Bonuses
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the points:");
            int points = int.Parse(Console.ReadLine());
            if (points < 9 || points < 0)
            {
                if (points >= 1 && points <= 3) Console.WriteLine(points*10);
                if (points >= 4 && points <= 6) Console.WriteLine(points * 100);
                if (points >= 7 && points <= 9) Console.WriteLine(points * 1000);
                

            }
            else
            {
                Console.WriteLine("Invalid Points entered!");            
            }

            Console.ReadLine();
        }
    }
}
