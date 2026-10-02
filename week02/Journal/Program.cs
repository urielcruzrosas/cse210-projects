using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                string answer = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry anEntry = new Entry();
                anEntry._date = date;
                anEntry._promptText = prompt;
                anEntry._entryText = answer;

                theJournal.AddEntry(anEntry);
            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter the filename: ");
                string file = Console.ReadLine();

                theJournal.SaveToFile(file);
            }
        }
    }
}