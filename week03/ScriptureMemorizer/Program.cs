using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureHider
{
    // My program works with a library of four scriptures. 
    // It chooses scriptures at random to present to the user.

    class Program
    {
        static void Main(string[] args)
        {
            var scriptureLibrary = new List<Scripture>
            {
                new Scripture("Proverbs", "3", "5-6", "Trust in the Lord with all your heart and lean not on your own understanding"),
                new Scripture("John", "3", "16", "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life"),
                new Scripture("Psalm", "23", "1", "The Lord is my shepherd I shall not want"),
                new Scripture("Philippians", "4", "13", "I can do all things through Christ who strengthens me")
            };

            var random = new Random();
            var scripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture);
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                
                string input = Console.ReadLine();
                if (input?.ToLower() == "quit") break;

                if (!scripture.HideRandomWords(3))
                {
                    Console.Clear();
                    Console.WriteLine("All words are now hidden.");
                    break;
                }
            }
        }
    }
}