using System;
public class methods4
  {
    public static void Main()
    {
       int[] arr1 = new int[5];
         
       Console.Write("Input 5 numbers in the array:");    
       for(int j=0; j<5; j++)    
       {    
        Console.Write("please enter a number: ");  
        arr1[j] = Convert.ToInt32(Console.ReadLine());         
       }    
       Console.WriteLine("The sum of the of the array is {0}", Sum(arr1));
    }
    public static int Sum(int[] arr1)
    {
        int count=0;
        for (int i = 0;i < arr1.Length; i++)
        count += arr1[i];
        return count;
    }
}


