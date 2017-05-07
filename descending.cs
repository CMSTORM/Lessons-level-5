using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descending
{
    class descending
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            if(a>b && a>c)
            {
                Console.Write(a + " ");
                if (b > c) Console.Write("{0} {1}" ,b,c);
                else Console.Write("{0} {1}",c,b);
            }
            else if (b>a && b>c)
            {
                Console.Write(b + " ");
                if (a > c) Console.Write("{0} {1}", a, c);
                else Console.Write("{0} {1}", c , a);
            }
            else
            {
                Console.Write(c + " ");
                if (b > a) Console.Write("{0} {1}", b, a);
                else Console.Write("{0} {1}", a,b);
            }
            Console.ReadLine();
        }
    }
}
