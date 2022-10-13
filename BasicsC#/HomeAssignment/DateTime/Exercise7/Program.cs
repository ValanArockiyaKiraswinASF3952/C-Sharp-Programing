using System;
namespace Exercise7;
class Program
{
    public static void Main(string[] args)
    {
        
        
        DateTime date1=new DateTime(2022,7,1,0,0,0);
        DateTime date2=new DateTime(1234,7,6,9,0,0);
        int result= DateTime.Compare(date1,date2);
        string result1;
        if (result<0)
        {
            result1="is earlier than";
        }
        else if(result==0)
        {
            result1="is the same time";
        }
        else
        {
            result1="is later than";
        }
        Console.WriteLine("{0}{1}{2} ",date1,result1,date2);
    }
}
        

