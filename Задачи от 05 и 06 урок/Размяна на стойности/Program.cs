using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Размяна_на_стойности
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a1 = 5;
            byte b1 = 10;
            byte c1 = 0;
            byte a = 5;
            
            

            




            Console.WriteLine("Before: a={0}",a1);
            Console.WriteLine("        b={0}", b1);

            a1 = b1;
            b1 = c1;
            c1 = a1;

            


            Console.WriteLine("After:  a={0}", c1);
         
            Console.WriteLine("        b={0}" , a);


            













        }
    }
}
