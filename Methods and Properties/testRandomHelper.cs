
using System;
class RandomHelper
{
    public static int randint(int min,int max)
    {
        Random rand = new Random(); 
        return rand.Next(min,max);
        
    }
    
     public static double randdouble(int min,int max)
    {
        Random rand1 = new Random(); 
       return rand1.NextDouble() * (max - min) + min;
        
    }
 
}
class testRandomHelper
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine(RandomHelper.randint(1,10));
        Console.WriteLine(RandomHelper.randdouble(1,10));
    }
}
