namespace Ex1
{
    public interface IFamilyInfo
    {
         string FatherName { get; set; }
         string MotherName { get; set; }
         string HouseAddress { get; set; }
         int Sibbling { get; set; }

         void GetFamilyInfo(string FatherName,string MotherName,string HouseAddress,int Sibbling);
    }
}