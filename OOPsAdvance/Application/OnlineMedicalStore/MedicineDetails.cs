using System;
namespace OnlineMediaStore
{
    public class MedicineDetails
    {
        private static int s_medicineId=100;
        public string MedicineID { get;  }
        public string MedicineName { get; set; }
        public int AvilableCount { get; set; }
        public int Price { get; set; }
        public DateTime DateOfExpiry { get; set; }

        public MedicineDetails(string medicineName,int avilableCount, int price, DateTime dateOfExpiry)
        {
            s_medicineId++;
            MedicineID="MID"+s_medicineId;
            MedicineName=medicineName;
            AvilableCount=avilableCount;
            Price=price;
            DateOfExpiry=dateOfExpiry;
        }

         public MedicineDetails(string datas)
       {
        string [] values = datas.Split(',');
        s_medicineId=int.Parse(values[0].Remove(0,3));
        MedicineID=values[0];
        MedicineName=values[1];
        AvilableCount=int.Parse(values[2]);
        Price=int.Parse(values[3]);
        DateOfExpiry=DateTime.Parse(values[4]);
       }

    }
}