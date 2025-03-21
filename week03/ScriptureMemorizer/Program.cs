using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //I want to first create a new instance of references class
        Reference reference1 = new Reference("Doctrine and Covenants", 4, 1, 7);

        Console.WriteLine(reference1.StringConverter());

        //A new object of the Word Class
        string scriptureText = "Now Behold, a marvelous work is about to come forth among the children of men. Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day.";
        Words word = new Words(scriptureText);

        //scripture class opening and then we ge the appropriate values
        Scripture scripture = new Scripture(reference1, scriptureText);


        //Loops as long as the conditions are favourable
        while (true)
        {
            Console.WriteLine("\n Press Enter to hide words or type 'quit' to exit.");

            //Looked this one up 
            string input = Console.ReadLine();

            if (input == "quit") break;

            if (!scripture.HideRandomWords(2)) break; // Hides 2 words 
            scripture.Display();
        }

        Console.WriteLine("\nAll words are hidden. Program has ended");


    }
}