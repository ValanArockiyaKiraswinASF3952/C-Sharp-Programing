namespace AbstractClasses
{
    public abstract class AbstractBase
    {
        protected string name; //Normal Field
        public abstract string Name { get; set; } //Abstrac Property
        public double Amount { get; set; } //Normal property
        public void Display(){System.Console.WriteLine(name);} //Normal Method
        public abstract void Salary(int dates);   //Abstract Medhot
    }
}