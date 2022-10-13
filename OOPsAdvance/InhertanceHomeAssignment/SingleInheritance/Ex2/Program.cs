using System;
namespace Ex2;
class Program 
{
    public static void Main(string[] args)
    {
        AccountInfo details = new AccountInfo("valan","jesu",1324868198,"valan@mail",new DateTime(11/11/1999),"Male","EEE","IFSC!@34");
        details.ShowDetails();
    }
}