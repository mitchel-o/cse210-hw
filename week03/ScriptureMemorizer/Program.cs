using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(text, reference);
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue or type 'quit' to finish.");
        string input = Console.ReadLine();
        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type'quit'to finish.");
            input = Console.ReadLine();
        }
    }
}