using System;
namespace ListDS;
class Program 
{
   public static void Main(string[] args)
   {
         List<int> data = new List<int>();
         data.AddElement(10);
         data.AddElement(20);
         data.AddElement(30);
         data.AddElement(40);
         data.AddElement(50);
         data.AddElement(60);
         data.AddElement(70);
         data.AddElement(80);
         data.AddElement(90);
         //data.Insert(2,25);
         //data.Remove(80);
         //data.RemoveAt(8);
         for (int i=0;i<data.Count;i++)
         {
            System.Console.WriteLine(data[i]);
         }
         foreach(var d in data)
         {
         }
   }
}