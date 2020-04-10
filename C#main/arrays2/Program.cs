using System;

namespace arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 10;
            int sum = 0;
            int[] number = new int[amount];
            number[0] = 34;
            number[1] = 5;
            number[2] = 67;
            number[3] = 1;
            number[4] = 99;
            number[5] = 34;
            number[6] = 44;
            number[7] = 78;
            number[8] = 34;
            number[9] = 0;
            
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            System.Console.WriteLine("Total = "  + sum);

        }
    }
}
