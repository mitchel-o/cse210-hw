using System;
namespace JournalProgram
{

    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();

            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("Journal Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display journal");
                Console.WriteLine("3. Save journal");
                Console.WriteLine("4. Load journal");
                Console.WriteLine("5. Quit");

                Console.Write("Choose an option: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            string date = DateTime.Now.ToShortDateString();

                            string prompt = promptGenerator.GetRandomPrompt();
                            Console.WriteLine(prompt);

                            Console.Write("Your response: ");
                            string response = Console.ReadLine();

                            Entry entry = new Entry(date, prompt, response);

                            journal.AddEntry(entry);
                            break;
                        }

                    case 2:
                        {
                            journal.DisplayAll();
                            break;
                        }

                    case 3:
                        {
                            Console.Write("Enter file name to save:");
                            string saveFile = Console.ReadLine();
                            journal.SaveToFile(saveFile);
                            Console.WriteLine("Journal saved successfully.");
                            break;
                        }

                    case 4:
                        {
                            Console.Write("Enter file name to load:");
                            string loadFile = Console.ReadLine();
                            journal.LoadFromFile(loadFile);
                            Console.WriteLine("Journal loaded successfully.");
                            break;
                        }

                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}