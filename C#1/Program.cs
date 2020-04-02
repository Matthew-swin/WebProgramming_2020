using System;

namespace Rudy
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            string ast = "*";
            int counter = 0;

            while (counter < 5) {
                counter++;
                int counter2 = counter;

                while (counter2 < 6) {
                    System.Console.Write(ast);
                    counter2++;
                }

                System.Console.WriteLine();
            }
        }
        }
    }
}
