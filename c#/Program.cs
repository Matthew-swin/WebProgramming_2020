using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string ast = "*";
            int counter = 0;

            Console.WriteLine("Enter amount of rows.");
            int rows= Convert.ToInt32(Console.ReadLine());

            while (counter < rows) {
                counter++;
                int counter2 = 1;

                while (counter2 <= counter) {
                    Console.Write(ast);
                    counter2++;
                }

                Console.WriteLine();
            }
        
        }
    }
}
