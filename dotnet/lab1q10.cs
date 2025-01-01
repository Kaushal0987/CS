using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a single character
        Console.Write("Enter an alphabet: ");
        char ch = Char.ToLower(Console.ReadKey().KeyChar); // Read a single character and convert to lowercase
        Console.WriteLine();

        // Check if the character is a vowel or consonant
        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine($"{ch} is a Vowel.");
                break;
            default:
                if (char.IsLetter(ch))
                {
                    Console.WriteLine($"{ch} is a Consonant.");
                }
                else
                {
                    Console.WriteLine($"{ch} is not a valid alphabet.");
                }
                break;
        }
    }
}
