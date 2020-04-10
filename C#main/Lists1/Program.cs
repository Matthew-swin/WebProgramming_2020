using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(7);
            numbers.Add(10);
            numbers.Add(43);
            numbers.Add(53);

    

            Console.WriteLine("enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            
            if (numbers.Contains(input)) 
                {
                Console.WriteLine("This number is already present in the list");
                }
                else 
                {
                Console.WriteLine("This number is not in the list");   
                }
                

            
            Console.ReadLine();
        }
    }

