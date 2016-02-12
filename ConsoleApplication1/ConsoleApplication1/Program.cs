using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int sum = 0;
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("Enter a number");
                input = Convert.ToInt32(Console.ReadLine());
                 while(input == 999)
                {
                    break;
                }

                 sum = sum + input;
                 Console.WriteLine(sum);
              
            }
        }
    }
}
