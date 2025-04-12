//Base class
class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    //We now create the constructor for use in the child classes
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //Now we create a function called run that runs each time we choose an option
    public void Run()
    {
        Console.Clear();
        Console.WriteLine($"{_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);  //This is the function that will create the animations

        PerformActivity(); //This function is gonna be a sandbox for the child functions for each to influence how the program will run according to the UI

        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    public virtual void PerformActivity()
    {

    }
    public int GetDuration()
    {
        return _duration;
    }

    public void ShowSpinner(int seconds)
    {
        //Animation
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(". ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}