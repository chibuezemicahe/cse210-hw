public class GratitudeActivity : Activity
{
    private List<string> _categories;
    private Dictionary<string, int> _gratitudeCount;

    public GratitudeActivity() : base("Gratitude Activity",
        "This activity will help you develop an attitude of gratitude by focusing on specific categories and tracking your grateful thoughts over time.")
    {
        _categories = new List<string>
        {
            "Family and Friends",
            "Personal Growth",
            "Nature and Environment",
            "Health and Well-being",
            "Daily Comforts"
        };
        _gratitudeCount = new Dictionary<string, int>();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Random rand = new Random();
        string category = _categories[rand.Next(_categories.Count)];
        
        Console.WriteLine($"\nToday's gratitude category: {category}");
        Console.WriteLine("Take a moment to think about this category...");
        ShowSpinner(5);

        Console.WriteLine("\nFor each thing you're grateful for, write a brief note about why it matters to you.");
        Console.WriteLine("Press enter after each entry. Press 'q' to finish before the time runs out.");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("\n> ");
            string entry = Console.ReadLine();
            if (entry.ToLower() == "q") break;
            if (!string.IsNullOrWhiteSpace(entry))
            {
                count++;
                if (!_gratitudeCount.ContainsKey(category))
                    _gratitudeCount[category] = 0;
                _gratitudeCount[category]++;
            }
        }

        Console.WriteLine($"\nYou recorded {count} grateful thoughts about {category}!");
        if (_gratitudeCount[category] > 1)
        {
            Console.WriteLine($"You have recorded {_gratitudeCount[category]} total thoughts in this category!");
        }

        DisplayEndingMessage();
    }
}