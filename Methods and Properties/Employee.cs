using System;
class Employee{
    public string empname;
    float basesal,HRA,DA,TAX,GrossPay,Netsal;
    public Employee(string name,int bsal){
        empname=name;
        basesal=bsal;
    }
    public void calculate(){
        HRA=(float)0.15*basesal;
        DA=(float)0.10*basesal;
        GrossPay=basesal+HRA+DA;
        TAX=(float)0.08*GrossPay;
        Netsal=GrossPay-TAX;
        
    }
    public void display(){
        Console.WriteLine(" Employee Name: "+empname+"\n" +" Basic Salary: "+basesal+"\n HRA: "+HRA+"\n DA: "+DA+"\n Gross pay: "+GrossPay+"\n Tax: "+TAX+"\n Net salary: "+Netsal);
        
    }
    
}
class Emp{
  static void Main() {
      Employee emp=new Employee("Sandeep",20000);
      emp.calculate();
      emp.display();
    
  }
}
