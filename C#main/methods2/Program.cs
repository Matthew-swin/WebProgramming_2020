using System;

namespace methods2
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("Please enter your name.");
            string a = Console.ReadLine();
            name(a);
        }
        
        public static void name (string a)
        {
            
            Console.WriteLine("Welcome Friend " + a + "!");
            Console.WriteLine("Have a nice day!");

        }
    }
}
