using System;

class Program
{
    static void Main(string[] args)
    {

 
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, new string[] { "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life." });

        // Clear the console screen and display the complete scripture
        Console.Clear();
        Console.WriteLine(scripture.GetReference().ToString());
        Console.WriteLine(scripture.GetRenderedText());

        // Prompt the user to press enter or type quit
        while (true)
        {
            Console.WriteLine("Press enter to hide a word or type quit to exit:");
            string input = Console.ReadLine();

            // If the user types quit, the program should end
        
        if (input.ToLower() == "quit")
            {
                break;
            }

            // If the user presses enter, hide a random word
            else
            {
                Random rand = new Random();
                int verseIndex = rand.Next(0, scripture.GetVerses().Length);
                string[] words = scripture.GetVerses()[verseIndex].Split(' ');
                int wordIndex = rand.Next(0, words.Length);

                scripture.HideWord(verseIndex, wordIndex);
                Console.Clear();
                Console.WriteLine(scripture.GetReference().ToString());
                Console.WriteLine(scripture.GetRenderedText());
            }
        }
    }
}


    
