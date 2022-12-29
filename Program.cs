using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QwertyAI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, a, b;        // Counting Start
            
            a = 20;
            Console.WriteLine("Numbers from 1-20");

           for (i = 1; i <= a; i++)
            {
                Console.WriteLine(i);

            }
            

                Console.WriteLine();              // Counting End


            Console.WriteLine("---> 10 times Pakistan");    // 10 Times Start
            i = 1;
           for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Pakistan " + i);
               
            }
            
            Console.WriteLine();                      // 10 Times End

            Console.WriteLine("Prime - Composite Checker");  // Prime - Composite Start

            Console.WriteLine();

            Console.WriteLine("Write your number: ");
            i = 0;
            b = Convert.ToInt32(Console.ReadLine());
            a = 2;
            int count = 0;
            for (i = 0; i <= b - 1; i++)
            {
                if (b % 2 == 0)
                {
                    count = 1;
                }
            }
            

            if (count == 1)
            {
                Console.WriteLine("The number is Composite.");

            }
            else
            {
                Console.WriteLine("The number is Prime.");

            }                                                    // Prime - Composite End

            Console.WriteLine();

            Console.WriteLine("First Ten Primes: ");

            int num, div, coun;                                // First Ten Primes Start
            num = 2;
            coun = 1;
            for (num = 2; num <= 30; num++)
            {
                div = 2;
               for (div = 2; div <= num; div++)
                {
                    if (num == div)
                    {
                        Console.WriteLine(coun + " --> " + num);
                        coun++;
                    }

                    if (num % div == 0)
                    {
                        break;
                    }

                }

            }

            // First Ten Primes End


            Console.WriteLine();
            Console.WriteLine("First Ten Composites: ");         // First Ten Composites Start
            num = 3;
            coun = 1;

            for (num = 3; num <= 23; num++)
            {
                div = 2;
                for (div = 2; div <= num; div++)
                {
                    if (num % div == 0)
                    {
                        Console.WriteLine(coun + " --> " + num);
                        coun++;
                    }

                    break;
                }

            }                                                      // First Ten Composites End

            Console.WriteLine();

            int q, w, e;                                            // Factorial Start

            q = 1;
            w = 1;
            Console.WriteLine("Write your desired number to find factorial:");
            e = Convert.ToInt32(Console.ReadLine());

            for (q = 1; q <= e; q++)
            {
                w = w * q;

            }
         
            Console.WriteLine("Factorial of " + e + " is " + w);            // Factorial End


            Console.WriteLine();

            Console.ReadLine();
          
        }
    }
}
