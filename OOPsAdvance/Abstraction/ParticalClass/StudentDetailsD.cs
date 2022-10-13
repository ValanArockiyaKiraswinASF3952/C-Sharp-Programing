namespace ParticalClass
{
    public partial class StudentDetails
    {
         public bool CheckEligibility(double cutoff)
        {
            double average = (double) (Physics+Chemistry+Maths)/3.0;
            if (average>=cutoff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}