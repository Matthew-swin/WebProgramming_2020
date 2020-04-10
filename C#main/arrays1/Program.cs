using System;

namespace arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string [5];
             names[0] = "matt";
             names[1] = "nick";
             names[2] = "kate";
             names[3] = "connor";
             names[4] = "soraya";

            foreach(string s in names)
            Console.WriteLine("Hello " + s);

            Console.ReadKey();


        }
    }
}
