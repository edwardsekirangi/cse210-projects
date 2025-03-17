using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.VisualBasic;

//using different system setting here, that I had to do some research on 
public class Journal
{


    //Creating a List that contains the data entries, called _entries
    public List<Entry> _entries = new List<Entry>();

    // tried using relative paths but I failed, so I resorted to absolute paths
    public string _journalFile = "/Users/Edward/Desktop/desktop folders/course/cse2410/cse210-projects/week02/Journal/journalings.txt";


    // This method gets the current date and time
    public string GetDateAndTime()
    {
        return DateTime.Now.ToString("yyyy-MM-dd");
    }

    //This function is to help us with formatting the entry list to get the proper format
    public string FormatEntry(Entry entry)
    {
        return $"Date: {entry._date} Prompt - {entry._promptText}\nEntry: {entry._entryText}";
    }


    //Add entry function, this method will help us add the entries into the file
    public void DisplayAll()
    {
        //We may need to iterate through the list and display everything on the screen
        foreach (Entry items in _entries)
        {
            Console.WriteLine(FormatEntry(items));
        }
    }


    // This next function or method is gonna write to the text file 
    public void SaveResponse(Entry entry)
    {
        //using FormatEntry to get a formatted string
        string formattedEntry = FormatEntry(entry);

        // here is code that will help us write to our saved file
        using (StreamWriter writer = new StreamWriter(_journalFile, true))
        {
            writer.WriteLine(formattedEntry);

        }
        Console.WriteLine("Your response has been saved to the journal <>");
    }

    public void SaveAllResponses()
    {
        foreach (Entry entry in _entries)
        {
            SaveResponse(entry);
        }
    }

    //We now want to read the files onto the console
    public void LoadFiles()
    {
        string filename = "/Users/Edward/Desktop/desktop folders/course/cse2410/cse210-projects/week02/Journal/journalings.txt";

        if (File.Exists(filename)) // Check if the file exists
        {
            string[] lines = File.ReadAllLines(filename); // Read all lines

            foreach (string line in lines) // Loop through each line
            {
                Console.WriteLine(line); // Print the line
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }

    }


}