﻿// accept a no and print whether it is even or odd
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0) goto Even;
            Console.WriteLine("no is odd");
            goto End;
        Even:
            Console.WriteLine("no is even");
        End:;

            Console.ReadLine();

        }
    }
}

