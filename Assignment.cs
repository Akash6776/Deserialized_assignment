using System;
using System.IO;
using System.Text;

namespace IncludeHelp
{
    class Test
    {
        // Main Method 
        static void Main(string[] args)
        {
        	string warning = "\tProject folder should be in downloads folder of C drive of your system!\n";
        	Console.WriteLine(warning);
        	Console.Write("Enter the user of this system: ");
        	string user = Console.ReadLine();
        	Console.Write("Enter the project folder name: ");
        	string folder = Console.ReadLine();
        	Console.Write("Enter the txt file name: ");
        	string filename = Console.ReadLine();
            //string filename = @"C:\Users\brvAnk\Downloads\akash\Assignment.txt";
			
			string filepath = @"C:\Users\" + user + "\\Downloads\\" + "\\" + folder + "\\" + filename + ".txt" ;
			
			if(File.Exists(filepath)){
				fileRead(filepath);
			}else{
				Console.WriteLine("\n\n" + warning);
				Console.WriteLine("No file exist for :" + filepath);
			}
            
            Console.ReadLine();
        }
        
        static void fileRead(string filepath){
        	Console.WriteLine("\n\nYour file details :\n"); 
			string str = File.ReadAllText(filepath);
			Console.WriteLine(str);
        }
    }
}
