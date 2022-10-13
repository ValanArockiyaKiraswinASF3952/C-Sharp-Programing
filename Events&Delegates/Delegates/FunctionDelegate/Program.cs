using System;
namespace FunctionDelegates;
class Program 
{
    static double Sum(int a , int b ) {return a+b ;}
    static double Subract(int a , int b ) {return a-b ;}
    static double Multiple(int a , int b ) {return a*b ;}
    static double Div(int a , int b ) {return a/b ;}


    static double Caculator(Func<int,int,double> operation, int x, int y)
    {
        return operation(x,y);
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine(Caculator(Sum,10,20));
        System.Console.WriteLine(Caculator(Subract,10,20));
        System.Console.WriteLine(Caculator(Multiple,10,20));
        System.Console.WriteLine(Caculator(Div,100,20));

    }
}