using System.IO;
namespace OnlineMediaStore
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Medicine"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("Medicine");
            }
            if(!File.Exists("Medicine/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Medicine/UserDetails.csv");
            }
            if(!File.Exists("Medicine/MedicineDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Medicine/MedicineDetails.csv");
            }
            if(!File.Exists("Medicine/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Medicine/OrderDetails.csv");
            }
             if(!File.Exists("Medicine/FoodDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Medicine/FoodDetails.csv");
            }
        } 



         public static void ReadFile()
        {
            string [] students = File.ReadAllLines("Medicine/UserDetails.csv");
            foreach(string data in students)
            {
            UserDetails student = new UserDetails(data);
            Operations.userList.Add(student);  
            }

            string [] department = File.ReadAllLines("Medicine/MedicineDetails.csv");
            foreach(string datas in department)
            {
            MedicineDetails dept = new MedicineDetails(datas);
            Operations.medicineList.Add(dept);  
            }

            string [] admission = File.ReadAllLines("Medicine/OrderDetails.csv");
            foreach(string dat in admission)
            {
            OrderDetails addmission = new OrderDetails(dat);
            Operations.orderList.Add(addmission);  
            }
            
        }
        public static void WriteToFile()
        {
            string [] UserDetails = new string[Operations.userList.Count];
            for (int i=0;i<Operations.userList.Count;i++)
            {
                UserDetails[i]=Operations.userList[i].UserID+","+Operations.userList[i].UserName+","+Operations.userList[i].Age+","+Operations.userList[i].City+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].Balance;
            }
            File.WriteAllLines("Medicine/UserDetails.csv",UserDetails);

            string [] MedicineDetails = new string[Operations.medicineList.Count];
            for (int i=0;i<Operations.medicineList.Count;i++)
            {
                MedicineDetails[i]=Operations.medicineList[i].MedicineID+","+Operations.medicineList[i].MedicineName+","+Operations.medicineList[i].AvilableCount+","+Operations.medicineList[i].Price+","+Operations.medicineList[i].DateOfExpiry;
            }
            File.WriteAllLines("Medicine/MedicineDetails.csv",MedicineDetails);

            string [] OrderDetails = new string[Operations.orderList.Count];
            for (int i=0;i<Operations.orderList.Count;i++)
            {
                OrderDetails[i]=Operations.orderList[i].OrderID+","+Operations.orderList[i].UserID+","+Operations.orderList[i].MedicineID+","+Operations.orderList[i].MedicineCount+","+Operations.orderList[i].TotalPrice+","+Operations.orderList[i].OrderDate+","+Operations.orderList[i].OrderStatus;
            }
            File.WriteAllLines("Medicine/OrderDetails.csv",OrderDetails);
        }
    }
   
}