using System;
class Program
{
    static void Main()
    {
      
         (Reference, string)[] scriptures = new (Reference, string)[]
        {
            (new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son."),
            (new Reference("Psalm", 23, 1), "The Lord is my shepherd I shall not want."),
            (new Reference("Proverbs", 3, 5), "Trust in the Lord with all your heart and lean not on your own understanding."),
            (new Reference("Genesis", 1, 1), "In the beginning God created the heavens and the earth.")
        };

        Random rand = new Random();
        int index = rand.Next(scriptures.Length);
        var (selectedRef, selectedText) = scriptures[index];

        Scripture scripture = new Scripture(selectedRef, selectedText);

        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("Press enter to continue type 'quit' to finish the program");
        string input = Console.ReadLine();

        while (input != "quit")
        {
            scripture.HideRandomWords();
            Console.WriteLine(scripture.GetDisplayText());
            input = Console.ReadLine();
        }



    }
}
