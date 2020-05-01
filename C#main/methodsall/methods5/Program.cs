using System;

namespace methods5
{
    class Program
    {
        public static void Main()
        {
           

           Console.WriteLine("please enter a number");
           int n1 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("please enter another number");
           int n2 = Convert.ToInt32(Console.ReadLine());

           change(ref n1, ref n2);

           Console.WriteLine("the first number is: {0} , and the second number is {1}", n1, n2);
        }
        public static void change (ref int num1, ref int num2)
        {
            int switchnum;
            
            switchnum = num1;
            num1 = num2;
            num2 = switchnum;


        }
    }
}
