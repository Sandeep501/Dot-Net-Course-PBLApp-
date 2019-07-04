
using System;
namespace intro
{
class prog4
{
  static void Main() 
  {
      Console.Write("Enter the string: ");
      string target=Console.ReadLine();
      string res1=target.ToUpper();
      string res2=target.ToLower();
      Console.WriteLine(res1);
      Console.WriteLine(res2);   
  }
}
}