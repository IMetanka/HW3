using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int Number = int.Parse(Console.ReadLine());
            bool flag = true;
            int i = 2;


            while (Number % i == 0)
            {
                flag = false;
                i++;
                break;
            }

            while (Number % i != 0)
            {
                flag = true;
                i++;
                break;
            }



            //for (int i = 2; i <= Number; i++)
            //{
            //    if (Number % i != 0)
            //        N = true;

            //    else 
            //        N = false;


            //}

            if (flag = true)
            Console.WriteLine($"Число простое.");
            else
            Console.WriteLine($"Число не является простым.");


            Console.ReadKey();



            

        }
    }
}
