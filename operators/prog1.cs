using System;
namespace intro
{
    class prog1
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.Write("Enter the number: ");
            num1=int.Parse(Console.ReadLine());
            int flag=num1;
            num2=flag++;
            Console.WriteLine(num2);
            ++num1;
            num2=0;
            num2=num1;
            Console.WriteLine(num2);
            
        }
    }
}