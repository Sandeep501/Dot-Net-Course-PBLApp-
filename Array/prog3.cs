using System;
namespace intro
{
    class prog3
    {
        static void Main(string[] args)
        {
            int[] arr=new int[10];
            Console.Write("Enter the 10 array elements: ");
            for(int i=0;i<10;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Array.Reverse(arr);
            foreach(int j in arr)
            {
                Console.WriteLine(j);
                
            }
        }
        
    }
}