using System;

namespace Exception_Handling_task
{

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Room ID");
            string roomNo = System.Console.ReadLine();

             int catchnum;

            while (
                !int.TryParse(Console.ReadLine(), out catchnum)
                )
            {
                Console.WriteLine("Invalid! Must enter a number");
                Console.Write("Enter Room ID: ");
            }

            System.Console.WriteLine("Enter Name: ");
            string personName = System.Console.ReadLine();

            System.Console.WriteLine("Entered on: DD/MM/YYYY HH:MM");
            DateTime entryDate;
            while (true)
            {
               try
                {
                    entryDate = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (System.FormatException)
                {
                    System.Console.WriteLine("Wrong Formatting, Follow Template = DD/MM/YYYY");
                } 
            }
                
            System.Console.WriteLine("Enter Date Exited: ");
            int departureTime = Int32.Parse(Console.ReadLine());
            
            System.Console.WriteLine($"Student {personName} entered {roomNo} at {entryDate}");
        
        }
    }
    
}