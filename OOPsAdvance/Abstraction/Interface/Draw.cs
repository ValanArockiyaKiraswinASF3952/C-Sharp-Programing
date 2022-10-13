namespace Interface
{
    public class Draw:IRectangle
    {
        public int Area { get; set; }
        public int Lenghth { get; set; }
        public int Breath { get; set; }

        public Draw(int lenghth, int breath)
        {
            Lenghth=lenghth;
            Breath=breath;
        }

        public void CalculateArea()
        {
            Area=Lenghth*Breath;
            System.Console.WriteLine("Area of Rectange: "+Area);

        }
       
    }
}