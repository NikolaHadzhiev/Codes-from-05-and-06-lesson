using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Десетично_към_шестнадесетично_и_двоично
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string number = Convert.ToString(n, 16);

            string number1 = number.ToUpper();

           

            Console.WriteLine(number1);

            string number2 = "";

            while (n > 0)
            {
                number2 += n % 2;
                n /= 2;

            }

            for (int i = number2.Length - 1; i >= 0; i--)
            {
                Console.Write(number2[i]);
                

            }
            Console.WriteLine();


        }
    }
}
