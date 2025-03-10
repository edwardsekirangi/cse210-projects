using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // This is our first program, the name program
        Console.WriteLine("Welcome to the first program <..>");
        Console.WriteLine();

        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}");

        
        // This is our second program that uses if statements and conditionals 
        Console.WriteLine();

        Console.WriteLine("Welcome to the second program <..>");
        Console.WriteLine();
        Console.Write("What is your Grade in percentage? ");
        string gradeFromUser = Console.ReadLine();

        int x = int.Parse(gradeFromUser);

        if (x >= 90)
        {
            Console.WriteLine("A");
        }
        else if (x >= 80)
        {
            Console.WriteLine("B");
        }
        else if (x >= 70)
        {
            Console.WriteLine("C");
        }
        else if (x >= 60)
        {
            Console.WriteLine("D");
        }
        else 
        {
            Console.WriteLine("F");
        }


        // This is our third program that is based on loops 
        // This is where the user specified the number
        Console.WriteLine();
        Console.WriteLine("Welcome to the magic number game");
        //Console.Write("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int numberMagic = int.Parse(magicNumber);

        // For Part 3, we use the random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,10);
        
        // We are gonna declare the guess integer from here and won't need to specify it's value again
        int numberGuess = -1;

        while (numberGuess != magicNumber)
        {

            Console.Write("What is your guess? ");

            numberGuess = int.Parse(Console.ReadLine());

            if (numberGuess > magicNumber)
            {
                Console.WriteLine("Lower");

            }
            else if (numberGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }

        }
       
        // This is our next program on lists 
        Console.WriteLine();
        Console.WriteLine("Welcome to the fourth game, the lists game <..>");

        // This program is going to be getting numbers from a user and adding them to a list for computing
        
        //we first need to create a list called numbers 
        List <int> numbers = new List<int> ();
        
        // Creating code that will add numbers to the list
        int userNumber = -1;
        while (userNumber != 0)
        {
            // Here is will be our code to add to the list

            Console.Write("Enter a number (0 to quit): ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }

        // We are now going to compute the sum
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // We wanna try to calculate the average 
        // average = sum * no. of items

        // We already have the sum, so we wanna try finding the number of items in the list
        //Console.WriteLine(numbers.Count);
        
        int quantity = numbers.Count;

        // Create a variable called average and then with decimal points
        double average = sum/quantity;

        Console.WriteLine($"The average is {average}");

        // We now need to find the biggest number, we can iterate through the list numbers and then find the bigger one
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // If this number is greater than max, we have found the new bigger number
                max = number;

            }
        }
        Console.WriteLine($"The biggest number is {max}");


        // here we have the functions exercise 
        // since the main function is at the top, it is stil running the programs
        Console.WriteLine();
        //Console.WriteLine("Welcome to the last game, the functions game <..>");

        DisplayWelcomeMessage();

        // We now want to get the userName, so we will call the function to do that for us and store it in a variable
        string userName = AskUserName();

        // We now want to prompt the user for their favorite
        int usersNumber = AskUserNumber();

        //We now want to call the square computing function and we will pass the user value in it
        int displaySquare = ComputeSquare(usersNumber);

        // We now want to call the Display result function to help us display the computed results
        DisplayResult(userName, displaySquare);

        static void DisplayWelcomeMessage ()
        {
            Console.WriteLine("Welcome to the last program!!");
        }

        static string AskUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int AskUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;
        }
        static int ComputeSquare(int userNumber)
        {
            int square = userNumber * userNumber;

            return square;
        }
        static void DisplayResult (string userName, int square)
        {
            Console.WriteLine($"Your name is {userName}, and the square of your favorite number is {square}");
        }



    }
}