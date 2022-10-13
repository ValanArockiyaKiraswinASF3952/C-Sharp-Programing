namespace AbstractClasses
{
    public class TCS:AbstractBase
    {
        public override string Name {get{return name;} set{name=value;}}
        //Abstract class definition
        public override void Salary(int dates)
        
            
            {
                Display(); //calling a abstract Base class normal method
                Amount=(double)dates*300;
                System.Console.WriteLine(Amount);
            }
    }
}