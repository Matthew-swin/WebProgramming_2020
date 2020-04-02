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

            Console.WriteLine("Enter amount of rows.");
            int rows= Convert.ToInt32(Console.ReadLine());

            while (counter < rows) {
                counter++;
                
                int counter2 = counter;

                while (counter2 < rows+1) {
                    System.Console.Write(ast);
                    counter2++;
                }

                System.Console.WriteLine();
            }
        }
        }
    }
}
