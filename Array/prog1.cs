using System;
namespace intro
{
    class prog1
    {
        static void Main(string[] args)
        {
            int[] arr=new int[]{1,2,3,4,5};
            int c=0;
            foreach(int j in arr)
            {
                c+=1;
                
            }
              Console.Write("The array size is "+c);
        }
        
    }
}