using System;

namespace nestedrepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            
        int counter = 0;

        Console.WriteLine("Enter amount of rows.");
        int rows= Convert.ToInt32(Console.ReadLine());

            while (counter < rows) {
                counter++;
                int counter2 = 1;

                while (counter2 <= 6) {

                    if (counter ==2) {
                        Console.Write("fy");
                    }
                    else {
                    Console.Write(counter);
                    counter2++;
                    }
                }
                }

                Console.WriteLine();
        }
    }
}