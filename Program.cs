using System;

namespace Exception_Handling_task
{

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Room ID: ");
            string roomNo = System.Console.ReadLine();
                
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
            


            System.Console.WriteLine($"Student {personName} entered {roomNo} at {entryDate} and exited at {departureTime}"); 
        
        }
    }
    
}