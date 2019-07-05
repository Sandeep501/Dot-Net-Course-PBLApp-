using System;

 class impleFan
 {
    const int SLOW=1,MEDIUM=2,FAST=3;
    private int speed;
    private bool on;
    private string color;
    private double radius;
    public impleFan(){
        
        speed=SLOW;
        on=false;
        color="red";
        radius=5;
    }   
    public int Speed
     {

            set { speed= value ; }

            get { return speed; }

    }
    public bool On
     {

            set { on= value ; }

            get { return on; }

    }
    public double Radius
     {

            set { radius= value ; }

            get { return radius; }

    }
    public string Color
     {

            set { color= value ; }

            get { return color; }

    }
    public void tostring(){
        if(on==true){
            Console.WriteLine("The "+color+" color Fan is on and rotating at a speed of "+speed+" and it's radius is at "+radius);
        }
        else{
            Console.WriteLine("The "+color+" color Fan is off state");
        }
    }
    
}
class Fan 
{
  static void Main() 
  {
    impleFan obj=new impleFan();
    obj.Speed=3;
    obj.On=true;
    obj.Color="black";
    obj.Radius=6;
    obj.tostring();
  }
}
