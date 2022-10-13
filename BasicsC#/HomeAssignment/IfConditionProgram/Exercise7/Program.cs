using System;
namespace Exercise7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The input ID:");
            double inputID=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The name:");
            string myName=Console.ReadLine();
            Console.WriteLine("Enter The Unit consumed:");
            double unitValue=double.Parse(Console.ReadLine());
            if (unitValue>50 && unitValue<200)
            {
                Console.WriteLine($"Customer ID Number: {inputID}");
                Console.WriteLine($"Customer Name : {myName}");
                Console.WriteLine($"Unit Consumed :  {unitValue}");
                Console.WriteLine($"Amount Charges @Rs. 1.20 per unit : {unitValue*1.20}");
                Console.WriteLine($"Net Amount Paid By The Customer : {unitValue*1.20}");
    
            }
            else if(unitValue>200 && unitValue<400)
            {
                Console.WriteLine($"Customer ID Number: {inputID}");
                Console.WriteLine($"Customer Name : {myName}");
                Console.WriteLine($"Unit Consumed : {unitValue}");
                Console.WriteLine($"Amount Charges @Rs. 1.50 per unit : {(unitValue*1.50)}");
                Console.WriteLine($"Net Amount Paid By The Customer : {unitValue*1.50}");
    
            }
            else if(unitValue>400 && unitValue<600)
            {
                Console.WriteLine($"Customer ID Number: {inputID}");
                Console.WriteLine($"Customer Name : {myName}");
                Console.WriteLine($"Unit Consumed : {unitValue}");
                Console.WriteLine($"Amount Charges @Rs. 1.80 per unit : {(unitValue*1.80)}");
                Console.WriteLine($"Surcharge Amount:  {unitValue*0.15}");
                Console.WriteLine($"Net Amount Paid By The Customer : {((unitValue*1.80)+(unitValue*0.15))}");
    
            }
            else 
            {
                Console.WriteLine($"Customer ID Number:  {inputID}");
                Console.WriteLine($"Customer Name : {myName}");
                Console.WriteLine($"Unit Consumed : {unitValue}");
                Console.WriteLine($"Amount Charges @Rs. 2 per unit : {(unitValue*2)}");
                Console.WriteLine($"Surcharge Amount: {((unitValue*0.15)*2)}");
                Console.WriteLine($"Net Amount Paid By The Customer : {((unitValue*2)+((unitValue*0.15)*2))}");
            
            
            }
        }
    }
}