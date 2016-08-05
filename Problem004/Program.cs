using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
A palindromic number reads the same both ways. 
The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
*/
namespace Problem004
{
    class Program
    {
        static void Main(string[] args)
        {
            int largest = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int product = i * j;
                    if (isPalindrome(product))
                    {
                        if (product > largest)
                        {
                            largest = product;
                            Console.WriteLine("{0} * {1} = {2}", i, j, largest.ToString());
                        }
                    }
                }
            }

            Console.Read();
        }

        static bool isPalindrome(int product)
        {
            string s1 = product.ToString();
            string s2 = "";
            for (int i = s1.Length-1; i >= 0; i--)
            {
                s2 += s1[i].ToString();
            }

            return s1 == s2;
        }
    }
}
