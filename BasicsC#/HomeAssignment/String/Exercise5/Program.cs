using System;  
namespace Exercise5;
class Program
{  
    public static void Main(string[] args)
{
    string string1, string2;
    int flg=0;
    int i=0,length1,length2,stringthLength=0;
        
      Console.Write("Input the 1st string : ");
      string1 = Console.ReadLine();    
       
      Console.Write("Input the 2nd string : ");
      string2 = Console.ReadLine();    

      length1=string1.Length;
      length2=string2.Length;

if(length1==length2)
  {
    for(i=0;i<length1;i++)
     {
        if(string1[i] != string2[i])
          {
            stringthLength=1;
            i=length1;
           
          }
     }
  }

    if(length1 == length2)
        flg=0;
    else if(length1 > length2)
        flg=1;
    else if(length1 < length2)
        flg=-1;

    if(flg == 0)
    {
       if(stringthLength==0)
       Console.Write("\nThe length of both strings are equal and also, both strings are same.");
    }
    else
    {
            Console.Write("\nThe length of both strings are equal but they are not same.");
    }
    }
}