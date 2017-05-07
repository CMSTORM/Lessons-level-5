using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOutOf5
{
    class Biggestone
    {
        static void Main(string[] args)
        {
            int a = 3124124;
            int b = 31232312;
            int c = 3121231;
            int d = 3125125;
            int e = 3123;
            if (a > b && a > c && a > d && a > e) Console.WriteLine("The biggest is: {0}", a);
            if (b > a && b > c && b > d && b > e) Console.WriteLine("The biggest is: {0}", b);
            if (c > b && c > a && c > d && c > e) Console.WriteLine("The biggest is: {0}", c);
            if (d > a && d > b && d > c && d > e) Console.WriteLine("The biggest is: {0}", d);
            if (e > a && e > b && e > c && e > d) Console.WriteLine("The biggest is: {0}", e);
            Console.ReadLine();

        }
    }
}
