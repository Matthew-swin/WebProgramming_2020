using System;
using System.Collections;
using System.Collections.Generic;


namespace List2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nolist =  new List<int>();

            Console.WriteLine("Please Enter 5 Numbers?");
            
                   
            for (int i = 0; i < 5; i++)
            {
                nolist.Add(int.Parse(Console.ReadLine()));
                
            }
        
            Console.WriteLine("Enter a number to check against your list?");
            int unumber = int.Parse(Console.ReadLine());


            int times = 0;
            for(int i = 0; i < nolist.Count;i++)
                {
                if(unumber == nolist[i])
                    {
                        times++;
                    }
                }

                if(times > 0)
                    {
                    Console.WriteLine(unumber + " has already been entered " + times + " time/s");
                    }   

                else {
                Console.WriteLine("This Number is not in the list");
                }
                
            Console.ReadKey();
        }
    }
}
