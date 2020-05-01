using System;

namespace methods7
{
    class Program
    {
        static void Main()
        {


            Console.Write(" Input number of Fibonacci Series : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Fibonacci series of numbers is : ", n1);
            for (int i = 0; i < n1; i++)
            {
                Console.Write("{0} ", fiby(i));
            }
        }

        public static int fiby(int fib)
        {
            int num1 = 0;
            int num2 = 1;
            for (int i = 0; i < fib; i++)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }
            return num1;
        }
    }
}
