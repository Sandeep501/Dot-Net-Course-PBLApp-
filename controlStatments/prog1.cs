using System;
namespace intro
{
    class prog1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string mainStr=Console.ReadLine();
            char[] c=mainStr.ToCharArray();
            string rev="";
            for(int i=c.Length-1;i>=0;i--)
            {
                rev+=c[i];
            }
            if(rev==mainStr)
            {
                Console.WriteLine(mainStr+" is a palindrome");
            }
            else
            {
                Console.WriteLine(mainStr+" is not a palindrome");
            }
        }
    }
}