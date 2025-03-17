using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;


    // This next method will organize the files into the format we want
    public void Display(string _date, string _promptText, string _entryText)
    {
        // string timestamp = GetDateAndTime();
        // Console.WriteLine(_date);
        // Console.WriteLine(_entryText);
        // Console.WriteLine(_promptText);

        string formatted = $"\n\nDate:{_date} - Prompt: {_promptText}\n{_entryText}";





        // // here is code that will help us write to our saved file
        // using (StreamWriter writer = new StreamWriter(_journalFile, true))
        // {
        //     writer.WriteLine($"Date: {timestamp}");
        //     writer.WriteLine($"Prompt: {prompt}");
        //     writer.WriteLine($"Response: {response}");

        // }
        // Console.WriteLine("Your response has been saved to the journal <>");
    }
}