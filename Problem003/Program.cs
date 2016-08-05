using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?
*/
namespace Problem003
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> factors = new List<int>();
            long number = 600851475143;
            int prime = 2;

            bool finding = true;

            while (finding)
            {
                if (number % prime == 0)
                {
                    factors.Add(prime);
                    Console.WriteLine("Prime: {0}", prime);
                }

                long product = MultiplyFactors(factors);
                if (product == number)
                    finding = false;
                else
                    prime = FindNextPrimeNumber(prime);
            }
            Console.Read();
        }

        private static long MultiplyFactors(List<int> factors)
        {
            long product = 1;
            for (int i = 0; i < factors.Count; i++)
            {
                product *= factors[i];
            }

            return product;
        }

        private static int FindNextPrimeNumber(int previousPrime)
        {
            int prime = previousPrime + 1;
            while (true)
            {
                if (isPrime(prime))
                    return prime;

                prime++;
            }
        }

        private static bool isPrime(int number)
        {
            if (number < 4) return true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
