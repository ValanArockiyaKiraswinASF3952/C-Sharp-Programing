using System;
using System.Collections;
namespace SingleCasting;
public delegate int Calculator(int n);
class Program 
{
    static int value =10;
    public static int AddNum(int number) {value+=number; return value;}
    public static int MulNum(int number) {value*=number; return value;}
    public static int GetNum() {return value;}

    public static void Main(string[] args)
    {
        //create delegate instance
        Calculator nc1 = new Calculator(AddNum);
        Calculator nc2 = new Calculator(MulNum);

        nc1(25);
        System.Console.WriteLine("Value of Num: "+GetNum());
        nc2(5);
        System.Console.WriteLine("Value of Num: "+GetNum());
        Console.ReadLine();
    }
}