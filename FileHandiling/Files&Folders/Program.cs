using System;
using System.IO;
namespace FilesandFolders;
class Program 
{
    public static void Main(string[] args)
    {
        string path =@"C:\Users\ValanArockiyaKiraswi\Desktop\MyFolder";
        string folderBath= path+"/Valan";
        string filePath=path+"/newFile.txt";
        if(!Directory.Exists(folderBath))
        {
            System.Console.WriteLine("folderBath not found creating folder");
            string folder = path+"/Valan";
            Directory.CreateDirectory(folder);
        }
        else{Console.WriteLine("Directory Found");}
        
        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("File not found creating file");
            File.Create(filePath);
        }
        else
        {
            System.Console.WriteLine("File already Exist");
        }
        System.Console.WriteLine("Select options \n1.Create Folder \n2.Create File \n3.Delete Folder \n4.Delete File");
        int option = int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine("Enter folder name you want to enter");
                string name1=Console.ReadLine();
                string newPath = path+"\\"+name1;
                if(!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                else
                {
                    System.Console.WriteLine("Directory name already exit");
                }
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Enter file name to create a file");
                string fileName=Console.ReadLine();
                System.Console.WriteLine("Enter file extention name to create a file");
                string extention = Console.ReadLine();
                string newPath = path+"\\"+fileName+"."+extention;
                if(!File.Exists(newPath))
                {
                    File.Create(newPath);
                }
                else
                {
                    System.Console.WriteLine("File name already exit");
                }
                break;
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select folder you want to delete");
                string name1 = Console.ReadLine();
                string newPath=path+"\\"+name1;
                foreach(string name in Directory.GetDirectories(path))
                {
                    if(name==newPath)
                    {
                        Directory.Delete(newPath);
                        System.Console.WriteLine("Folder Deleted");
                    }
                }
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Enter file name to delete the file");
                foreach(string name in Directory.GetFiles(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select file you want to delete");
                string name1 = Console.ReadLine();
                System.Console.WriteLine("Select file extention you want to delete");
                string name2 = Console.ReadLine();
                string newPath=path+"\\"+name1+"."+name2;
                foreach(string name in Directory.GetFiles(path))
                {
                    if(name==newPath)
                    {
                        File.Delete(newPath);
                        System.Console.WriteLine("File Deleted");
                    }
                }
                break;
            }
            
        }
    }
}