﻿using System;
public class Methods9

{
public static void Main() 
    {
	  int num;

      Console.Write("Enter a number: ");
      num = Convert.ToInt32(Console.ReadLine() );

      Console.WriteLine("The sum of the digits of the number {0} is: {1} ",num,SumCal(num));    
    }
public static int SumCal( int n ) 
    { 
       string n1 = Convert.ToString(n);
       int sum = 0;  
       for (int i = 0; i < n1.Length; i++)
         sum += Convert.ToInt32(n1.Substring(i,1));
         return sum;
    }
}
