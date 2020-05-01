using System;
public class Methods8
{

    public static void Main()
    {
        Console.WriteLine("Input a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (prime(n))
            Console.WriteLine(n + " is a prime number");
        else
            Console.WriteLine(n + " is not a prime number");
    }
    public static bool prime(int num)
    {
        for (int i = 2; i < num; i++)
            if (num % i == 0)
                return false;
        return true;
    }
}