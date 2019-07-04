using System;
namespace intro
{
    class prog4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number: ");
            string s=Console.ReadLine();
            char[] c=s.ToCharArray();
            Console.Write("Enter the digit to search: ");
            string digit=Console.ReadLine();
            char[] ch=digit.ToCharArray();
            int count=0;
            for(int i=0;i<c.Length;i++)
            {
                if(c[i]==ch[0])
                {
                    count++;
                }
            }
            Console.WriteLine(digit+" is repeated "+count+" no.of times");
        }
    }
}