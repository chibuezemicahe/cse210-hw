using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
              // Show the menu
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Delete an entry");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    myJournal.AddEntry();
                    break;
                
                case "2":
                    myJournal.DisplayJournal();
                    break;
                
                case "3":
                    myJournal.SaveJournal();
                    break;
                
                case "4":
                    myJournal.LoadJournal();
                    break;
                
                case "5":
                  myJournal.DeleteEntry(0);
                    break;

                case "6":
                    running = false;
                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }   
    }
}

//I exceeded requirements by adding the delete entry option