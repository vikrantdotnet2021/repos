﻿// write a program to find the reverse no
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp, remainder, reverse = 0;
            Console.WriteLine("Enter an integer \n");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            Console.WriteLine("Given number is = {0}", temp);
            Console.WriteLine("Its reverse is = {0}", reverse);
            Console.ReadLine();
        }
    }
}
