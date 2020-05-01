using System;
public class nethods3
{

    public static void Main()
	{
	    string str2;
		Console.Write("Please input a string : ");
        str2 = Console.ReadLine();
		Console.WriteLine("\""+str2+"\""+" contains {0} spaces", SpaceCount(str2) );
	}    
	
    public static int SpaceCount(string str)
	{   
		int spaces=0;
		string str1;
		for (int i = 0;i < str.Length;i++)
			{
			  str1 = str.Substring(i,1);
			  if (str1 == " ")
					spaces++;
			}
		return spaces;
	} 
}