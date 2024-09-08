using System;

class Program
{
    static void Main()
    {
        string[] Lyrics = new string[4];

        Console.WriteLine("Please enter 4 lines of lyrics:");

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Line {i + 1}: ");
            Lyrics[i] = Console.ReadLine();
        }

        Console.WriteLine("\nYou entered:");
        foreach (string line in Lyrics)
        {
            Console.WriteLine(line);
        }
    }
}