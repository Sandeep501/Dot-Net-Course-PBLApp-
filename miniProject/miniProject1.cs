using System;
public class miniProject1 {
 public static void Main()
  {
        Console.WriteLine("Enter the no.of test Cases: ");
        int iteration=int.Parse(Console.ReadLine());
        int i=0;
        while(i<iteration)
	{
        	Console.WriteLine("Enter the String followed by the N and M values:  ");
        	string main=Console.ReadLine();
     		int N=int.Parse(Console.ReadLine());
        	int M=int.Parse(Console.ReadLine());
       		string subStr=main.Substring(N,M);
        	char[] ch=subStr.ToCharArray();
        	Array.Sort(ch);
        	Array.Reverse(ch);
		string s=string.Join("",ch);
		string finalRes=main.Replace(subStr,s);
		Console.WriteLine(finalRes);
       		i++;
        }
        
        
  }
}
