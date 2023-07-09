using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DrawRectangle
{
    internal class Program
    {
        static void drawing(int row)
        {
            for (int i = 1; i <=row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == row )

                        Console.Write("*");
                    else

                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Put in an amount of rows: ");
                int row = int.Parse(Console.ReadLine());
                drawing(row);

                Console.WriteLine("Type '1' to make another triangle.");

            }
            // int condition = int.Parse(Console.ReadLine());
            while (Console.ReadLine() == "1");// if the input is =1
        }
    }
}
