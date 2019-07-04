using System;
namespace intro
{
class prog3 
{
  static void Main() 
  {
      Console.Write("Enter the string: ");
      string target=Console.ReadLine();
      char[] c=target.ToCharArray();
      string res="";
      for(int i=0;i<c.Length;i++)
      {
          c[i]++;
          res+=c[i];
      }
      Console.Write(res);
  }
}
}