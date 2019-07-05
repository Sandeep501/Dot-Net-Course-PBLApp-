
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
class test
{
    public static void Main(string[] args)
    {
        // RandomHelper obj=new RandomHelper();
        // int res1= ;
        // double res2=obj.randdouble(1,10);
        // Console.WriteLine(obj);
        // Console.WriteLine(res2);
        Console.WriteLine(RandomHelper.randint(1,10));
        Console.WriteLine(RandomHelper.randdouble(1,10));
    }
}
