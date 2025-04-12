using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void PerformActivity()
    {
        int cycle = GetDuration()/6; // 3 in, 3 out
        for (int i = 0; i < cycle; i++)
        {
            Console.Write("\nBreathe in... ");
            Countdown(3);
            Console.Write("Breathe out... ");
            Countdown(3);
        }
    }
}