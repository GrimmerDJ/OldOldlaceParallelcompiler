using System;

class Program
{
    static void Main()
    {
        Console.Write("How many lines of lyrics would you like to enter? ");
        int numberOfLines = int.Parse(Console.ReadLine());

        string[] lines = new string[numberOfLines];

        Console.WriteLine($"\nPlease enter {numberOfLines} lines of lyrics:");

        for (int i = 0; i < lines.Length; i++)
        {
            Console.Write($"Enter line {i + 1}: ");
            lines[i] = Console.ReadLine();
        }

        Console.WriteLine("\nYou have entered:");

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}