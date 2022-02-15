// wap to print no from 1 to 10 using system
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
            // wap to print no from 1 to 10 using system
            int i, j;
            for (i = 1; i < 10; i++)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}

