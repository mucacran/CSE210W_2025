//Make sure to describe anything you have done to exceed the requirements in comments in the Program.cs file.
// Create 6 menu items, where 3 is the one that deletes an entry.
// You can create a file to save the entries and load them.

////www.plantuml.com/plantuml/png/RL7BQiCm4BphAvQSRDByW2aXXOH0IQ6axQcKi5HB4EXX93cDAVttobe_Gh0FjdTcThIpseI8FZP6Ys-D8S2hTsUF1du5m19UKDaYHA_i-VCBq9z32HLSd9BYJwI7UvvTuotghcTr8fla52eug10VTwbgrqB0Sb0LPLSyIPcf8h_1qa_-6TsJPAj2hR7TiLznIxtXXURmWqCvXn_9EEve2sKZA2lfMbPJ3Z6bDtNSaoMFqVak49pg30Re8_4wrftldk8HhNI6-_APJBCji6i-c1VQcuqw1YDTxo69aHAqJPztPKXab1Em3DZf0VgoyoW5y5HRYgXqk1q8qaJ3vQxMR5N1uYFGOi8JCLpc37U_db6p8IiRe_y1

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