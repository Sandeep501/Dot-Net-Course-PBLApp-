using System;
class Car
{
    string carmake,carModel;
    int mfgYear;
    string city;
    
    public Car(string carmake,string carModel,int mfgYear,string city)
    {
       this.carmake=carmake;
       this.carModel=carModel;
       this.mfgYear=mfgYear;
       this.city=city;
        
    }
    
    public static void Main(string[] args)
    {
        Car obj1=new Car("BMW","Q700",2018,"Chennai");
        
        Car obj2=new Car("Audi","A8",2018,"Bengalore");
        
        Console.WriteLine("carCompany: " + obj1.carmake + 
                         " carModel: " + obj1.carModel+" Manifacturing Year: "+obj1.mfgYear+"Location: "+obj1.city); 
         Console.WriteLine("carCompany: " + obj2.carmake + 
                         " carModel: " + obj2.carModel+" Manifacturing Year: "+obj2.mfgYear+"Location: "+obj2.city); 

    }
       
}