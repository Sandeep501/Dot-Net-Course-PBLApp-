using System;
namespace intro
{
    
      class prog5
    {
        static void Main(string[] args)
        {
          string rev="";
          string slice="";
          Console.Write("Enter the String: ");
          string target=Console.ReadLine();
          char[] c=target.ToCharArray();
        //   char[] rev=Array.Reverse(c);
          for(int i=c.Length-1;i>=0;i--)
          {
              rev+=c[i];
              
          }
        for(int i=2;i<c.Length;i++)
          {
              slice+=c[i];
              
          }
          
          Console.WriteLine(rev);
          
          Console.WriteLine(slice);
          
          Console.Write("Enter the char to replace in the string: ");
          string tar=Console.ReadLine();
        //   int j=0;
          char[] ch=tar.ToCharArray(); 
          string res2="";
          
          for(int j=0;j<c.Length;j++)
          {
              if(c[j]==ch[0])
              {
                  res2+='$';
              }
              else{
                  res2+=c[j];
              }
            //   j+=1;
          }
          
        Console.WriteLine(res2);
            
        Console.Write("Enter something to modify the string: ");
        string name=Console.ReadLine();
        string modifiedString=target+" "+name;
        Console.WriteLine(modifiedString);

        }
       
    }
    
}