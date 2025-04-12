using System;

// Extra Credit Activity
class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "What are three things that made you smile today?",
        "List things you're grateful for in your current surroundings.",
        "Name people who have positively impacted your life recently.",
        "What recent experience are you most thankful for?"
    };

    public GratitudeActivity()
        : base("Gratitude", "This activity helps you focus on gratitude and acknowledge positive things in your life.")
    {
    }

    public override void PerformActivity()
    {
        //Selecting random prompts
        
        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(3);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                {
                    items.Add(item);
                }
            }
        }

        Console.WriteLine($"\nYou expressed gratitude for {items.Count} things. Keep this spirit alive!");
    }
}