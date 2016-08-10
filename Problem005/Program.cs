using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/
namespace Problem005
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 20;
            int min = 1;
            int number = max;
            bool searching = true;
            while (searching)
            {
                number++;
                bool semResto = true;
                for (int i = min; i <= max; i++)
                {
                    if (number % i > 0)
                    {
                        semResto = false;
                        break;
                    }
                }

                //bool semResto = false;
                //if (number % 20 == 0 &&
                //    number % 19 == 0 &&
                //    number % 18 == 0 &&
                //    number % 17 == 0 &&
                //    number % 16 == 0 &&
                //    number % 15 == 0 &&
                //    number % 14 == 0 &&
                //    number % 13 == 0 &&
                //    number % 12 == 0 &&
                //    number % 11 == 0)
                //{
                //    semResto = true;
                //}

                searching = !semResto;
            }
            Console.WriteLine(number.ToString());
            Console.Read();
        }

    }
}
