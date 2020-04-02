using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string ast = "*";
            int counter = 0;


            while (counter < 5) {
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
