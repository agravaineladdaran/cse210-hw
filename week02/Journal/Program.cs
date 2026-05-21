using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;
        
        while (choice!=5)
        {
            Console.WriteLine("JOURNAL MENU");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input.");
                choice = 0;
            }

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
            }

            else if (choice ==2 )
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Filename: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }

            else if (choice == 4)
            {
                Console.Write("Filename: ");
                string fileName = Console.ReadLine();

                try
                {
                    journal.LoadFromFile(fileName);
                    Console.WriteLine("Journal loaded successfully.");
                    journal.DisplayAll();
                }
                catch
                {
                    Console.WriteLine("Could not load file.");
                }
            }
        }
        Console.WriteLine("Thank you for using the Journal App today!");
    }
}