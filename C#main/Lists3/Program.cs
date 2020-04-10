using System;
using System.Collections;
using System.Collections.Generic;

namespace Lists3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordlist =  new List<string>();

            int i = 0;
            while (i <= wordlist.Count)
            {   
                i++;

                 if (wordlist.Contains("stop"))
                 {
                    Console.WriteLine(".");
                    wordlist.Reverse();
                    wordlist.RemoveAt(index: 0);
                    wordlist.ForEach(x => { Console.WriteLine(x); });

                 }
                 else
                {
                     Console.WriteLine("Please Enter a word?");
                     wordlist.Add((Console.ReadLine()));
                }
            }
        

            Console.ReadKey();

        
        }
    }
}
