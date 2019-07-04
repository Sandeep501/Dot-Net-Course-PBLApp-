/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
namespace intro
{
class prog2 {
  static void Main() 
  {
    Console.Write("Enter the String: ");
    string target=Console.ReadLine();
    char[] c=target.ToCharArray();
    int alpha=0,num=0;
    for(int i=0;i<c.Length;i++)
    {
        if((c[i]>='A'&&c[i]<='Z')||(c[i]>='a'&&c[i]<='z'))
        {
            alpha+=1;
        }
        else if(c[i]>='0'&&c[i]<='9')
        {
            num+=1;
        }
    }
    Console.WriteLine("Alphabet count "+alpha+" digits count "+num);
  }
}
}