using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Iteration
    {
        static void Main() 
        {

            Console.WriteLine("GOTO demo");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    goto dell;
            }
        dell:
            Console.Write("Hello");
            Console.Write("Student");
            Console.Write("welcome");


            Console.WriteLine();

            Console.WriteLine("Print 1-50 numbers");
            for (int i = 0; i < 50; i++) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Print Even numbers");
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Print odd numbers");
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("Do while demo program");
            /**Do while loop**/
            int b = 20;
            do
            {
                Console.Write("Enter b value " + b);
            } while (b==40);

            Console.WriteLine("while do demo program");
            int a = 10;
            while (a<50)
            {

                Console.Write(a+ " ");
                a++;
            }

            Console.ReadLine(); 
        }   
    }
}
