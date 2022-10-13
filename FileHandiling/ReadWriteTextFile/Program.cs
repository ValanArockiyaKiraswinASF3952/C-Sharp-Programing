using System;
using System.IO;
namespace FilesandFolders;

class Program 
{
    public static void Main(string[] args)
    {
        
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder Created");
        }
        else{Console.WriteLine("Folder Exist");}

        if(!File.Exists("TestFolder/Text.txt"))
        {
            File.Create("TestFolder/Text.txt");
            System.Console.WriteLine("File Created");
        }
        else
        {
            System.Console.WriteLine("File Found");
        }

        System.Console.WriteLine("Select option \n1.Read File Info \n2.Write File Info");
        int option = int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                string line;
                StreamReader sr = null;
                try{
                    //pass the file path and file name to be StreamReader constructor
                    sr=new StreamReader("TestFolder/Text.txt");
                    //read the first line of text
                    line = sr.ReadLine();
                    while(line!=null)
                    {
                        System.Console.WriteLine(line);
                        line=sr.ReadLine();

                    }
                }catch(Exception e)
                {
                    System.Console.WriteLine("Exception :"+e.Message);
                }finally
                {
                    if(sr!=null)
                    {
                        System.Console.WriteLine("Executing finally block");sr.Close();
                    }
                }
                break;
            }
            case 2:
            {
                StreamWriter sw = null;
                try{
                string [] old = File.ReadAllLines("TestFolder/Text.txt");
                 sw = new StreamWriter("TestFolder/Text.txt");
                System.Console.WriteLine("Enter new content to placed in the file");
                string info = Console.ReadLine();
                string old1=" ";
                foreach (string text in old)
                {
                    old1=old1+"\n"+text;
                }
                old1=old1+"\n"+info;
                sw.WriteLine(old1);
                }catch(Exception e)
                {
                    System.Console.WriteLine("Exception :"+e.Message);
                }finally
                {
                    if(sw!=null)
                    {
                        System.Console.WriteLine("Executing Finally block");
                        sw.Close();
                    }
                }
                
                break;
            }
        }
    }
}