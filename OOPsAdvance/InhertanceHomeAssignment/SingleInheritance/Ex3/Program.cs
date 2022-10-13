using System;
namespace Ex3;
class Program 
{
    public static void Main(string[] args)
    {
        EmloyeeInfo employee = new EmloyeeInfo(new DateTime(11/11/1111),12,"Jan","Feb","valan","Jesu",1231,"valan@mail",new DateTime(11/11/1111),"MAle");
        employee.ShowDetails();
    }
}