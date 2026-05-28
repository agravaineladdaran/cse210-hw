// Creativity and Exceeding Requirements:
// - Added a library of 8 scriptures
// - Program selects a scripture randomly each run
// - Improved hiding logic so only visible words are hidden

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("1 Nephi", 3, 7),
                "I will go and do the things which the Lord hath commanded"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Ether", 12, 27),
                "If men come unto me I will show unto them their weakness"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("2 Nephi", 32, 3),
                "Angels speak by the power of the Holy Ghost wherefore they speak the words of Christ"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Alma", 37, 6, 7),
                "Now ye may suppose that this is foolishness in me but behold I say unto you that by small and simple things are great things brought to pass and small means in many instances doth confound the wise"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Moroni", 10, 4, 5),
                "And when ye shall receive these things I would exhort you that ye would ask God the Eternal Father in the name of Christ if these things are not true and if ye shall ask with a sincere heart with real intent having faith in Christ he will manifest the truth of it unto you by the power of the Holy Ghost"
            )
        );

        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        Scripture scripture = scriptures[randomIndex];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit':");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram ended.");
    }
}