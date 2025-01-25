//Make sure to describe anything you have done to exceed the requirements in comments in the Program.cs file.
// Create 6 menu items, where 3 is the one that deletes an entry.
// You can create a file to save the entries and load them.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine("Please select one of the following choise:");
            Console.WriteLine("1. Add entry\n2. Display entries\n3. Remove entry\n4. Save entry\n5. Load entry\n6. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Your response: > ");
                string userInput = Console.ReadLine();

                Entry newEntry = new Entry(prompt, userInput);
                journal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the index of the entry to remove: ");
                int index = int.Parse(Console.ReadLine());
                journal.RemoveEntry(index);
            }
            else if (choice == "4")
            {
                journal.SaveEntries();
            }
            else if (choice == "5")
            {
                journal.LoadEntries();
            }
            else if (choice == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}