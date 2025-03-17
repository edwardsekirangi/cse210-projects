using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the journal object
        Journal journal = new Journal();

        //Create the prompt object
        PromptGenerator prompt = new PromptGenerator();


        //I now wanna try creating the menu of the application, if the user picks one, then it proceeds and so on and so forth 
        Console.WriteLine("Welcome to your journal!");

        //Creating a While loop to continue looping while a certain condition is true

        int userInput = 0;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            userInput = int.Parse(Console.ReadLine());

            //using this part if the userInput is 1
            if (userInput == 1)
            {
                //using a method in the journal object to get a random prompt
                string prompts = prompt.GetRandomPrompt();
                Console.WriteLine($"{prompts}");
                Console.Write(">");

                //Store the user prompt inside a variable
                string response = Console.ReadLine();

                //We have called the SaveResponse method from the journal object to save the response into the file journal.txt file


                // We are now going to call the Entry object to get its variable values
                Entry entryData = new Entry();
                entryData._date = DateTime.Now.ToString("yyyy-MM-dd");
                entryData._entryText = response;
                entryData._promptText = prompts;

                //Let us feed the entry method, "Display" that needs these values to display
                entryData.Display(entryData._date, entryData._promptText, entryData._entryText);

                //We now add the data in entryData into the journal list;
                journal._entries.Add(entryData);
            }
            else if (userInput == 2)
            {
                //This one here will call the display all function in journal object
                journal.DisplayAll();

            }
            else if (userInput == 4)
            {
                //This one here will call the save to file function in journal object
                journal.SaveAllResponses();
            }
            else if (userInput == 3)
            {
                //This one will call the load function to load the files in the journal file
                //to read them on to the screen for the user
                journal.LoadFiles();
            }
            else if (userInput == 5)
            {
                Console.WriteLine("GoodBye, Check in tomorrow");
            }

        }
        while (userInput <= 4);


    }
}