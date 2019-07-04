
using System;
class Stock
{
    string stockName;
    string stockSymbol;
    double previousStock;
    double currentStock;
    
    
    public Stock( string stockName,string stockSymbol,double previousStock,double currentStock)
    {
      
        this.stockName=stockName;
        this.stockSymbol=stockSymbol;
        this. previousStock= previousStock;
        this. currentStock= currentStock;
       
    }
    public static double getChangePercentage(double a,double b)
    {
        double change=b-a;
        
        return (change/a)*100;
    }
    
    public static void Main(string[] args)
    {
       
       Stock obj=new Stock("Wipro Stocks","flower",275.34,290.45);
    
       double res=getChangePercentage(obj.previousStock,obj.currentStock);
    //   Console.WriteLine(obj.stockName);
    //   Console.Write(res);
        Console.Write(obj.stockName+" currently experiencing "+res+"% of difference compared to the previous stock price");
    
        
    }
       
}