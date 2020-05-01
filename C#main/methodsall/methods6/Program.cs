using System;

namespace methods6
{
    class Program
    {
        public static void Main()
        {
            int n1;
            int pow1;

            Console.WriteLine("input number");
            n1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input power");
            pow1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(power(n1, pow1));


        }
        public static int power(int num, int pow)
        {
            int value = 1;
            int i = 1;
            while (i<=pow){
            i++;
            value = value*num;
            }
            return value;
        }
    }
}
