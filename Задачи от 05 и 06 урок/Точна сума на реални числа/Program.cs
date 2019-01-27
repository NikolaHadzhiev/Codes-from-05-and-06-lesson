using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Точна_сума_на_реални_числа
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {

                sum += decimal.Parse(Console.ReadLine());







            }

            Console.WriteLine(sum);






        }
    }
}
